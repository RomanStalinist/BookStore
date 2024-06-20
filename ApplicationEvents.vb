Namespace My
    Partial Friend Class MyApplication
        Public Контекст As New Контекст()
        Public Пользователь As Пользователь

        Protected Overrides Sub OnShutdown()
            Контекст.Dispose()
            MyBase.OnShutdown()
        End Sub
    End Class
End Namespace
