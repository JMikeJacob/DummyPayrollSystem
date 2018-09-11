Public Class PerInfo
    Dim ctr As Integer
    Dim countrow As Integer
    Dim ds As DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim cnn As New OleDb.OleDbConnection
    Dim command As New OleDb.OleDbCommand
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub PerInfo_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
        Dim str As String = ("SELECT * FROM InSpiritRecord WHERE ID = '" & MainPage.LbID.Text & "'")
        command = New OleDb.OleDbCommand(str, cnn)
        da = New OleDb.OleDbDataAdapter(command)
        ds = New DataSet
        cnn.Open()
        da.Fill(ds, "ProjectIIITLE")
        showinfo()
        countrow = ds.Tables("ProjectIIITLE").Rows.Count
    End Sub

    Private Sub PerInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TxMail.Visible = False
        TxAddr.Visible = False
        TxCont.Visible = False
        LDate.Text = Today
        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

        Dim str As String = ("SELECT * FROM InSpiritRecord WHERE (ID = '" & MainPage.LbID.Text & "')")
        command = New OleDb.OleDbCommand(str, cnn)
        da = New OleDb.OleDbDataAdapter(command)
        ds = New DataSet
        cnn.Open()
        da.Fill(ds, "ProjectIIITLE")
        showinfo()
        countrow = ds.Tables("ProjectIIITLE").Rows.Count
    End Sub

    Private Sub bClear_Click(sender As System.Object, e As System.EventArgs) Handles bClear.Click
        Dim remv = MessageBox.Show("Are you sure?", "InSpirit Network", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If remv = Windows.Forms.DialogResult.Yes Then
            TxDiary.Text = ""
        End If

    End Sub

    Private Sub bDia_Click(sender As System.Object, e As System.EventArgs) Handles bDia.Click

        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
        Dim str As String = ("UPDATE InSpiritRecord SET sDiary = '" & TxDiary.Text & "' WHERE ID = '" & LID.Text & "'")
        command = New OleDb.OleDbCommand(str, cnn)
        da = New OleDb.OleDbDataAdapter(command)
        cnn.Open()
        command.ExecuteNonQuery()
        MessageBox.Show("Diary saved!", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cnn.Close()
    End Sub


    Private Sub PTime_Tick(sender As System.Object, e As System.EventArgs) Handles PTime.Tick
        LTime.Text = TimeOfDay
    End Sub

    Private Sub bDown_Click(sender As System.Object, e As System.EventArgs) Handles bDown.Click
        Dim DiarySave As New SaveFileDialog()

        DiarySave.DefaultExt = "*.rtf"
        DiarySave.Filter = "RTF Files|*.rtf"

        If (DiarySave.ShowDialog() = System.Windows.Forms.DialogResult.OK) And (DiarySave.FileName.Length > 0) Then
            TxDiary.SaveFile(DiarySave.FileName)
        End If

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles bRef.Click
        If bRef.Text = "Refresh" Then
            cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

            Dim str As String = ("SELECT * FROM InSpiritRecord WHERE (ID = '" & MainPage.LbID.Text & "')")
            command = New OleDb.OleDbCommand(str, cnn)
            da = New OleDb.OleDbDataAdapter(command)
            ds = New DataSet
            cnn.Open()
            da.Fill(ds, "ProjectIIITLE")
            showinfo()
            countrow = ds.Tables("ProjectIIITLE").Rows.Count
        Else
            LMail.Visible = True
            LAddress.Visible = True
            LContact.Visible = True
            TxMail.Text = LMail.Text
            TxMail.Visible = False
            TxAddr.Text = LAddress.Text
            TxAddr.Visible = False
            TxCont.Text = LContact.Text
            TxCont.Visible = False
            bRef.Text = "Refresh"
            bEdit.Text = "Edit"
            bClose.Enabled = True
        End If
    End Sub

    Private Sub bEdit_Click(sender As System.Object, e As System.EventArgs) Handles bEdit.Click
        If bEdit.Text = "Edit" Then
            LMail.Visible = False
            LAddress.Visible = False
            LContact.Visible = False
            bEdit.Text = "Update"
            TxMail.Visible = True
            TxAddr.Visible = True
            TxCont.Visible = True
            bRef.Text = "Cancel"
            bClose.Enabled = False
        Else
            If TxMail.Text.Length > 0 And TxAddr.Text.Length > 0 And TxCont.Text.Length > 0 Then
                Dim edi = MessageBox.Show("Done?", "InSpirit Network", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If edi = Windows.Forms.DialogResult.Yes Then

                    cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
                    Dim str As String = ("UPDATE InSpiritRecord SET seMail = '" & TxMail.Text & "', sAddress = '" & TxAddr.Text & "', sContact = '" & TxCont.Text & "' WHERE ID = '" & LID.Text & "'")
                    command = New OleDb.OleDbCommand(str, cnn)
                    da = New OleDb.OleDbDataAdapter(command)
                    cnn.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Data updated!", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cnn.Close()

                    LMail.Visible = True
                    LAddress.Visible = True
                    LContact.Visible = True
                    TxMail.Visible = False
                    TxAddr.Visible = False
                    TxCont.Visible = False
                    bClose.Enabled = True
                    bRef.Text = "Refresh"
                    bEdit.Text = "Edit"
                End If
            End If
        End If
    End Sub

    Private Sub showinfo()
        LName.Text = MainPage.LbLast.Text
        LID.Text = MainPage.LbID.Text
        
        LMail.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(4)
        LAddress.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(7)
        LPosDept.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(8) + ", " + ds.Tables("ProjectIIITLE").Rows(ctr).Item(9) + " Department"
        LBirth.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(10)
        LContact.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(11)
        LEmploy.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(12)
        TxMail.Text = LMail.Text
        TxAddr.Text = LAddress.Text
        TxCont.Text = LContact.Text
        If Not ds.Tables("ProjectIIITLE").Rows(ctr).Item(13).ToString = "" Then
            TxDiary.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(13)
        End If
        PictureBox1.Image = Image.FromFile(ds.Tables("ProjectIIITLE").Rows(ctr).Item(14))
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        MainPage.Focus()
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProfileToolStripMenuItem.Click
        Me.Show()
        Me.Focus()
    End Sub

    Private Sub ViewPayrollToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewPayrollToolStripMenuItem.Click
        Payroll.Show()
        Payroll.Focus()
    End Sub

    Private Sub ViewRegistryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewRegistryToolStripMenuItem.Click
        Form1.Show()
        Form1.auth = 0
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        MainPage.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.ShowReadOnly = False
        OpenFileDialog1.Filter = "All Files|*.*|Image Files (*)|*.bmp;*.gif;*.jpg;*.jpeg; *.png"
        OpenFileDialog1.FilterIndex = 2

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim FName() As String = OpenFileDialog1.FileName.Split("\\")
            If System.IO.File.Exists("Profiles\\" + FName(FName.Length - 1)) = False Then
                System.IO.File.Copy(OpenFileDialog1.FileName, "Profiles\\" + FName(FName.Length - 1))

                cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
                Dim spr As String = ("UPDATE InSpiritRecord SET ProfilePicture = 'Profiles\" & FName(FName.Length - 1) & "' WHERE ID = '" & LID.Text & "'")
                command = New OleDb.OleDbCommand(spr, cnn)
                da = New OleDb.OleDbDataAdapter(command)
                cnn.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Please refresh to view changes.", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cnn.Close()

                
            Else
                 cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
                Dim spr As String = ("UPDATE InSpiritRecord SET ProfilePicture = 'Profiles\" & FName(FName.Length - 1) & "' WHERE ID = '" & LID.Text & "'")
                command = New OleDb.OleDbCommand(spr, cnn)
                da = New OleDb.OleDbDataAdapter(command)
                cnn.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Please refresh to view changes.", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cnn.Close()
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Cursor.Current = Cursors.Hand
    End Sub

    Private Sub PerInfo_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        Cursor.Current = Cursors.Default
        stat.Text = "In Spirit™ Group of Companies®. In one, In spirit. 2014"
    End Sub

    Private Sub bEdit_MouseEnter(sender As Object, e As System.EventArgs) Handles bEdit.MouseEnter
        stat.Text = "Edit contact information."
    End Sub

    Private Sub bRef_MouseEnter(sender As Object, e As System.EventArgs) Handles bRef.MouseEnter
        stat.Text = "Refresh the current page."
    End Sub

    Private Sub bDia_MouseEnter(sender As Object, e As System.EventArgs) Handles bDia.MouseEnter
        stat.Text = "Save the contents of your diary."
    End Sub

    Private Sub bClear_MouseEnter(sender As Object, e As System.EventArgs) Handles bClear.MouseEnter
        stat.Text = "Erase the contents of your diary."
    End Sub

    Private Sub bDown_MouseEnter(sender As Object, e As System.EventArgs) Handles bDown.MouseEnter
        stat.Text = "Save your diary to your computer in .rtf format."
    End Sub

    Private Sub bClose_MouseEnter(sender As Object, e As System.EventArgs) Handles bClose.MouseEnter
        stat.Text = "Close this window and return to home page."
    End Sub
End Class