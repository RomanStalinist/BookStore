Imports Microsoft.EntityFrameworkCore

Public Class ФормаКниг
    Public Sub New()
        InitializeComponent()

        Dim книги = My.Application.Контекст.Книги
        BooksGrid.Rows.Clear()

        For Each книга In книги
            BooksGrid.Rows.Add(книга.Код, книга.Жанр, книга.Название, книга.ДатаИздания, книга.Автор,
                               книга.Цена)
        Next
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim формаДобавленияКниги As New ФормаДобавленияКниги(Me)
        формаДобавленияКниги.Show()
    End Sub

    Private Sub DropButton_Click(sender As Object, e As EventArgs) Handles DropButton.Click
        If BooksGrid.SelectedRows.Count > 0 Then
            Dim выбранныйКод = CInt(BooksGrid.SelectedRows(0).Cells(0).Value)
            Dim выбраннаяКнига = My.Application.Контекст.Книги.First(
                Function(к As Книга) к.Код = выбранныйКод
            )
            My.Application.Контекст.Книги.Remove(выбраннаяКнига)
            My.Application.Контекст.SaveChanges()
            BooksGrid.Rows.RemoveAt(BooksGrid.SelectedRows(0).Index)
            MessageBox.Show("Книга " & выбраннаяКнига.ToString() & " успешно удалена")
        Else
            MessageBox.Show("Не выбрана запись")
        End If
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Dim запрос As String = SearchBox.Text
        Dim книги = My.Application.Контекст.Книги.Where(
            Function(к As Книга) EF.Functions.Like(к.Название & к.Автор & к.Жанр, $"%{запрос}%")
        )

        BooksGrid.Rows.Clear()
        For Each книга In книги
            BooksGrid.Rows.Add(книга.Код, книга.Жанр, книга.Название, книга.ДатаИздания, книга.Автор,
                               книга.Цена)
        Next
    End Sub
End Class