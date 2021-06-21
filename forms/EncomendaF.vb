Imports System.Data.SqlClient

Public Class EncomendaF
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim currentContact1 As Integer
    Dim preco As Integer = 0
    Private Sub EncomendaF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Button1.Visible = False
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
        CMD.CommandText = "SELECT * FROM proj.Fornecedor"
        CN.Open()
        RDR = CMD.ExecuteReader

        ListBox2.Items.Clear()
        While RDR.Read
            Dim C As New FornecedorC
            C.Nif = RDR.Item("Nif")
            C.Name = RDR.Item("Nome")
            C.Morada = RDR.Item("Morada")
            ListBox2.Items.Add(C)
        End While
        CN.Close()
        currentContact1 = 0
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
            If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
            Dim contact As New ProdutosC
            contact = CType(ListBox1.Items.Item(currentContact), ProdutosC)
            Try
                Dim input = InputBox("Defina a quantidade que pretende: ")
                txtQuantidade.Text = input
                txtidProd.Text = contact.Codigo

                preco += 1
                If preco = 2 Then
                    Button1.Visible = True
                End If
            Catch
                Close()
            End Try
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

        If ListBox1.SelectedIndex > -1 Then
            currentContact1 = ListBox2.SelectedIndex
            If ListBox2.Items.Count = 0 Or currentContact1 < 0 Then Exit Sub
            Dim contact As New FornecedorC
            contact = CType(ListBox2.Items.Item(currentContact), FornecedorC)
            txtFornecedor.Text = contact.Nif
            preco += 1
            If preco = 2 Then
                Button1.Visible = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim thisDate As Date
        thisDate = Today
        MsgBox(Today)

        MsgBox(DateTime.Today.AddDays(7))
        CMD.CommandText = "proj.FazerEncomenda"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@num", SqlDbType.Int).Value = Form1.txtId.Text
        CMD.Parameters.Add("@data_p", SqlDbType.Date).Value = thisDate
        CMD.Parameters.Add("@date_entrega", SqlDbType.Date).Value = DateTime.Today.AddDays(7)
        CMD.Parameters.Add("@nif", SqlDbType.Char, 9).Value = txtFornecedor.Text
        CMD.Parameters.Add("@code", SqlDbType.Int).Value = txtidProd.Text
        CMD.Parameters.Add("@quantidade", SqlDbType.Int).Value = txtQuantidade.Text

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
        MsgBox("Encomenda efetuada com sucesso")
        Close()
    End Sub
End Class