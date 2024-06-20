Public Class ФормаАвторизации
    Private Sub КликПоКнопкеВход(sender As Object, e As EventArgs) Handles InButton.Click
        Dim логин = LoginBox.Text
        Dim пароль = PasswordBox.Text

        If String.IsNullOrEmpty(логин) Then
            MessageBox.Show("Заполните логин")
        ElseIf String.IsNullOrEmpty(пароль) Then
            MessageBox.Show("Заполните пароль")
        Else
            Try
                Dim пользователь = My.Application.Контекст.ПолучитьПользователяПоЛогинуИПаролю(логин, пароль)
                My.Application.Пользователь = пользователь
                Hide()
                Dim главнаяФорма As New ГлавнаяФорма()
                главнаяФорма.LoginLabel.Text = логин
                главнаяФорма.Show()
            Catch
                MessageBox.Show("Пользователь не найден")
            End Try
        End If
    End Sub

    Private Sub КликПоКнопкеРегистрации(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim формаРегистрации As New ФормаРегистрации()
        формаРегистрации.Show()
        Hide()
    End Sub

    Private Sub ЗакрытиеФормыАвторизации(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
