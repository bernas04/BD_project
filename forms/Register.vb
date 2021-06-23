Imports System.Data.SqlClient

Public Class Register
    Dim CMD As SqlCommand
    Dim CN As SqlConnection
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        If (TextBox2.Text <> TextBox3.Text) Then
            MsgBox("Error: Palavras passes não coincidem")
            TextBox2.Text = ""
            TextBox3.Text = ""

        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            CMD.CommandText = "proj.add_editN_Cliente"
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.Clear()
            CMD.Parameters.Add("@email", SqlDbType.VarChar, 20).Value = TextBox1.Text
            CMD.Parameters.Add("@pass", SqlDbType.VarChar, 500).Value = TextBox2.Text
            CMD.Parameters.Add("@NIF", SqlDbType.Char, 9).Value = TextBox5.Text
            CMD.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = TextBox6.Text
            CMD.Parameters.Add("@data", SqlDbType.Date).Value = DateTimePicker1.Text
            CMD.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = TextBox4.Text
            CMD.Parameters.Add("@genero", SqlDbType.Char, 1).Value = ComboBox1.Text
            CMD.Parameters.Add("@edit", SqlDbType.Bit).Value = 0

            CN.Open()
            Try
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
            Finally
                CN.Close()
            End Try
            CN.Close()
            MsgBox("Cliente adicionado com sucesso")
            Close()
        End If
    End Sub
End Class