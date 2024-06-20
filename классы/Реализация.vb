Imports System.ComponentModel.DataAnnotations

Public Class Реализация
    <Key>
    Public Property Код As Integer
    Public Property ДатаПродажи As String
    Public Property Количество As Integer
    Public Property Цена As Decimal
    Public Property КодКниги As Integer
    Public Property КодПользователя As Integer
    Public Overrides Function ToString() As String
        Return $"{ДатаПродажи} {Количество} {Цена}"
    End Function
End Class
