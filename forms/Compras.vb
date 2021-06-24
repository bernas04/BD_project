Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class Compras
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
        If (Form1.txt_ret.Text = "client") Then
            CMD.CommandText = "Select * FROM proj.Compra where cliente_id=" & Form1.txtId.Text
        Else
            CMD.CommandText = "SELECT * FROM proj.Compra"
        End If
        DetalhesComprasButton.Visible = False
        CN.Open()
        LockControls()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New ComprasC
            C.ClienteId = RDR.Item("cliente_id")
            C.Data = RDR.Item("datas")
            C.Total = RDR.Item("preco")
            C.Id = RDR.Item("id")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0
    End Sub

    Sub LockControls()
        txtClienteId.ReadOnly = True
        txtData.ReadOnly = True
        txtTotal.ReadOnly = True
    End Sub

    Sub ShowCompras()
        If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
        Dim contact As New ComprasC
        contact = CType(ListBox1.Items.Item(currentContact), ComprasC)
        txtData.Text = contact.Data
        txtTotal.Text = contact.Total
        txtClienteId.Text = contact.ClienteId
        txtId.Text = contact.Id
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
            ShowCompras()
        End If
        DetalhesComprasButton.Visible = True
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F10 Then
            MsgBox("There are " & ListBox1.Items.Count.ToString &
                      " contacts in the database")
            e.Handled = True
        End If
    End Sub

    Sub ClearFields()
        txtData.Text = ""
        txtClienteId.Text = ""
        txtTotal.Text = ""
        txtId.Text = ""
    End Sub



    Private Sub SubmitContact(ByVal C As ComprasC)
        CMD.CommandText = "INSERT proj.Compra (preco,cliente_id,datas) " &
                          "VALUES (@preco, @cliente_id, @datas) "

        CMD.Parameters.Clear()
        'CMD.Parameters.AddWithValue("@id", C.Id)

        CMD.Parameters.AddWithValue("@cliente_id", C.ClienteId)
        CMD.Parameters.AddWithValue("@datas", C.Data)
        CMD.Parameters.AddWithValue("@preco", C.Total)

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



    Private Sub DetalhesComprasButton_Click(sender As Object, e As EventArgs) Handles DetalhesComprasButton.Click
        DetalhesCompra.Label1.Text = txtId.Text
        DetalhesCompra.Show()
    End Sub
End Class