<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bEnter = New System.Windows.Forms.Button()
        Me.bClose = New System.Windows.Forms.Button()
        Me.TxAuth = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bEnter
        '
        Me.bEnter.BackColor = System.Drawing.Color.Linen
        Me.bEnter.Font = New System.Drawing.Font("Charlemagne Std", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEnter.Location = New System.Drawing.Point(12, 43)
        Me.bEnter.Name = "bEnter"
        Me.bEnter.Size = New System.Drawing.Size(75, 23)
        Me.bEnter.TabIndex = 1
        Me.bEnter.Text = "Submit"
        Me.bEnter.UseVisualStyleBackColor = False
        '
        'bClose
        '
        Me.bClose.BackColor = System.Drawing.Color.Linen
        Me.bClose.Font = New System.Drawing.Font("Charlemagne Std", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClose.Location = New System.Drawing.Point(209, 43)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(75, 23)
        Me.bClose.TabIndex = 2
        Me.bClose.Text = "Cancel"
        Me.bClose.UseVisualStyleBackColor = False
        '
        'TxAuth
        '
        Me.TxAuth.BackColor = System.Drawing.Color.OldLace
        Me.TxAuth.Location = New System.Drawing.Point(12, 12)
        Me.TxAuth.Name = "TxAuth"
        Me.TxAuth.Size = New System.Drawing.Size(272, 20)
        Me.TxAuth.TabIndex = 0
        Me.TxAuth.UseSystemPasswordChar = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.RedCurve
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(296, 78)
        Me.Controls.Add(Me.TxAuth)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.bEnter)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(312, 117)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(312, 117)
        Me.Name = "Form1"
        Me.Text = "In Spirit Authorization"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bEnter As System.Windows.Forms.Button
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents TxAuth As System.Windows.Forms.TextBox
End Class
