Imports System.Data.SqlClient

Public Class Clientes
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
        LockControls()
        CMD.CommandText = "SELECT * FROM proj.ClientesEvento()"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New ClientesC
            C.Id = RDR.Item("id")
            C.Nome = RDR.Item("Nome")
            C.Nif = RDR.Item("Nif")
            C.Ntelefone = RDR.Item("N_telefone")
            C.Datanascimento = RDR.Item("Data_nascimento")
            C.Email = RDR.Item("Email")
            C.Genero = RDR.Item("Genero")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0
    End Sub

    Sub ShowClientes()
        If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
        Dim contact As New ClientesC
        contact = CType(ListBox1.Items.Item(currentContact), ClientesC)
        txtName.Text = contact.Nome
        txtNif.Text = contact.Nif
        txtNtelefone.Text = contact.Ntelefone
        txtDataNascimento.Text = contact.Datanascimento
        txtEmail.Text = contact.Email
        txtGenero.Text = contact.Genero
        txtId.Text = contact.Id
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
            ShowClientes()
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F10 Then
            MsgBox("There are " & ListBox1.Items.Count.ToString &
                      " contacts in the database")
            e.Handled = True
        End If
    End Sub

    Sub LockControls()
        txtDataNascimento.ReadOnly = True
        txtEmail.ReadOnly = True
        txtGenero.ReadOnly = True
        txtName.ReadOnly = True
        txtNif.ReadOnly = True
        txtNtelefone.ReadOnly = True
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        ListBox1.Enabled = True
        If ListBox1.Items.Count > 0 Then
            currentContact = ListBox1.SelectedIndex
            If currentContact < 0 Then currentContact = 0
            ShowClientes()
        End If
        LockControls()
        okbtn.Visible = False
        cancelbtn.Visible = False
        editbtn.Visible = True
        ButtonCompra.Visible = True
        ButtonInscreve.Visible = True
    End Sub




    Private Sub okbtn_Click(sender As Object, e As EventArgs) Handles okbtn.Click
        Try
            SaveCliente()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        LockControls()
        Dim idx As Integer = ListBox1.FindString(txtId.Text)
        ListBox1.SelectedIndex = idx
        okbtn.Visible = False
        cancelbtn.Visible = False
        editbtn.Visible = True
        ButtonCompra.Visible = True
        ButtonInscreve.Visible = True
    End Sub

    Private Function SaveCliente() As Boolean
        Dim contact As New ClientesC
        Try
            contact.Id = txtId.Text
            contact.Nome = txtName.Text
            contact.Nif = txtNif.Text
            contact.Ntelefone = txtNtelefone.Text
            contact.Datanascimento = txtDataNascimento.Text
            contact.Email = txtEmail.Text
            contact.Genero = txtGenero.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        If adding Then
            'SubmitContact(contact)
            ListBox1.Items.Add(contact)
        Else

            UpdateContact(contact)
            ListBox1.Items(currentContact) = contact
        End If
        Return True
    End Function

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        currentContact = ListBox1.SelectedIndex
        If currentContact < 0 Then
            MsgBox("Please select a contact to edit")
            Exit Sub
        End If
        adding = False
        ButtonCompra.Visible = False
        ButtonInscreve.Visible = False
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub UpdateContact(ByVal C As ClientesC)

        CMD.CommandText = "proj.add_editCliente"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@NIF", SqlDbType.Char, 9).Value = C.Nif
        CMD.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = C.Ntelefone
        CMD.Parameters.Add("@email", SqlDbType.VarChar, 20).Value = C.Email
        CMD.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = C.Nome
        CMD.Parameters.Add("@data", SqlDbType.Date).Value = C.Datanascimento
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

    Sub HideButtons()
        UnlockControls()
        editbtn.Visible = False
        okbtn.Visible = True
        cancelbtn.Visible = True
    End Sub

    Sub UnlockControls()
        txtEmail.ReadOnly = False
        txtNtelefone.ReadOnly = False
    End Sub

    Private Sub ButtonInscreve_Click(sender As Object, e As EventArgs) Handles ButtonInscreve.Click
        ClienteInscreveEvento.nifCliente.Text = txtNif.Text
        ClienteInscreveEvento.Show()
    End Sub
End Class