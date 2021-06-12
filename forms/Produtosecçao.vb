Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class Produtosecçao
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean
    Private Sub Produtosecçao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM dbo.produtos_Secção where Secção_Codigo = " & txtCodSec.Text
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader()
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New ProdutosecçaoC
            C.seccao = RDR.Item("Secção_Codigo")
            C.codProd = RDR.Item("Produto_Codigo")
            C.descricao = RDR.Item("descricao")
            C.nomesec = RDR.Item("Secção_Nome")
            C.preco = RDR.Item("preco")
            C.prod = RDR.Item("Produto_nome")
            C.stock = RDR.Item("stock")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0
    End Sub
End Class