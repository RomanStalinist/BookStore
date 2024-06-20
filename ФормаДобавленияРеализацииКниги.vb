Public Class ФормаДобавленияРеализацииКниги
    Private формаРеализаций As ФормаРеализаций

    Public Sub New(формаРеализаций As ФормаРеализаций)
        InitializeComponent()

        Me.формаРеализаций = формаРеализаций
        For Each книга In My.Application.Контекст.ПолучитьКниги()
            BooksBox.Items.Add(книга)
        Next

        For Each пользователь In My.Application.Контекст.ПолучитьПользователей()
            UsersBox.Items.Add(пользователь)
        Next
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try

            Dim книга = DirectCast(BooksBox.SelectedItem, Книга)
            Dim пользователь = DirectCast(UsersBox.SelectedItem, Пользователь)
            Dim количество = CountBox.Value
            Dim дата = DateTimePicker.Value

            If IsNothing(дата) Or
            IsNothing(книга) Or
            IsNothing(пользователь) Then
                MessageBox.Show("Выберите дату, книгу и пользователя")

            Else
                Dim цена = количество * книга.Цена
                PriceBox.Value = цена

                If количество = 0 Then
                    MessageBox.Show("Количество быть больше 0")

                Else
                    Dim реализация As New Реализация() With {
                        .ДатаПродажи = дата,
                        .Количество = количество,
                        .Цена = цена,
                        .КодКниги = книга.Код,
                        .КодПользователя = пользователь.Код
                    }

                    My.Application.Контекст.Реализации.Add(реализация)
                    My.Application.Контекст.SaveChanges()
                    Dim добавленная = My.Application.Контекст.Реализации.OrderBy(Function(р As Реализация) р.Код).Last()
                    формаРеализаций.SalesGrid.Rows.Add(
                        добавленная.Код,
                        добавленная.ДатаПродажи,
                        добавленная.Количество,
                        добавленная.Цена,
                        добавленная.КодКниги,
                        добавленная.КодПользователя
                    )

                    MessageBox.Show("Реализация """ & реализация.ToString() & """ успешно добавлена")
                    Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class