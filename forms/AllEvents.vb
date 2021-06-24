Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class AllEvents
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
        CMD.CommandText = "SELECT * FROM proj.Evento"
        CN.Open()
        Dim RDR As SqlDataReader
        If Form1.txt_ret.Text = "client" Then
            Button2.Visible = True
            Button1.Visible = False
        ElseIf Form1.txt_ret.Text = "nclient" Then
            Button2.Visible = True
            Button1.Visible = False
        Else
            Button2.Visible = False
            Button1.Visible = True
        End If
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New EventosC
            C.Data = RDR.Item("datas")
            C.Hora = RDR.Item("hora").ToString
            C.CodSec = RDR.Item("secçao_codigo")
            C.Nvagas = RDR.Item("n_vagas").ToString
            C.Custo = RDR.Item("custo").ToString
            C.Id = RDR.Item("id")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0
    End Sub

    Sub ShowEventos()
        If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
        Dim contact As New EventosC
        contact = CType(ListBox1.Items.Item(currentContact), EventosC)
        txtEventoID.Text = contact.Id
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
        End If
        ShowEventos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Participants.txtEventoId.Text = txtEventoID.Text
        Participants.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClienteInscreveEvento.Show()
    End Sub
End Class