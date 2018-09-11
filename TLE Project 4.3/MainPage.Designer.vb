<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.bOut = New System.Windows.Forms.Button()
        Me.bReg = New System.Windows.Forms.Button()
        Me.LbLast = New System.Windows.Forms.Label()
        Me.LbID = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscellaneousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRegistryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LbPosDept = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bRef = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxAnn = New System.Windows.Forms.RichTextBox()
        Me.LbAnn = New System.Windows.Forms.Label()
        Me.bAnn = New System.Windows.Forms.Button()
        Me.pRoll = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bInfo = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LDate = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.LTime = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'bOut
        '
        Me.bOut.BackColor = System.Drawing.Color.PapayaWhip
        Me.bOut.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bOut.Location = New System.Drawing.Point(550, 397)
        Me.bOut.Name = "bOut"
        Me.bOut.Size = New System.Drawing.Size(121, 38)
        Me.bOut.TabIndex = 3
        Me.bOut.Text = "Log Out"
        Me.bOut.UseVisualStyleBackColor = False
        '
        'bReg
        '
        Me.bReg.BackColor = System.Drawing.Color.PapayaWhip
        Me.bReg.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bReg.Location = New System.Drawing.Point(361, 397)
        Me.bReg.Name = "bReg"
        Me.bReg.Size = New System.Drawing.Size(120, 38)
        Me.bReg.TabIndex = 2
        Me.bReg.Text = "View Registry"
        Me.bReg.UseVisualStyleBackColor = False
        '
        'LbLast
        '
        Me.LbLast.AutoSize = True
        Me.LbLast.BackColor = System.Drawing.Color.Transparent
        Me.LbLast.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLast.ForeColor = System.Drawing.Color.White
        Me.LbLast.Location = New System.Drawing.Point(104, 75)
        Me.LbLast.Name = "LbLast"
        Me.LbLast.Size = New System.Drawing.Size(221, 21)
        Me.LbLast.TabIndex = 4
        Me.LbLast.Text = "(First Name) (MI) (Last Name)"
        '
        'LbID
        '
        Me.LbID.AutoSize = True
        Me.LbID.BackColor = System.Drawing.Color.Transparent
        Me.LbID.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbID.ForeColor = System.Drawing.Color.White
        Me.LbID.Location = New System.Drawing.Point(579, 71)
        Me.LbID.Name = "LbID"
        Me.LbID.Size = New System.Drawing.Size(92, 17)
        Me.LbID.TabIndex = 5
        Me.LbID.Text = "000-000-000"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Minion Pro", 8.25!)
        Me.RichTextBox1.Location = New System.Drawing.Point(10, 344)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(164, 91)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = "Comments:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 181)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "About In Spirit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Minion Pro Med", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 156)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ProfileToolStripMenuItem, Me.PayrollToolStripMenuItem, Me.MiscellaneousToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(677, 24)
        Me.MenuStrip1.TabIndex = 14
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
        'LbPosDept
        '
        Me.LbPosDept.AutoSize = True
        Me.LbPosDept.BackColor = System.Drawing.Color.Transparent
        Me.LbPosDept.Font = New System.Drawing.Font("Minion Pro", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPosDept.ForeColor = System.Drawing.Color.White
        Me.LbPosDept.Location = New System.Drawing.Point(104, 101)
        Me.LbPosDept.Name = "LbPosDept"
        Me.LbPosDept.Size = New System.Drawing.Size(181, 15)
        Me.LbPosDept.TabIndex = 15
        Me.LbPosDept.Text = "(Position), (Department) Department"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 441)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(677, 22)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stat
        '
        Me.stat.Name = "stat"
        Me.stat.Size = New System.Drawing.Size(297, 17)
        Me.stat.Text = "In Spirit™ Group of Companies®. In one, In spirit. 2014 "
        '
        'bRef
        '
        Me.bRef.BackColor = System.Drawing.Color.PapayaWhip
        Me.bRef.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRef.Location = New System.Drawing.Point(107, 128)
        Me.bRef.Name = "bRef"
        Me.bRef.Size = New System.Drawing.Size(75, 23)
        Me.bRef.TabIndex = 20
        Me.bRef.Text = "Refresh"
        Me.bRef.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxAnn)
        Me.GroupBox2.Controls.Add(Me.LbAnn)
        Me.GroupBox2.Controls.Add(Me.bAnn)
        Me.GroupBox2.Font = New System.Drawing.Font("Monotype Corsiva", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(180, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(174, 278)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Announcements"
        '
        'TxAnn
        '
        Me.TxAnn.Enabled = False
        Me.TxAnn.Location = New System.Drawing.Point(6, 17)
        Me.TxAnn.Name = "TxAnn"
        Me.TxAnn.Size = New System.Drawing.Size(159, 226)
        Me.TxAnn.TabIndex = 2
        Me.TxAnn.Text = "..."
        '
        'LbAnn
        '
        Me.LbAnn.AutoSize = True
        Me.LbAnn.Location = New System.Drawing.Point(6, 17)
        Me.LbAnn.Name = "LbAnn"
        Me.LbAnn.Size = New System.Drawing.Size(0, 14)
        Me.LbAnn.TabIndex = 1
        '
        'bAnn
        '
        Me.bAnn.BackColor = System.Drawing.Color.PapayaWhip
        Me.bAnn.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAnn.ForeColor = System.Drawing.Color.Black
        Me.bAnn.Location = New System.Drawing.Point(6, 249)
        Me.bAnn.Name = "bAnn"
        Me.bAnn.Size = New System.Drawing.Size(159, 23)
        Me.bAnn.TabIndex = 0
        Me.bAnn.Text = "Announce!"
        Me.bAnn.UseVisualStyleBackColor = False
        '
        'pRoll
        '
        Me.pRoll.BackgroundImage = CType(resources.GetObject("pRoll.BackgroundImage"), System.Drawing.Image)
        Me.pRoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pRoll.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pRoll.Location = New System.Drawing.Point(598, 91)
        Me.pRoll.Name = "pRoll"
        Me.pRoll.Size = New System.Drawing.Size(67, 60)
        Me.pRoll.TabIndex = 18
        Me.pRoll.Text = "Payroll"
        Me.pRoll.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.pRoll.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BlueCurve
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-7, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 46)
        Me.Panel1.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.LOGO3
        Me.PictureBox1.Location = New System.Drawing.Point(20, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(539, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "In One, In Spirit 2014"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "In Spirit Group of Companies - United Network"
        '
        'bInfo
        '
        Me.bInfo.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blank
        Me.bInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bInfo.Location = New System.Drawing.Point(12, 71)
        Me.bInfo.Name = "bInfo"
        Me.bInfo.Size = New System.Drawing.Size(86, 80)
        Me.bInfo.TabIndex = 0
        Me.bInfo.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.LTime)
        Me.GroupBox5.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox5.Controls.Add(Me.LDate)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Font = New System.Drawing.Font("Monotype Corsiva", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(360, 157)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(305, 234)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Date"
        '
        'LDate
        '
        Me.LDate.AutoSize = True
        Me.LDate.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDate.Location = New System.Drawing.Point(213, 15)
        Me.LDate.Name = "LDate"
        Me.LDate.Size = New System.Drawing.Size(86, 22)
        Me.LDate.TabIndex = 1
        Me.LDate.Text = "01/01/2015"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Minion Pro Med", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 12)
        Me.Label7.TabIndex = 0
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(41, 48)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 2
        '
        'LTime
        '
        Me.LTime.AutoSize = True
        Me.LTime.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTime.Location = New System.Drawing.Point(8, 17)
        Me.LTime.Name = "LTime"
        Me.LTime.Size = New System.Drawing.Size(100, 22)
        Me.LTime.TabIndex = 3
        Me.LTime.Text = "00:00:00 AM"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.PurpleCurve
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(677, 463)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bOut)
        Me.Controls.Add(Me.bRef)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pRoll)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LbPosDept)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.LbID)
        Me.Controls.Add(Me.LbLast)
        Me.Controls.Add(Me.bReg)
        Me.Controls.Add(Me.bInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(693, 502)
        Me.MinimumSize = New System.Drawing.Size(693, 502)
        Me.Name = "MainPage"
        Me.Text = "In Spirit - Home Page"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bOut As System.Windows.Forms.Button
    Friend WithEvents bInfo As System.Windows.Forms.Button
    Friend WithEvents bReg As System.Windows.Forms.Button
    Friend WithEvents LbLast As System.Windows.Forms.Label
    Friend WithEvents LbID As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiscellaneousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRegistryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LbPosDept As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pRoll As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bRef As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxAnn As System.Windows.Forms.RichTextBox
    Friend WithEvents LbAnn As System.Windows.Forms.Label
    Friend WithEvents bAnn As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LDate As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LTime As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
End Class
