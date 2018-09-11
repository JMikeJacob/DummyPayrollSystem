<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerInfo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PerInfo))
        Me.bClose = New System.Windows.Forms.Button()
        Me.TxDiary = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bDia = New System.Windows.Forms.Button()
        Me.bDown = New System.Windows.Forms.Button()
        Me.bClear = New System.Windows.Forms.Button()
        Me.LID = New System.Windows.Forms.Label()
        Me.LName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LMail = New System.Windows.Forms.Label()
        Me.LPosDept = New System.Windows.Forms.Label()
        Me.LAddress = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBirth = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LContact = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LEmploy = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PTime = New System.Windows.Forms.Timer(Me.components)
        Me.bRef = New System.Windows.Forms.Button()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.TxMail = New System.Windows.Forms.TextBox()
        Me.TxCont = New System.Windows.Forms.TextBox()
        Me.TxAddr = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscellaneousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRegistryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LDate = New System.Windows.Forms.Label()
        Me.LTime = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bClose
        '
        Me.bClose.BackColor = System.Drawing.Color.PapayaWhip
        Me.bClose.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClose.Location = New System.Drawing.Point(409, 363)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(85, 56)
        Me.bClose.TabIndex = 9
        Me.bClose.Text = "Return to Main"
        Me.bClose.UseVisualStyleBackColor = False
        '
        'TxDiary
        '
        Me.TxDiary.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDiary.Location = New System.Drawing.Point(7, 222)
        Me.TxDiary.Name = "TxDiary"
        Me.TxDiary.Size = New System.Drawing.Size(487, 138)
        Me.TxDiary.TabIndex = 0
        Me.TxDiary.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Minion Pro SmBd", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Personal Diary"
        '
        'bDia
        '
        Me.bDia.BackColor = System.Drawing.Color.PapayaWhip
        Me.bDia.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDia.Location = New System.Drawing.Point(12, 366)
        Me.bDia.Name = "bDia"
        Me.bDia.Size = New System.Drawing.Size(102, 23)
        Me.bDia.TabIndex = 1
        Me.bDia.Text = "Save Diary"
        Me.bDia.UseVisualStyleBackColor = False
        '
        'bDown
        '
        Me.bDown.BackColor = System.Drawing.Color.PapayaWhip
        Me.bDown.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDown.Location = New System.Drawing.Point(306, 363)
        Me.bDown.Name = "bDown"
        Me.bDown.Size = New System.Drawing.Size(102, 56)
        Me.bDown.TabIndex = 3
        Me.bDown.Text = "Download Diary"
        Me.bDown.UseVisualStyleBackColor = False
        '
        'bClear
        '
        Me.bClear.BackColor = System.Drawing.Color.PapayaWhip
        Me.bClear.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClear.Location = New System.Drawing.Point(12, 395)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(102, 23)
        Me.bClear.TabIndex = 2
        Me.bClear.Text = "Clear Diary"
        Me.bClear.UseVisualStyleBackColor = False
        '
        'LID
        '
        Me.LID.AutoSize = True
        Me.LID.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LID.Location = New System.Drawing.Point(413, 84)
        Me.LID.Name = "LID"
        Me.LID.Size = New System.Drawing.Size(81, 17)
        Me.LID.TabIndex = 6
        Me.LID.Text = "000-000-000"
        Me.LID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LName
        '
        Me.LName.AutoSize = True
        Me.LName.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.Location = New System.Drawing.Point(99, 84)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(172, 18)
        Me.LName.TabIndex = 7
        Me.LName.Text = "First Name, MI, Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Minion Pro SmBd", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "E-mail:"
        '
        'LMail
        '
        Me.LMail.AutoSize = True
        Me.LMail.Font = New System.Drawing.Font("Minion Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMail.Location = New System.Drawing.Point(159, 128)
        Me.LMail.Name = "LMail"
        Me.LMail.Size = New System.Drawing.Size(45, 15)
        Me.LMail.TabIndex = 9
        Me.LMail.Text = "(E-mail)"
        '
        'LPosDept
        '
        Me.LPosDept.AutoSize = True
        Me.LPosDept.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPosDept.Location = New System.Drawing.Point(99, 105)
        Me.LPosDept.Name = "LPosDept"
        Me.LPosDept.Size = New System.Drawing.Size(129, 16)
        Me.LPosDept.TabIndex = 10
        Me.LPosDept.Text = "(Position), (Department)"
        '
        'LAddress
        '
        Me.LAddress.AutoSize = True
        Me.LAddress.Font = New System.Drawing.Font("Minion Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAddress.Location = New System.Drawing.Point(159, 179)
        Me.LAddress.Name = "LAddress"
        Me.LAddress.Size = New System.Drawing.Size(52, 15)
        Me.LAddress.TabIndex = 12
        Me.LAddress.Text = "(Address)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Minion Pro SmBd", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(99, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Address:"
        '
        'LBirth
        '
        Me.LBirth.AutoSize = True
        Me.LBirth.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBirth.Location = New System.Drawing.Point(430, 127)
        Me.LBirth.Name = "LBirth"
        Me.LBirth.Size = New System.Drawing.Size(64, 16)
        Me.LBirth.TabIndex = 14
        Me.LBirth.Text = "11/11/2011"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Minion Pro SmBd", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(362, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Birthdate:"
        '
        'LContact
        '
        Me.LContact.AutoSize = True
        Me.LContact.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContact.Location = New System.Drawing.Point(159, 153)
        Me.LContact.Name = "LContact"
        Me.LContact.Size = New System.Drawing.Size(74, 16)
        Me.LContact.TabIndex = 16
        Me.LContact.Text = "12345678901"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Minion Pro SmBd", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(99, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Contact:"
        '
        'LEmploy
        '
        Me.LEmploy.AutoSize = True
        Me.LEmploy.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmploy.Location = New System.Drawing.Point(430, 106)
        Me.LEmploy.Name = "LEmploy"
        Me.LEmploy.Size = New System.Drawing.Size(64, 16)
        Me.LEmploy.TabIndex = 18
        Me.LEmploy.Text = "11/11/2011"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Minion Pro SmBd", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(315, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 18)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Employment Date: "
        '
        'PTime
        '
        Me.PTime.Enabled = True
        '
        'bRef
        '
        Me.bRef.BackColor = System.Drawing.Color.PapayaWhip
        Me.bRef.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRef.Location = New System.Drawing.Point(7, 193)
        Me.bRef.Name = "bRef"
        Me.bRef.Size = New System.Drawing.Size(86, 23)
        Me.bRef.TabIndex = 5
        Me.bRef.Text = "Refresh"
        Me.bRef.UseVisualStyleBackColor = False
        '
        'bEdit
        '
        Me.bEdit.BackColor = System.Drawing.Color.PapayaWhip
        Me.bEdit.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEdit.Location = New System.Drawing.Point(7, 167)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(86, 23)
        Me.bEdit.TabIndex = 4
        Me.bEdit.Text = "Edit"
        Me.bEdit.UseVisualStyleBackColor = False
        '
        'TxMail
        '
        Me.TxMail.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxMail.Location = New System.Drawing.Point(152, 124)
        Me.TxMail.Name = "TxMail"
        Me.TxMail.Size = New System.Drawing.Size(100, 22)
        Me.TxMail.TabIndex = 7
        '
        'TxCont
        '
        Me.TxCont.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCont.Location = New System.Drawing.Point(152, 150)
        Me.TxCont.Name = "TxCont"
        Me.TxCont.Size = New System.Drawing.Size(100, 22)
        Me.TxCont.TabIndex = 6
        '
        'TxAddr
        '
        Me.TxAddr.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAddr.Location = New System.Drawing.Point(152, 176)
        Me.TxAddr.Name = "TxAddr"
        Me.TxAddr.Size = New System.Drawing.Size(342, 22)
        Me.TxAddr.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ProfileToolStripMenuItem, Me.PayrollToolStripMenuItem, Me.MiscellaneousToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(506, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPayrollToolStripMenuItem})
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.PayrollToolStripMenuItem.Text = "Payroll"
        '
        'ViewPayrollToolStripMenuItem
        '
        Me.ViewPayrollToolStripMenuItem.Name = "ViewPayrollToolStripMenuItem"
        Me.ViewPayrollToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ViewPayrollToolStripMenuItem.Text = "View Payroll"
        '
        'MiscellaneousToolStripMenuItem
        '
        Me.MiscellaneousToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewRegistryToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MiscellaneousToolStripMenuItem.Name = "MiscellaneousToolStripMenuItem"
        Me.MiscellaneousToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.MiscellaneousToolStripMenuItem.Text = "Miscellaneous"
        '
        'ViewRegistryToolStripMenuItem
        '
        Me.ViewRegistryToolStripMenuItem.Name = "ViewRegistryToolStripMenuItem"
        Me.ViewRegistryToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ViewRegistryToolStripMenuItem.Text = "View Registry..."
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LDate)
        Me.GroupBox1.Controls.Add(Me.LTime)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(120, 363)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 56)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "In Spirit, Philippines"
        '
        'LDate
        '
        Me.LDate.AutoSize = True
        Me.LDate.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDate.Location = New System.Drawing.Point(46, 37)
        Me.LDate.Name = "LDate"
        Me.LDate.Size = New System.Drawing.Size(88, 16)
        Me.LDate.TabIndex = 22
        Me.LDate.Text = "MM/DD/YYYY"
        '
        'LTime
        '
        Me.LTime.AutoSize = True
        Me.LTime.Font = New System.Drawing.Font("Kristen ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTime.Location = New System.Drawing.Point(43, 18)
        Me.LTime.Name = "LTime"
        Me.LTime.Size = New System.Drawing.Size(94, 18)
        Me.LTime.TabIndex = 21
        Me.LTime.Text = "12:59:99 PM"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 425)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(506, 22)
        Me.StatusStrip1.TabIndex = 28
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stat
        '
        Me.stat.Name = "stat"
        Me.stat.Size = New System.Drawing.Size(294, 17)
        Me.stat.Text = "In Spirit™ Group of Companies®. In one, In spirit. 2014"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(506, 46)
        Me.Panel1.TabIndex = 27
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.LOGO3
        Me.PictureBox2.Location = New System.Drawing.Point(5, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(366, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "In one, In Spirit 2014"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(77, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(298, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "In Spirit Group of Companies - Profile"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.blank
        Me.PictureBox1.Location = New System.Drawing.Point(7, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'PerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(506, 447)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxAddr)
        Me.Controls.Add(Me.TxCont)
        Me.Controls.Add(Me.TxMail)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.bRef)
        Me.Controls.Add(Me.LEmploy)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LContact)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LBirth)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LPosDept)
        Me.Controls.Add(Me.LMail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LName)
        Me.Controls.Add(Me.LID)
        Me.Controls.Add(Me.bClear)
        Me.Controls.Add(Me.bDown)
        Me.Controls.Add(Me.bDia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxDiary)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(522, 486)
        Me.MinimumSize = New System.Drawing.Size(522, 486)
        Me.Name = "PerInfo"
        Me.Text = "In Spirit - Personal Data"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents TxDiary As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bDia As System.Windows.Forms.Button
    Friend WithEvents bDown As System.Windows.Forms.Button
    Friend WithEvents bClear As System.Windows.Forms.Button
    Friend WithEvents LID As System.Windows.Forms.Label
    Friend WithEvents LName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LMail As System.Windows.Forms.Label
    Friend WithEvents LPosDept As System.Windows.Forms.Label
    Friend WithEvents LAddress As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LBirth As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LContact As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LEmploy As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PTime As System.Windows.Forms.Timer
    Friend WithEvents bRef As System.Windows.Forms.Button
    Friend WithEvents bEdit As System.Windows.Forms.Button
    Friend WithEvents TxMail As System.Windows.Forms.TextBox
    Friend WithEvents TxCont As System.Windows.Forms.TextBox
    Friend WithEvents TxAddr As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiscellaneousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRegistryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LDate As System.Windows.Forms.Label
    Friend WithEvents LTime As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stat As System.Windows.Forms.ToolStripStatusLabel
End Class
