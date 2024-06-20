Public Class ФормаРегистрации
    Private Sub КликПоКнопкеРегистрации(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim логин = LoginBox.Text
        Dim пароль = PasswordBox.Text
        Dim повторенный = RepeatPasswordBox.Text

        If String.IsNullOrEmpty(логин) Or String.IsNullOrEmpty(пароль) Or String.IsNullOrEmpty(повторенный) Then
            MessageBox.Show("Заполните все поля")
        ElseIf пароль <> повторенный Then
            MessageBox.Show("Пароли не совпадают")
        Else
            Try
                Dim пользователь As New Пользователь With {.Логин = логин, .Пароль = пароль}
                My.Application.Контекст.Пользователи.Add(пользователь)
                My.Application.Контекст.SaveChanges()
                My.Application.Пользователь = пользователь
                MessageBox.Show("Добро пожаловать, " & логин)
                Hide()
                Dim главнаяФорма As New ГлавнаяФорма
                главнаяФорма.LoginLabel.Text = логин
                главнаяФорма.Show()
            Catch ex As Exception
                MessageBox.Show("Ошибка " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub КликПоКнопкеВход(sender As Object, e As EventArgs) Handles InButton.Click
        Hide()
        Dim формаАвторизации As New ФормаАвторизации
        формаАвторизации.Show()
    End Sub

    Private Sub ЗакрытиеФормыРегистрации(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class