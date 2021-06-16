Imports System.Data.SqlClient
Public Class NaoClientesvb
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean

    Private Sub Fornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM proj.N_ClientesEvento" & "(" & ")"
        CN.Open()
        Button1.Visible = False
        Button2.Visible = False
        txtNif.ReadOnly = True
        txtName.ReadOnly = True
        txtEmail.ReadOnly = True
        txtTelefone.ReadOnly = True
        txtGenero.ReadOnly = True
        '  DateTimePicker1.Enabled = False
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New NaoClientesC
            C.Nif = RDR.Item("Nif")
            C.Name = RDR.Item("Nome")
            C.Data = RDR.Item("Data_nascimento")

            C.Email = RDR.Item("Email")
            C.Genero = RDR.Item("Genero")
            C.Telefone = RDR.Item("N_telefone")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0


    End Sub


    Sub ShowFornecedor()
        If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
        Dim contact As New NaoClientesC
        contact = CType(ListBox1.Items.Item(currentContact), NaoClientesC)
        txtName.Text = contact.Name
        txtNif.Text = contact.Nif
        txtTelefone.Text = contact.Telefone
        txtGenero.Text = contact.Genero
        txtEmail.Text = contact.Email
        DateTimePicker1.Text = contact.Data
        NClienteInscreveEvento.txtNifnCliente.Text = txtNif.Text
    End Sub
    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelbtn.Click
        ListBox1.Enabled = True
        Button1.Visible = True
        Button2.Visible = True
        If ListBox1.Items.Count > 0 Then
            currentContact = ListBox1.SelectedIndex
            If currentContact < 0 Then currentContact = 0
            ShowFornecedor()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Private Sub bttnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okbtn.Click
        Try
            Button1.Visible = True
            Button2.Visible = True
            SaveFornecedor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(txtNif.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub



    Private Sub bttnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Addbtn.Click
        Button1.Visible = False
        Button2.Visible = False
        adding = True
        ClearFields()
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F10 Then
            MsgBox("There are " & ListBox1.Items.Count.ToString &
                      " contacts in the database")
            e.Handled = True
        End If
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        ' If we're not in EDIT mode, reject keystrokes
        If Not okbtn.Visible Then
            e.Handled = True
        End If
    End Sub

    Private Function SaveFornecedor() As Boolean
        Dim contact As New NaoClientesC
        Try
            contact.Name = txtName.Text
            contact.Nif = txtNif.Text
            contact.Telefone = txtTelefone.Text
            contact.Data = DateTimePicker1.Text
            contact.Email = txtEmail.Text
            contact.Genero = txtGenero.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        If adding Then
            SubmitContact(contact)
            ListBox1.Items.Add(contact)
        Else
            UpdateContact(contact)
            ListBox1.Items(currentContact) = contact
        End If
        Return True
    End Function

    Private Sub bttnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editbtn.Click
        currentContact = ListBox1.SelectedIndex
        If currentContact < 0 Then
            MsgBox("Please select a contact to edit")
            Exit Sub
        End If
        Button1.Visible = False
        Button2.Visible = False
        adding = False
        HideButtonsEdit()
        ListBox1.Enabled = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex

            DateTimePicker1.Enabled = True
            ShowFornecedor()
        End If
        Button1.Visible = True
        Button2.Visible = True
    End Sub

    ' Helper routines
    Sub LockControls()
        txtNif.ReadOnly = True
        txtName.ReadOnly = True
        txtEmail.ReadOnly = True
        txtGenero.ReadOnly = True
        txtTelefone.ReadOnly = True
        DateTimePicker1.Enabled = False

    End Sub

    Sub UnlockControls()
        txtEmail.ReadOnly = False
        txtName.ReadOnly = False
        txtNif.ReadOnly = False
        txtGenero.ReadOnly = False
        txtTelefone.ReadOnly = False
        DateTimePicker1.Enabled = True

    End Sub
    Sub LockControlsEdit()
        txtEmail.ReadOnly = False
        txtName.ReadOnly = True
        txtNif.ReadOnly = True
        txtGenero.ReadOnly = True
        txtTelefone.ReadOnly = False
        DateTimePicker1.Enabled = True
    End Sub

    Sub ShowButtons()
        LockControls()
        Addbtn.Visible = True
        editbtn.Visible = True
        okbtn.Visible = False
        cancelbtn.Visible = False
    End Sub

    Sub ClearFields()
        txtNif.Text = ""
        txtEmail.Text = ""
        txtName.Text = ""
        txtTelefone.Text = ""
        txtGenero.Text = ""
        DateTimePicker1.ResetText()
    End Sub
    Sub HideButtonsEdit()
        LockControlsEdit()
        Addbtn.Visible = False
        editbtn.Visible = False
        okbtn.Visible = True
        cancelbtn.Visible = True
    End Sub


    Sub HideButtons()
        UnlockControls()
        Addbtn.Visible = False
        editbtn.Visible = False
        okbtn.Visible = True
        cancelbtn.Visible = True
    End Sub

    Private Sub SubmitContact(ByVal C As NaoClientesC)
        CMD.CommandText = "proj.add_editN_Cliente"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@NIF", SqlDbType.Char, 9).Value = C.Nif
        CMD.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = C.Telefone
        CMD.Parameters.Add("@email", SqlDbType.VarChar, 20).Value = C.Email
        CMD.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = C.Name
        CMD.Parameters.Add("@data", SqlDbType.Date).Value = C.Data
        CMD.Parameters.Add("@genero", SqlDbType.Char, 1).Value = C.Genero
        CMD.Parameters.Add("@edit", SqlDbType.Bit).Value = 0
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub


    Private Sub UpdateContact(ByVal C As NaoClientesC)

        'CMD.CommandText = " exec proj.add_editN_Cliente @Nif, @telefone,@email,@name, @data,@genero,@edit"
        CMD.CommandText = "proj.add_editN_Cliente"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@NIF", SqlDbType.Char, 9).Value = C.Nif
        CMD.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = C.Telefone
        CMD.Parameters.Add("@email", SqlDbType.VarChar, 20).Value = C.Email
        CMD.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = C.Name

        CMD.Parameters.Add("@data", SqlDbType.Date).Value = C.Data
        CMD.Parameters.Add("@genero", SqlDbType.Char, 1).Value = C.Genero
        CMD.Parameters.Add("@edit", SqlDbType.Bit).Value = 1

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NClienteInscreveEvento.Show()
    End Sub

End Class