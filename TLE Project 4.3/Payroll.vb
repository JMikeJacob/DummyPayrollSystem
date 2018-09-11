Public Class Payroll
    Dim ctr As Integer
    Public countrow As Integer
    Dim ds, dss As DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim cnn As New OleDb.OleDbConnection
    Dim command As New OleDb.OleDbCommand
    Public master = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExit.Click, bExit.Click
        Me.Close()
    End Sub

    Private Sub Payroll_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        master = 0
        LbID.Text = MainPage.LbID.Text
        LbName.Text = MainPage.LbLast.Text

        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

        Dim str As String = ("SELECT * FROM InSpiritPayroll WHERE ID = '" & LbID.Text & "'")
        command = New OleDb.OleDbCommand(str, cnn)
        da = New OleDb.OleDbDataAdapter(command)
        ds = New DataSet
        cnn.Open()
        da.Fill(ds, "ProjectIIITLE")
        showrecord()
        countrow = ds.Tables("ProjectIIITLE").Rows.Count
        cnn.Close()

        Dim spr As String = ("SELECT GSIS, SSS, PhilHealth, PAGIBIG FROM InSpiritPayroll ORDER BY ID")
        command = New OleDb.OleDbCommand(spr, cnn)
        da = New OleDb.OleDbDataAdapter(command)
        dss = New DataSet
        cnn.Open()
        da.Fill(dss, "ProjectIIITLE")
        LsBene.SetItemChecked(0, dss.Tables("ProjectIIITLE").Rows(ctr).Item(0))
        LsBene.SetItemChecked(1, dss.Tables("ProjectIIITLE").Rows(ctr).Item(1))
        LsBene.SetItemChecked(2, dss.Tables("ProjectIIITLE").Rows(ctr).Item(2))
        LsBene.SetItemChecked(3, dss.Tables("ProjectIIITLE").Rows(ctr).Item(3))
        countrow = dss.Tables("ProjectIIITLE").Rows.Count
        cnn.Close()
        bFirst.Visible = False
        bPrev.Visible = False
        bNext.Visible = False
        bLast.Visible = False
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles bCalc.Click
        CalcuPay.Show()
        CalcuPay.Focus()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If LinkLabel1.Text = "View Master Payroll Record" Then
            Form1.Show()
            Form1.auth = 1
        Else
            master = 0
            LbID.Text = MainPage.LbID.Text
            LbName.Text = MainPage.LbLast.Text

            Dim str As String = ("SELECT * FROM InSpiritPayroll WHERE ID = '" & LbID.Text & "'")
            command = New OleDb.OleDbCommand(str, cnn)
            da = New OleDb.OleDbDataAdapter(command)
            ds = New DataSet
            cnn.Open()
            da.Fill(ds, "ProjectIIITLE")
            ctr = countrow = ds.Tables("ProjectIIITLE").Rows.Count
            showrecord()
            cnn.Close()

            LinkLabel1.Text = "View Master Payroll Record"
            bFirst.Visible = False
            bPrev.Visible = False
            bNext.Visible = False
            bLast.Visible = False

        End If
    End Sub

    Public Sub showrecord()
        LbPosDept.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(4) + ", " + ds.Tables("ProjectIIITLE").Rows(ctr).Item(5) + " Department"
        LbPay.Text = "Php " & FormatNumber(ds.Tables("ProjectIIITLE").Rows(ctr).Item(6), 2)
        LbHours.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(7) & " Hrs"
        LbOTPay.Text = "Php " & FormatNumber(ds.Tables("ProjectIIITLE").Rows(ctr).Item(9), 2)
        LbOTHours.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(8) & " Hrs"
        LbGross.Text = "Php " & FormatNumber(ds.Tables("ProjectIIITLE").Rows(ctr).Item(11), 2)
        LbTax.Text = "Php " & FormatNumber(ds.Tables("ProjectIIITLE").Rows(ctr).Item(10), 2)
        LbDeduct.Text = "Php " & FormatNumber(ds.Tables("ProjectIIITLE").Rows(ctr).Item(17), 2)
        LbNet.Text = "Php " & FormatNumber(ds.Tables("ProjectIIITLE").Rows(ctr).Item(12), 2)
    End Sub


    Private Sub bRef_Click(sender As System.Object, e As System.EventArgs) Handles bRef.Click

        Select Case master
            Case 0
                Dim str As String = ("SELECT * FROM InSpiritPayroll WHERE ID = '" & LbID.Text & "'")
                command = New OleDb.OleDbCommand(str, cnn)
                da = New OleDb.OleDbDataAdapter(command)
                ds = New DataSet
                cnn.Open()
                da.Fill(ds, "ProjectIIITLE")
                showrecord()
                countrow = ds.Tables("ProjectIIITLE").Rows.Count
                cnn.Close()

                Dim spr As String = ("SELECT GSIS, SSS, PhilHealth, PAGIBIG FROM InSpiritPayroll WHERE ID = '" & LbID.Text & "'")
                command = New OleDb.OleDbCommand(spr, cnn)
                da = New OleDb.OleDbDataAdapter(command)
                dss = New DataSet
                cnn.Open()
                da.Fill(dss, "ProjectIIITLE")
                LsBene.SetItemChecked(0, dss.Tables("ProjectIIITLE").Rows(ctr).Item(0))
                LsBene.SetItemChecked(1, dss.Tables("ProjectIIITLE").Rows(ctr).Item(1))
                LsBene.SetItemChecked(2, dss.Tables("ProjectIIITLE").Rows(ctr).Item(2))
                LsBene.SetItemChecked(3, dss.Tables("ProjectIIITLE").Rows(ctr).Item(3))
                countrow = dss.Tables("ProjectIIITLE").Rows.Count
                cnn.Close()
            Case 1
                cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

                Dim str As String = ("SELECT * FROM InSpiritPayroll ORDER BY ID")
                command = New OleDb.OleDbCommand(str, cnn)
                da = New OleDb.OleDbDataAdapter(command)
                ds = New DataSet
                cnn.Open()
                da.Fill(ds, "ProjectIIITLE")
                showpayroll()
                countrow = ds.Tables("ProjectIIITLE").Rows.Count
                cnn.Close()

                Dim spr As String = ("SELECT GSIS, SSS, PhilHealth, PAGIBIG FROM InSpiritPayroll ORDER BY ID")
                command = New OleDb.OleDbCommand(spr, cnn)
                da = New OleDb.OleDbDataAdapter(command)
                dss = New DataSet
                cnn.Open()
                da.Fill(dss, "ProjectIIITLE")
                LsBene.SetItemChecked(0, dss.Tables("ProjectIIITLE").Rows(ctr).Item(0))
                LsBene.SetItemChecked(1, dss.Tables("ProjectIIITLE").Rows(ctr).Item(1))
                LsBene.SetItemChecked(2, dss.Tables("ProjectIIITLE").Rows(ctr).Item(2))
                LsBene.SetItemChecked(3, dss.Tables("ProjectIIITLE").Rows(ctr).Item(3))
                countrow = dss.Tables("ProjectIIITLE").Rows.Count
                cnn.Close()
        End Select
    End Sub

    Private Sub bFirst_Click(sender As System.Object, e As System.EventArgs) Handles bFirst.Click
        If ctr = 0 Then
            buttoncode()
            MessageBox.Show("First Record", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ctr = 0
            buttoncode()
            MessageBox.Show("First Record", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bLast_Click(sender As System.Object, e As System.EventArgs) Handles bLast.Click

        If ctr <> countrow Then
            ctr = countrow - 1
            buttoncode()
            MessageBox.Show("Last Record", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bPrev_Click(sender As System.Object, e As System.EventArgs) Handles bPrev.Click

        If ctr > 0 Then
            ctr -= 1
            buttoncode()
        Else
            MessageBox.Show("First Record", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bNext_Click(sender As System.Object, e As System.EventArgs) Handles bNext.Click

        If ctr < countrow - 1 Then
            ctr += 1
            buttoncode()
        Else
            MessageBox.Show("Last Record", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub showpayroll()
        LbName.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(2) & " " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(3) & " " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(1)
        LbID.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(0)
        LbPosDept.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(4) + ", " + ds.Tables("ProjectIIITLE").Rows(ctr).Item(5) + " Department"
        LbPay.Text = "Php " & FormatNumber(ds.Tables("ProjectIIITLE").Rows(ctr).Item(6), 2)
        LbHours.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(7) & " Hrs"
        LbOTPay.Text = "Php " & FormatNumber(ds.Tables("ProjectIIITLE").Rows(ctr).Item(9), 2)
        LbOTHours.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(8) & " Hrs"
        LbGross.Text = "Php " & FormatNumber(ds.Tables("ProjectIIITLE").Rows(ctr).Item(11), 2)
        LbTax.Text = "Php " & FormatNumber(ds.Tables("ProjectIIITLE").Rows(ctr).Item(10), 2)
        LbDeduct.Text = "Php " & FormatNumber(ds.Tables("ProjectIIITLE").Rows(ctr).Item(17), 2)
        LbNet.Text = "Php " & FormatNumber(ds.Tables("ProjectIIITLE").Rows(ctr).Item(12), 2)
    End Sub

    Private Sub buttoncode()
        Dim str As String = ("SELECT * FROM InSpiritPayroll ORDER BY ID")
        command = New OleDb.OleDbCommand(str, cnn)
        da = New OleDb.OleDbDataAdapter(command)
        ds = New DataSet
        cnn.Open()
        da.Fill(ds, "ProjectIIITLE")
        showpayroll()
        countrow = ds.Tables("ProjectIIITLE").Rows.Count
        cnn.Close()

        Dim spr As String = ("SELECT GSIS, SSS, PhilHealth, PAGIBIG FROM InSpiritPayroll ORDER BY ID")
        command = New OleDb.OleDbCommand(spr, cnn)
        da = New OleDb.OleDbDataAdapter(command)
        dss = New DataSet
        cnn.Open()
        da.Fill(dss, "ProjectIIITLE")
        LsBene.SetItemChecked(0, dss.Tables("ProjectIIITLE").Rows(ctr).Item(0))
        LsBene.SetItemChecked(1, dss.Tables("ProjectIIITLE").Rows(ctr).Item(1))
        LsBene.SetItemChecked(2, dss.Tables("ProjectIIITLE").Rows(ctr).Item(2))
        LsBene.SetItemChecked(3, dss.Tables("ProjectIIITLE").Rows(ctr).Item(3))
        countrow = dss.Tables("ProjectIIITLE").Rows.Count
        cnn.Close()

        CalcuPay.LbID.Text = LbID.Text
        CalcuPay.LbName.Text = LbName.Text
        CalcuPay.LbPosDept.Text = LbPosDept.Text
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        MainPage.Focus()
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProfileToolStripMenuItem.Click
        PerInfo.Show()
        PerInfo.Focus()
    End Sub

    Private Sub ViewPayrollToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewPayrollToolStripMenuItem.Click
        Me.Show()
        Me.Focus()
    End Sub

    Private Sub ViewRegistryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewRegistryToolStripMenuItem.Click
        Form1.Show()
        Form1.auth = 0
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        MainPage.Close()
    End Sub


    Private Sub bPrint_Click(sender As System.Object, e As System.EventArgs) Handles bPrint.Click

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim prFont As New Font("Adobe Gothic Std", 16, GraphicsUnit.Point)
        e.HasMorePages = False

        e.Graphics.DrawRectangle(Pens.Black, 50, 50, 750, 1000)


        e.Graphics.DrawString(LbName.Text, New Font("Adobe Gothic Std ", 18, GraphicsUnit.Point), Brushes.Black, 100, 230)
        e.Graphics.DrawString(LbPosDept.Text, New Font("Adobe Gothic Std", 18, GraphicsUnit.Point), Brushes.Black, 100, 270)
        e.Graphics.DrawString(LbID.Text, New Font("Adobe Gothic Std", 18, GraphicsUnit.Point), Brushes.Black, 630, 230)
        e.Graphics.DrawString(Today, New Font("Adobe Gothic Std", 18, GraphicsUnit.Point), Brushes.Black, 640, 270)

        e.Graphics.DrawString(Label2.Text, prFont, Brushes.Black, 100, 350)
        e.Graphics.DrawString(Label3.Text, prFont, Brushes.Black, 100, 400)
        e.Graphics.DrawString(Label4.Text, prFont, Brushes.Black, 100, 450)
        e.Graphics.DrawString(Label6.Text, prFont, Brushes.Black, 100, 500)
        e.Graphics.DrawString(Label5.Text, prFont, Brushes.Black, 100, 550)
        e.Graphics.DrawString(Label12.Text, prFont, Brushes.Black, 100, 600)
        e.Graphics.DrawString(Label8.Text, prFont, Brushes.Black, 457, 350)
        e.Graphics.DrawString(Label10.Text, prFont, Brushes.Black, 457, 450)
        e.Graphics.DrawString(Label13.Text, prFont, Brushes.Black, 457, 550)

        If LsBene.GetItemChecked(0) = True Then
            e.Graphics.DrawString("☑ GSIS", prFont, Brushes.Black, 200, 600)
        Else
            e.Graphics.DrawString("□ GSIS", prFont, Brushes.Black, 200, 600)
        End If

        If LsBene.GetItemChecked(1) = True Then
            e.Graphics.DrawString("☑ SSS", prFont, Brushes.Black, 300, 600)
        Else
            e.Graphics.DrawString("□ SSS", prFont, Brushes.Black, 300, 600)
        End If

        If LsBene.GetItemChecked(2) = True Then
            e.Graphics.DrawString("☑ PhilHealth", prFont, Brushes.Black, 400, 600)
        Else
            e.Graphics.DrawString("□ PhilHealth", prFont, Brushes.Black, 400, 600)
        End If

        If LsBene.GetItemChecked(3) = True Then
            e.Graphics.DrawString("☑ PAGIBIG", prFont, Brushes.Black, 570, 600)
        Else
            e.Graphics.DrawString("□ PAGIBIG", prFont, Brushes.Black, 570, 600)
        End If

        e.Graphics.DrawString(LbPay.Text, prFont, Brushes.Black, 254, 350)
        e.Graphics.DrawString(LbHours.Text, prFont, Brushes.Black, 254, 400)
        e.Graphics.DrawString(LbOTPay.Text, prFont, Brushes.Black, 254, 450)
        e.Graphics.DrawString(LbOTHours.Text, prFont, Brushes.Black, 254, 500)
        e.Graphics.DrawString(LbTax.Text, prFont, Brushes.Black, 254, 550)
        e.Graphics.DrawString(LbGross.Text, prFont, Brushes.Black, 613, 350)
        e.Graphics.DrawString(LbDeduct.Text, prFont, Brushes.Black, 613, 450)
        e.Graphics.DrawString(LbNet.Text, prFont, Brushes.Black, 613, 550)

        e.Graphics.DrawString("IN SPIRIT GROUP OF COMPANIES", New Font("Monotype Corsiva", 22, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 260, 100)
        e.Graphics.DrawString("MONTHLY EMPLOYEE PAYROLL", New Font("Adobe Gothic Std B", 20, GraphicsUnit.Point), Brushes.Black, 290, 140)
        e.Graphics.DrawString("SUMMARY REPORT", New Font("Adobe Gothic Std B", 20, GraphicsUnit.Point), Brushes.Black, 360, 170)
        e.Graphics.DrawImage(My.Resources.LOGO1, New Rectangle(65, 65, 200, 160))
        e.Graphics.DrawString("------------------------------------------------------------------------------------------", New Font("Times New Roman", 15, GraphicsUnit.Point), Brushes.Black, 100, 700)

        e.Graphics.DrawString("TOTAL SALARY:", New Font("Modern No. 20", 32), Brushes.Black, 100, 750)
        e.Graphics.DrawString(LbNet.Text, New Font("Modern No. 20", 32), Brushes.Black, 480, 750)

        e.Graphics.DrawString("Please retrieve your pay and payslip at the Executive Office of your workplace. Thank you.", New Font("Modern No. 20", 12, GraphicsUnit.Point), Brushes.Black, 135, 950)
        e.Graphics.DrawString("In Spirit™ Group of Companies®. In one, In spirit.", New Font("Modern No. 20", 12, GraphicsUnit.Point), Brushes.Black, 400, 1000)
    End Sub

    Private Sub bPrint_MouseEnter(sender As Object, e As System.EventArgs) Handles bPrint.MouseEnter
        stat.Text = "Print out summary report of payroll record."
    End Sub

    Private Sub bRef_MouseEnter(sender As Object, e As System.EventArgs) Handles bRef.MouseEnter
        stat.Text = "Refresh the current page."
    End Sub

    Private Sub bExit_MouseHover(sender As Object, e As System.EventArgs) Handles bExit.MouseHover
        stat.Text = "Closes the current page."
    End Sub

    Private Sub bCalc_MouseHover(sender As Object, e As System.EventArgs) Handles bCalc.MouseHover
        stat.Text = "Calculate and update payroll records."
    End Sub

    Private Sub bFirst_MouseEnter(sender As Object, e As System.EventArgs) Handles bFirst.MouseEnter
        stat.Text = "View first record."
    End Sub

    Private Sub bLast_MouseEnter(sender As Object, e As System.EventArgs) Handles bLast.MouseEnter
        stat.Text = "View last record."
    End Sub

    Private Sub bPrev_MouseEnter(sender As Object, e As System.EventArgs) Handles bPrev.MouseEnter
        stat.Text = "View previous record."
    End Sub

    Private Sub bNext_MouseEnter(sender As Object, e As System.EventArgs) Handles bNext.MouseEnter
        stat.Text = "View next record."
    End Sub

    Private Sub Payroll_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        stat.Text = "In Spirit™ Group of Companies®. In one, In spirit. 2014"
    End Sub

    Private Sub LinkLabel1_MouseEnter(sender As Object, e As System.EventArgs) Handles LinkLabel1.MouseEnter
        stat.Text = "View master payroll record. (Authorized personnel only.)"
    End Sub
End Class