Imports Microsoft.EntityFrameworkCore

Public Class Контекст
    Inherits DbContext

    Public Property Пользователи As DbSet(Of Пользователь)
    Public Property Книги As DbSet(Of Книга)
    Public Property Реализации As DbSet(Of Реализация)

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        MyBase.OnConfiguring(optionsBuilder)
        optionsBuilder.UseSqlite("Data Source=бд/магазин.sqlite3")
    End Sub

    Public Function ПолучитьПользователей() As List(Of Пользователь)
        Return Пользователи.ToList()
    End Function

    Public Function ПолучитьПользователяПоЛогинуИПаролю(логин As String, пароль As String) As Пользователь
        Dim Пользователь = Пользователи.First(Function(U As Пользователь) U.Логин = логин And U.Пароль = пароль)

        If IsNothing(Пользователь) Then
            Throw New Exception("Пользователь не найден")
        Else
            Return Пользователь
        End If
    End Function

    Public Function ПолучитьКниги() As List(Of Книга)
        Return Книги.ToList()
    End Function

    Public Function ПолучитьКнигиПоПриблизительномуНазванию(приблизительноеНазвание As String) As List(Of Книга)
        Return Книги.Where(
            Function(B As Книга) EF.Functions.Like(B.Название, $"%{приблизительноеНазвание}%")
        ).ToList()
    End Function

    Public Function ПолучитьРеализации() As List(Of Реализация)
        Return Реализации.ToList()
    End Function

    Public Function ПолучитьРеализацииСортированныеПоДатеОтБолееПоздней() As List(Of Реализация)
        Return Реализации.OrderByDescending(Function(S As Реализация) S.ДатаПродажи).ToList()
    End Function
End Class
