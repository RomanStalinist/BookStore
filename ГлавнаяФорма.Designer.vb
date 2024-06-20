<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ГлавнаяФорма
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ГлавнаяФорма))
        Panel2 = New Panel()
        LeaveButton = New Button()
        UsersButton = New Button()
        SalesButton = New Button()
        BooksButton = New Button()
        Panel1 = New Panel()
        LoginLabel = New Label()
        Label4 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(LoginLabel)
        Panel2.Controls.Add(LeaveButton)
        Panel2.Controls.Add(UsersButton)
        Panel2.Controls.Add(SalesButton)
        Panel2.Controls.Add(BooksButton)
        Panel2.Location = New Point(-7, 134)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(479, 242)
        Panel2.TabIndex = 16
        ' 
        ' LeaveButton
        ' 
        LeaveButton.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        LeaveButton.FlatStyle = FlatStyle.Flat
        LeaveButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        LeaveButton.ForeColor = Color.White
        LeaveButton.Location = New Point(156, 154)
        LeaveButton.Name = "LeaveButton"
        LeaveButton.Size = New Size(167, 41)
        LeaveButton.TabIndex = 2
        LeaveButton.Text = "Выход"
        LeaveButton.UseVisualStyleBackColor = False
        ' 
        ' UsersButton
        ' 
        UsersButton.BackColor = Color.FromArgb(CByte(77), CByte(59), CByte(254))
        UsersButton.FlatStyle = FlatStyle.Flat
        UsersButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        UsersButton.ForeColor = Color.White
        UsersButton.Location = New Point(156, 107)
        UsersButton.Name = "UsersButton"
        UsersButton.Size = New Size(167, 41)
        UsersButton.TabIndex = 2
        UsersButton.Text = "Пользователи"
        UsersButton.UseVisualStyleBackColor = False
        ' 
        ' SalesButton
        ' 
        SalesButton.BackColor = Color.FromArgb(CByte(77), CByte(59), CByte(254))
        SalesButton.FlatStyle = FlatStyle.Flat
        SalesButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        SalesButton.ForeColor = Color.White
        SalesButton.Location = New Point(156, 60)
        SalesButton.Name = "SalesButton"
        SalesButton.Size = New Size(167, 41)
        SalesButton.TabIndex = 2
        SalesButton.Text = "Реализации"
        SalesButton.UseVisualStyleBackColor = False
        ' 
        ' BooksButton
        ' 
        BooksButton.BackColor = Color.FromArgb(CByte(77), CByte(59), CByte(254))
        BooksButton.FlatStyle = FlatStyle.Flat
        BooksButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        BooksButton.ForeColor = Color.White
        BooksButton.Location = New Point(156, 14)
        BooksButton.Name = "BooksButton"
        BooksButton.Size = New Size(167, 40)
        BooksButton.TabIndex = 2
        BooksButton.Text = "Книги"
        BooksButton.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(182), CByte(166), CByte(250))
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(-7, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(479, 144)
        Panel1.TabIndex = 15
        ' 
        ' LoginLabel
        ' 
        LoginLabel.AutoSize = True
        LoginLabel.BackColor = Color.White
        LoginLabel.Font = New Font("Oracle Sans Semi Bold", 14F, FontStyle.Bold)
        LoginLabel.ForeColor = Color.Black
        LoginLabel.Location = New Point(19, 206)
        LoginLabel.Name = "LoginLabel"
        LoginLabel.Size = New Size(71, 25)
        LoginLabel.TabIndex = 0
        LoginLabel.Text = "Логин"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Oracle Sans Semi Bold", 16F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(117, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(241, 29)
        Label4.TabIndex = 0
        Label4.Text = "Книжный магазин"
        ' 
        ' ГлавнаяФорма
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(41))
        ClientSize = New Size(464, 374)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ГлавнаяФорма"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Главная"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents SalesButton As Button
    Friend WithEvents BooksButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents LeaveButton As Button
    Friend WithEvents UsersButton As Button
    Friend WithEvents LoginLabel As Label
End Class
