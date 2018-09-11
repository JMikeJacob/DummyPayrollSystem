<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIN))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BLog = New System.Windows.Forms.Button()
        Me.TxPass = New System.Windows.Forms.MaskedTextBox()
        Me.BQuit = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.TClock = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LTime = New System.Windows.Forms.Label()
        Me.ID1 = New System.Windows.Forms.TextBox()
        Me.ID2 = New System.Windows.Forms.TextBox()
        Me.ID3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LDate = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Company ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'BLog
        '
        Me.BLog.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLog.Location = New System.Drawing.Point(185, 164)
        Me.BLog.Name = "BLog"
        Me.BLog.Size = New System.Drawing.Size(75, 23)
        Me.BLog.TabIndex = 4
        Me.BLog.Text = "Log In"
        Me.BLog.UseVisualStyleBackColor = True
        '
        'TxPass
        '
        Me.TxPass.BackColor = System.Drawing.Color.White
        Me.TxPass.Font = New System.Drawing.Font("Modern No. 20", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPass.Location = New System.Drawing.Point(172, 114)
        Me.TxPass.Name = "TxPass"
        Me.TxPass.Size = New System.Drawing.Size(100, 16)
        Me.TxPass.TabIndex = 3
        Me.TxPass.UseSystemPasswordChar = True
        '
        'BQuit
        '
        Me.BQuit.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BQuit.Location = New System.Drawing.Point(185, 193)
        Me.BQuit.Name = "BQuit"
        Me.BQuit.Size = New System.Drawing.Size(75, 23)
        Me.BQuit.TabIndex = 5
        Me.BQuit.Text = "Exit"
        Me.BQuit.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(171, 226)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(74, 15)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Register Now!"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.Location = New System.Drawing.Point(171, 251)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(96, 15)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Forgot Something?"
        '
        'TClock
        '
        Me.TClock.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.LDate)
        Me.GroupBox1.Controls.Add(Me.LTime)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(154, 73)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "In Spirit Clock PST"
        '
        'LTime
        '
        Me.LTime.AutoSize = True
        Me.LTime.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTime.Location = New System.Drawing.Point(37, 17)
        Me.LTime.Name = "LTime"
        Me.LTime.Size = New System.Drawing.Size(111, 23)
        Me.LTime.TabIndex = 10
        Me.LTime.Text = "12:59:59 PM"
        '
        'ID1
        '
        Me.ID1.BackColor = System.Drawing.Color.White
        Me.ID1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID1.Location = New System.Drawing.Point(172, 63)
        Me.ID1.MaxLength = 3
        Me.ID1.Name = "ID1"
        Me.ID1.Size = New System.Drawing.Size(25, 21)
        Me.ID1.TabIndex = 0
        Me.ID1.Text = "000"
        '
        'ID2
        '
        Me.ID2.BackColor = System.Drawing.Color.White
        Me.ID2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID2.Location = New System.Drawing.Point(211, 63)
        Me.ID2.MaxLength = 3
        Me.ID2.Name = "ID2"
        Me.ID2.Size = New System.Drawing.Size(25, 21)
        Me.ID2.TabIndex = 1
        Me.ID2.Text = "000"
        '
        'ID3
        '
        Me.ID3.BackColor = System.Drawing.Color.White
        Me.ID3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID3.Location = New System.Drawing.Point(249, 63)
        Me.ID3.MaxLength = 3
        Me.ID3.Name = "ID3"
        Me.ID3.Size = New System.Drawing.Size(25, 21)
        Me.ID3.TabIndex = 2
        Me.ID3.Text = "000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(238, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "-"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sky
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-5, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 63)
        Me.Panel1.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(90, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "In One, In Spirit 2014"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 28)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "In Spirit Group of Companies"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.LOGO2
        Me.PictureBox1.Location = New System.Drawing.Point(9, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'LDate
        '
        Me.LDate.AutoSize = True
        Me.LDate.Font = New System.Drawing.Font("Kristen ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDate.Location = New System.Drawing.Point(37, 40)
        Me.LDate.Name = "LDate"
        Me.LDate.Size = New System.Drawing.Size(108, 22)
        Me.LDate.TabIndex = 10
        Me.LDate.Text = "12:59:59 PM"
        '
        'LogIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(284, 284)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BQuit)
        Me.Controls.Add(Me.TxPass)
        Me.Controls.Add(Me.BLog)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ID3)
        Me.Controls.Add(Me.ID2)
        Me.Controls.Add(Me.ID1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 323)
        Me.MinimumSize = New System.Drawing.Size(300, 323)
        Me.Name = "LogIN"
        Me.Text = "Welcome to In Spirit"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BLog As System.Windows.Forms.Button
    Friend WithEvents TxPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BQuit As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents TClock As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LTime As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ID1 As System.Windows.Forms.TextBox
    Friend WithEvents ID2 As System.Windows.Forms.TextBox
    Friend WithEvents ID3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LDate As System.Windows.Forms.Label
End Class
