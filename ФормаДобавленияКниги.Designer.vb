<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ФормаДобавленияКниги
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ФормаДобавленияКниги))
        GenreBox = New TextBox()
        Label1 = New Label()
        AddButton = New Button()
        Label2 = New Label()
        TitleBox = New TextBox()
        Label3 = New Label()
        AuthorBox = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        DateTimePicker = New DateTimePicker()
        PriceBox = New NumericUpDown()
        CType(PriceBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GenreBox
        ' 
        GenreBox.AllowDrop = True
        GenreBox.BackColor = SystemColors.Window
        GenreBox.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        GenreBox.ForeColor = Color.Black
        GenreBox.Location = New Point(12, 37)
        GenreBox.Name = "GenreBox"
        GenreBox.Size = New Size(203, 32)
        GenreBox.TabIndex = 1
        GenreBox.WordWrap = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 25)
        Label1.TabIndex = 23
        Label1.Text = "Жанр"
        ' 
        ' AddButton
        ' 
        AddButton.BackColor = Color.FromArgb(CByte(77), CByte(59), CByte(254))
        AddButton.FlatStyle = FlatStyle.Flat
        AddButton.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        AddButton.ForeColor = Color.White
        AddButton.Location = New Point(237, 156)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(203, 41)
        AddButton.TabIndex = 6
        AddButton.Text = "Добавить"
        AddButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(12, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 25)
        Label2.TabIndex = 23
        Label2.Text = "Название"
        ' 
        ' TitleBox
        ' 
        TitleBox.AllowDrop = True
        TitleBox.BackColor = SystemColors.Window
        TitleBox.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        TitleBox.ForeColor = Color.Black
        TitleBox.Location = New Point(12, 100)
        TitleBox.Name = "TitleBox"
        TitleBox.Size = New Size(203, 32)
        TitleBox.TabIndex = 2
        TitleBox.WordWrap = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(12, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 25)
        Label3.TabIndex = 23
        Label3.Text = "Автор"
        ' 
        ' AuthorBox
        ' 
        AuthorBox.AllowDrop = True
        AuthorBox.BackColor = SystemColors.Window
        AuthorBox.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        AuthorBox.ForeColor = Color.Black
        AuthorBox.Location = New Point(12, 165)
        AuthorBox.Name = "AuthorBox"
        AuthorBox.Size = New Size(203, 32)
        AuthorBox.TabIndex = 3
        AuthorBox.WordWrap = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(237, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 25)
        Label4.TabIndex = 23
        Label4.Text = "Цена"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(237, 72)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 25)
        Label5.TabIndex = 23
        Label5.Text = "Дата издания"
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.CalendarFont = New Font("Oracle Sans", 10F)
        DateTimePicker.CustomFormat = ""
        DateTimePicker.Font = New Font("Oracle Sans", 14.2499981F)
        DateTimePicker.Format = DateTimePickerFormat.Short
        DateTimePicker.Location = New Point(240, 100)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(200, 32)
        DateTimePicker.TabIndex = 5
        DateTimePicker.Value = New Date(2024, 6, 20, 0, 0, 0, 0)
        ' 
        ' PriceBox
        ' 
        PriceBox.DecimalPlaces = 2
        PriceBox.Font = New Font("Oracle Sans", 14.2499981F)
        PriceBox.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        PriceBox.Location = New Point(240, 37)
        PriceBox.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        PriceBox.Name = "PriceBox"
        PriceBox.Size = New Size(120, 32)
        PriceBox.TabIndex = 4
        ' 
        ' ФормаДобавленияКниги
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(463, 215)
        Controls.Add(PriceBox)
        Controls.Add(DateTimePicker)
        Controls.Add(AuthorBox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TitleBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(GenreBox)
        Controls.Add(Label1)
        Controls.Add(AddButton)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ФормаДобавленияКниги"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Добавление книги"
        CType(PriceBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GenreBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TitleBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AuthorBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents PriceBox As NumericUpDown
End Class
