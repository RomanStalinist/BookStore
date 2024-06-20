Imports Microsoft.EntityFrameworkCore

Public Class ФормаРеализаций
    Public Sub New()
        InitializeComponent()

        Dim колонкаКниг = DirectCast(SalesGrid.Columns(4), DataGridViewComboBoxColumn)
        колонкаКниг.DataSource = My.Application.Контекст.ПолучитьКниги()
        колонкаКниг.DisplayMember = "Название"
        колонкаКниг.ValueMember = "Код"

        Dim колонкаПользователей = DirectCast(SalesGrid.Columns(5), DataGridViewComboBoxColumn)
        колонкаПользователей.DataSource = My.Application.Контекст.ПолучитьПользователей()
        колонкаПользователей.DisplayMember = "Логин"
        колонкаПользователей.ValueMember = "Код"

        Dim реализации = My.Application.Контекст.Реализации

        For Each реализация In реализации
            SalesGrid.Rows.Add(
                реализация.Код,
                реализация.ДатаПродажи,
                реализация.Количество,
                реализация.Цена,
                реализация.КодКниги,
                реализация.КодПользователя
            )
        Next
    End Sub

    Private Sub SalesGrid_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles SalesGrid.CellValidating
        Dim index = SalesGrid.Columns(e.ColumnIndex).Index
        Dim вводимоеЗначение As String = e.FormattedValue.ToString()

        If index = 2 Then
            Dim число As Integer
            If Not Integer.TryParse(вводимоеЗначение, число) Then
                e.Cancel = True
                MessageBox.Show("Пожалуйста, введите числовое значение.")
            End If
        ElseIf index = 3 Then
            Dim число As Double
            If Not Double.TryParse(вводимоеЗначение, число) Then
                e.Cancel = True
                MessageBox.Show("Пожалуйста, введите числовое значение.")
            End If
        End If
    End Sub

    Private Sub ДобавлениеРеализации(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim формаДобавленияРеализации As New ФормаДобавленияРеализацииКниги(Me)
        формаДобавленияРеализации.Show()
    End Sub

    Private Sub DropButton_Click(sender As Object, e As EventArgs) Handles DropButton.Click
        If SalesGrid.SelectedRows.Count > 0 Then
            Dim выбранныйКод = CInt(SalesGrid.SelectedRows(0).Cells(0).Value)
            Dim выбраннаяРеализация = My.Application.Контекст.Реализации.First(
                Function(р As Реализация) р.Код = выбранныйКод
            )
            My.Application.Контекст.Реализации.Remove(выбраннаяРеализация)
            My.Application.Контекст.SaveChanges()
            SalesGrid.Rows.RemoveAt(SalesGrid.SelectedRows(0).Index)
            MessageBox.Show("Реализация """ & выбраннаяРеализация.ToString() & """ успешно удалена")
        Else
            MessageBox.Show("Не выбрана запись")
        End If
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Dim реализации = My.Application.Контекст.Реализации.Where(
            Function(р As Реализация) EF.Functions.Like(
                р.ДатаПродажи & My.Application.Контекст.Книги.First(
                    Function(к As Книга) к.Код = р.КодКниги
                ).Название & My.Application.Контекст.Пользователи.First(
                    Function(п As Пользователь) п.Код = р.КодПользователя
                ).Логин, $"%{SearchBox.Text}%"
            )
        )

        SalesGrid.Rows.Clear()
        For Each реализация In реализации
            SalesGrid.Rows.Add(
                реализация.Код,
                реализация.ДатаПродажи,
                реализация.Количество,
                реализация.Цена,
                реализация.КодКниги,
                реализация.КодПользователя
            )
        Next
    End Sub
End Class