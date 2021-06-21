Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient
Public Class Horrario
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
        CMD.CommandText = "SELECT * FROM proj.HorarioFuncionario(" & Form1.txtId.Text & ")"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        While RDR.Read
            Label2.Text = RDR.Item("hora_inicio").ToString
            Label3.Text = RDR.Item("hora_fim").ToString
        End While

        CN.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (CStr(ComboBox1.Text) = CStr("08:00:00")) Then
            TextBox1.Text = "14:00:00"
        Else
            TextBox1.Text = "22:00:00"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CMD.CommandText = "select distinct hora_inicio,hora_fim from proj.Horario"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        While RDR.Read
            ComboBox1.Items.Add(RDR.Item("hora_inicio").ToString())

        End While
        ComboBox1.Visible = True
        Button2.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Button3.Visible = True
        TextBox1.Visible = True
        CN.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CMD.CommandText = "UPDATE proj.Horario " &
            "SET  hora_inicio= @h1, " &
            "    hora_fim = @h2 " &
            "WHERE n_funcionario=@h3"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@h1", ComboBox1.Text)
        CMD.Parameters.AddWithValue("@h2", TextBox1.Text)
        CMD.Parameters.AddWithValue("@h3", Form1.txtId.Text)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        ComboBox1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        TextBox1.Visible = False
        Close()
    End Sub
End Class