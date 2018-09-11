Public Class MReg
    Dim ctr As Integer
    Dim countrow As Integer
    Dim ds, dss As DataSet
    Dim sd As OleDb.OleDbDataReader
    Dim da As New OleDb.OleDbDataAdapter
    Dim cnn, cpr As New OleDb.OleDbConnection
    Dim command As New OleDb.OleDbCommand

    Private Sub MReg_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ChGSIS.Checked = False
        ChSSS.Checked = False
        ChPhil.Checked = False
        ChPag.Checked = False
        TxDept.DropDownStyle = ComboBoxStyle.Simple
        TxPos.DropDownStyle = ComboBoxStyle.Simple

        TxDept.Items.Add("Executive")
        TxDept.Items.Add("Industrial")
        TxDept.Items.Add("Commercial")
        TxDept.Items.Add("Research")

        enabledfalse()
        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

        Dim str As String = ("SELECT * FROM InSpiritRecord ORDER BY ID")
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
        ChGSIS.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(0)
        ChSSS.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(1)
        ChPhil.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(2)
        ChPag.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(3)
        countrow = dss.Tables("ProjectIIITLE").Rows.Count
        cnn.Close()

        RdFem.Visible = False
        RdMale.Visible = False
        RdOther.Visible = False
        TxGender.Visible = True
    End Sub

    Private Sub bAdd_Click(sender As System.Object, e As System.EventArgs) Handles bAdd.Click
        If bAdd.Text = "ADD" Then
            bAdd.Text = "SAV"
            enabledtrue()
            clear()
            bDelete.Enabled = False
            bEdit.Enabled = False
            bRef.Enabled = False
            textblack()
            bExit.Text = "Cancel"
            TxDept.DropDownStyle = ComboBoxStyle.DropDownList
            TxPos.DropDownStyle = ComboBoxStyle.DropDownList
            clear()
            RdFem.Visible = True
            RdMale.Visible = True
            RdOther.Visible = True
            TxGender.Visible = False
        Else
            If ID1.Text.Length > 0 And ID2.Text.Length > 0 And ID3.Text.Length > 0 And TxMail.Text.Length > 0 And TxPass.Text.Length > 0 And TxLast.Text.Length > 0 And TxFirst.Text.Length > 0 And TxMid.Text.Length > 0 And TxAddr.Text.Length > 0 And TxCont.Text.Length > 0 And TxDate.Text.Length > 0 And IsDate(TxDate.Text) = True And (RdMale.Checked = True Or RdFem.Checked = True Or RdOther.Checked = True) Then
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
                sd = command.ExecuteReader()
                If Not sd.HasRows Then
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
                    End If

                    textgray()
                    bAdd.Text = "ADD"
                    enabledfalse()
                    bEdit.Enabled = True
                    bDelete.Enabled = True
                    TxDept.DropDownStyle = ComboBoxStyle.Simple
                    TxPos.DropDownStyle = ComboBoxStyle.Simple
                    bRef.Enabled = True
                    bExit.Text = "Close"
                Else
                    MessageBox.Show("ID Number has already been registered.", "In Spirit Group of Companies", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Do not leave any forms blank.", "In Spirit Group of Companies", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub bExit_Click(sender As System.Object, e As System.EventArgs) Handles bExit.Click
        If bExit.Text = "Close" Then
            Dim bAlert = MessageBox.Show("Are you sure?", "In Spirit Network", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bAlert = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        Else
            Dim bSure = MessageBox.Show("Are you sure?", "In Spirit Network", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bSure = Windows.Forms.DialogResult.Yes Then

                clear()

                cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

                Dim str As String = ("SELECT * FROM InSpiritRecord ORDER BY ID")
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
                ChGSIS.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(0)
                ChSSS.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(1)
                ChPhil.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(2)
                ChPag.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(3)
                countrow = dss.Tables("ProjectIIITLE").Rows.Count
                cnn.Close()

                textgray()
                enabledfalse()
                bAdd.Text = "ADD"
                bExit.Text = "Close"
                bEdit.Text = "EDT"
                TxDept.DropDownStyle = ComboBoxStyle.Simple
                TxPos.DropDownStyle = ComboBoxStyle.Simple
                bAdd.Enabled = True
                bDelete.Enabled = True
                bEdit.Enabled = True
                bRef.Enabled = True
                RdFem.Visible = False
                RdMale.Visible = False
                RdOther.Visible = False
                TxGender.Visible = True
            End If
        End If
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

    Private Sub bOut_Click(sender As System.Object, e As System.EventArgs) Handles bOut.Click
        Dim bAlert = MessageBox.Show("Are you sure?", "In Spirit Network", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If bAlert = Windows.Forms.DialogResult.Yes Then

            PerInfo.Close()
            MainPage.Close()
            Me.Hide()

        End If
    End Sub

    Private Sub bEdit_Click(sender As System.Object, e As System.EventArgs) Handles bEdit.Click
        If bEdit.Text = "EDT" Then
            bEdit.Text = "UPD"
            bAdd.Enabled = False
            bDelete.Enabled = False
            bRef.Enabled = False
            bExit.Text = "Cancel"
            enabledtrue()
            bNext.Enabled = True
            bFirst.Enabled = True
            bLast.Enabled = True
            bPrev.Enabled = True
            textblack()
            RdFem.Visible = True
            RdMale.Visible = True
            RdOther.Visible = True
            TxGender.Visible = False
            If TxGender.Text = "Male" Then
                RdMale.Checked = True
            ElseIf TxGender.Text = "Female" Then
                RdFem.Checked = True
            ElseIf TxGender.Text = "Other" Then
                RdOther.Checked = True
            End If

            TxDept.DropDownStyle = ComboBoxStyle.DropDownList
            TxPos.DropDownStyle = ComboBoxStyle.DropDownList
            ID1.Enabled = False
            ID2.Enabled = False
            ID3.Enabled = False
            TxLast.Enabled = False
            TxFirst.Enabled = False
            TxMid.Enabled = False
        Else
            If ID1.Text.Length > 0 And ID2.Text.Length > 0 And ID3.Text.Length > 0 And TxMail.Text.Length > 0 And TxPass.Text.Length > 0 And TxLast.Text.Length > 0 And TxFirst.Text.Length > 0 And TxMid.Text.Length > 0 And TxAddr.Text.Length > 0 And TxCont.Text.Length > 0 And TxDate.Text.Length > 0 And IsDate(TxDate.Text) = True And (Not (TxDate.Text = "MM/DD/YYYY" And TxPos.SelectedItem = "" And TxDept.SelectedItem = "")) And (RdMale.Checked = True Or RdFem.Checked = True Or RdOther.Checked = True) Then
                Dim edi = MessageBox.Show("Done?", "InSpirit Network", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If edi = Windows.Forms.DialogResult.Yes Then
                    If RdMale.Checked = True Then
                        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
                        Dim str As String = ("UPDATE InSpiritRecord SET seMail = '" & TxMail.Text & "', sPassword = '" & TxPass.Text & "', sLast = '" & TxLast.Text & "', sFirst = '" & TxFirst.Text & "', sMid = '" & TxMid.Text & "', sSex = 'Male', sAddress = '" & TxAddr.Text & "', sPosition = '" & TxPos.Text & "', sDepartment = '" & TxDept.Text & "', sBirthdate = '" & TxDate.Text & "', sContact = '" & TxCont.Text & "' WHERE ID = '" & ID1.Text & "' & '-' & '" & ID2.Text & "' & '-' & '" & ID3.Text & "'")
                        command = New OleDb.OleDbCommand(str, cnn)
                        da = New OleDb.OleDbDataAdapter(command)
                        cnn.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Data updated!", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cnn.Close()
                    ElseIf RdFem.Checked = True Then
                        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
                        Dim str As String = ("UPDATE InSpiritRecord SET seMail = '" & TxMail.Text & "', sPassword = '" & TxPass.Text & "', sLast = '" & TxLast.Text & "', sFirst = '" & TxFirst.Text & "', sMid = '" & TxMid.Text & "', sSex = 'Female', sAddress = '" & TxAddr.Text & "', sPosition = '" & TxPos.Text & "', sDepartment = '" & TxDept.Text & "', sBirthdate = '" & TxDate.Text & "', sContact = '" & TxCont.Text & "' WHERE ID = '" & ID1.Text & "' & '-' & '" & ID2.Text & "' & '-' & '" & ID3.Text & "'")
                        command = New OleDb.OleDbCommand(str, cnn)
                        da = New OleDb.OleDbDataAdapter(command)
                        cnn.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Data updated!", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cnn.Close()
                    ElseIf RdOther.Checked = True Then
                        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
                        Dim str As String = ("UPDATE InSpiritRecord SET seMail = '" & TxMail.Text & "', sPassword = '" & TxPass.Text & "', sLast = '" & TxLast.Text & "', sFirst = '" & TxFirst.Text & "', sMid = '" & TxMid.Text & "', sSex = 'Other', sAddress = '" & TxAddr.Text & "', sPosition = '" & TxPos.Text & "', sDepartment = '" & TxDept.Text & "', sBirthdate = '" & TxDate.Text & "', sContact = '" & TxCont.Text & "' WHERE ID = '" & ID1.Text & "' & '-' & '" & ID2.Text & "' & '-' & '" & ID3.Text & "'")
                        command = New OleDb.OleDbCommand(str, cnn)
                        da = New OleDb.OleDbDataAdapter(command)
                        cnn.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Data updated!", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cnn.Close()
                    End If

                    'Payroll'
                    cpr = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
                    Dim spr As String = ("UPDATE InSpiritPayroll SET sPosition = '" & TxPos.Text & "', sDepartment = '" & TxDept.Text & "', GSIS = " & ChGSIS.Checked & ", SSS = " & ChSSS.Checked & ", PhilHealth = " & ChPhil.Checked & ", PAGIBIG = " & ChPag.Checked & " WHERE ID = '" & ID1.Text & "' & '-' & '" & ID2.Text & "' & '-' & '" & ID3.Text & "'")
                    command = New OleDb.OleDbCommand(spr, cpr)
                    da = New OleDb.OleDbDataAdapter(command)
                    cpr.Open()
                    command.ExecuteNonQuery()
                    cpr.Close()

                    textgray()
                    TxDept.DropDownStyle = ComboBoxStyle.Simple
                    TxPos.DropDownStyle = ComboBoxStyle.Simple
                    bEdit.Text = "EDT"
                    enabledfalse()
                    TxGender.Visible = True
                    bAdd.Enabled = True
                    bDelete.Enabled = True
                    bRef.Enabled = True
                    bExit.Text = "Close"
                End If
            Else
                MessageBox.Show("Do not leave any forms blank.", "In Spirit Group of Companies", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub enabledtrue()
        ID1.Enabled = True
        ID2.Enabled = True
        ID3.Enabled = True
        TxMail.Enabled = True
        TxPass.Enabled = True
        TxLast.Enabled = True
        TxFirst.Enabled = True
        TxMid.Enabled = True
        TxAddr.Enabled = True
        RdFem.Enabled = True
        RdMale.Enabled = True
        RdOther.Enabled = True
        RdFem.Checked = False
        RdMale.Checked = False
        RdOther.Checked = False
        TxPos.Enabled = True
        TxDept.Enabled = True
        TxDate.Enabled = True
        TxCont.Enabled = True
        ChGSIS.Enabled = True
        ChSSS.Enabled = True
        ChPhil.Enabled = True
        ChPag.Enabled = True
        bFirst.Enabled = False
        bLast.Enabled = False
        bPrev.Enabled = False
        bNext.Enabled = False
    End Sub

    Private Sub clear()
        ID1.Text = ""
        ID2.Text = ""
        ID3.Text = ""
        TxMail.Text = ""
        TxPass.Text = ""
        TxLast.Text = ""
        TxFirst.Text = ""
        TxMid.Text = ""
        TxAddr.Text = ""
        RdFem.Checked = False
        RdMale.Checked = False
        RdOther.Checked = False
        TxPos.SelectedText = ""
        TxDept.SelectedText = ""
        TxDate.Text = "MM/DD/YYYY"
        TxCont.Text = ""
        ChGSIS.Checked = False
        ChSSS.Checked = False
        ChPhil.Checked = False
        ChPag.Checked = False
    End Sub

    Private Sub enabledfalse()

        ID1.Enabled = False
        ID2.Enabled = False
        ID3.Enabled = False
        TxMail.Enabled = False
        TxPass.Enabled = False
        TxLast.Enabled = False
        TxFirst.Enabled = False
        TxMid.Enabled = False
        TxAddr.Enabled = False
        TxGender.Visible = True
        TxGender.Enabled = False
        RdFem.Enabled = False
        RdMale.Enabled = False
        RdOther.Enabled = False
        TxPos.Enabled = False
        TxDept.Enabled = False
        TxDate.Enabled = False
        TxCont.Enabled = False
        ChGSIS.Enabled = False
        ChSSS.Enabled = False
        ChPhil.Enabled = False
        ChPag.Enabled = False
        bFirst.Enabled = True
        bLast.Enabled = True
        bPrev.Enabled = True
        bNext.Enabled = True
    End Sub

    Private Sub textblack()
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
        Label6.ForeColor = Color.Black
        Label7.ForeColor = Color.Black
        Label8.ForeColor = Color.Black
        Label9.ForeColor = Color.Black
        Label10.ForeColor = Color.Black
        Label11.ForeColor = Color.Black
        Label12.ForeColor = Color.Black
    End Sub

    Private Sub textgray()
        Label1.ForeColor = Color.Gray
        Label2.ForeColor = Color.Gray
        Label3.ForeColor = Color.Gray
        Label4.ForeColor = Color.Gray
        Label5.ForeColor = Color.Gray
        Label6.ForeColor = Color.Gray
        Label7.ForeColor = Color.Gray
        Label8.ForeColor = Color.Gray
        Label9.ForeColor = Color.Gray
        Label10.ForeColor = Color.Gray
        Label11.ForeColor = Color.Gray
        Label12.ForeColor = Color.Gray
    End Sub

    Private Sub showrecord()
        ID1.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(0).ToString(0) + ds.Tables("ProjectIIITLE").Rows(ctr).Item(0).ToString(1) + ds.Tables("ProjectIIITLE").Rows(ctr).Item(0).ToString(2)
        ID2.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(0).ToString(4) + ds.Tables("ProjectIIITLE").Rows(ctr).Item(0).ToString(5) + ds.Tables("ProjectIIITLE").Rows(ctr).Item(0).ToString(6)
        ID3.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(0).ToString(8) + ds.Tables("ProjectIIITLE").Rows(ctr).Item(0).ToString(9) + ds.Tables("ProjectIIITLE").Rows(ctr).Item(0).ToString(10)
        TxLast.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(1)
        TxFirst.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(2)
        TxMid.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(3)
        TxMail.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(4)
        TxPass.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(5)
        TxGender.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(6)
        TxAddr.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(7)
        TxPos.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(8)
        TxDept.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(9)
        TxDate.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(10)
        TxCont.Text = ds.Tables("ProjectIIITLE").Rows(ctr).Item(11)

    End Sub

    Private Sub bRef_Click(sender As System.Object, e As System.EventArgs) Handles bRef.Click
        ChGSIS.Checked = False
        ChSSS.Checked = False
        ChPhil.Checked = False
        ChPag.Checked = False
        enabledfalse()
        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

        Dim str As String = ("SELECT * FROM InSpiritRecord ORDER BY ID")
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
        ChGSIS.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(0)
        ChSSS.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(1)
        ChPhil.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(2)
        ChPag.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(3)
        countrow = dss.Tables("ProjectIIITLE").Rows.Count
        cnn.Close()

    End Sub

    Private Sub bDelete_Click(sender As System.Object, e As System.EventArgs) Handles bDelete.Click
        Dim remv = MessageBox.Show("Are you sure?", "InSpirit Network", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If remv = Windows.Forms.DialogResult.Yes Then
            If ID1.Text & "-" & ID2.Text & "-" & ID3.Text = MainPage.LbID.Text Then
                MessageBox.Show("Profile is currently open. Please close the window before deleting.", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Main Record'
                cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")

                Dim str As String = ("DELETE  FROM InSpiritRecord WHERE ID = '" & ID1.Text & "' & '-' & '" & ID2.Text & "' & '-' & '" & ID3.Text & "'")
                command = New OleDb.OleDbCommand(str, cnn)
                da = New OleDb.OleDbDataAdapter(command)
                cnn.Open()
                command.ExecuteNonQuery()
                Dim rimv = MessageBox.Show("The data has been deleted!", "InSpirit Network", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cnn.Close()

                'Payroll'
                cpr = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
                Dim spr As String = ("DELETE  FROM InSpiritPayroll WHERE ID = '" & ID1.Text & "' & '-' & '" & ID2.Text & "' & '-' & '" & ID3.Text & "'")
                command = New OleDb.OleDbCommand(spr, cnn)
                da = New OleDb.OleDbDataAdapter(command)
                cnn.Open()
                command.ExecuteNonQuery()
                cnn.Close()

                If rimv = Windows.Forms.DialogResult.OK Then
                    ChGSIS.Checked = False
                    ChSSS.Checked = False
                    ChPhil.Checked = False
                    ChPag.Checked = False

                    Dim stri As String = ("SELECT * FROM InSpiritRecord ORDER BY ID")
                    command = New OleDb.OleDbCommand(stri, cnn)
                    da = New OleDb.OleDbDataAdapter(command)
                    ds = New DataSet
                    cnn.Open()
                    da.Fill(ds, "ProjectIIITLE")
                    If ctr = 0 Then
                        ctr = ctr + 1
                    Else
                        ctr = ctr - 1
                    End If
                    countrow = ds.Tables("ProjectIIITLE").Rows.Count
                    showrecord()

                    cnn.Close()

                    Dim ssr As String = ("SELECT GSIS, SSS, PhilHealth, PAGIBIG FROM InSpiritPayroll ORDER BY ID")
                    command = New OleDb.OleDbCommand(ssr, cnn)
                    da = New OleDb.OleDbDataAdapter(command)
                    dss = New DataSet
                    cnn.Open()
                    da.Fill(dss, "ProjectIIITLE")
                    ctr = countrow - 1
                    ChGSIS.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(0)
                    ChSSS.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(1)
                    ChPhil.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(2)
                    ChPag.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(3)
                    countrow = dss.Tables("ProjectIIITLE").Rows.Count
                    cnn.Close()
                End If
            End If
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
    Private Sub buttoncode()
        ChGSIS.Checked = False
        ChSSS.Checked = False
        ChPhil.Checked = False
        ChPag.Checked = False
        cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectIIITLE.accdb")
        Dim str As String = ("SELECT * FROM InSpiritRecord ORDER BY ID")
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
        ChGSIS.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(0)
        ChSSS.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(1)
        ChPhil.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(2)
        ChPag.Checked = dss.Tables("ProjectIIITLE").Rows(ctr).Item(3)
        countrow = dss.Tables("ProjectIIITLE").Rows.Count
        cnn.Close()

        If TxGender.Text = "Male" Then
            RdMale.Checked = True
        ElseIf TxGender.Text = "Female" Then
            RdFem.Checked = True
        ElseIf TxGender.Text = "Other" Then
            RdOther.Checked = True
        End If
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

    Private Sub bAdd_MouseEnter(sender As Object, e As System.EventArgs) Handles bAdd.MouseEnter
        stat.Text = "Add new record to database."
    End Sub

    Private Sub bEdit_MouseEnter(sender As Object, e As System.EventArgs) Handles bEdit.MouseEnter
        stat.Text = "Edit existing records."
    End Sub

    Private Sub bRef_MouseEnter(sender As Object, e As System.EventArgs) Handles bRef.MouseEnter
        stat.Text = "Refresh all existing records."
    End Sub

    Private Sub bDelete_MouseEnter(sender As Object, e As System.EventArgs) Handles bDelete.MouseEnter
        stat.Text = "Delete current record."
    End Sub

    Private Sub bExit_MouseEnter(sender As Object, e As System.EventArgs) Handles bExit.MouseEnter
        stat.Text = "Close the registry."
    End Sub

    Private Sub bOut_MouseEnter(sender As Object, e As System.EventArgs) Handles bOut.MouseEnter
        stat.Text = "Log out of the system and return to the login page."
    End Sub

    Private Sub MReg_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        stat.Text = "In Spirit™ Group of Companies®. In one, In spirit. 2014"
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

    Private Sub ID1_GotFocus(sender As Object, e As System.EventArgs) Handles ID1.GotFocus
        ID1.SelectAll()
    End Sub


    Private Sub ID2_GotFocus(sender As Object, e As System.EventArgs) Handles ID2.GotFocus
        ID2.SelectAll()
    End Sub

    Private Sub ID3_GotFocus(sender As Object, e As System.EventArgs) Handles ID3.GotFocus
        ID3.SelectAll()
    End Sub

    Private Sub TxPass_GotFocus(sender As Object, e As System.EventArgs) Handles TxPass.GotFocus
        TxPass.UseSystemPasswordChar = False
    End Sub

    Private Sub TxPass_LostFocus(sender As Object, e As System.EventArgs) Handles TxPass.LostFocus
        TxPass.UseSystemPasswordChar = True
    End Sub

    Private Sub TxPass_MouseEnter(sender As Object, e As System.EventArgs) Handles TxPass.MouseEnter, Label6.MouseEnter

        TxPass.UseSystemPasswordChar = False

    End Sub

    Private Sub TxPass_MouseLeave(sender As Object, e As System.EventArgs) Handles TxPass.MouseLeave, Label6.MouseLeave
        TxPass.UseSystemPasswordChar = True
    End Sub
End Class