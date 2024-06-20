Public Class ФормаДобавленияКниги
    Private формаКниг As ФормаКниг

    Public Sub New(формаКниг As ФормаКниг)
        InitializeComponent()

        Me.формаКниг = формаКниг
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim жанр = GenreBox.Text
        Dim название = TitleBox.Text
        Dim автор = AuthorBox.Text
        Dim цена = PriceBox.Value
        Dim дата = DateTimePicker.Value

        If цена = 0 Then
            MessageBox.Show("Цена должна быть больше 0")

        ElseIf IsNothing(дата) Then
            MessageBox.Show("Выберите дату")

        ElseIf String.IsNullOrEmpty(жанр) Or
        String.IsNullOrEmpty(название) Or
        String.IsNullOrEmpty(автор) Then
            MessageBox.Show("Заполните все поля")

        Else
            Dim книга As New Книга() With {
                .Автор = автор,
                .ДатаИздания = дата,
                .Жанр = жанр,
                .Название = название,
                .Цена = цена
            }

            My.Application.Контекст.Книги.Add(книга)
            My.Application.Контекст.SaveChanges()
            Dim добавленная = My.Application.Контекст.Книги.OrderBy(Function(к As Книга) к.Код).Last()
            формаКниг.BooksGrid.Rows.Add(
                добавленная.Код,
                добавленная.Жанр,
                добавленная.Название,
                добавленная.Автор,
                добавленная.ДатаИздания,
                добавленная.Цена
            )

            MessageBox.Show("Книга " & книга.ToString() & " успешно добавлена")
            Close()
        End If
    End Sub
End Class