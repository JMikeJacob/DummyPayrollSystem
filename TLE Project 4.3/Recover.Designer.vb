<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recover
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Position = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ID1 = New System.Windows.Forms.TextBox()
        Me.TxMail = New System.Windows.Forms.TextBox()
        Me.TxPos = New System.Windows.Forms.ComboBox()
        Me.TxDept = New System.Windows.Forms.ComboBox()
        Me.bExit = New System.Windows.Forms.Button()
        Me.ID2 = New System.Windows.Forms.TextBox()
        Me.ID3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxPass = New System.Windows.Forms.TextBox()
        Me.vPass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bCan = New System.Windows.Forms.Button()
        Me.bSub = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bReg
        '
        Me.bReg.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bReg.Location = New System.Drawing.Point(42, 193)
        Me.bReg.Name = "bReg"
        Me.bReg.Size = New System.Drawing.Size(75, 23)
        Me.bReg.TabIndex = 6
        Me.bReg.Text = "Submit"
        Me.bReg.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please fill out the following forms."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'Position
        '
        Me.Position.AutoSize = True
        Me.Position.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Position.Location = New System.Drawing.Point(39, 163)
        Me.Position.Name = "Position"
        Me.Position.Size = New System.Drawing.Size(47, 15)
        Me.Position.TabIndex = 3
        Me.Position.Text = "Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "E-mail"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ID1
        '
        Me.ID1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID1.Location = New System.Drawing.Point(120, 81)
        Me.ID1.MaxLength = 3
        Me.ID1.Name = "ID1"
        Me.ID1.Size = New System.Drawing.Size(28, 21)
        Me.ID1.TabIndex = 0
        Me.ID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxMail
        '
        Me.TxMail.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxMail.Location = New System.Drawing.Point(120, 106)
        Me.TxMail.Name = "TxMail"
        Me.TxMail.Size = New System.Drawing.Size(127, 22)
        Me.TxMail.TabIndex = 3
        '
        'TxPos
        '
        Me.TxPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxPos.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPos.FormattingEnabled = True
        Me.TxPos.Location = New System.Drawing.Point(120, 160)
        Me.TxPos.Name = "TxPos"
        Me.TxPos.Size = New System.Drawing.Size(127, 24)
        Me.TxPos.TabIndex = 5
        '
        'TxDept
        '
        Me.TxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxDept.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDept.FormattingEnabled = True
        Me.TxDept.Location = New System.Drawing.Point(120, 132)
        Me.TxDept.Name = "TxDept"
        Me.TxDept.Size = New System.Drawing.Size(127, 24)
        Me.TxDept.TabIndex = 4
        '
        'bExit
        '
        Me.bExit.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bExit.Location = New System.Drawing.Point(172, 193)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(75, 23)
        Me.bExit.TabIndex = 7
        Me.bExit.Text = "Cancel"
        Me.bExit.UseVisualStyleBackColor = True
        '
        'ID2
        '
        Me.ID2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID2.Location = New System.Drawing.Point(169, 81)
        Me.ID2.MaxLength = 3
        Me.ID2.Name = "ID2"
        Me.ID2.Size = New System.Drawing.Size(28, 21)
        Me.ID2.TabIndex = 1
        Me.ID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ID3
        '
        Me.ID3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID3.Location = New System.Drawing.Point(219, 81)
        Me.ID3.MaxLength = 3
        Me.ID3.Name = "ID3"
        Me.ID3.Size = New System.Drawing.Size(28, 21)
        Me.ID3.TabIndex = 2
        Me.ID3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(151, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 24)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "-"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(200, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 24)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "-"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxPass)
        Me.GroupBox1.Controls.Add(Me.vPass)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.bCan)
        Me.GroupBox1.Controls.Add(Me.bSub)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 125)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'TxPass
        '
        Me.TxPass.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPass.Location = New System.Drawing.Point(107, 16)
        Me.TxPass.Name = "TxPass"
        Me.TxPass.Size = New System.Drawing.Size(128, 19)
        Me.TxPass.TabIndex = 8
        Me.TxPass.UseSystemPasswordChar = True
        '
        'vPass
        '
        Me.vPass.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vPass.Location = New System.Drawing.Point(107, 45)
        Me.vPass.Name = "vPass"
        Me.vPass.Size = New System.Drawing.Size(128, 19)
        Me.vPass.TabIndex = 9
        Me.vPass.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Verify Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "New Password"
        '
        'bCan
        '
        Me.bCan.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCan.Location = New System.Drawing.Point(160, 84)
        Me.bCan.Name = "bCan"
        Me.bCan.Size = New System.Drawing.Size(75, 23)
        Me.bCan.TabIndex = 11
        Me.bCan.Text = "Cancel"
        Me.bCan.UseVisualStyleBackColor = True
        '
        'bSub
        '
        Me.bSub.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSub.Location = New System.Drawing.Point(14, 84)
        Me.bSub.Name = "bSub"
        Me.bSub.Size = New System.Drawing.Size(75, 23)
        Me.bSub.TabIndex = 10
        Me.bSub.Text = "Submit"
        Me.bSub.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sky
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-6, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 63)
        Me.Panel1.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(119, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "In One, In Spirit. 2014"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(74, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 22)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "In Spirit Group of Companies"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.LOGO3
        Me.PictureBox1.Location = New System.Drawing.Point(10, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Recover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(280, 321)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bExit)
        Me.Controls.Add(Me.TxDept)
        Me.Controls.Add(Me.TxPos)
        Me.Controls.Add(Me.TxMail)
        Me.Controls.Add(Me.ID3)
        Me.Controls.Add(Me.ID2)
        Me.Controls.Add(Me.ID1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Position)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bReg)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(296, 360)
        Me.MinimumSize = New System.Drawing.Size(296, 360)
        Me.Name = "Recover"
        Me.Text = "In Spirit - Recovery"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bReg As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Position As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ID1 As System.Windows.Forms.TextBox
    Friend WithEvents TxMail As System.Windows.Forms.TextBox
    Friend WithEvents TxPos As System.Windows.Forms.ComboBox
    Friend WithEvents TxDept As System.Windows.Forms.ComboBox
    Friend WithEvents bExit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ID2 As System.Windows.Forms.TextBox
    Friend WithEvents ID3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxPass As System.Windows.Forms.TextBox
    Friend WithEvents vPass As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bCan As System.Windows.Forms.Button
    Friend WithEvents bSub As System.Windows.Forms.Button
End Class
