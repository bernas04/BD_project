Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class ProdutoPage
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean
    Dim letras As String
    Dim Price As Integer
    Dim bloquear As Boolean
    Private Sub ProdutoPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM proj.Tipo_Prod"
        CN.Open()
        Dim RDR As SqlDataReader

        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New TipoProd_C
            Dim des As String
            des = RDR.Item("descricao").ToString
            If des.Equals("") Then
            Else
                C.Descricao = des
                C.Codigo = RDR.Item("codigo_grupo")
                ListBox1.Items.Add(C)
            End If
        End While
        CN.Close()
        currentContact = 0
        CMD.CommandText = "SELECT * FROM proj.Secçao"
        CN.Open()


        RDR = CMD.ExecuteReader
        ListBox2.Items.Clear()
        While RDR.Read
            Dim C As New SecçaoC
            C.Codigo = RDR.Item("codigo")
            C.ID = RDR.Item("funcionario_num")
            C.Name = RDR.Item("nome")
            ListBox2.Items.Add(C)
        End While
        CN.Close()

        letras = Label9.Text
        If Label9.Text.Equals("") Then
            bloquear = True

            Button2.Visible = False
        Else

            bloquear = False
            editProduto(CN, letras)
            caixaNome.ReadOnly = True
            caixaSeccao.ReadOnly = True
            caixaTipo_Prod.ReadOnly = True
            caixaStock.ReadOnly = True
            Button1.Visible = False

        End If
    End Sub
    Sub editProduto(ByVal CN As SqlConnection, ByVal letra As String)

        Dim querySQL As String = "SELECT * FROM proj.Produto where  codigo=" + letras + ""
        Dim CMD As New SqlCommand(querySQL, CN)
        CN.Open()
        Dim reader As SqlDataReader
        reader = CMD.ExecuteReader

        While reader.Read
            caixaNome.Text = reader.Item("nome")
            caixaDesc.Text = reader.Item("descricao")
            caixaPrec.Text = reader.Item("preco")
            caixaSeccao.Text = reader.Item("secçao_codigo")
            caixaTipo_Prod.Text = reader.Item("tipo_prod_codigo")
            caixaStock.Text = reader.Item("stock")
        End While
        CN.Close()



    End Sub

    Sub criarProduto()
        Try
            addProduto()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 And bloquear Then
            currentContact = ListBox1.SelectedIndex
            If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
            Dim contact As New TipoProd_C
            contact = CType(ListBox1.Items.Item(currentContact), TipoProd_C)
            caixaTipo_Prod.Text = contact.Codigo

        End If
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedIndex > -1 And bloquear Then
            currentContact = ListBox2.SelectedIndex
            If ListBox2.Items.Count = 0 Or currentContact < 0 Then Exit Sub
            Dim contact As New SecçaoC
            contact = CType(ListBox2.Items.Item(currentContact), SecçaoC)
            caixaSeccao.Text = contact.Codigo

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            SaveFornecedor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Close()
        Produto.Close()
        Produto.Show()
    End Sub
    Private Function SaveFornecedor() As Boolean
        Dim contact As New ProdutosC
        Try
            contact.Name = caixaNome.Text
            contact.Descricao = caixaDesc.Text
            contact.Codigo = Label9.Text
            contact.Preco = caixaPrec.Text
            contact.SecCode = caixaSeccao.Text
            contact.Stock = caixaStock.Text
            contact.TipoProduto = caixaTipo_Prod.Text


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        UpdateContact(contact)
        Return True
    End Function

    Private Function addProduto() As Boolean
        Dim contact As New ProdutosC
        Try
            contact.Name = caixaNome.Text
            contact.Descricao = caixaDesc.Text
            contact.Preco = caixaPrec.Text
            contact.SecCode = caixaSeccao.Text
            contact.Stock = caixaStock.Text
            contact.TipoProduto = caixaTipo_Prod.Text


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        SubmitContact(contact)
        Return True
    End Function
    Private Sub UpdateContact(ByVal C As ProdutosC)
        CMD.CommandText = "UPDATE proj.Produto " &
            "SET descricao  = @Morada, " &
            "    preco	 = @Name " &
            "WHERE codigo=@Nif"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@Nif", C.Codigo)
        CMD.Parameters.AddWithValue("@Morada", C.Descricao)
        CMD.Parameters.AddWithValue("@Name", C.Preco)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
            MsgBox("Atulizado com Sucesso")
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub SubmitContact(ByVal C As ProdutosC)
        CMD.CommandText = "INSERT proj.Produto (stock,descricao,nome,preco,secçao_codigo,tipo_prod_codigo) " &
                          "VALUES (@stock, @descricao, @nome,@preco,@sec,@tipo) "

        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@stock", C.Stock)
        CMD.Parameters.AddWithValue("@descricao", C.Descricao)
        CMD.Parameters.AddWithValue("@nome", C.Name)
        CMD.Parameters.AddWithValue("@preco", C.Preco)
        CMD.Parameters.AddWithValue("@sec", C.SecCode)
        CMD.Parameters.AddWithValue("@tipo", C.TipoProduto)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
            MsgBox("ADICIONADO  com Sucesso")
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        criarProduto()
        Close()
        Produto.Close()
        Produto.Show()
    End Sub
End Class