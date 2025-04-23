<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TxtName = New TextBox()
        TxtSurname = New TextBox()
        TxtContact = New TextBox()
        LblName = New Label()
        LblSurname = New Label()
        LblContact = New Label()
        GroupBox1 = New GroupBox()
        RadGamingLaptop = New RadioButton()
        RadBusinessLaptop = New RadioButton()
        RadStudentLaptop = New RadioButton()
        GroupBox2 = New GroupBox()
        ChkLaptopBag = New CheckBox()
        ChkMechanicalKeyboard = New CheckBox()
        ChkwirelessMouse = New CheckBox()
        BtnShowDiscountOffer = New Button()
        BtnClearAll = New Button()
        BtnExit = New Button()
        LblDiscount = New Label()
        LblVAT = New Label()
        LblTotal = New Label()
        LblSubTotal = New Label()
        TxtSubTotal = New TextBox()
        TxtDiscount = New TextBox()
        TxtVAT = New TextBox()
        TxtTotal = New TextBox()
        LstDisplay = New ListBox()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(147, 272)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(125, 27)
        TxtName.TabIndex = 0
        ' 
        ' TxtSurname
        ' 
        TxtSurname.Location = New Point(147, 326)
        TxtSurname.Name = "TxtSurname"
        TxtSurname.Size = New Size(125, 27)
        TxtSurname.TabIndex = 1
        ' 
        ' TxtContact
        ' 
        TxtContact.Location = New Point(147, 373)
        TxtContact.Name = "TxtContact"
        TxtContact.Size = New Size(125, 27)
        TxtContact.TabIndex = 2
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.Location = New Point(35, 279)
        LblName.Name = "LblName"
        LblName.Size = New Size(49, 20)
        LblName.TabIndex = 4
        LblName.Text = "Name"
        ' 
        ' LblSurname
        ' 
        LblSurname.AutoSize = True
        LblSurname.Location = New Point(35, 329)
        LblSurname.Name = "LblSurname"
        LblSurname.Size = New Size(67, 20)
        LblSurname.TabIndex = 5
        LblSurname.Text = "Surname"
        ' 
        ' LblContact
        ' 
        LblContact.AutoSize = True
        LblContact.Location = New Point(35, 380)
        LblContact.Name = "LblContact"
        LblContact.Size = New Size(60, 20)
        LblContact.TabIndex = 6
        LblContact.Text = "Contact"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadGamingLaptop)
        GroupBox1.Controls.Add(RadBusinessLaptop)
        GroupBox1.Controls.Add(RadStudentLaptop)
        GroupBox1.Location = New Point(22, 431)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 125)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupA"
        ' 
        ' RadGamingLaptop
        ' 
        RadGamingLaptop.AutoSize = True
        RadGamingLaptop.Location = New Point(4, 96)
        RadGamingLaptop.Name = "RadGamingLaptop"
        RadGamingLaptop.Size = New Size(207, 24)
        RadGamingLaptop.TabIndex = 2
        RadGamingLaptop.TabStop = True
        RadGamingLaptop.Text = "Gaming Laptop (R9000.00)"
        RadGamingLaptop.UseVisualStyleBackColor = True
        ' 
        ' RadBusinessLaptop
        ' 
        RadBusinessLaptop.AutoSize = True
        RadBusinessLaptop.Location = New Point(6, 63)
        RadBusinessLaptop.Name = "RadBusinessLaptop"
        RadBusinessLaptop.Size = New Size(207, 24)
        RadBusinessLaptop.TabIndex = 1
        RadBusinessLaptop.TabStop = True
        RadBusinessLaptop.Text = "Business laptop (R7000.00)"
        RadBusinessLaptop.UseVisualStyleBackColor = True
        ' 
        ' RadStudentLaptop
        ' 
        RadStudentLaptop.AutoSize = True
        RadStudentLaptop.Location = New Point(7, 27)
        RadStudentLaptop.Name = "RadStudentLaptop"
        RadStudentLaptop.Size = New Size(206, 24)
        RadStudentLaptop.TabIndex = 0
        RadStudentLaptop.TabStop = True
        RadStudentLaptop.Text = "Student Laptop (R5000.00)"
        RadStudentLaptop.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ChkLaptopBag)
        GroupBox2.Controls.Add(ChkMechanicalKeyboard)
        GroupBox2.Controls.Add(ChkwirelessMouse)
        GroupBox2.Location = New Point(288, 431)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(250, 125)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupB"
        ' 
        ' ChkLaptopBag
        ' 
        ChkLaptopBag.AutoSize = True
        ChkLaptopBag.Location = New Point(5, 94)
        ChkLaptopBag.Name = "ChkLaptopBag"
        ChkLaptopBag.Size = New Size(155, 24)
        ChkLaptopBag.TabIndex = 2
        ChkLaptopBag.Text = "Laptpo Bag (R250)"
        ChkLaptopBag.UseVisualStyleBackColor = True
        ' 
        ' ChkMechanicalKeyboard
        ' 
        ChkMechanicalKeyboard.AutoSize = True
        ChkMechanicalKeyboard.Location = New Point(3, 60)
        ChkMechanicalKeyboard.Name = "ChkMechanicalKeyboard"
        ChkMechanicalKeyboard.Size = New Size(240, 24)
        ChkMechanicalKeyboard.TabIndex = 1
        ChkMechanicalKeyboard.Text = "mechanical Keyboard (R150.00)"
        ChkMechanicalKeyboard.UseVisualStyleBackColor = True
        ' 
        ' ChkwirelessMouse
        ' 
        ChkwirelessMouse.AutoSize = True
        ChkwirelessMouse.Location = New Point(5, 27)
        ChkwirelessMouse.Name = "ChkwirelessMouse"
        ChkwirelessMouse.Size = New Size(200, 24)
        ChkwirelessMouse.TabIndex = 0
        ChkwirelessMouse.Text = "Wireless Mouse (R100.00)"
        ChkwirelessMouse.UseVisualStyleBackColor = True
        ' 
        ' BtnShowDiscountOffer
        ' 
        BtnShowDiscountOffer.Location = New Point(25, 597)
        BtnShowDiscountOffer.Name = "BtnShowDiscountOffer"
        BtnShowDiscountOffer.Size = New Size(201, 29)
        BtnShowDiscountOffer.TabIndex = 9
        BtnShowDiscountOffer.Text = "Show Discount Offer"
        BtnShowDiscountOffer.UseVisualStyleBackColor = True
        ' 
        ' BtnClearAll
        ' 
        BtnClearAll.Location = New Point(247, 597)
        BtnClearAll.Name = "BtnClearAll"
        BtnClearAll.Size = New Size(214, 29)
        BtnClearAll.TabIndex = 10
        BtnClearAll.Text = "Clear All"
        BtnClearAll.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(497, 597)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(208, 29)
        BtnExit.TabIndex = 11
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' LblDiscount
        ' 
        LblDiscount.AutoSize = True
        LblDiscount.Location = New Point(622, 474)
        LblDiscount.Name = "LblDiscount"
        LblDiscount.Size = New Size(67, 20)
        LblDiscount.TabIndex = 14
        LblDiscount.Text = "Discount"
        ' 
        ' LblVAT
        ' 
        LblVAT.AutoSize = True
        LblVAT.Location = New Point(622, 512)
        LblVAT.Name = "LblVAT"
        LblVAT.Size = New Size(34, 20)
        LblVAT.TabIndex = 15
        LblVAT.Text = "VAT"
        ' 
        ' LblTotal
        ' 
        LblTotal.AutoSize = True
        LblTotal.Location = New Point(622, 551)
        LblTotal.Name = "LblTotal"
        LblTotal.Size = New Size(42, 20)
        LblTotal.TabIndex = 16
        LblTotal.Text = "Total"
        ' 
        ' LblSubTotal
        ' 
        LblSubTotal.AutoSize = True
        LblSubTotal.Location = New Point(622, 431)
        LblSubTotal.Name = "LblSubTotal"
        LblSubTotal.Size = New Size(67, 20)
        LblSubTotal.TabIndex = 13
        LblSubTotal.Text = "SubTotal"
        ' 
        ' TxtSubTotal
        ' 
        TxtSubTotal.Location = New Point(747, 424)
        TxtSubTotal.Name = "TxtSubTotal"
        TxtSubTotal.Size = New Size(125, 27)
        TxtSubTotal.TabIndex = 17
        ' 
        ' TxtDiscount
        ' 
        TxtDiscount.Location = New Point(747, 467)
        TxtDiscount.Name = "TxtDiscount"
        TxtDiscount.Size = New Size(125, 27)
        TxtDiscount.TabIndex = 18
        ' 
        ' TxtVAT
        ' 
        TxtVAT.Location = New Point(747, 505)
        TxtVAT.Name = "TxtVAT"
        TxtVAT.Size = New Size(125, 27)
        TxtVAT.TabIndex = 19
        ' 
        ' TxtTotal
        ' 
        TxtTotal.Location = New Point(749, 548)
        TxtTotal.Name = "TxtTotal"
        TxtTotal.Size = New Size(125, 27)
        TxtTotal.TabIndex = 20
        ' 
        ' LstDisplay
        ' 
        LstDisplay.FormattingEnabled = True
        LstDisplay.Location = New Point(345, 233)
        LstDisplay.Name = "LstDisplay"
        LstDisplay.Size = New Size(523, 184)
        LstDisplay.TabIndex = 21
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(169, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(530, 204)
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 657)
        Controls.Add(PictureBox1)
        Controls.Add(LstDisplay)
        Controls.Add(TxtTotal)
        Controls.Add(TxtVAT)
        Controls.Add(TxtDiscount)
        Controls.Add(TxtSubTotal)
        Controls.Add(LblTotal)
        Controls.Add(LblVAT)
        Controls.Add(LblDiscount)
        Controls.Add(LblSubTotal)
        Controls.Add(BtnExit)
        Controls.Add(BtnClearAll)
        Controls.Add(BtnShowDiscountOffer)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(LblContact)
        Controls.Add(LblSurname)
        Controls.Add(LblName)
        Controls.Add(TxtContact)
        Controls.Add(TxtSurname)
        Controls.Add(TxtName)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtSurname As TextBox
    Friend WithEvents TxtContact As TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents LblSurname As Label
    Friend WithEvents LblContact As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadGamingLaptop As RadioButton
    Friend WithEvents RadBusinessLaptop As RadioButton
    Friend WithEvents RadStudentLaptop As RadioButton
    Friend WithEvents ChkLaptopBag As CheckBox
    Friend WithEvents ChkMechanicalKeyboard As CheckBox
    Friend WithEvents ChkwirelessMouse As CheckBox
    Friend WithEvents BtnShowDiscountOffer As Button
    Friend WithEvents BtnClearAll As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblDiscount As Label
    Friend WithEvents LblVAT As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblSubTotal As Label
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents TxtDiscount As TextBox
    Friend WithEvents TxtVAT As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents LstDisplay As ListBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
