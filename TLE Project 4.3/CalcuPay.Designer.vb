<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcuPay
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
        Me.bExit = New System.Windows.Forms.Button()
        Me.LbName = New System.Windows.Forms.Label()
        Me.LbID = New System.Windows.Forms.Label()
        Me.LbPosDept = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxRegPpH = New System.Windows.Forms.TextBox()
        Me.TxHr = New System.Windows.Forms.TextBox()
        Me.TxOTHr = New System.Windows.Forms.TextBox()
        Me.LbGross = New System.Windows.Forms.Label()
        Me.LbNet = New System.Windows.Forms.Label()
        Me.LbDed = New System.Windows.Forms.Label()
        Me.bGo = New System.Windows.Forms.Button()
        Me.bClr = New System.Windows.Forms.Button()
        Me.bUpd = New System.Windows.Forms.Button()
        Me.LbOTPpH = New System.Windows.Forms.Label()
        Me.LsBene = New System.Windows.Forms.CheckedListBox()
        Me.TxTax = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bExit
        '
        Me.bExit.BackColor = System.Drawing.Color.Beige
        Me.bExit.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bExit.Location = New System.Drawing.Point(295, 364)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(84, 23)
        Me.bExit.TabIndex = 0
        Me.bExit.Text = "Close"
        Me.bExit.UseVisualStyleBackColor = False
        '
        'LbName
        '
        Me.LbName.AutoSize = True
        Me.LbName.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbName.Location = New System.Drawing.Point(6, 81)
        Me.LbName.Name = "LbName"
        Me.LbName.Size = New System.Drawing.Size(279, 26)
        Me.LbName.TabIndex = 4
        Me.LbName.Text = "(First Name) (MI) (Last Name)"
        '
        'LbID
        '
        Me.LbID.AutoSize = True
        Me.LbID.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbID.Location = New System.Drawing.Point(307, 81)
        Me.LbID.Name = "LbID"
        Me.LbID.Size = New System.Drawing.Size(81, 17)
        Me.LbID.TabIndex = 5
        Me.LbID.Text = "000-000-000"
        '
        'LbPosDept
        '
        Me.LbPosDept.AutoSize = True
        Me.LbPosDept.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPosDept.Location = New System.Drawing.Point(8, 107)
        Me.LbPosDept.Name = "LbPosDept"
        Me.LbPosDept.Size = New System.Drawing.Size(237, 20)
        Me.LbPosDept.TabIndex = 6
        Me.LbPosDept.Text = "(Position), (Department) Department"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Regular Pay (Php)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hours (Hr)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Overtime Pay (Php)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Overtime (Hr)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tax (Php)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(208, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 18)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Gross Pay (Php)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(208, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 18)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Deductions (Php)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 18)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Benefits"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(207, 273)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 21)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Net Pay (Php)"
        '
        'TxRegPpH
        '
        Me.TxRegPpH.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxRegPpH.Location = New System.Drawing.Point(113, 143)
        Me.TxRegPpH.Name = "TxRegPpH"
        Me.TxRegPpH.Size = New System.Drawing.Size(84, 22)
        Me.TxRegPpH.TabIndex = 7
        '
        'TxHr
        '
        Me.TxHr.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHr.Location = New System.Drawing.Point(113, 166)
        Me.TxHr.Name = "TxHr"
        Me.TxHr.Size = New System.Drawing.Size(84, 22)
        Me.TxHr.TabIndex = 8
        '
        'TxOTHr
        '
        Me.TxOTHr.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxOTHr.Location = New System.Drawing.Point(115, 211)
        Me.TxOTHr.Name = "TxOTHr"
        Me.TxOTHr.Size = New System.Drawing.Size(84, 22)
        Me.TxOTHr.TabIndex = 10
        '
        'LbGross
        '
        Me.LbGross.AutoSize = True
        Me.LbGross.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGross.Location = New System.Drawing.Point(310, 146)
        Me.LbGross.Name = "LbGross"
        Me.LbGross.Size = New System.Drawing.Size(78, 22)
        Me.LbGross.TabIndex = 12
        Me.LbGross.Text = "999999.99"
        '
        'LbNet
        '
        Me.LbNet.AutoSize = True
        Me.LbNet.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNet.Location = New System.Drawing.Point(310, 273)
        Me.LbNet.Name = "LbNet"
        Me.LbNet.Size = New System.Drawing.Size(78, 22)
        Me.LbNet.TabIndex = 12
        Me.LbNet.Text = "999999.99"
        '
        'LbDed
        '
        Me.LbDed.AutoSize = True
        Me.LbDed.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDed.Location = New System.Drawing.Point(310, 192)
        Me.LbDed.Name = "LbDed"
        Me.LbDed.Size = New System.Drawing.Size(78, 22)
        Me.LbDed.TabIndex = 12
        Me.LbDed.Text = "999999.99"
        '
        'bGo
        '
        Me.bGo.BackColor = System.Drawing.Color.Beige
        Me.bGo.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGo.Location = New System.Drawing.Point(9, 335)
        Me.bGo.Name = "bGo"
        Me.bGo.Size = New System.Drawing.Size(106, 52)
        Me.bGo.TabIndex = 13
        Me.bGo.Text = "Calculate"
        Me.bGo.UseVisualStyleBackColor = False
        '
        'bClr
        '
        Me.bClr.BackColor = System.Drawing.Color.Beige
        Me.bClr.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClr.Location = New System.Drawing.Point(121, 335)
        Me.bClr.Name = "bClr"
        Me.bClr.Size = New System.Drawing.Size(34, 52)
        Me.bClr.TabIndex = 13
        Me.bClr.Text = "C"
        Me.bClr.UseVisualStyleBackColor = False
        '
        'bUpd
        '
        Me.bUpd.BackColor = System.Drawing.Color.Beige
        Me.bUpd.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bUpd.Location = New System.Drawing.Point(295, 335)
        Me.bUpd.Name = "bUpd"
        Me.bUpd.Size = New System.Drawing.Size(84, 23)
        Me.bUpd.TabIndex = 13
        Me.bUpd.Text = "Update..."
        Me.bUpd.UseVisualStyleBackColor = False
        '
        'LbOTPpH
        '
        Me.LbOTPpH.AutoSize = True
        Me.LbOTPpH.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbOTPpH.Location = New System.Drawing.Point(131, 188)
        Me.LbOTPpH.Name = "LbOTPpH"
        Me.LbOTPpH.Size = New System.Drawing.Size(68, 20)
        Me.LbOTPpH.TabIndex = 14
        Me.LbOTPpH.Text = "999999.99"
        '
        'LsBene
        '
        Me.LsBene.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsBene.FormattingEnabled = True
        Me.LsBene.Items.AddRange(New Object() {"GSIS", "SSS", "PhilHealth", "PAG-IBIG"})
        Me.LsBene.Location = New System.Drawing.Point(103, 273)
        Me.LsBene.Name = "LsBene"
        Me.LsBene.Size = New System.Drawing.Size(96, 40)
        Me.LsBene.TabIndex = 15
        '
        'TxTax
        '
        Me.TxTax.AutoSize = True
        Me.TxTax.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTax.Location = New System.Drawing.Point(129, 247)
        Me.TxTax.Name = "TxTax"
        Me.TxTax.Size = New System.Drawing.Size(68, 20)
        Me.TxTax.TabIndex = 16
        Me.TxTax.Text = "999999.99"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 390)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(391, 22)
        Me.StatusStrip1.TabIndex = 20
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
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.OrangeCurve
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 73)
        Me.Panel1.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(8, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 22)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "0.0.1.0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(158, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "In One, In Spirit. 2014"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "In Spirit™ Payroll Calculator"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.LOGO2
        Me.PictureBox1.Location = New System.Drawing.Point(272, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'CalcuPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(391, 412)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxTax)
        Me.Controls.Add(Me.LsBene)
        Me.Controls.Add(Me.LbOTPpH)
        Me.Controls.Add(Me.bClr)
        Me.Controls.Add(Me.bUpd)
        Me.Controls.Add(Me.bGo)
        Me.Controls.Add(Me.LbDed)
        Me.Controls.Add(Me.LbNet)
        Me.Controls.Add(Me.LbGross)
        Me.Controls.Add(Me.TxOTHr)
        Me.Controls.Add(Me.TxHr)
        Me.Controls.Add(Me.TxRegPpH)
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
        Me.Controls.Add(Me.bExit)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(407, 451)
        Me.MinimumSize = New System.Drawing.Size(407, 451)
        Me.Name = "CalcuPay"
        Me.Text = "In Spirit - Payroll System"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bExit As System.Windows.Forms.Button
    Friend WithEvents LbName As System.Windows.Forms.Label
    Friend WithEvents LbID As System.Windows.Forms.Label
    Friend WithEvents LbPosDept As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxRegPpH As System.Windows.Forms.TextBox
    Friend WithEvents TxHr As System.Windows.Forms.TextBox
    Friend WithEvents TxOTHr As System.Windows.Forms.TextBox
    Friend WithEvents LbGross As System.Windows.Forms.Label
    Friend WithEvents LbNet As System.Windows.Forms.Label
    Friend WithEvents LbDed As System.Windows.Forms.Label
    Friend WithEvents bGo As System.Windows.Forms.Button
    Friend WithEvents bClr As System.Windows.Forms.Button
    Friend WithEvents bUpd As System.Windows.Forms.Button
    Friend WithEvents LbOTPpH As System.Windows.Forms.Label
    Friend WithEvents LsBene As System.Windows.Forms.CheckedListBox
    Friend WithEvents TxTax As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
