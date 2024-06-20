<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ФормаРегистрации
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ФормаРегистрации))
        Label4 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label5 = New Label()
        LoginBox = New TextBox()
        CreateButton = New Button()
        InButton = New Button()
        RepeatPasswordBox = New TextBox()
        Label1 = New Label()
        PasswordBox = New TextBox()
        Label6 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Oracle Sans Semi Bold", 16F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(127, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(241, 29)
        Label4.TabIndex = 0
        Label4.Text = "Книжный магазин"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(182), CByte(166), CByte(250))
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(-6, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(479, 144)
        Panel1.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(LoginBox)
        Panel2.Controls.Add(CreateButton)
        Panel2.Controls.Add(InButton)
        Panel2.Controls.Add(RepeatPasswordBox)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PasswordBox)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(-6, 133)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(479, 209)
        Panel2.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(29, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 25)
        Label5.TabIndex = 0
        Label5.Text = "Логин"
        ' 
        ' LoginBox
        ' 
        LoginBox.AllowDrop = True
        LoginBox.BackColor = SystemColors.Window
        LoginBox.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        LoginBox.ForeColor = Color.Black
        LoginBox.Location = New Point(29, 38)
        LoginBox.Name = "LoginBox"
        LoginBox.Size = New Size(195, 32)
        LoginBox.TabIndex = 1
        LoginBox.WordWrap = False
        ' 
        ' CreateButton
        ' 
        CreateButton.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CreateButton.FlatStyle = FlatStyle.Flat
        CreateButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        CreateButton.ForeColor = Color.White
        CreateButton.Location = New Point(262, 23)
        CreateButton.Name = "CreateButton"
        CreateButton.Size = New Size(167, 75)
        CreateButton.TabIndex = 4
        CreateButton.Text = "Регистрация"
        CreateButton.UseVisualStyleBackColor = False
        ' 
        ' InButton
        ' 
        InButton.BackColor = Color.FromArgb(CByte(77), CByte(59), CByte(254))
        InButton.FlatStyle = FlatStyle.Flat
        InButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        InButton.ForeColor = Color.White
        InButton.Location = New Point(262, 122)
        InButton.Name = "InButton"
        InButton.Size = New Size(167, 72)
        InButton.TabIndex = 5
        InButton.Text = "Войти"
        InButton.UseVisualStyleBackColor = False
        ' 
        ' RepeatPasswordBox
        ' 
        RepeatPasswordBox.AllowDrop = True
        RepeatPasswordBox.BackColor = SystemColors.Window
        RepeatPasswordBox.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        RepeatPasswordBox.ForeColor = Color.Black
        RepeatPasswordBox.Location = New Point(29, 162)
        RepeatPasswordBox.Name = "RepeatPasswordBox"
        RepeatPasswordBox.Size = New Size(195, 32)
        RepeatPasswordBox.TabIndex = 3
        RepeatPasswordBox.UseSystemPasswordChar = True
        RepeatPasswordBox.WordWrap = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(29, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 25)
        Label1.TabIndex = 0
        Label1.Text = "Повторить пароль"
        ' 
        ' PasswordBox
        ' 
        PasswordBox.AllowDrop = True
        PasswordBox.BackColor = SystemColors.Window
        PasswordBox.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        PasswordBox.ForeColor = Color.Black
        PasswordBox.Location = New Point(29, 99)
        PasswordBox.Name = "PasswordBox"
        PasswordBox.Size = New Size(195, 32)
        PasswordBox.TabIndex = 2
        PasswordBox.UseSystemPasswordChar = True
        PasswordBox.WordWrap = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(29, 73)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 25)
        Label6.TabIndex = 0
        Label6.Text = "Пароль"
        ' 
        ' ФормаРегистрации
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(41))
        ClientSize = New Size(464, 341)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ФормаРегистрации"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Регистрация"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents LoginBox As TextBox
    Friend WithEvents CreateButton As Button
    Friend WithEvents InButton As Button
    Friend WithEvents RepeatPasswordBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents Label6 As Label
End Class
