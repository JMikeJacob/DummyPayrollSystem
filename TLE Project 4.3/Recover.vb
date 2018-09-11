Public Class Recover

    Dim ctr As Integer
    Dim countrow As Integer
    Dim ds As OleDb.OleDbDataReader
    Dim da As New OleDb.OleDbDataAdapter
    Dim cnn As New OleDb.OleDbConnection
    Dim command As New OleDb.OleDbCommand


    Private Sub bExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExit.Click
        Dim recv = MessageBox.Show("Are you sure?", "In Spirit Network", MessageBoxButtons.YesNo)
        If recv = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub



    Private Sub Recover_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxDept.Items.Add("Executive")
        TxDept.Items.Add("Industrial")
        TxDept.Items.Add("Commercial")
        TxDept.Items.Add("Research")
        GroupBox1.Hide()
    End Sub



    Private Sub bCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim recv = MessageBox.Show("Are you sure?", "In Spirit Network", MessageBoxButtons.YesNo)
        If recv = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub bSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim recv = MessageBox.Show("Are you sure?", "In Spirit Network", MessageBoxButtons.YesNo)
        If recv = Windows.Forms.DialogResult.Yes Then
            If vPass.Text.Length > 0 And TxPass.Text.Length > 0 And vPass.Text = TxPass.Text Then
                cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

                Dim str As String = ("UPDATE InSpiritRecord SET sPassword = '" & TxPass.Text & "' WHERE (ID = '" & Me.ID1.Text & "')")
                command = New OleDb.OleDbCommand(str, cnn)
                da = New OleDb.OleDbDataAdapter(command)
                cnn.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Password updated!", "In Spirit - Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cnn.Close()
                Me.Close()
            Else
                MessageBox.Show("Passwords do not match.", "In Spririt - Recovery", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub bReg_Click_1(sender As System.Object, e As System.EventArgs) Handles bReg.Click
        Dim recv = MessageBox.Show("Are you sure?", "In Spirit Network", MessageBoxButtons.YesNo)
        If recv = Windows.Forms.DialogResult.Yes Then
            cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

            Dim str As String = ("SELECT ID, sPosition, seMail, sDepartment FROM InSpiritRecord WHERE (((ID)=@sID) AND ((sPosition)=@sPosition) AND ((seMail)=@seMail) AND ((sDepartment)=@sDepartment))")
            command = New OleDb.OleDbCommand(str, cnn)
            command.Parameters.AddRange(
                New OleDb.OleDbParameter() _
                {New OleDb.OleDbParameter With {.ParameterName = "@ID", .DbType = DbType.String},
                    New OleDb.OleDbParameter With {.ParameterName = "@sPosition", .DbType = DbType.String},
                    New OleDb.OleDbParameter With {.ParameterName = "@seMail", .DbType = DbType.String},
                    New OleDb.OleDbParameter With {.ParameterName = "@sDepartment", .DbType = DbType.String}
                }
            )
            command.Parameters(0).Value = ID1.Text & "-" & ID2.Text & "-" & ID3.Text
            command.Parameters(1).Value = TxPos.Text
            command.Parameters(2).Value = TxMail.Text
            command.Parameters(3).Value = TxDept.Text
            cnn.Open()
            ds = command.ExecuteReader()
            If Not ds.HasRows Then
                ctr += 1
                MessageBox.Show("Incomplete or incorrect input.", "In Spirit - Recovery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If ctr >= 5 Then
                    MessageBox.Show("Limit reached. Returning to login page.", "In Spirit - Recovery", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.Close()
                End If
            Else
                GroupBox1.Show()
            End If
            cnn.Close()
        End If
    End Sub


    Private Sub TxDept_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TxDept.SelectedIndexChanged
        TxPos.Items.Clear()
        If TxDept.Text = "Executive" Then
            TxPos.Items.Add("CEO/President")
            TxPos.Items.Add("Vice President")
            TxPos.Items.Add("Chairman of the Board")
            TxPos.Items.Add("Chief of Staff")
            TxPos.Items.Add("COO/Head Director")
            TxPos.Items.Add("CIO/Secretary")
            TxPos.Items.Add("CFO/Treasurer")
            TxPos.Items.Add("CAO/Head of Security")
            TxPos.Items.Add("CCO/Director of Research")
            TxPos.Items.Add("CMO/Commercial Director")

        ElseIf TxDept.Text = "Industrial" Then
            TxPos.Items.Add("Manager")
            TxPos.Items.Add("Overseer")
            TxPos.Items.Add("Security Officer")
            TxPos.Items.Add("Production Officer")
            TxPos.Items.Add("Production Worker")
        ElseIf TxDept.Text = "Commercial" Then
            TxPos.Items.Add("Manager")
            TxPos.Items.Add("Company Accountant")
            TxPos.Items.Add("Advertisement Staff")
            TxPos.Items.Add("Advertisement Officer")
            TxPos.Items.Add("Retail Officer")
            TxPos.Items.Add("Retail Staff")
        ElseIf TxDept.Text = "Research" Then
            TxPos.Items.Add("Manager")
            TxPos.Items.Add("Market Researcher")
            TxPos.Items.Add("Resource Researcher")
            TxPos.Items.Add("Prototype Researcher")
            TxPos.Items.Add("Product Researcher")
        End If
    End Sub

End Class