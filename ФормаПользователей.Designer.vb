<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ФормаПользователей
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ФормаПользователей))
        Panel1 = New Panel()
        Label4 = New Label()
        UsersGrid = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        FindButton = New Button()
        SearchBox = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(UsersGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(182), CByte(166), CByte(250))
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(-5, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(293, 113)
        Panel1.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Oracle Sans Semi Bold", 16F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(22, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(241, 29)
        Label4.TabIndex = 0
        Label4.Text = "Книжный магазин"
        ' 
        ' UsersGrid
        ' 
        UsersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        UsersGrid.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Oracle Sans", 12F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        UsersGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        UsersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        UsersGrid.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Oracle Sans", 12F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        UsersGrid.DefaultCellStyle = DataGridViewCellStyle2
        UsersGrid.Location = New Point(17, 132)
        UsersGrid.Name = "UsersGrid"
        UsersGrid.ReadOnly = True
        UsersGrid.Size = New Size(254, 304)
        UsersGrid.TabIndex = 18
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Код"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Visible = False
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Логин"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' FindButton
        ' 
        FindButton.BackColor = Color.FromArgb(CByte(77), CByte(59), CByte(254))
        FindButton.FlatStyle = FlatStyle.Flat
        FindButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        FindButton.ForeColor = Color.White
        FindButton.Location = New Point(17, 517)
        FindButton.Name = "FindButton"
        FindButton.Size = New Size(254, 41)
        FindButton.TabIndex = 25
        FindButton.Text = "Найти"
        FindButton.UseVisualStyleBackColor = False
        ' 
        ' SearchBox
        ' 
        SearchBox.AllowDrop = True
        SearchBox.BackColor = SystemColors.Window
        SearchBox.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        SearchBox.ForeColor = Color.Black
        SearchBox.Location = New Point(17, 479)
        SearchBox.Name = "SearchBox"
        SearchBox.Size = New Size(254, 32)
        SearchBox.TabIndex = 24
        SearchBox.WordWrap = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(17, 451)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 25)
        Label1.TabIndex = 23
        Label1.Text = "Поиск"
        ' 
        ' ФормаПользователей
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(287, 570)
        Controls.Add(FindButton)
        Controls.Add(SearchBox)
        Controls.Add(Label1)
        Controls.Add(UsersGrid)
        Controls.Add(Panel1)
        Font = New Font("Oracle Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ФормаПользователей"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Пользователи"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UsersGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents UsersGrid As DataGridView
    Friend WithEvents КодDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ЛогинDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ПарольDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents FindButton As Button
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Label1 As Label
End Class
