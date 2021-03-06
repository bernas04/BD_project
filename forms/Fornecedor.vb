Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class Fornecedor

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
        CMD.CommandText = "SELECT * FROM proj.Fornecedor"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        LockControls()
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New FornecedorC
            C.Nif = RDR.Item("Nif")
            C.Name = RDR.Item("Nome")
            C.Morada = RDR.Item("Morada")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0


    End Sub


    Sub ShowFornecedor()
        If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
        Dim contact As New FornecedorC
        contact = CType(ListBox1.Items.Item(currentContact), FornecedorC)
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
        Dim velhice = New Fornecedor
        Close()
        velhice.Show()
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
        Dim contact As New FornecedorC
        Try
            contact.Name = txtName.Text
            contact.Nif = txtNif.Text
            contact.Morada = txtMorada.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        If adding Then
            submitcontact(contact)
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
        HideButtons()

        txtNif.ReadOnly = True
        txtName.ReadOnly = True
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

    Sub ShowButtons()
        LockControls()
        Addbtn.Visible = True
        editbtn.Visible = True
        okbtn.Visible = False
        cancelbtn.Visible = False
    End Sub

    Sub ClearFields()
        txtNif.Text = ""
        txtMorada.Text = ""
        txtName.Text = ""

    End Sub



    Sub HideButtons()
        UnlockControls()
        Addbtn.Visible = False
        editbtn.Visible = False
        okbtn.Visible = True
        cancelbtn.Visible = True
    End Sub

    Private Sub SubmitContact(ByVal C As FornecedorC)
        CMD.CommandText = "INSERT proj.Fornecedor (NIF,Morada,Nome) " &
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


    Private Sub UpdateContact(ByVal C As FornecedorC)
        CMD.CommandText = "UPDATE proj.Fornecedor " &
            "SET Morada = @Morada, " &
            "    Nome = @Name " &
            "WHERE NIF=@Nif"
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

    'updates
    Private Sub RemoveContact(ByVal Nif As String)
        CMD.CommandText = "DELETE proj.Fornecedor WHERE NIF=@Nif "
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