Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class Encomendas
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
        CMD.CommandText = "SELECT * FROM proj.Encomenda"
        CN.Open()

        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New EncomendasC
            C.Id = RDR.Item("id")
            C.DataPedido = RDR.Item("data_pedido")
            C.DataEntrega = RDR.Item("data_entrega")
            C.Conta = RDR.Item("preco")
            C.CodProd = RDR.Item("produto_codigo")
            C.nFunct = RDR.Item("funcionario_n_func")
            C.niFornecedor = RDR.Item("fornecedor_nif")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0
    End Sub

    Sub ShowEncomendas()
        If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
        Dim contact As New EncomendasC
        contact = CType(ListBox1.Items.Item(currentContact), EncomendasC)
        txtCodProds.Text = contact.CodProd
        txtDataEntrega.Text = contact.DataEntrega
        txtDataPedido.Text = contact.DataPedido
        txtNifForne.Text = contact.niFornecedor
        txtNumFunc.Text = contact.nFunct
        txtPreco.Text = contact.Conta
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
            ShowEncomendas()
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
        txtCodProds.Text = ""
        txtDataEntrega.Text = ""
        txtDataPedido.Text = ""
        txtNifForne.Text = ""
        txtNumFunc.Text = ""
        txtPreco.Text = ""
    End Sub

    Sub LockControls()
        txtCodProds.Text = True
        txtDataEntrega.Text = True
        txtDataPedido.Text = True
        txtNifForne.Text = True
        txtNumFunc.Text = True
        txtPreco.Text = True
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
            ShowEncomendas()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Private Sub okbtn_Click(sender As Object, e As EventArgs) Handles okbtn.Click
        Try
            SaveEncomendas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(txtId.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Function SaveEncomendas() As Boolean
        Dim contact As New EncomendasC
        Try
            contact.CodProd = txtCodProds.Text
            contact.DataEntrega = txtDataEntrega.Text
            contact.DataPedido = txtDataPedido.Text
            contact.niFornecedor = txtNifForne.Text
            contact.nFunct = txtNumFunc.Text
            contact.Conta = txtPreco.Text
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

    Private Sub SubmitContact(ByVal C As EncomendasC)
        CMD.CommandText = "INSERT proj.Encomenda (data_pedido,data_entrega,preco,produto_codigo,funcionario_n_func,fornecedor_nif) " &
                          "VALUES (@data_pedido, @data_entrega, @preco, @produto_codigo, @funcionario_n_func, @fornecedor_nif) "

        CMD.Parameters.Clear()

        CMD.Parameters.AddWithValue("@data_pedido", C.DataPedido)
        CMD.Parameters.AddWithValue("@data_entrega", C.DataEntrega)
        CMD.Parameters.AddWithValue("@preco", C.Conta)
        CMD.Parameters.AddWithValue("@produto_codigo", C.CodProd)
        CMD.Parameters.AddWithValue("@funcionario_n_func", C.nFunct)
        CMD.Parameters.AddWithValue("@fornecedor_nif", C.niFornecedor)

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

    Private Sub UpdateContact(ByVal C As EncomendasC) 'TODO: ver aqui
        CMD.CommandText = "UPDATE proj.Encomenda " &
            "SET data_pedido = @data_pedido, " &
            "    data_entrega = @data_entrega, " & "   preco = @preco,   " & "   produto_codigo = @produto_codigo,   " & "   funcionario_n_func = @funcionario_n_func,   " & "   funcionario_n_func = @funcionario_n_func   " &
            "WHERE id=@id"
        CMD.Parameters.AddWithValue("@data_pedido", C.DataPedido)
        CMD.Parameters.AddWithValue("@data_entrega", C.DataEntrega)
        CMD.Parameters.AddWithValue("@preco", C.Conta)
        CMD.Parameters.AddWithValue("@produto_codigo", C.CodProd)
        CMD.Parameters.AddWithValue("@funcionario_n_func", C.nFunct)
        CMD.Parameters.AddWithValue("@fornecedor_nif", C.niFornecedor)
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
        CMD.CommandText = "DELETE proj.Encomenda WHERE id=@id "
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
                RemoveContact(CType(ListBox1.SelectedItem, EncomendasC).Id) 'ver aqui
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
                ShowEncomendas()
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
        txtCodProds.Text = False
        txtDataEntrega.Text = False
        txtDataPedido.Text = False
        txtNifForne.Text = False
        txtNumFunc.Text = False
        txtPreco.Text = False
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