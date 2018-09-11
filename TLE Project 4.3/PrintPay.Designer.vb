<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintPay
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
        Me.bSave = New System.Windows.Forms.Button()
        Me.bPrint = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintBox = New System.Windows.Forms.PrintPreviewControl()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.SuspendLayout()
        '
        'bSave
        '
        Me.bSave.Location = New System.Drawing.Point(12, 226)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(75, 23)
        Me.bSave.TabIndex = 0
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = True
        '
        'bPrint
        '
        Me.bPrint.Location = New System.Drawing.Point(93, 226)
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Size = New System.Drawing.Size(75, 23)
        Me.bPrint.TabIndex = 0
        Me.bPrint.Text = "Print"
        Me.bPrint.UseVisualStyleBackColor = True
        '
        'bCancel
        '
        Me.bCancel.Location = New System.Drawing.Point(174, 226)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(75, 23)
        Me.bCancel.TabIndex = 0
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintBox
        '
        Me.PrintBox.Location = New System.Drawing.Point(48, 12)
        Me.PrintBox.Name = "PrintBox"
        Me.PrintBox.Size = New System.Drawing.Size(156, 208)
        Me.PrintBox.TabIndex = 1
        '
        'PrintPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 261)
        Me.Controls.Add(Me.PrintBox)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bPrint)
        Me.Controls.Add(Me.bSave)
        Me.Name = "PrintPay"
        Me.Text = "PrintPay"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bSave As System.Windows.Forms.Button
    Friend WithEvents bPrint As System.Windows.Forms.Button
    Friend WithEvents bCancel As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintBox As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
End Class
