Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Form1

    Dim CMD As SqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT count(*) as total FROM proj.Funcionario"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader


        While RDR.Read
            func_txt.Text = "A empresa possui " & RDR.Item("total") & " funcionários"
        End While
        CN.Close()

        CMD.CommandText = "SELECT count(*) as total FROM proj.Cliente"
        CN.Open()
        Dim RDR1 As SqlDataReader
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            clientes_txt.Text = "A empresa possui " & RDR1.Item("total") & " clientes"
        End While
        CN.Close()


        CN.Open()
        CMD.CommandText = "SELECT count(*) as total FROM proj.Fornecedor"

        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            forn_txt.Text = "A empresa possui " & RDR1.Item("total") & " fornecedores"
        End While
        CN.Close()

        CN.Open()
        CMD.CommandText = "SELECT count(*) as total FROM proj.Secçao"

        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            seccao_txt.Text = "A empresa possui " & RDR1.Item("total") & " secções"
        End While
        CN.Close()

        CN.Open()
        CMD.CommandText = "SELECT count(*) as total FROM proj.Evento"

        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            eventos_txt.Text = "A empresa já organizou  " & RDR1.Item("total") & " eventos"
        End While
        CN.Close()

        If txt_ret.Text = "client" Then
            PictureBox_Pessoal.Visible = False
            Label_Pessoal.Visible = False
            PictureBox_Fornecedor.Visible = False
            Label_Fornecedor.Visible = False
            PictureBox_Encomendas.Visible = False
            Label_Encomendas.Visible = False
            PictureBox_Seccao.Visible = False
            Label_Seccaco.Visible = False
            AllEvents.Button1.Visible = False
            Produto.Addbtn.Visible = False
            Produto.editbtn.Visible = False
            PictureBox2.Visible = True
            Label3.Visible = True
        End If

        If txt_ret.Text = "func" Then
            Clientes.ButtonCompra.Visible = False
            Clientes.ButtonInscreve.Visible = False
        End If

        If txt_ret.Text = "nclient" Then
            PictureBox_Pessoal.Visible = False
            Label_Pessoal.Visible = False
            PictureBox_Fornecedor.Visible = False
            Label_Fornecedor.Visible = False
            PictureBox_Encomendas.Visible = False
            Label_Encomendas.Visible = False
            PictureBox_Seccao.Visible = False
            Label_Seccaco.Visible = False
            AllEvents.Button1.Visible = False
            Produto.Addbtn.Visible = False
            Produto.editbtn.Visible = False
            PictureBox2.Visible = True
            Label3.Visible = True
            PictureBox_Compras.Visible = False
            Label_Compras.Visible = False
        End If




    End Sub


    Private Sub PictureBox_Pessoal_Click(sender As Object, e As EventArgs) Handles PictureBox_Pessoal.Click
        GestaoPes.Show()
    End Sub

    Private Sub Label_Pessoal_Click(sender As Object, e As EventArgs) Handles Label_Pessoal.Click
        GestaoPes.Show()
    End Sub

    Private Sub PictureBox_Eventos_Click(sender As Object, e As EventArgs) Handles PictureBox_Eventos.Click
        AllEvents.Show()
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles pesquisa.TextChanged
        Dim CMD As SqlCommand
        Dim txt As String = pesquisa.Text
        Dim CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = "Select * FROM proj.Pesquisa(" & txtId.Text & ")"

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ClientesCompras.Show()
    End Sub
End Class
