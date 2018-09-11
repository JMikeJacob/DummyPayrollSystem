Public Class LogIN
    Dim ctr As Integer
    Dim countrow As Integer
    Dim ds As OleDb.OleDbDataReader
    Dim da As New OleDb.OleDbDataAdapter
    Dim cnn As New OleDb.OleDbConnection
    Dim command As New OleDb.OleDbCommand

    Private Sub BQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BQuit.Click

        Dim bAlert = MessageBox.Show("Are you sure?", "In Spirit Network", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If bAlert = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLog.Click
        If ID1.Text = "OLE" And ID2.Text = "OLE" And ID3.Text = "OLE" And TxPass.Text = "pseudocode101" Then
            MReg.Show()
            MReg.bOut.Enabled = False
        Else
            If ID1.Text.Length > 0 And ID2.Text.Length > 0 And ID3.Text.Length > 0 And TxPass.Text.Length > 0 Then
                cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

                Dim str As String = ("SELECT ID, sPassword FROM InSpiritRecord WHERE (((ID)=@ID AND (sPassword)=@sPassword))")
                command = New OleDb.OleDbCommand(str, cnn)
                command.Parameters.AddRange(
                    New OleDb.OleDbParameter() _
                    {New OleDb.OleDbParameter With {.ParameterName = "@ID", .DbType = DbType.String},
                        New OleDb.OleDbParameter With {.ParameterName = "@sPassword", .DbType = DbType.String}
                    }
                )
                command.Parameters(0).Value = ID1.Text & "-" & ID2.Text & "-" & ID3.Text
                command.Parameters(1).Value = TxPass.Text
                cnn.Open()
                ds = command.ExecuteReader()
                If Not ds.HasRows Then
                    ctr += 1
                    MessageBox.Show("Wrong ID or Password.", "In Spirit Network", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If ctr >= 5 Then
                        MessageBox.Show("Limit reached. Commencing Shutdown.", "In Spirit Network", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Success!", "In Spirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MainPage.Show()
                    LoREG.Close()
                    Recover.Close()
                    MReg.Close()
                    Me.Hide()
                End If
                cnn.Close()
            Else
                MessageBox.Show("Please input the required information.", "In Spirit Network", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub LogIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ID1.Text = ""
        ID2.Text = ""
        ID3.Text = ""
        TxPass.Text = ""
        MReg.Close()
    End Sub

    Private Sub TClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TClock.Tick
        LTime.Text = TimeOfDay
        LDate.Text = Today
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Recover.Show()
        Recover.Focus()
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoREG.Show()
        LoREG.Focus()
    End Sub

    Private Sub LogIN_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ID1.Text = ""
        ID2.Text = ""
        ID3.Text = ""
        TxPass.Text = ""

    End Sub

    Private Sub LogIN_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        ID1.Text = ""
        ID2.Text = ""
        ID3.Text = ""
        TxPass.Text = ""
    End Sub


    Private Sub ID1_TextChanged(sender As System.Object, e As System.EventArgs) Handles ID1.TextChanged
        If ID1.Text.Length >= 3 Then
            ID2.Focus()
        End If
    End Sub

    Private Sub ID2_TextChanged(sender As System.Object, e As System.EventArgs) Handles ID2.TextChanged
        If ID2.Text.Length >= 3 Then
            ID3.Focus()
        End If
    End Sub

    Private Sub ID3_TextChanged(sender As System.Object, e As System.EventArgs) Handles ID3.TextChanged
        If ID3.Text.Length >= 3 Then
            TxPass.Focus()
        End If
    End Sub

    Private Sub ID1_GotFocus(sender As Object, e As System.EventArgs) Handles ID1.GotFocus
        ID1.SelectAll()
    End Sub


    Private Sub ID2_GotFocus(sender As Object, e As System.EventArgs) Handles ID2.GotFocus
        ID2.SelectAll()
    End Sub

    Private Sub ID3_GotFocus(sender As Object, e As System.EventArgs) Handles ID3.GotFocus
        ID3.SelectAll()
    End Sub
End Class