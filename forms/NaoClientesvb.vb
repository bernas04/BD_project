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
        CMD.CommandText = "SELECT * FROM proj.N_cliente"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New NaoClientesC
            C.Nif = RDR.Item("pessoa_NIF")
            C.Name = RDR.Item("nome")
            C.Morada = RDR.Item("morada")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0


    End Sub


    Sub ShowFornecedor()
        If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
        Dim contact As New NaoClientesC
        contact = CType(ListBox1.Items.Item(currentContact), NaoClientesC)
        txtMorada.Text = contact.Morada
        txtName.Text = contact.Name
        txtNif.Text = contact.Nif

    End Sub
    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelbtn.Click
        ListBox1.Enabled = True
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
            SaveFornecedor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(txtNif.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub bttnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delbtn.Click
        If ListBox1.SelectedIndex > -1 Then
            Try
                RemoveContact(CType(ListBox1.SelectedItem, NaoClientesC).Nif)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            If currentContact = ListBox1.Items.Count Then currentContact = ListBox1.Items.Count - 1
            If currentContact = -1 Then
                ClearFields()
                MsgBox("There are no more contacts")
            Else
                ShowFornecedor()
            End If
        End If
    End Sub

    Private Sub bttnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Addbtn.Click
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
            contact.Morada = txtMorada.Text
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
        adding = False
        HideButtonsEdit()
        ListBox1.Enabled = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
            ShowFornecedor()
        End If
    End Sub

    ' Helper routines
    Sub LockControls()
        txtNif.ReadOnly = True
        txtName.ReadOnly = True
        txtMorada.ReadOnly = True

    End Sub

    Sub UnlockControls()
        txtMorada.ReadOnly = False
        txtName.ReadOnly = False
        txtNif.ReadOnly = False

    End Sub
    Sub LockControlsEdit()
        txtMorada.ReadOnly = False
        txtName.ReadOnly = True
        txtNif.ReadOnly = True

    End Sub

    Sub ShowButtons()
        LockControls()
        Addbtn.Visible = True
        delbtn.Visible = True
        editbtn.Visible = True
        okbtn.Visible = False
        cancelbtn.Visible = False
    End Sub

    Sub ClearFields()
        txtNif.Text = ""
        txtMorada.Text = ""
        txtName.Text = ""

    End Sub
    Sub HideButtonsEdit()
        LockControlsEdit()
        Addbtn.Visible = False
        delbtn.Visible = False
        editbtn.Visible = False
        okbtn.Visible = True
        cancelbtn.Visible = True
    End Sub


    Sub HideButtons()
        UnlockControls()
        Addbtn.Visible = False
        delbtn.Visible = False
        editbtn.Visible = False
        okbtn.Visible = True
        cancelbtn.Visible = True
    End Sub

    Private Sub SubmitContact(ByVal C As NaoClientesC)
        CMD.CommandText = "INSERT proj.N_cliente(pessoa_NIF  ,Morada,Nome) " &
                          "VALUES (@Nif, @Morada, @Name) "

        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@Nif", C.Nif)
        CMD.Parameters.AddWithValue("@Morada", C.Morada)
        CMD.Parameters.AddWithValue("@Name", C.Name)

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
        CMD.CommandText = "UPDATE proj.N_cliente " &
            "SET Morada = @Morada, " &
            "    Nome = @Name " &
            "WHERE pessoa_NIF =@Nif"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@Nif", C.Nif)
        CMD.Parameters.AddWithValue("@Morada", C.Morada)
        CMD.Parameters.AddWithValue("@Name", C.Name)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub


    Private Sub RemoveContact(ByVal Nif As String)
        CMD.CommandText = "DELETE proj.N_cliente WHERE pessoa_NIF =@Nif "
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@Nif", Nif)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to delete contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub


End Class