
Public Class MainPage
    Dim ctr As Integer
    Dim countrow As Integer
    Dim ds As DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim cnn As New OleDb.OleDbConnection
    Dim command As New OleDb.OleDbCommand

    Private Sub bOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOut.Click
        Me.Close()
    End Sub

    Private Sub bInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bInfo.Click
        PerInfo.Show()
        PerInfo.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Payroll.Show()
    End Sub

    Private Sub MainPage_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PerInfo.Close()
        Form1.Close()
        MReg.Close()
        Payroll.Close()
        CalcuPay.Close()

        LogIN.Show()
    End Sub

    Private Sub MainPage_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim close = MessageBox.Show("Do you want to log out?", "In Spirit Network", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub MainPage_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
        Dim str As String = ("SELECT * FROM InSpiritRecord WHERE ID = '" & LbID.Text & "'")
        command = New OleDb.OleDbCommand(str, cnn)
        da = New OleDb.OleDbDataAdapter(command)
        ds = New DataSet
        cnn.Open()
        bInfo.BackgroundImage = Image.FromFile(ds.Tables("ProjectIIITLE").Rows(ctr).Item(14))
        countrow = ds.Tables("ProjectIIITLE").Rows.Count
        cnn.Close()
    End Sub

    Private Sub MainPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim reader, read As String
        reader = My.Computer.FileSystem.ReadAllText("Announcements.txt")
        read = My.Computer.FileSystem.ReadAllText("Comments.txt")
        RichTextBox1.Text = read
        TxAnn.Text = reader

        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
        Dim str As String = ("SELECT * FROM InSpiritRecord WHERE ID = '" & LogIN.ID1.Text & "' & '-' & '" & LogIN.ID2.Text & "' & '-' & '" & LogIN.ID3.Text & "' AND sPassword = '" & LogIN.TxPass.Text & "'")
        command = New OleDb.OleDbCommand(str, cnn)
        da = New OleDb.OleDbDataAdapter(command)
        ds = New DataSet
        cnn.Open()
        da.Fill(ds, "ProjectIIITLE")
        LbLast.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(2) & " " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(3) & " " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(1)
        LbID.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(0)
        LbPosDept.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(8) + ", " + ds.Tables("ProjectIIITLE").Rows(ctr).Item(9) + " Department"
        bInfo.BackgroundImage = Image.FromFile(ds.Tables("ProjectIIITLE").Rows(ctr).Item(14))
        countrow = ds.Tables("ProjectIIITLE").Rows.Count
        cnn.Close()

        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
        Dim spr As String = ("SELECT * FROM InSpiritLog")
        command = New OleDb.OleDbCommand(str, cnn)
        da = New OleDb.OleDbDataAdapter(command)
        ds = New DataSet
        cnn.Open()
        da.Fill(ds, "ProjectIIITLE")
        'TimeLogSet

    End Sub

    Private Sub bReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bReg.Click
        Form1.Show()
        Form1.Focus()
        Form1.auth = 0
    End Sub


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Payroll.Show()
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        Cursor = Cursors.Hand

    End Sub

    Private Sub MainPage_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        stat.Text = "In Spirit™ Group of Companies®. In one, In spirit. 2014"
    End Sub

    Private Sub MainPage_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LTime.Text = TimeOfDay
        LDate.text = Today
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Focus()
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileToolStripMenuItem.Click
        PerInfo.Show()
        PerInfo.Focus()
    End Sub

    Private Sub ViewPayrollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPayrollToolStripMenuItem.Click
        Payroll.Show()
        Payroll.Focus()
    End Sub

    Private Sub ViewRegistryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewRegistryToolStripMenuItem.Click
        Form1.Show()
        Form1.auth = 0
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pRoll.Click
        Payroll.Show()
        Payroll.Focus()
    End Sub

    Private Sub bInfo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles bInfo.MouseEnter
        stat.Text = "View and edit personal data."
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pRoll.MouseEnter
        stat.Text = "View and calculate monthly payroll records."
    End Sub

    Private Sub bRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRef.Click
        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
        Dim str As String = ("SELECT * FROM InSpiritRecord WHERE ID = '" & LbID.Text & "'")
        command = New OleDb.OleDbCommand(str, cnn)
        da = New OleDb.OleDbDataAdapter(command)
        ds = New DataSet
        cnn.Open()
        da.Fill(ds, "ProjectIIITLE")
        LbLast.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(2) & " " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(3) & " " & ds.Tables("ProjectIIITLE").Rows(ctr).Item(1)
        LbID.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(0)
        LbPosDept.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(8) + ", " + ds.Tables("ProjectIIITLE").Rows(ctr).Item(9) + " Department"
        bInfo.BackgroundImage = Image.FromFile(ds.Tables("ProjectIIITLE").Rows(ctr).Item(14))
        countrow = ds.Tables("ProjectIIITLE").Rows.Count
        cnn.Close()

    End Sub

    Private Sub bRef_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles bRef.MouseEnter
        stat.Text = "Refresh the current page."
    End Sub

    Private Sub bReg_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles bReg.MouseEnter
        stat.Text = "View company registry. (Authorized personnel only.)"
    End Sub

    Private Sub bOut_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles bOut.MouseEnter
        stat.Text = "Log out of the system and return to the login page."
    End Sub

    Private Sub bAnn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAnn.Click
        If TxAnn.Enabled = False Then
            TxAnn.Enabled = True
        Else
            My.Computer.FileSystem.WriteAllText("Announcements.txt", TxAnn.Text, False)
            TxAnn.Enabled = False
        End If

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        My.Computer.FileSystem.WriteAllText("Comments.txt", RichTextBox1.Text, False)
    End Sub

End Class