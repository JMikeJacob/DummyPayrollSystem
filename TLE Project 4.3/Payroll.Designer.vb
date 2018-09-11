<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payroll))
        Me.bExit = New System.Windows.Forms.Button()
        Me.bCalc = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbName = New System.Windows.Forms.Label()
        Me.LbID = New System.Windows.Forms.Label()
        Me.LbPosDept = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbPay = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbHours = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbOTPay = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LbOTHours = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LbTax = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LbGross = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LbDeduct = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LbNet = New System.Windows.Forms.Label()
        Me.bFirst = New System.Windows.Forms.Button()
        Me.bLast = New System.Windows.Forms.Button()
        Me.bPrev = New System.Windows.Forms.Button()
        Me.bNext = New System.Windows.Forms.Button()
        Me.bRef = New System.Windows.Forms.Button()
        Me.LsBene = New System.Windows.Forms.CheckedListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscellaneousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRegistryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bPrint = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bExit
        '
        Me.bExit.BackColor = System.Drawing.Color.FloralWhite
        Me.bExit.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bExit.Location = New System.Drawing.Point(392, 429)
        Me.bExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(87, 32)
        Me.bExit.TabIndex = 0
        Me.bExit.Text = "Close"
        Me.bExit.UseVisualStyleBackColor = False
        '
        'bCalc
        '
        Me.bCalc.BackColor = System.Drawing.Color.FloralWhite
        Me.bCalc.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCalc.Location = New System.Drawing.Point(237, 389)
        Me.bCalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bCalc.Name = "bCalc"
        Me.bCalc.Size = New System.Drawing.Size(149, 39)
        Me.bCalc.TabIndex = 1
        Me.bCalc.Text = "Calculate Pay"
        Me.bCalc.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(311, 102)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(171, 20)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "View Master Payroll Record"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "In Spirit Monthly Payroll"
        '
        'LbName
        '
        Me.LbName.AutoSize = True
        Me.LbName.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbName.Location = New System.Drawing.Point(8, 133)
        Me.LbName.Name = "LbName"
        Me.LbName.Size = New System.Drawing.Size(279, 26)
        Me.LbName.TabIndex = 4
        Me.LbName.Text = "(First Name) (MI) (Last Name)"
        '
        'LbID
        '
        Me.LbID.AutoSize = True
        Me.LbID.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbID.Location = New System.Drawing.Point(398, 139)
        Me.LbID.Name = "LbID"
        Me.LbID.Size = New System.Drawing.Size(81, 17)
        Me.LbID.TabIndex = 5
        Me.LbID.Text = "000-000-000"
        '
        'LbPosDept
        '
        Me.LbPosDept.AutoSize = True
        Me.LbPosDept.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPosDept.Location = New System.Drawing.Point(9, 159)
        Me.LbPosDept.Name = "LbPosDept"
        Me.LbPosDept.Size = New System.Drawing.Size(237, 20)
        Me.LbPosDept.TabIndex = 6
        Me.LbPosDept.Text = "(Position), (Department) Department"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Regular Pay"
        '
        'LbPay
        '
        Me.LbPay.AutoSize = True
        Me.LbPay.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPay.Location = New System.Drawing.Point(101, 202)
        Me.LbPay.Name = "LbPay"
        Me.LbPay.Size = New System.Drawing.Size(91, 22)
        Me.LbPay.TabIndex = 7
        Me.LbPay.Text = "P 999999.99"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hours"
        '
        'LbHours
        '
        Me.LbHours.AutoSize = True
        Me.LbHours.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHours.Location = New System.Drawing.Point(101, 234)
        Me.LbHours.Name = "LbHours"
        Me.LbHours.Size = New System.Drawing.Size(26, 22)
        Me.LbHours.TabIndex = 7
        Me.LbHours.Text = "24"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Overtime Pay"
        '
        'LbOTPay
        '
        Me.LbOTPay.AutoSize = True
        Me.LbOTPay.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbOTPay.Location = New System.Drawing.Point(101, 269)
        Me.LbOTPay.Name = "LbOTPay"
        Me.LbOTPay.Size = New System.Drawing.Size(91, 22)
        Me.LbOTPay.TabIndex = 7
        Me.LbOTPay.Text = "P 999999.99"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Overtime"
        '
        'LbOTHours
        '
        Me.LbOTHours.AutoSize = True
        Me.LbOTHours.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbOTHours.Location = New System.Drawing.Point(104, 296)
        Me.LbOTHours.Name = "LbOTHours"
        Me.LbOTHours.Size = New System.Drawing.Size(26, 22)
        Me.LbOTHours.TabIndex = 7
        Me.LbOTHours.Text = "24"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tax"
        '
        'LbTax
        '
        Me.LbTax.AutoSize = True
        Me.LbTax.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTax.Location = New System.Drawing.Point(90, 350)
        Me.LbTax.Name = "LbTax"
        Me.LbTax.Size = New System.Drawing.Size(91, 22)
        Me.LbTax.TabIndex = 7
        Me.LbTax.Text = "P 999999.99"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(286, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Gross Pay"
        '
        'LbGross
        '
        Me.LbGross.AutoSize = True
        Me.LbGross.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGross.Location = New System.Drawing.Point(373, 292)
        Me.LbGross.Name = "LbGross"
        Me.LbGross.Size = New System.Drawing.Size(91, 22)
        Me.LbGross.TabIndex = 7
        Me.LbGross.Text = "P 999999.99"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(286, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 18)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Deductions"
        '
        'LbDeduct
        '
        Me.LbDeduct.AutoSize = True
        Me.LbDeduct.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDeduct.Location = New System.Drawing.Point(373, 317)
        Me.LbDeduct.Name = "LbDeduct"
        Me.LbDeduct.Size = New System.Drawing.Size(91, 22)
        Me.LbDeduct.TabIndex = 7
        Me.LbDeduct.Text = "P 999999.99"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 381)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 18)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Benefits"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(286, 351)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 18)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Net Pay"
        '
        'LbNet
        '
        Me.LbNet.AutoSize = True
        Me.LbNet.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNet.Location = New System.Drawing.Point(373, 348)
        Me.LbNet.Name = "LbNet"
        Me.LbNet.Size = New System.Drawing.Size(91, 22)
        Me.LbNet.TabIndex = 7
        Me.LbNet.Text = "P 999999.99"
        '
        'bFirst
        '
        Me.bFirst.BackColor = System.Drawing.Color.FloralWhite
        Me.bFirst.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bFirst.Location = New System.Drawing.Point(237, 429)
        Me.bFirst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bFirst.Name = "bFirst"
        Me.bFirst.Size = New System.Drawing.Size(28, 32)
        Me.bFirst.TabIndex = 8
        Me.bFirst.Text = "|<"
        Me.bFirst.UseVisualStyleBackColor = False
        '
        'bLast
        '
        Me.bLast.BackColor = System.Drawing.Color.FloralWhite
        Me.bLast.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLast.Location = New System.Drawing.Point(359, 429)
        Me.bLast.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bLast.Name = "bLast"
        Me.bLast.Size = New System.Drawing.Size(27, 32)
        Me.bLast.TabIndex = 9
        Me.bLast.Text = ">|"
        Me.bLast.UseVisualStyleBackColor = False
        '
        'bPrev
        '
        Me.bPrev.BackColor = System.Drawing.Color.FloralWhite
        Me.bPrev.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPrev.Location = New System.Drawing.Point(271, 429)
        Me.bPrev.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bPrev.Name = "bPrev"
        Me.bPrev.Size = New System.Drawing.Size(38, 32)
        Me.bPrev.TabIndex = 8
        Me.bPrev.Text = "<"
        Me.bPrev.UseVisualStyleBackColor = False
        '
        'bNext
        '
        Me.bNext.BackColor = System.Drawing.Color.FloralWhite
        Me.bNext.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNext.Location = New System.Drawing.Point(315, 429)
        Me.bNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bNext.Name = "bNext"
        Me.bNext.Size = New System.Drawing.Size(38, 32)
        Me.bNext.TabIndex = 9
        Me.bNext.Text = ">"
        Me.bNext.UseVisualStyleBackColor = False
        '
        'bRef
        '
        Me.bRef.BackColor = System.Drawing.Color.FloralWhite
        Me.bRef.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRef.Location = New System.Drawing.Point(10, 407)
        Me.bRef.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bRef.Name = "bRef"
        Me.bRef.Size = New System.Drawing.Size(76, 50)
        Me.bRef.TabIndex = 8
        Me.bRef.Text = "Refresh"
        Me.bRef.UseVisualStyleBackColor = False
        '
        'LsBene
        '
        Me.LsBene.Enabled = False
        Me.LsBene.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsBene.FormattingEnabled = True
        Me.LsBene.Items.AddRange(New Object() {"GSIS", "SSS", "PhilHealth", "PAGIBIG"})
        Me.LsBene.Location = New System.Drawing.Point(93, 381)
        Me.LsBene.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LsBene.Name = "LsBene"
        Me.LsBene.Size = New System.Drawing.Size(117, 76)
        Me.LsBene.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ProfileToolStripMenuItem, Me.PayrollToolStripMenuItem, Me.MiscellaneousToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(491, 26)
        Me.MenuStrip1.TabIndex = 11
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
        'bPrint
        '
        Me.bPrint.BackColor = System.Drawing.Color.FloralWhite
        Me.bPrint.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPrint.Location = New System.Drawing.Point(392, 389)
        Me.bPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Size = New System.Drawing.Size(87, 32)
        Me.bPrint.TabIndex = 12
        Me.bPrint.Text = "Print..."
        Me.bPrint.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 465)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(491, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "In Spirit™ Group of Companies®. In one, In spirit. 2014"
        '
        'stat
        '
        Me.stat.Name = "stat"
        Me.stat.Size = New System.Drawing.Size(294, 17)
        Me.stat.Text = "In Spirit™ Group of Companies®. In one, In spirit. 2014"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Olive
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.GreenCurve
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 64)
        Me.Panel1.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(327, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 18)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "In One, In Spirit. 2014"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(83, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(301, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "In Spirit Group of Companies - Payroll"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.LOGO3
        Me.PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(491, 487)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.bPrint)
        Me.Controls.Add(Me.LsBene)
        Me.Controls.Add(Me.bNext)
        Me.Controls.Add(Me.bLast)
        Me.Controls.Add(Me.bRef)
        Me.Controls.Add(Me.bPrev)
        Me.Controls.Add(Me.bFirst)
        Me.Controls.Add(Me.LbOTHours)
        Me.Controls.Add(Me.LbHours)
        Me.Controls.Add(Me.LbTax)
        Me.Controls.Add(Me.LbOTPay)
        Me.Controls.Add(Me.LbDeduct)
        Me.Controls.Add(Me.LbNet)
        Me.Controls.Add(Me.LbGross)
        Me.Controls.Add(Me.LbPay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LbPosDept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbID)
        Me.Controls.Add(Me.LbName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.bCalc)
        Me.Controls.Add(Me.bExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(507, 526)
        Me.MinimumSize = New System.Drawing.Size(507, 526)
        Me.Name = "Payroll"
        Me.Text = "In Spirit - Payroll System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bExit As System.Windows.Forms.Button
    Friend WithEvents bCalc As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LbName As System.Windows.Forms.Label
    Friend WithEvents LbID As System.Windows.Forms.Label
    Friend WithEvents LbPosDept As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LbPay As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LbHours As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LbOTPay As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LbOTHours As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LbTax As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LbGross As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LbDeduct As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LbNet As System.Windows.Forms.Label
    Friend WithEvents bFirst As System.Windows.Forms.Button
    Friend WithEvents bLast As System.Windows.Forms.Button
    Friend WithEvents bPrev As System.Windows.Forms.Button
    Friend WithEvents bNext As System.Windows.Forms.Button
    Friend WithEvents bRef As System.Windows.Forms.Button
    Friend WithEvents LsBene As System.Windows.Forms.CheckedListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiscellaneousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRegistryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bPrint As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
