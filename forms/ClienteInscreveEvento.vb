
Imports System.Data.SqlClient


Public Class ClienteInscreveEvento
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean


    Private Sub AllEvents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM proj.clienteEventosNaoInscrito(" & nifCliente.Text & ")"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New ClienteInscreveEventoc
            C.Data = RDR.Item("datas")
            C.Hora = RDR.Item("hora").ToString
            C.numEvento = RDR.Item("num_evento")
            C.Vagas = RDR.Item("n_vagas").ToString
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0
    End Sub

    Sub ShowEventos()
        If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
        Dim contact As New ClienteInscreveEventoc
        contact = CType(ListBox1.Items.Item(currentContact), ClienteInscreveEventoc)
        idEvento.Text = contact.numEvento
        If (contact.Vagas = "") Then
            contact.Vagas = 1000
        End If
        txtVagas.Text = contact.Vagas
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
        End If
        ShowEventos()
    End Sub

    Private Sub ButtonOkInscreve_Click(sender As Object, e As EventArgs) Handles ButtonOkInscreve.Click
        SubmitContact()
        ListBox1.SelectedIndex = -1
        Close()
    End Sub

    Private Sub SubmitContact()
        CMD.CommandText = "proj.ClienteFazerInscricao"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@nif", SqlDbType.Char, 9).Value = nifCliente.Text
        CMD.Parameters.Add("@id", SqlDbType.Int).Value = idEvento.Text
        CMD.Parameters.Add("@vagas", SqlDbType.Int).Value = txtVagas.Text
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
            MsgBox("Cliente Inscrito com sucesso")
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub
End Class