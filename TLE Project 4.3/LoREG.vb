Public Class LoREG
        Dim ctr As Integer
        Dim countrow As Integer
        Dim ds As OleDb.OleDbDataReader
        Dim da As New OleDb.OleDbDataAdapter
    Dim cnn, cpr As New OleDb.OleDbConnection
        Dim command As New OleDb.OleDbCommand



        Private Sub bExit_Click(sender As System.Object, e As System.EventArgs) Handles bExit.Click
        Dim bAlert = MessageBox.Show("Are you sure?", "In Spirit Network", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bAlert = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        End Sub

        Private Sub bReg_Click(sender As System.Object, e As System.EventArgs) Handles bReg.Click
        If ID1.Text.Length > 0 And TxMail.Text.Length > 0 And TxPass.Text.Length > 0 And TxLast.Text.Length > 0 And TxFirst.Text.Length > 0 And TxMid.Text.Length > 0 And TxAddr.Text.Length > 0 And TxCont.Text.Length > 0 And TxDate.Text.Length > 0 And IsDate(TxDate.Text) = True And Not (TxPos.Text = "" And TxDept.Text = "") And (RdMale.Checked = True Or RdFem.Checked = True Or RdOther.Checked = True) Then
            cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

            Dim str As String = ("SELECT ID  FROM InSpiritRecord WHERE (((ID)=@ID))")
            command = New OleDb.OleDbCommand(str, cnn)
            command.Parameters.AddRange(
                New OleDb.OleDbParameter() _
                {New OleDb.OleDbParameter With {.ParameterName = "@ID", .DbType = DbType.String},
                    New OleDb.OleDbParameter With {.ParameterName = "@sPassword", .DbType = DbType.String}
                }
            )
            command.Parameters(0).Value = ID1.Text & "-" & ID2.Text & "-" & ID3.Text
            cnn.Open()
            ds = command.ExecuteReader()
            If Not ds.HasRows Then
                Dim addi = MessageBox.Show("Are you sure?", "In Spirit Network", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If addi = Windows.Forms.DialogResult.Yes Then
                    If RdMale.Checked = True Then
                        'Main Record'
                        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
                        Dim srr As String = ("INSERT INTO InSpiritRecord VALUES('" & ID1.Text & "' & '-' & '" & ID2.Text & "' & '-' & '" & ID3.Text & "', '" & TxLast.Text & "', '" & TxFirst.Text & "', '" & TxMid.Text & "', '" & TxMail.Text & "', '" & TxPass.Text & "', 'Male', '" & TxAddr.Text & "', '" & TxPos.Text & "', '" & TxDept.Text & "','" & TxDate.Text & "' , '" & TxCont.Text & "', '" & Today & "', '...', 'Profiles\blank.png' )")
                        command = New OleDb.OleDbCommand(srr, cnn)
                        da = New OleDb.OleDbDataAdapter(command)
                        cnn.Open()
                        command.ExecuteNonQuery()
                        Dim save = MessageBox.Show("Register complete!", "In Spirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cnn.Close()

                    ElseIf RdFem.Checked = True Then
                        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
                        Dim srr As String = ("INSERT INTO InSpiritRecord VALUES('" & ID1.Text & "' & '-' & '" & ID2.Text & "' & '-' & '" & ID3.Text & "', '" & TxLast.Text & "', '" & TxFirst.Text & "', '" & TxMid.Text & "', '" & TxMail.Text & "', '" & TxPass.Text & "', 'Male', '" & TxAddr.Text & "', '" & TxPos.Text & "', '" & TxDept.Text & "','" & TxDate.Text & "' , '" & TxCont.Text & "', '" & Today & "', '...', 'Profiles\blank.png' )")
                        command = New OleDb.OleDbCommand(srr, cnn)
                        da = New OleDb.OleDbDataAdapter(command)
                        cnn.Open()
                        command.ExecuteNonQuery()
                        Dim save = MessageBox.Show("Register complete!", "In Spirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cnn.Close()

                    ElseIf RdOther.Checked = True Then
                        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
                        Dim srr As String = ("INSERT INTO InSpiritRecord VALUES('" & ID1.Text & "' & '-' & '" & ID2.Text & "' & '-' & '" & ID3.Text & "', '" & TxLast.Text & "', '" & TxFirst.Text & "', '" & TxMid.Text & "', '" & TxMail.Text & "', '" & TxPass.Text & "', 'Male', '" & TxAddr.Text & "', '" & TxPos.Text & "', '" & TxDept.Text & "','" & TxDate.Text & "' , '" & TxCont.Text & "', '" & Today & "', '...', 'Profiles\blank.png' )")
                        command = New OleDb.OleDbCommand(srr, cnn)
                        da = New OleDb.OleDbDataAdapter(command)
                        cnn.Open()
                        command.ExecuteNonQuery()
                        Dim saved = MessageBox.Show("Register complete!", "In Spirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cnn.Close()

                    End If
                    'Payroll'
                    cpr = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
                    Dim spr As String = ("INSERT INTO InSpiritPayroll VALUES('" & ID1.Text & "' & '-' & '" & ID2.Text & "' & '-' & '" & ID3.Text & "', '" & TxLast.Text & "', '" & TxFirst.Text & "', '" & TxMid.Text & "', '" & TxPos.Text & "', '" & TxDept.Text & "', 75, 0, 10, 0, 0, 0, " & ChGSIS.Checked & ", " & ChSSS.Checked & ", " & ChPhil.Checked & ", " & ChPag.Checked & ", 0, 0)")
                    command = New OleDb.OleDbCommand(spr, cpr)
                    da = New OleDb.OleDbDataAdapter(command)
                    cpr.Open()
                    command.ExecuteNonQuery()
                    cpr.Close()

                    Me.Close()
                End If
            Else
                MessageBox.Show("ID Number has already been registered.", "In Spirit Group of Companies", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please fill in all fields before registering.", "In Spirit Group of Companies", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub LoREG_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TxDate.Text = "MM/DD/YYYY"
        LDate.Text = Date.Today

        TxDept.Items.Add("Executive")
        TxDept.Items.Add("Industrial")
        TxDept.Items.Add("Commercial")
        TxDept.Items.Add("Research")

        ChGSIS.Checked = False
        ChSSS.Checked = False
        ChPhil.Checked = False
        ChPag.Checked = False
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

    Private Sub ID1_GotFocus(sender As Object, e As System.EventArgs) Handles ID1.GotFocus
        ID1.SelectAll()
    End Sub


    Private Sub ID2_GotFocus(sender As Object, e As System.EventArgs) Handles ID2.GotFocus
        ID2.SelectAll()
    End Sub

    Private Sub ID3_GotFocus(sender As Object, e As System.EventArgs) Handles ID3.GotFocus
        ID3.SelectAll()
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
    Private Sub TxDate_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDate.TextChanged
        If ID1.Text.Length = 2 Then
            ID1.AppendText("/")
        End If
        If ID1.Text.Length = 5 Then
            ID1.AppendText("/")
        End If
    End Sub

End Class
