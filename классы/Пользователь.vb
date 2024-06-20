Imports System.ComponentModel.DataAnnotations

Public Class Пользователь
    <Key>
    Public Property Код As Integer
    Public Property Логин As String
    Public Property Пароль As String
    Public Overrides Function ToString() As String
        Return Логин
    End Function
End Class
