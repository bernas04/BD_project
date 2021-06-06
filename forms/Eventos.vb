Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class Eventos
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean

    Private Sub Eventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM proj.Evento"
        CN.Open()
        Dim RDR As SqlDataReader
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
        txtData.Text = contact.Data
        txtHora.Text = contact.Hora.ToString
        txtVagas.Text = contact.Nvagas.ToString
        txtCusto.Text = contact.Custo
        txtCodSec.Text = contact.CodSec
        Label10.Text = contact.Id
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F10 Then
            MsgBox("There are " & ListBox1.Items.Count.ToString &
                      " contacts in the database")
            e.Handled = True
        End If
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles txtData.ValueChanged
        txtHora.Text = txtData.Value().ToLongTimeString
        Dim data1 = txtData.Value()
        Dim data2 = DateTime.Now
        If DateTime.Compare(data1, data2) = -1 Then
            MsgBox("Não pode agendar um evento para uma data anterior à data atual", 48)
            txtData.Value = DateTime.Today.AddDays(1)
        End If
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        ListBox1.Enabled = True
        If ListBox1.Items.Count > 0 Then
            currentContact = ListBox1.SelectedIndex
            If currentContact < 0 Then currentContact = 0
            ShowEventos()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
            ShowEventos()
        End If
    End Sub
    Sub ClearFields()
        txtData.Text = ""
        txtHora.Text = ""
        txtVagas.Text = ""
        txtCusto.Text = ""
        txtCodSec.Text = ""
        Label10.Text = ""
    End Sub

    Sub LockControls()
        'txtData.ReadOnly = True
        txtHora.ReadOnly = True
        txtVagas.ReadOnly = True
        txtCusto.ReadOnly = True
        txtCodSec.ReadOnly = True
    End Sub

    Sub ShowButtons()
        LockControls()
        Addbtn.Visible = True
        delbtn.Visible = True
        editbtn.Visible = True
        okbtn.Visible = False
        cancelbtn.Visible = False
    End Sub

    Private Sub okbtn_Click(sender As Object, e As EventArgs) Handles okbtn.Click
        Try
            SaveEvento()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(Label10.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Function SaveEvento() As Boolean
        Dim contact As New EventosC
        Try
            contact.Hora = txtHora.ToString
            contact.Data = txtData.Text
            contact.Custo = txtCusto.Text
            contact.Nvagas = txtVagas.Text.ToString
            contact.CodSec = txtCodSec.Text
            'contact.Id = Label10.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        If adding Then
            submitcontact(contact)
            ListBox1.Items.Add(contact)
        Else
            contact.Id = Label10.Text
            UpdateContact(contact)
            ListBox1.Items(currentContact) = contact
        End If
        Return True
    End Function

    Private Sub SubmitContact(ByVal C As EventosC)
        CMD.CommandText = "INSERT proj.Evento (datas,hora,n_vagas, custo, secçao_codigo) " &
                          "VALUES (@datas, @hora, @n_vagas, @custo, @secçao_codigo) "

        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@datas", C.Data)
        CMD.Parameters.AddWithValue("@hora", C.Hora)
        CMD.Parameters.AddWithValue("@secçao_codigo", C.CodSec)
        CMD.Parameters.AddWithValue("@n_vagas", C.Nvagas)
        CMD.Parameters.AddWithValue("@custo", C.Custo)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub

    Private Sub UpdateContact(ByVal C As EventosC)  'TODO: alterar aqui ter atenção as virgulas'
        CMD.CommandText = "UPDATE proj.Evento " &
            "SET Morada = @Morada, " &
            "    Nome = @Name " &
            "WHERE id=@id"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@datas", C.Data)
        CMD.Parameters.AddWithValue("@hora", C.Hora)
        CMD.Parameters.AddWithValue("@n_vagas", C.Nvagas)
        CMD.Parameters.AddWithValue("@custo", C.Custo)
        CMD.Parameters.AddWithValue("@secçao_codigo", C.CodSec)
        CMD.Parameters.AddWithValue("@id", C.Id)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("2Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub RemoveContact(ByVal Id As String)
        CMD.CommandText = "DELETE proj.Evento WHERE id=@ID "
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@ID", Id) 'ver esta situação'
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to delete contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        If ListBox1.SelectedIndex > -1 Then
            Try
                RemoveContact(CType(ListBox1.SelectedItem, EventosC).Id) 'ver aqui
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            If currentContact = ListBox1.Items.Count Then currentContact = ListBox1.Items.Count - 1
            If currentContact = -1 Then
                ClearFields()
                MsgBox("There are no more contacts")
            Else
                ShowEventos()
            End If
        End If
    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        adding = True
        ClearFields()
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Sub HideButtons()
        UnlockControls()
        Addbtn.Visible = False
        delbtn.Visible = False
        editbtn.Visible = False
        okbtn.Visible = True
        cancelbtn.Visible = True
    End Sub

    Sub UnlockControls()
        'txtData.ReadOnly = False
        txtHora.ReadOnly = False
        txtVagas.ReadOnly = False
        txtCusto.ReadOnly = False
        txtCodSec.ReadOnly = False
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        currentContact = ListBox1.SelectedIndex
        If currentContact < 0 Then
            MsgBox("Please select a contact to edit")
            Exit Sub
        End If
        adding = False
        HideButtons()
        ListBox1.Enabled = False
    End Sub


End Class