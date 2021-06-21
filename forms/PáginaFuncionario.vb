Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient
Public Class PáginaFuncionario
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean

    Private Sub PáginaFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM proj.FuncionarioTodos where  Num_funcionario=" & Label1.Text
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        While RDR.Read

            txtNum.Text = RDR.Item("Num_funcionario")
            txtNif.Text = RDR.Item("NIF")
            txtSec.Text = RDR.Item("secçao_codigo")
            txtEmail.Text = RDR.Item("Email")
            txtTele.Text = RDR.Item("N_telefone")
            txtName.Text = RDR.Item("Nome")
            txtGene.Text = RDR.Item("Genero")
            DateTimePicker1.Text = RDR.Item("Data_nascimento")
        End While
        LockControlsEdit()
        CN.Close()
    End Sub

    Sub LockControlsEdit()
        txtEmail.ReadOnly = True
        txtName.ReadOnly = True
        txtNif.ReadOnly = True
        txtTele.ReadOnly = True
        txtNum.ReadOnly = True
        DateTimePicker1.Enabled = True
        txtGene.ReadOnly = True
        txtSec.ReadOnly = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles edit.Click
        txtEmail.ReadOnly = False
        txtTele.ReadOnly = False
        hor.Visible = False
        enco.Visible = False
        edit.Visible = False
        ok.Visible = True
        cancel.Visible = True
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        txtEmail.ReadOnly = True
        txtTele.ReadOnly = True
        hor.Visible = True
        enco.Visible = True
        edit.Visible = True
        ok.Visible = False
        cancel.Visible = False
    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        txtEmail.ReadOnly = True
        txtTele.ReadOnly = True
        hor.Visible = True
        enco.Visible = True
        edit.Visible = True
        ok.Visible = False
        cancel.Visible = False
        Submit()
    End Sub

    Private Sub Submit()
        'CMD.CommandText = " exec proj.add_editN_Cliente @Nif, @telefone,@email,@name, @data,@genero,@edit"
        CMD.CommandText = "proj.addFunct"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@NIF", SqlDbType.Char, 9).Value = txtNif.Text
        CMD.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = txtTele.Text
        CMD.Parameters.Add("@email", SqlDbType.VarChar, 20).Value = txtEmail.Text
        CMD.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = txtName.Text

        CMD.Parameters.Add("@data", SqlDbType.Date).Value = DateTimePicker1.Text
        CMD.Parameters.Add("@genero", SqlDbType.Char, 1).Value = txtGene.Text
        CMD.Parameters.Add("@edit", SqlDbType.Bit).Value = 1
        CMD.Parameters.Add("@sec", SqlDbType.Int).Value = txtSec.Text
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        MsgBox("ALTERADO COM SUCESSO")
    End Sub

    Private Sub hor_Click(sender As Object, e As EventArgs) Handles hor.Click
        Horrario.Show()
    End Sub

    Private Sub enco_Click(sender As Object, e As EventArgs) Handles enco.Click
        EncomendaF.Show()
    End Sub
End Class