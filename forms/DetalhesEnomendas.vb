Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class DetalhesEnomendas

    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean

    Private Sub DetalhesEnomendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = "select * from proj.DetalhesEncomendas(" & idEncomenda.Text & ")"

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New DetalhesEncomendaC
            C.IdEncomenda = RDR.Item("Id_Encomenda")
            C.nomeProduto = RDR.Item("nome_produto")
            C.nomeSeccao = RDR.Item("Nome_Secção")
            C.codigoSeccao = RDR.Item("Codigo_Secção")
            C.nomeFuncionario = RDR.Item("Nome_funcionario")
            C.nifFuncionario = RDR.Item("Nif_Funcionario")
            C.nomeFornecedor = RDR.Item("Nome_Fornecedor")
            C.nifFornecedor = RDR.Item("Nif_Fornecedor")
            C.moradaFornecedor = RDR.Item("Morada_Fornecedor")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
    End Sub
End Class