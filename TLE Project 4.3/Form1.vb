Public Class Form1
    Public auth = 0
    Dim ctr As Integer
    Dim countrow As Integer
    Dim ds As DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim cnn As New OleDb.OleDbConnection
    Dim command As New OleDb.OleDbCommand

    Private Sub bClose_Click(sender As System.Object, e As System.EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub bEnter_Click(sender As System.Object, e As System.EventArgs) Handles bEnter.Click
        Select Case auth
            Case 0
                If TxAuth.Text = "pseudocode101" Then
                    MReg.Show()
                    MReg.Focus()
                    MReg.bOut.Enabled = True
                    Me.Close()
                Else
                    MessageBox.Show("Code Incorrect. Access Denied!", "In Spirit Authorization", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            Case 1
                If TxAuth.Text = "pseudocode101" Then
                    Payroll.LinkLabel1.Text = "View Personal Payroll Record"
                    Payroll.master = 1
                    cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

                    Dim str As String = ("SELECT * FROM InSpiritPayroll ORDER BY ID")
                    command = New OleDb.OleDbCommand(str, cnn)
                    da = New OleDb.OleDbDataAdapter(command)
                    ds = New DataSet
                    cnn.Open()
                    da.Fill(ds, "ProjectIIITLE")
                    showpayroll()
                    Payroll.countrow = ds.Tables("ProjectIIITLE").Rows.Count
                    cnn.Close()
                    Payroll.bFirst.Visible = True
                    Payroll.bNext.Visible = True
                    Payroll.bLast.Visible = True
                    Payroll.bPrev.Visible = True
                    Payroll.bFirst.Enabled = True
                    Payroll.bNext.Enabled = True
                    Payroll.bLast.Enabled = True
                    Payroll.bPrev.Enabled = True
                    Me.Close()
                Else
                    MessageBox.Show("Code Incorrect. Access Denied!", "In Spirit Authorization", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            Case 2
                If TxAuth.Text = "pseudocode101" Then
                    cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

                    Dim str As String = ("UPDATE InSpiritPayroll SET PayPerHour = '" & CalcuPay.TxRegPpH.Text & "', RegularWorkHours = '" & CalcuPay.TxHr.Text & "', OvertimePayPerHour = '" & CalcuPay.LbOTPpH.Text & "', OvertimeHours = '" & CalcuPay.TxOTHr.Text & "', GrossPay = '" & CalcuPay.LbGross.Text & "', Tax = '" & CalcuPay.TxTax.Text & "', GSIS = " & CalcuPay.LsBene.GetItemChecked(0) & ", SSS = " & CalcuPay.LsBene.GetItemChecked(1) & ", PhilHealth = " & CalcuPay.LsBene.GetItemChecked(2) & ", PAGIBIG = " & CalcuPay.LsBene.GetItemChecked(3) & ", Deductions = '" & CalcuPay.LbDed.Text & "', NetPay = '" & CalcuPay.LbNet.Text & "' WHERE ID = '" & CalcuPay.LbID.Text & "'")
                    command = New OleDb.OleDbCommand(str, cnn)
                    da = New OleDb.OleDbDataAdapter(command)
                    ds = New DataSet
                    cnn.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Payroll updated!", "In Spirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cnn.Close()
                    Me.Close()
                Else
                    MessageBox.Show("Code Incorrect. Access Denied!", "In Spirit Authorization", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub showpayroll()
        Payroll.LbName.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(2) & " " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(3) & " " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(1)
        Payroll.LbID.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(0)
        Payroll.LbPosDept.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(4) + ", " + ds.Tables("ProjectIIITLE").Rows(ctr).Item(5) + " Department"
        Payroll.LbPay.Text = "Php " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(6)
        Payroll.LbHours.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(7) & " Hrs"
        Payroll.LbOTPay.Text = "Php " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(8)
        Payroll.LbOTHours.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(9) & "Hrs"
        Payroll.LbGross.Text = "Php " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(10)
        Payroll.LbTax.Text = "Php " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(11)
        Payroll.LbDeduct.Text = "Php " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(11)
        Payroll.LbNet.Text = "Php " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(12)
    End Sub

End Class