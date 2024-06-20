<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ФормаКниг
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ФормаКниг))
        Panel1 = New Panel()
        Label4 = New Label()
        BooksGrid = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        FindButton = New Button()
        SearchBox = New TextBox()
        Label1 = New Label()
        DropButton = New Button()
        AddButton = New Button()
        Panel1.SuspendLayout()
        CType(BooksGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(182), CByte(166), CByte(250))
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(-5, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(739, 106)
        Panel1.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Oracle Sans Semi Bold", 16F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(250, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(241, 29)
        Label4.TabIndex = 0
        Label4.Text = "Книжный магазин"
        ' 
        ' BooksGrid
        ' 
        BooksGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        BooksGrid.BackgroundColor = SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Oracle Sans", 12F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        BooksGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        BooksGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BooksGrid.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        BooksGrid.Location = New Point(12, 124)
        BooksGrid.MultiSelect = False
        BooksGrid.Name = "BooksGrid"
        BooksGrid.ReadOnly = True
        BooksGrid.ScrollBars = ScrollBars.Vertical
        BooksGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        BooksGrid.Size = New Size(711, 269)
        BooksGrid.TabIndex = 17
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
        Column2.HeaderText = "Жанр"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Название"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Дата издания"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Автор"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Цена"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' FindButton
        ' 
        FindButton.BackColor = Color.FromArgb(CByte(77), CByte(59), CByte(254))
        FindButton.FlatStyle = FlatStyle.Flat
        FindButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        FindButton.ForeColor = Color.White
        FindButton.Location = New Point(306, 408)
        FindButton.Name = "FindButton"
        FindButton.Size = New Size(131, 41)
        FindButton.TabIndex = 27
        FindButton.Text = "Найти"
        FindButton.UseVisualStyleBackColor = False
        ' 
        ' SearchBox
        ' 
        SearchBox.AllowDrop = True
        SearchBox.BackColor = SystemColors.Window
        SearchBox.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        SearchBox.ForeColor = Color.Black
        SearchBox.Location = New Point(97, 413)
        SearchBox.Name = "SearchBox"
        SearchBox.Size = New Size(203, 32)
        SearchBox.TabIndex = 26
        SearchBox.WordWrap = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(20, 416)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 25)
        Label1.TabIndex = 25
        Label1.Text = "Поиск"
        ' 
        ' DropButton
        ' 
        DropButton.BackColor = Color.FromArgb(CByte(77), CByte(59), CByte(254))
        DropButton.FlatStyle = FlatStyle.Flat
        DropButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        DropButton.ForeColor = Color.White
        DropButton.Location = New Point(581, 408)
        DropButton.Name = "DropButton"
        DropButton.Size = New Size(132, 41)
        DropButton.TabIndex = 23
        DropButton.Text = "Удалить"
        DropButton.UseVisualStyleBackColor = False
        ' 
        ' AddButton
        ' 
        AddButton.BackColor = Color.FromArgb(CByte(77), CByte(59), CByte(254))
        AddButton.FlatStyle = FlatStyle.Flat
        AddButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        AddButton.ForeColor = Color.White
        AddButton.Location = New Point(443, 408)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(132, 41)
        AddButton.TabIndex = 24
        AddButton.Text = "Добавить"
        AddButton.UseVisualStyleBackColor = False
        ' 
        ' ФормаКниг
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(735, 461)
        Controls.Add(FindButton)
        Controls.Add(SearchBox)
        Controls.Add(Label1)
        Controls.Add(DropButton)
        Controls.Add(AddButton)
        Controls.Add(BooksGrid)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Font = New Font("JetBrains Mono SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        MinimizeBox = False
        Name = "ФормаКниг"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Книги"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(BooksGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents BooksGrid As DataGridView
    Friend WithEvents КодDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ЖанрDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents НазваниеDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents АвторDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ДатаИзданияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ЦенаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents FindButton As Button
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DropButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
