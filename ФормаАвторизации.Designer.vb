<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ФормаАвторизации
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ФормаАвторизации))
        LoginBox = New TextBox()
        PasswordBox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        InButton = New Button()
        CreateButton = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' LoginBox
        ' 
        LoginBox.AllowDrop = True
        LoginBox.BackColor = SystemColors.Window
        LoginBox.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        LoginBox.ForeColor = Color.Black
        LoginBox.Location = New Point(31, 40)
        LoginBox.Name = "LoginBox"
        LoginBox.Size = New Size(167, 32)
        LoginBox.TabIndex = 1
        LoginBox.WordWrap = False
        ' 
        ' PasswordBox
        ' 
        PasswordBox.AllowDrop = True
        PasswordBox.BackColor = SystemColors.Window
        PasswordBox.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        PasswordBox.ForeColor = Color.Black
        PasswordBox.Location = New Point(31, 110)
        PasswordBox.Name = "PasswordBox"
        PasswordBox.Size = New Size(167, 32)
        PasswordBox.TabIndex = 2
        PasswordBox.UseSystemPasswordChar = True
        PasswordBox.WordWrap = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(31, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 25)
        Label2.TabIndex = 0
        Label2.Text = "Логин"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(31, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 25)
        Label3.TabIndex = 0
        Label3.Text = "Пароль"
        ' 
        ' InButton
        ' 
        InButton.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        InButton.FlatStyle = FlatStyle.Flat
        InButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        InButton.ForeColor = Color.White
        InButton.Location = New Point(264, 30)
        InButton.Name = "InButton"
        InButton.Size = New Size(167, 40)
        InButton.TabIndex = 3
        InButton.Text = "Войти"
        InButton.UseVisualStyleBackColor = False
        ' 
        ' CreateButton
        ' 
        CreateButton.BackColor = Color.FromArgb(CByte(77), CByte(59), CByte(254))
        CreateButton.FlatStyle = FlatStyle.Flat
        CreateButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        CreateButton.ForeColor = Color.White
        CreateButton.Location = New Point(264, 101)
        CreateButton.Name = "CreateButton"
        CreateButton.Size = New Size(167, 41)
        CreateButton.TabIndex = 4
        CreateButton.Text = "Регистрация"
        CreateButton.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(182), CByte(166), CByte(250))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-7, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(471, 166)
        Panel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Oracle Sans Semi Bold", 16F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(116, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(241, 29)
        Label1.TabIndex = 0
        Label1.Text = "Книжный магазин"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(LoginBox)
        Panel2.Controls.Add(CreateButton)
        Panel2.Controls.Add(InButton)
        Panel2.Controls.Add(PasswordBox)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(-7, 159)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(471, 181)
        Panel2.TabIndex = 4
        ' 
        ' ФормаАвторизации
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(41))
        ClientSize = New Size(464, 341)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        ForeColor = SystemColors.Control
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "ФормаАвторизации"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Авторизация"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents LoginBox As TextBox
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents InButton As Button
    Friend WithEvents CreateButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label

End Class
