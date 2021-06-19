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
        LockControls()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        Button1.Visible = False
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
        txtId.Text = contact.Id
        DetalhesEnomendas.idEncomenda.Text = txtId.Text
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
            Button1.Visible = True
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



    Sub LockControls()
        txtCodProds.ReadOnly = True
        txtDataEntrega.ReadOnly = True
        txtDataPedido.ReadOnly = True
        txtNifForne.ReadOnly = True
        txtNumFunc.ReadOnly = True
        txtPreco.ReadOnly = True
    End Sub



    Private Sub cancelbtn_Click(sender As Object, e As EventArgs)
        ListBox1.Enabled = True
        If ListBox1.Items.Count > 0 Then
            currentContact = ListBox1.SelectedIndex
            If currentContact < 0 Then currentContact = 0
            ShowEncomendas()
        Else
            LockControls()
        End If
    End Sub

    Private Sub okbtn_Click(sender As Object, e As EventArgs)
        Try
            SaveEncomendas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(txtId.Text)
        ListBox1.SelectedIndex = idx
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
            SubmitContact(contact)
            ListBox1.Items.Add(contact)
        Else
            contact.Id = Label10.Text
            ListBox1.Items(currentContact) = contact
        End If
        Return True
    End Function

    Private Sub SubmitContact(ByVal C As EncomendasC)
        CMD.CommandText = "INSERT proj.Encomenda (data_pedido,data_entrega,preco,produto_codigo,funcionario_n_func,fornecedor_nif) " &
                          "VALUES (@data_pedido, @data_entrega, @preco, @produto_codigo, @funcionario_n_func, @fornecedor_nif) "

        CMD.Parameters.Clear()
        'CMD.Parameters.AddWithValue("@id", C.Id)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DetalhesEnomendas.Show()
        ListBox1.SelectedIndex = -1
        Button1.Visible = False
    End Sub


End Class