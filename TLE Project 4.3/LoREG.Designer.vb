<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoREG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bReg = New System.Windows.Forms.Button()
        Me.bExit = New System.Windows.Forms.Button()
        Me.ID1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxLast = New System.Windows.Forms.TextBox()
        Me.TxFirst = New System.Windows.Forms.TextBox()
        Me.TxMid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxMail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxPass = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TxVer = New System.Windows.Forms.Label()
        Me.TxAddr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxDate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxCont = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxPos = New System.Windows.Forms.ComboBox()
        Me.TxDept = New System.Windows.Forms.ComboBox()
        Me.RdMale = New System.Windows.Forms.RadioButton()
        Me.RdFem = New System.Windows.Forms.RadioButton()
        Me.RdOther = New System.Windows.Forms.RadioButton()
        Me.LDate = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ChGSIS = New System.Windows.Forms.CheckBox()
        Me.ChSSS = New System.Windows.Forms.CheckBox()
        Me.ChPhil = New System.Windows.Forms.CheckBox()
        Me.ChPag = New System.Windows.Forms.CheckBox()
        Me.ID2 = New System.Windows.Forms.TextBox()
        Me.ID3 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bReg
        '
        Me.bReg.BackColor = System.Drawing.Color.Snow
        Me.bReg.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bReg.Location = New System.Drawing.Point(159, 333)
        Me.bReg.Name = "bReg"
        Me.bReg.Size = New System.Drawing.Size(99, 23)
        Me.bReg.TabIndex = 21
        Me.bReg.Text = "Register"
        Me.bReg.UseVisualStyleBackColor = False
        '
        'bExit
        '
        Me.bExit.BackColor = System.Drawing.Color.Snow
        Me.bExit.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bExit.Location = New System.Drawing.Point(264, 333)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(99, 23)
        Me.bExit.TabIndex = 22
        Me.bExit.Text = "Cancel"
        Me.bExit.UseVisualStyleBackColor = False
        '
        'ID1
        '
        Me.ID1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID1.Location = New System.Drawing.Point(14, 95)
        Me.ID1.MaxLength = 3
        Me.ID1.Name = "ID1"
        Me.ID1.Size = New System.Drawing.Size(27, 21)
        Me.ID1.TabIndex = 0
        Me.ID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "I.D. No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Last Name"
        '
        'TxLast
        '
        Me.TxLast.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxLast.Location = New System.Drawing.Point(17, 134)
        Me.TxLast.Name = "TxLast"
        Me.TxLast.Size = New System.Drawing.Size(100, 23)
        Me.TxLast.TabIndex = 3
        '
        'TxFirst
        '
        Me.TxFirst.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFirst.Location = New System.Drawing.Point(123, 134)
        Me.TxFirst.Name = "TxFirst"
        Me.TxFirst.Size = New System.Drawing.Size(100, 23)
        Me.TxFirst.TabIndex = 4
        '
        'TxMid
        '
        Me.TxMid.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxMid.Location = New System.Drawing.Point(229, 134)
        Me.TxMid.MaxLength = 4
        Me.TxMid.Name = "TxMid"
        Me.TxMid.Size = New System.Drawing.Size(29, 23)
        Me.TxMid.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(120, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(226, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 15)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "M.I,"
        '
        'TxMail
        '
        Me.TxMail.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxMail.Location = New System.Drawing.Point(17, 183)
        Me.TxMail.Name = "TxMail"
        Me.TxMail.Size = New System.Drawing.Size(100, 23)
        Me.TxMail.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(14, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 15)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "E-mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 15)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxPass
        '
        Me.TxPass.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPass.Location = New System.Drawing.Point(17, 225)
        Me.TxPass.Name = "TxPass"
        Me.TxPass.Size = New System.Drawing.Size(100, 23)
        Me.TxPass.TabIndex = 10
        Me.TxPass.UseSystemPasswordChar = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(17, 267)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.MaskedTextBox1.TabIndex = 11
        Me.MaskedTextBox1.UseSystemPasswordChar = True
        '
        'TxVer
        '
        Me.TxVer.AutoSize = True
        Me.TxVer.BackColor = System.Drawing.Color.Transparent
        Me.TxVer.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxVer.ForeColor = System.Drawing.Color.White
        Me.TxVer.Location = New System.Drawing.Point(14, 250)
        Me.TxVer.Name = "TxVer"
        Me.TxVer.Size = New System.Drawing.Size(84, 15)
        Me.TxVer.TabIndex = 69
        Me.TxVer.Text = "Verify Password"
        Me.TxVer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxAddr
        '
        Me.TxAddr.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAddr.Location = New System.Drawing.Point(158, 183)
        Me.TxAddr.Name = "TxAddr"
        Me.TxAddr.Size = New System.Drawing.Size(206, 23)
        Me.TxAddr.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(155, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(156, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 15)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Position"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(155, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Department"
        '
        'TxDate
        '
        Me.TxDate.Location = New System.Drawing.Point(264, 227)
        Me.TxDate.MaxLength = 10
        Me.TxDate.Name = "TxDate"
        Me.TxDate.Size = New System.Drawing.Size(100, 20)
        Me.TxDate.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(261, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Birthdate"
        '
        'TxCont
        '
        Me.TxCont.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCont.Location = New System.Drawing.Point(264, 266)
        Me.TxCont.Name = "TxCont"
        Me.TxCont.Size = New System.Drawing.Size(100, 23)
        Me.TxCont.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(261, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 15)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Contact No."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(275, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 15)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "Gender"
        '
        'TxPos
        '
        Me.TxPos.BackColor = System.Drawing.Color.White
        Me.TxPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxPos.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPos.FormattingEnabled = True
        Me.TxPos.Location = New System.Drawing.Point(158, 225)
        Me.TxPos.Name = "TxPos"
        Me.TxPos.Size = New System.Drawing.Size(100, 26)
        Me.TxPos.TabIndex = 13
        '
        'TxDept
        '
        Me.TxDept.BackColor = System.Drawing.Color.White
        Me.TxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxDept.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDept.FormattingEnabled = True
        Me.TxDept.Location = New System.Drawing.Point(158, 267)
        Me.TxDept.Name = "TxDept"
        Me.TxDept.Size = New System.Drawing.Size(100, 26)
        Me.TxDept.TabIndex = 14
        '
        'RdMale
        '
        Me.RdMale.AutoSize = True
        Me.RdMale.BackColor = System.Drawing.Color.Transparent
        Me.RdMale.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdMale.ForeColor = System.Drawing.Color.White
        Me.RdMale.Location = New System.Drawing.Point(278, 135)
        Me.RdMale.Name = "RdMale"
        Me.RdMale.Size = New System.Drawing.Size(38, 22)
        Me.RdMale.TabIndex = 6
        Me.RdMale.TabStop = True
        Me.RdMale.Text = "M"
        Me.RdMale.UseVisualStyleBackColor = False
        '
        'RdFem
        '
        Me.RdFem.AutoSize = True
        Me.RdFem.BackColor = System.Drawing.Color.Transparent
        Me.RdFem.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdFem.ForeColor = System.Drawing.Color.White
        Me.RdFem.Location = New System.Drawing.Point(318, 135)
        Me.RdFem.Name = "RdFem"
        Me.RdFem.Size = New System.Drawing.Size(33, 22)
        Me.RdFem.TabIndex = 7
        Me.RdFem.TabStop = True
        Me.RdFem.Text = "F"
        Me.RdFem.UseVisualStyleBackColor = False
        '
        'RdOther
        '
        Me.RdOther.AutoSize = True
        Me.RdOther.BackColor = System.Drawing.Color.Transparent
        Me.RdOther.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdOther.ForeColor = System.Drawing.Color.White
        Me.RdOther.Location = New System.Drawing.Point(350, 135)
        Me.RdOther.Name = "RdOther"
        Me.RdOther.Size = New System.Drawing.Size(36, 22)
        Me.RdOther.TabIndex = 8
        Me.RdOther.TabStop = True
        Me.RdOther.Text = "O"
        Me.RdOther.UseVisualStyleBackColor = False
        '
        'LDate
        '
        Me.LDate.AutoSize = True
        Me.LDate.BackColor = System.Drawing.Color.Transparent
        Me.LDate.Font = New System.Drawing.Font("Minion Pro SmBd", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDate.ForeColor = System.Drawing.Color.White
        Me.LDate.Location = New System.Drawing.Point(322, 79)
        Me.LDate.Name = "LDate"
        Me.LDate.Size = New System.Drawing.Size(64, 18)
        Me.LDate.TabIndex = 87
        Me.LDate.Text = "12/12/2012"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(14, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(189, 15)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "Please fill in the following information."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(32, 303)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 15)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "Benefits:"
        '
        'ChGSIS
        '
        Me.ChGSIS.AutoSize = True
        Me.ChGSIS.BackColor = System.Drawing.Color.Transparent
        Me.ChGSIS.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChGSIS.ForeColor = System.Drawing.Color.White
        Me.ChGSIS.Location = New System.Drawing.Point(87, 303)
        Me.ChGSIS.Name = "ChGSIS"
        Me.ChGSIS.Size = New System.Drawing.Size(52, 22)
        Me.ChGSIS.TabIndex = 17
        Me.ChGSIS.Text = "GSIS"
        Me.ChGSIS.UseVisualStyleBackColor = False
        '
        'ChSSS
        '
        Me.ChSSS.AutoSize = True
        Me.ChSSS.BackColor = System.Drawing.Color.Transparent
        Me.ChSSS.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChSSS.ForeColor = System.Drawing.Color.White
        Me.ChSSS.Location = New System.Drawing.Point(144, 303)
        Me.ChSSS.Name = "ChSSS"
        Me.ChSSS.Size = New System.Drawing.Size(45, 22)
        Me.ChSSS.TabIndex = 18
        Me.ChSSS.Text = "SSS"
        Me.ChSSS.UseVisualStyleBackColor = False
        '
        'ChPhil
        '
        Me.ChPhil.AutoSize = True
        Me.ChPhil.BackColor = System.Drawing.Color.Transparent
        Me.ChPhil.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChPhil.ForeColor = System.Drawing.Color.White
        Me.ChPhil.Location = New System.Drawing.Point(197, 303)
        Me.ChPhil.Name = "ChPhil"
        Me.ChPhil.Size = New System.Drawing.Size(83, 22)
        Me.ChPhil.TabIndex = 19
        Me.ChPhil.Text = "PhilHealth"
        Me.ChPhil.UseVisualStyleBackColor = False
        '
        'ChPag
        '
        Me.ChPag.AutoSize = True
        Me.ChPag.BackColor = System.Drawing.Color.Transparent
        Me.ChPag.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChPag.ForeColor = System.Drawing.Color.White
        Me.ChPag.Location = New System.Drawing.Point(277, 302)
        Me.ChPag.Name = "ChPag"
        Me.ChPag.Size = New System.Drawing.Size(81, 22)
        Me.ChPag.TabIndex = 20
        Me.ChPag.Text = "PAG-IBIG"
        Me.ChPag.UseVisualStyleBackColor = False
        '
        'ID2
        '
        Me.ID2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID2.Location = New System.Drawing.Point(45, 95)
        Me.ID2.MaxLength = 3
        Me.ID2.Name = "ID2"
        Me.ID2.Size = New System.Drawing.Size(27, 21)
        Me.ID2.TabIndex = 1
        Me.ID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ID3
        '
        Me.ID3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID3.Location = New System.Drawing.Point(78, 95)
        Me.ID3.MaxLength = 3
        Me.ID3.Name = "ID3"
        Me.ID3.Size = New System.Drawing.Size(27, 21)
        Me.ID3.TabIndex = 2
        Me.ID3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BrownCurve
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 51)
        Me.Panel1.TabIndex = 90
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(139, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 17)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "In One, In Spirit. 2014"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(8, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(203, 22)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "In Spirit Network - Register"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.LOGO2
        Me.PictureBox1.Location = New System.Drawing.Point(277, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'LoREG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.YellowCurve
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(392, 368)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ChPag)
        Me.Controls.Add(Me.ChPhil)
        Me.Controls.Add(Me.ChSSS)
        Me.Controls.Add(Me.ChGSIS)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LDate)
        Me.Controls.Add(Me.RdOther)
        Me.Controls.Add(Me.RdFem)
        Me.Controls.Add(Me.RdMale)
        Me.Controls.Add(Me.TxDept)
        Me.Controls.Add(Me.TxPos)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxCont)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxAddr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.TxVer)
        Me.Controls.Add(Me.TxPass)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxMail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxMid)
        Me.Controls.Add(Me.TxFirst)
        Me.Controls.Add(Me.TxLast)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ID3)
        Me.Controls.Add(Me.ID2)
        Me.Controls.Add(Me.ID1)
        Me.Controls.Add(Me.bReg)
        Me.Controls.Add(Me.bExit)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(408, 407)
        Me.MinimumSize = New System.Drawing.Size(408, 407)
        Me.Name = "LoREG"
        Me.Text = "In Spirit - Register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bReg As System.Windows.Forms.Button
    Friend WithEvents bExit As System.Windows.Forms.Button
    Friend WithEvents ID1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxLast As System.Windows.Forms.TextBox
    Friend WithEvents TxFirst As System.Windows.Forms.TextBox
    Friend WithEvents TxMid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxMail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxVer As System.Windows.Forms.Label
    Friend WithEvents TxAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxDate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxCont As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxPos As System.Windows.Forms.ComboBox
    Friend WithEvents TxDept As System.Windows.Forms.ComboBox
    Friend WithEvents RdMale As System.Windows.Forms.RadioButton
    Friend WithEvents RdFem As System.Windows.Forms.RadioButton
    Friend WithEvents RdOther As System.Windows.Forms.RadioButton
    Friend WithEvents LDate As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ChGSIS As System.Windows.Forms.CheckBox
    Friend WithEvents ChSSS As System.Windows.Forms.CheckBox
    Friend WithEvents ChPhil As System.Windows.Forms.CheckBox
    Friend WithEvents ChPag As System.Windows.Forms.CheckBox
    Friend WithEvents ID2 As System.Windows.Forms.TextBox
    Friend WithEvents ID3 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
