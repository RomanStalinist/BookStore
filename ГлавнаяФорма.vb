Public Class ГлавнаяФорма
    Private Sub НавигаторПоКликуНаКнопки(sender As Object, e As EventArgs) Handles BooksButton.Click, SalesButton.Click, UsersButton.Click, LeaveButton.Click
        Dim кнопка = DirectCast(sender, Button)
        Select Case кнопка.Text
            Case "Книги"
                Dim формаКниг As New ФормаКниг()
                формаКниг.ShowDialog()
                Return

            Case "Реализации"
                Dim формаРеализаций As New ФормаРеализаций()
                формаРеализаций.ShowDialog()
                Return

            Case "Пользователи"
                Dim формаПользователей As New ФормаПользователей()
                формаПользователей.ShowDialog()
                Return

            Case "Выход"
                Hide()
                Dim формаАвторизации As New ФормаАвторизации()
                формаАвторизации.Show()
                Return
        End Select
    End Sub

    Private Sub ЗакрытиеГлавнойФормы(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class