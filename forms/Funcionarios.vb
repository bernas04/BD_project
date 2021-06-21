Imports System.Data.SqlClient
Public Class Funcionarios
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
        CMD.CommandText = "SELECT  * from proj.FuncionarioTodos"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New FuncionarioC
            C.Num_func = RDR.Item("Num_funcionario")
            C.Pessoa_NIF = RDR.Item("NIF")
            C.Mail = RDR.Item("secçao_codigo")
            C.Telefone = RDR.Item("Email")
            C.Nome = RDR.Item("N_telefone")
            C.Sec = RDR.Item("Nome")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class