Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient


Public Class DetalhesCompra

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

        CMD.CommandText = "SELECT * FROM proj.Compra_Produtos(" & Label1.Text & ")"

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New DetalhesCompraC
            C.CompraId = RDR.Item("Compra_id")
            C.NomeProduto = RDR.Item("Produto")
            C.PrecoProduto = RDR.Item("Preço")
            C.nomePessoa = RDR.Item("Nome_Cliente")
            C.NifCliente = RDR.Item("Nif_Cliente")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
    End Sub

End Class