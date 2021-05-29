Imports System.Data.SqlClient
Public Class Form1

    Dim CMD As SqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN

    End Sub


    Private Sub PictureBox_Pessoal_Click(sender As Object, e As EventArgs) Handles PictureBox_Pessoal.Click
        GestaoPes.Show()
    End Sub

    Private Sub Label_Pessoal_Click(sender As Object, e As EventArgs) Handles Label_Pessoal.Click
        GestaoPes.Show()
    End Sub

    Private Sub PictureBox_Eventos_Click(sender As Object, e As EventArgs) Handles PictureBox_Eventos.Click
        Eventos.Show()
    End Sub

    Private Sub Label_Eventos_Click(sender As Object, e As EventArgs) Handles Label_Eventos.Click
        Eventos.Show()
    End Sub

    Private Sub PictureBox_Fornecedor_Click(sender As Object, e As EventArgs) Handles PictureBox_Fornecedor.Click
        Fornecedor.Show()

    End Sub

    Private Sub Label_Fornecedor_Click(sender As Object, e As EventArgs) Handles Label_Fornecedor.Click
        Fornecedor.Show()
    End Sub

    Private Sub PictureBox_Compras_Click(sender As Object, e As EventArgs) Handles PictureBox_Compras.Click
        Compras.Show()
    End Sub

    Private Sub Label_Compras_Click(sender As Object, e As EventArgs) Handles Label_Compras.Click
        Compras.Show()
    End Sub

    Private Sub PictureBox_Encomendas_Click(sender As Object, e As EventArgs) Handles PictureBox_Encomendas.Click
        Encomendas.Show()

    End Sub

    Private Sub Label_Encomendas_Click(sender As Object, e As EventArgs) Handles Label_Encomendas.Click
        Encomendas.Show()
    End Sub

    Private Sub PictureBox_Produtos_Click(sender As Object, e As EventArgs) Handles PictureBox_Produtos.Click
        Produto.Show()

    End Sub

    Private Sub Label_Produtos_Click(sender As Object, e As EventArgs) Handles Label_Produtos.Click
        Produto.Show()
    End Sub

    Private Sub PictureBox_Seccao_Click(sender As Object, e As EventArgs) Handles PictureBox_Seccao.Click
        Seccao.Show()

    End Sub

    Private Sub Label_Seccaco_Click(sender As Object, e As EventArgs) Handles Label_Seccaco.Click
        Seccao.Show()
    End Sub


End Class
