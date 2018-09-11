Public Class CalcuPay
    Dim ctr As Integer
    Dim countrow As Integer
    Dim ds As DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim cnn As New OleDb.OleDbConnection
    Dim command As New OleDb.OleDbCommand

    Private Sub CalcuPay_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Payroll.LinkLabel1.Enabled = True
        If Payroll.master = 1 Then
            Payroll.bFirst.Enabled = True
            Payroll.bPrev.Enabled = True
            Payroll.bNext.Enabled = True
            Payroll.bLast.Enabled = True
        End If
    End Sub

    Private Sub CalcuPay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Payroll.LinkLabel1.Enabled = False
        LbName.Text = Payroll.LbName.Text
        LbID.Text = Payroll.LbID.Text
        LbPosDept.Text = Payroll.LbPosDept.Text
        LbDed.Text = ""
        LbOTPpH.Text = ""
        LbGross.Text = ""
        LbNet.Text = ""
        TxTax.Text = ""
    End Sub

    Private Sub bExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExit.Click
        Me.Close()
    End Sub

    Private Sub bUpd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bUpd.Click

        If TxRegPpH.Text.Length > 0 And TxHr.Text.Length > 0 And TxOTHr.Text.Length > 0 And LbNet.Text.Length > 0 Then
            If Payroll.master = 1 Then
                cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

                Dim str As String = ("UPDATE InSpiritPayroll SET PayPerHour = '" & TxRegPpH.Text & "', RegularWorkHours = '" & TxHr.Text & "', OvertimePayPerHour = '" & LbOTPpH.Text & "', OvertimeHours = '" & TxOTHr.Text & "', GrossPay = '" & LbGross.Text & "', Tax = '" & TxTax.Text & "', GSIS = " & LsBene.GetItemChecked(0) & ", SSS = " & LsBene.GetItemChecked(1) & ", PhilHealth = " & LsBene.GetItemChecked(2) & ", PAGIBIG = " & LsBene.GetItemChecked(3) & ", Deductions = '" & LbDed.Text & "', NetPay = '" & LbNet.Text & "' WHERE ID = '" & LbID.Text & "'")
                command = New OleDb.OleDbCommand(str, cnn)
                da = New OleDb.OleDbDataAdapter(command)
                ds = New DataSet
                cnn.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Payroll updated!", "In Spirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cnn.Close()
            Else
                Form1.Show()
                Form1.auth = 2
            End If
        Else
            MessageBox.Show("Please input the required data.", "In Spirit Payroll Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub bGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGo.Click

        If TxRegPpH.Text.Length > 0 And TxHr.Text.Length > 0 And TxOTHr.Text.Length > 0 Then
            Dim result As Single
            If Double.TryParse(TxRegPpH.Text, result) = True And Double.TryParse(TxHr.Text, result) = True And Double.TryParse(TxOTHr.Text, result) = True Then
                Dim pay, hour, otpay, othour, tax, gsis, sss, phil, pag, ded, gross, net As Single
                pay = TxRegPpH.Text
                hour = TxHr.Text
                othour = TxOTHr.Text

                'Calculations'
                otpay = (0.2 * pay)

                LbOTPpH.Text = FormatNumber(otpay, 2)

                gross = (pay * hour) + (otpay * othour)

                If gross > 10000 Then
                    tax = (gross * 0.32)
                Else
                    tax = 0
                End If

                TxTax.Text = FormatNumber(tax, 2)

                If LsBene.GetItemChecked(0) = True Then
                    gsis = gross * 0.1
                End If

                If LsBene.GetItemChecked(1) = True Then
                    sss = gross * 0.104
                End If

                If LsBene.GetItemChecked(2) = True Then
                    phil = gross * 0.025
                End If

                If LsBene.GetItemChecked(3) = True Then
                    pag = gross * 0.02
                End If

                ded = tax + gsis + sss + phil + pag
                net = gross - ded


                LbGross.Text = FormatNumber(gross, 2)
                LbDed.Text = FormatNumber(ded, 2)
                If net > 0 Then
                    LbNet.Text = FormatNumber(net, 2)
                Else
                    LbNet.Text = FormatNumber(0, 2)
                End If

            Else
                MessageBox.Show("Please use numbers and decimals only.", "In Spirit Payroll Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please input the required data.", "In Spirit Payroll Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub bClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClr.Click
        TxHr.Text = ""
        TxOTHr.Text = ""
        TxRegPpH.Text = ""
        TxTax.Text = ""
        LbDed.Text = ""
        LbOTPpH.Text = ""
        LbGross.Text = ""
        LbNet.Text = ""
    End Sub
    Private Sub bGo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles bGo.MouseEnter
        stat.Text = "Calculate payroll based on input information."
    End Sub

    Private Sub bClr_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles bClr.MouseEnter
        stat.Text = "Clear all input data."
    End Sub

    Private Sub bUpd_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles bUpd.MouseEnter
        stat.Text = "Update payroll record based on calculations."
    End Sub

    Private Sub bExit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles bExit.MouseEnter
        stat.Text = "Close the current window."
    End Sub

    Private Sub CalcuPay_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        stat.Text = "In Spirit™ Group of Companies®. In one, In spirit. 2014"
    End Sub
End Class