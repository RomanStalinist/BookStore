<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ФормаРеализаций
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ФормаРеализаций))
        Panel1 = New Panel()
        Label4 = New Label()
        SalesGrid = New DataGridView()
        Column0 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewComboBoxColumn()
        Column5 = New DataGridViewComboBoxColumn()
        AddButton = New Button()
        FindButton = New Button()
        SearchBox = New TextBox()
        Label1 = New Label()
        DropButton = New Button()
        Panel1.SuspendLayout()
        CType(SalesGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(182), CByte(166), CByte(250))
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(724, 106)
        Panel1.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Oracle Sans Semi Bold", 16F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(233, 41)
        Label4.Name = "Label4"
        Label4.Size = New Size(241, 29)
        Label4.TabIndex = 0
        Label4.Text = "Книжный магазин"
        ' 
        ' SalesGrid
        ' 
        SalesGrid.AllowUserToAddRows = False
        SalesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        SalesGrid.BackgroundColor = SystemColors.Control
        SalesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SalesGrid.Columns.AddRange(New DataGridViewColumn() {Column0, Column1, Column2, Column3, Column4, Column5})
        SalesGrid.Location = New Point(16, 125)
        SalesGrid.Name = "SalesGrid"
        SalesGrid.ReadOnly = True
        SalesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        SalesGrid.Size = New Size(693, 266)
        SalesGrid.TabIndex = 18
        ' 
        ' Column0
        ' 
        Column0.HeaderText = "Код"
        Column0.Name = "Column0"
        Column0.ReadOnly = True
        Column0.Visible = False
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Дата продажи"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Количество"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Цена"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Книга"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Resizable = DataGridViewTriState.True
        Column4.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Пользователь"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Resizable = DataGridViewTriState.True
        Column5.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' AddButton
        ' 
        AddButton.BackColor = Color.FromArgb(CByte(77), CByte(59), CByte(254))
        AddButton.FlatStyle = FlatStyle.Flat
        AddButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        AddButton.ForeColor = Color.White
        AddButton.Location = New Point(439, 408)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(132, 41)
        AddButton.TabIndex = 19
        AddButton.Text = "Добавить"
        AddButton.UseVisualStyleBackColor = False
        ' 
        ' FindButton
        ' 
        FindButton.BackColor = Color.FromArgb(CByte(77), CByte(59), CByte(254))
        FindButton.FlatStyle = FlatStyle.Flat
        FindButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        FindButton.ForeColor = Color.White
        FindButton.Location = New Point(302, 408)
        FindButton.Name = "FindButton"
        FindButton.Size = New Size(131, 41)
        FindButton.TabIndex = 22
        FindButton.Text = "Найти"
        FindButton.UseVisualStyleBackColor = False
        ' 
        ' SearchBox
        ' 
        SearchBox.AllowDrop = True
        SearchBox.BackColor = SystemColors.Window
        SearchBox.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        SearchBox.ForeColor = Color.Black
        SearchBox.Location = New Point(93, 413)
        SearchBox.Name = "SearchBox"
        SearchBox.Size = New Size(203, 32)
        SearchBox.TabIndex = 21
        SearchBox.WordWrap = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(16, 416)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 25)
        Label1.TabIndex = 20
        Label1.Text = "Поиск"
        ' 
        ' DropButton
        ' 
        DropButton.BackColor = Color.FromArgb(CByte(77), CByte(59), CByte(254))
        DropButton.FlatStyle = FlatStyle.Flat
        DropButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        DropButton.ForeColor = Color.White
        DropButton.Location = New Point(577, 408)
        DropButton.Name = "DropButton"
        DropButton.Size = New Size(132, 41)
        DropButton.TabIndex = 19
        DropButton.Text = "Удалить"
        DropButton.UseVisualStyleBackColor = False
        ' 
        ' ФормаРеализаций
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(721, 461)
        Controls.Add(FindButton)
        Controls.Add(SearchBox)
        Controls.Add(Label1)
        Controls.Add(DropButton)
        Controls.Add(AddButton)
        Controls.Add(SalesGrid)
        Controls.Add(Panel1)
        Font = New Font("Oracle Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "ФормаРеализаций"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Реализации"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(SalesGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents SalesGrid As DataGridView
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewComboBoxColumn
    Friend WithEvents Column5 As DataGridViewComboBoxColumn
    Friend WithEvents AddButton As Button
    Friend WithEvents FindButton As Button
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DropButton As Button
End Class
