Imports System.ComponentModel.DataAnnotations

Public Class Книга
    <Key>
    Public Property Код As Integer
    Public Property Жанр As String
    Public Property Название As String
    Public Property Автор As String
    Public Property ДатаИздания As String
    Public Property Цена As Decimal
    Public Overrides Function ToString() As String
        Return Название
    End Function
End Class
