Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class ProdutoPage
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean
    Dim letras As String
    Dim Price As Integer
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

        letras = Label9.Text
        If Label9.Text.Equals("") Then
            criarProduto()

        Else


            editProduto(CN, letras)


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


    End Sub
End Class