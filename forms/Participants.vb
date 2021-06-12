Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient


Public Class Participants
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean
    Private Sub Participants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM proj.pessoas_Eventos where id =" & txtEventoId.Text
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader()
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New ParticipantsC
            C.nome = RDR.Item("Nome").ToString
            C.nClienteNIF = RDR.Item("ncliente_nif")
            C.Id = RDR.Item("id")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0
    End Sub


End Class