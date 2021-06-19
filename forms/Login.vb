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
        CMD.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text
        CMD.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtpass.Text
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
            Form1.Show()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub
End Class