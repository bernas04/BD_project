
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class Funcionariosecçao
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean


    Private Sub Funcionarioseccao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM proj.Funcionario_Secçao where codigo = " & txtSeccao.Text
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader()
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New FuncionariosecçaoC
            C.codigo = RDR.Item("codigo")
            C.chefe = RDR.Item("Chefe_Seccao_Numero")
            C.nif = RDR.Item("NIF")
            C.nome = RDR.Item("Nome_Pessoa")
            C.nomeSec = RDR.Item("Nome_Secção")
            C.numFu = RDR.Item("Num_funcionario")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0
    End Sub

    Private Sub Funcionariosecçao_Load(sender As Object, e As EventArgs)

    End Sub
End Class