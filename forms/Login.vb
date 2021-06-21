Imports System.Data.SqlClient
Public Class Login
    Dim CMD As SqlCommand
    Dim CN As SqlConnection
    Private Sub Registar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Registar.LinkClicked
        Register.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "proj.ValidaLogin"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = txtmail.Text
        CMD.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = txtpass.Text

        CMD.Parameters.Add("@ret", SqlDbType.VarChar, 50)
        CMD.Parameters("@ret").Direction = ParameterDirection.Output
        CMD.Parameters.Add("@nif", SqlDbType.VarChar, 9)
        CMD.Parameters("@nif").Direction = ParameterDirection.Output
        CMD.Parameters.Add("@numero", SqlDbType.Int)
        CMD.Parameters("@numero").Direction = ParameterDirection.Output

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
        Dim str As String = CMD.Parameters("@ret").Value
        If (str = "error") Then
            MsgBox("Dados Invalidos")
            txtmail.Text = ""
            txtpass.Text = ""
        Else
            Dim nif As String = CMD.Parameters("@nif").Value
            Dim number As Integer = CMD.Parameters("@numero").Value
            Form1.txtNif.Text = nif
            Form1.txt_ret.Text = str
            Form1.txtId.Text = number
            Form1.Show()
            txtmail.Text = ""
            txtpass.Text = ""
        End If
    End Sub


End Class