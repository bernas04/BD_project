Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient
Public Class Produto
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean

    Private Sub Secçao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM proj.Produto"
        CN.Open()
        txtProd.ReadOnly = True
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









    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F10 Then
            MsgBox("There are " & ListBox1.Items.Count.ToString &
                      " contacts in the database")
            e.Handled = True
        End If
    End Sub



    Private Sub bttnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        currentContact = ListBox1.SelectedIndex
        If currentContact < 0 Then
            MsgBox("Please select a contact to edit")
            Exit Sub
        End If
        adding = False

        ListBox1.Enabled = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
            ShowFornecedor()
        End If
    End Sub
    Sub ShowFornecedor()
        If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
        Dim contact As New ProdutosC
        contact = CType(ListBox1.Items.Item(currentContact), ProdutosC)
        txtProd.Text = contact.Name
        Label4.Text = contact.Codigo
    End Sub
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        ProdutoPage.Show()
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        currentContact = ListBox1.SelectedIndex
        If currentContact < 0 Then
            MsgBox("Please select a contact to edit")
            Exit Sub
        End If
        ProdutoPage.Label9.Text = Label4.Text
        ProdutoPage.Show()
    End Sub


End Class