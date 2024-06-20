<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ФормаДобавленияРеализацииКниги
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ФормаДобавленияРеализацииКниги))
        PriceBox = New NumericUpDown()
        DateTimePicker = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        AddButton = New Button()
        BooksBox = New ComboBox()
        Label3 = New Label()
        UsersBox = New ComboBox()
        CountBox = New NumericUpDown()
        CType(PriceBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(CountBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PriceBox
        ' 
        PriceBox.DecimalPlaces = 2
        PriceBox.Font = New Font("Oracle Sans", 14.2499981F)
        PriceBox.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        PriceBox.Location = New Point(12, 165)
        PriceBox.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        PriceBox.Name = "PriceBox"
        PriceBox.ReadOnly = True
        PriceBox.Size = New Size(203, 32)
        PriceBox.TabIndex = 27
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.CalendarFont = New Font("Oracle Sans", 10F)
        DateTimePicker.CustomFormat = ""
        DateTimePicker.Font = New Font("Oracle Sans", 14.2499981F)
        DateTimePicker.Format = DateTimePickerFormat.Short
        DateTimePicker.Location = New Point(9, 38)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(206, 32)
        DateTimePicker.TabIndex = 28
        DateTimePicker.Value = New Date(2024, 6, 20, 0, 0, 0, 0)
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(6, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(152, 25)
        Label5.TabIndex = 30
        Label5.Text = "Дата продажи"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(9, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 25)
        Label4.TabIndex = 31
        Label4.Text = "Цена"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(233, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 25)
        Label2.TabIndex = 33
        Label2.Text = "Книга"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(9, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 25)
        Label1.TabIndex = 34
        Label1.Text = "Количество"
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
        AddButton.TabIndex = 29
        AddButton.Text = "Добавить"
        AddButton.UseVisualStyleBackColor = False
        ' 
        ' BooksBox
        ' 
        BooksBox.Font = New Font("Oracle Sans", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        BooksBox.FormattingEnabled = True
        BooksBox.Location = New Point(237, 37)
        BooksBox.Name = "BooksBox"
        BooksBox.Size = New Size(199, 33)
        BooksBox.TabIndex = 35
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Oracle Sans Semi Bold", 14.2499981F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(233, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(153, 25)
        Label3.TabIndex = 33
        Label3.Text = "Пользователь"
        ' 
        ' UsersBox
        ' 
        UsersBox.Font = New Font("Oracle Sans", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        UsersBox.FormattingEnabled = True
        UsersBox.Location = New Point(237, 104)
        UsersBox.Name = "UsersBox"
        UsersBox.Size = New Size(199, 33)
        UsersBox.TabIndex = 35
        ' 
        ' CountBox
        ' 
        CountBox.Font = New Font("Oracle Sans", 14.2499981F)
        CountBox.Location = New Point(12, 105)
        CountBox.Name = "CountBox"
        CountBox.Size = New Size(203, 32)
        CountBox.TabIndex = 27
        ' 
        ' ФормаДобавленияРеализацииКниги
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(457, 209)
        Controls.Add(UsersBox)
        Controls.Add(BooksBox)
        Controls.Add(CountBox)
        Controls.Add(PriceBox)
        Controls.Add(DateTimePicker)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(AddButton)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ФормаДобавленияРеализацииКниги"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Добавление реализации"
        CType(PriceBox, ComponentModel.ISupportInitialize).EndInit()
        CType(CountBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PriceBox As NumericUpDown
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents UsersBox As ComboBox
    Friend WithEvents BooksBox As ComboBox
    Friend WithEvents CountBox As NumericUpDown
End Class
