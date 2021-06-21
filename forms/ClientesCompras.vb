Imports System.Data.SqlClient
Public Class ClientesCompras
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean
    Dim preco As Double = 0
    Dim arrayList As String

    Private Sub ClientesCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM proj.Produto"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New ProdutosC
            C.Codigo = RDR.Item("codigo")
            C.Name = RDR.Item("nome")
            C.Stock = RDR.Item("stock")
            C.Descricao = RDR.Item("descricao")
            C.Preco = RDR.Item("preco")
            C.SecCode = RDR.Item("secçao_codigo")
            C.TipoProduto = RDR.Item("tipo_prod_codigo")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
            If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
            Dim contact As New ProdutosC
            contact = CType(ListBox1.Items.Item(currentContact), ProdutosC)
            Dim p As New Double
            p = Double.Parse(contact.Preco)
            Dim input = InputBox("Defina a quantidade que pretende: ")
            preco += Integer.Parse(input) * p
            ListBox1.SelectedIndex = -1
            If Not arrayList = "" Then
                arrayList += ","
            End If
            arrayList += contact.Codigo + " " + input
            contact.Stock = input
            ListBox2.Items.Add(contact)
        End If

        txtTotal.Text = preco

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox2.Items.Clear()
        arrayList = ""
        txtTotal.Text = 0
        preco = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")


        Dim thisDate As Date
        thisDate = Today
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "proj.ClienteCompra"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@preco", SqlDbType.Float).Value = txtTotal.Text
        CMD.Parameters.Add("@id", SqlDbType.Int).Value = Form1.txtId.Text
        CMD.Parameters.Add("@lista", SqlDbType.VarChar, 500).Value = arrayList
        CMD.Parameters.Add("@dia", SqlDbType.Date).Value = thisDate
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
        MsgBox("Compra efetuada com sucesso")
        Close()
    End Sub
End Class