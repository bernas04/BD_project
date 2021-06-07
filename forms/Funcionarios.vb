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
        CMD.CommandText = "SELECT  Pessoa_NIF,Nome,Num_funcionario,N_telefone,Email from proj.Pessoa join  
                            proj.Funcionario on  
                            Pessoa.NIF=Funcionario.Pessoa_NIF"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New FuncionarioC
            C.Num_func = RDR.Item("Num_funcionario")
            C.Pessoa_NIF = RDR.Item("Pessoa_NIF")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0


    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
            Button1.Enabled = True
            If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
            Dim contact As New FuncionarioC
            contact = CType(ListBox1.Items.Item(currentContact), FuncionarioC)
            Label2.Text = contact.Num_func

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PáginaFuncionario.Label1.Text = Label2.Text
        PáginaFuncionario.Show()
    End Sub
End Class