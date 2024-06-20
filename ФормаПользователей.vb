Imports Microsoft.EntityFrameworkCore

Public Class ФормаПользователей
    Public Sub New()
        InitializeComponent()

        Dim пользователи = My.Application.Контекст.Пользователи
        For Each пользователь In пользователи
            UsersGrid.Rows.Add(пользователь.Код, пользователь.Логин)
        Next
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Dim запрос As String = SearchBox.Text
        Dim пользователи = My.Application.Контекст.Пользователи.Where(
            Function(п As Пользователь) EF.Functions.Like(п.Код & п.Логин, $"%{запрос}%")
        )

        UsersGrid.Rows.Clear()
        For Each пользователь In пользователи
            UsersGrid.Rows.Add(пользователь.Код, пользователь.Логин)
        Next
    End Sub
End Class