Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class Compras
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean

    Private Sub Eventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM proj.Compra"
        CN.Open()

        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New ComprasC
            C.ClienteId = RDR.Item("id")
            C.Data = RDR.Item("datas")
            C.Total = RDR.Item("preco")
            C.Id = RDR.Item("id")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0
    End Sub

    Sub ShowCompras()
        If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
        Dim contact As New ComprasC
        contact = CType(ListBox1.Items.Item(currentContact), ComprasC)
        txtData.Text = contact.Data
        txtTotal.Text = contact.Total
        txtId.Text = contact.ClienteId
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
            ShowCompras()
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F10 Then
            MsgBox("There are " & ListBox1.Items.Count.ToString &
                      " contacts in the database")
            e.Handled = True
        End If
    End Sub

    Sub ClearFields()
        txtData.Text = ""
        txtId.Text = ""
        txtTotal.Text = ""
        txtId1.Text = ""
    End Sub

    Sub LockControls()
        txtData.Text = True
        txtId.Text = True
        txtTotal.Text = True
        txtId1.Text = True
    End Sub

    Sub ShowButtons()
        LockControls()
        Addbtn.Visible = True
        delbtn.Visible = True
        editbtn.Visible = True
        okbtn.Visible = False
        cancelbtn.Visible = False
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        ListBox1.Enabled = True
        If ListBox1.Items.Count > 0 Then
            currentContact = ListBox1.SelectedIndex
            If currentContact < 0 Then currentContact = 0
            ShowCompras()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Private Sub okbtn_Click(sender As Object, e As EventArgs) Handles okbtn.Click
        Try
            SaveCompras()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(txtId1.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Function SaveCompras() As Boolean
        Dim contact As New ComprasC
        Try
            contact.Data = txtData.Text
            contact.ClienteId = txtId.Text
            contact.Id = txtId1.Text
            contact.Total = txtTotal.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        If adding Then
            submitcontact(contact)
            ListBox1.Items.Add(contact)
        Else
            contact.Id = Label10.Text
            UpdateContact(contact)
            ListBox1.Items(currentContact) = contact
        End If
        Return True
    End Function

    Private Sub SubmitContact(ByVal C As ComprasC)
        CMD.CommandText = "INSERT proj.Compra (preco,clientes_id,datas) " &
                          "VALUES (@preco, @cliente_id, @datas) "

        CMD.Parameters.Clear()
        'CMD.Parameters.AddWithValue("@id", C.Id)
        CMD.Parameters.AddWithValue("@cliente_id", C.ClienteId)
        CMD.Parameters.AddWithValue("@datas", C.Data)
        CMD.Parameters.AddWithValue("@preco", C.Total)

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

    Private Sub UpdateContact(ByVal C As ComprasC) 'TODO: ver aqui
        CMD.CommandText = "UPDATE proj.Evento " &
            "SET Morada = @Morada, " &
            "    Nome = @Name " &
            "WHERE id=@id"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@cliente_id", C.ClienteId)
        CMD.Parameters.AddWithValue("@datas", C.Data)
        CMD.Parameters.AddWithValue("@preco", C.Total)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub RemoveContact(ByVal Id As String)
        CMD.CommandText = "DELETE proj.Evento WHERE id=@id "
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@id", Id) 'ver esta situação'
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to delete contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        If ListBox1.SelectedIndex > -1 Then
            Try
                RemoveContact(CType(ListBox1.SelectedItem, EventosC).Id) 'ver aqui
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
                ShowCompras()
            End If
        End If
    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        adding = True
        ClearFields()
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Sub HideButtons()
        UnlockControls()
        Addbtn.Visible = False
        delbtn.Visible = False
        editbtn.Visible = False
        okbtn.Visible = True
        cancelbtn.Visible = True
    End Sub

    Sub UnlockControls()
        'txtData.ReadOnly = False
        txtTotal.ReadOnly = False
        txtId.ReadOnly = False
        txtData.ReadOnly = False
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        currentContact = ListBox1.SelectedIndex
        If currentContact < 0 Then
            MsgBox("Please select a contact to edit")
            Exit Sub
        End If
        adding = False
        HideButtons()
        ListBox1.Enabled = False
    End Sub


End Class