Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class Seccao
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentContact As Integer
    Dim adding As Boolean

    Private Sub Secçao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source=tcp:mednat.ieeta.pt\SQLSERVER,8101;" &
                               "Initial Catalog = p5g2; uid = p5g2;" &
                               "password = P52021bd")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM proj.Secçao"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        LockControls()
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New SecçaoC
            C.Codigo = RDR.Item("codigo")
            C.Name = RDR.Item("nome")
            C.LojaNif = RDR.Item("loja_NIF")
            C.ID = RDR.Item("funcionario_num")
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0


    End Sub


    Sub ShowFornecedor()
        If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
        Dim contact As New SecçaoC
        contact = CType(ListBox1.Items.Item(currentContact), SecçaoC)
        txtName2.Text = contact.Name
        txtMorada.Text = contact.ID
        txtCodigo.Text = contact.Codigo
        Eventos.Label10.Text = contact.Codigo
        Funcionariosecçao.txtSeccao.Text = contact.Codigo
        Produtosecçao.txtCodSec.Text = contact.Codigo
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelbtn2.Click
        ListBox1.Enabled = True
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        If ListBox1.Items.Count > 0 Then
            currentContact = ListBox1.SelectedIndex
            If currentContact < 0 Then currentContact = 0
            ShowFornecedor()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Private Sub bttnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okbtn2.Click
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Try
            SaveFornecedor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(txtCodigo.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()

        Dim velhice = New Seccao
        Close()
        velhice.Show()
    End Sub

    Private Sub bttnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles addbtn2.Click
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        adding = True
        ClearFields()
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F10 Then
            MsgBox("There are " & ListBox1.Items.Count.ToString &
                      " contacts in the database")
            e.Handled = True
        End If
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        ' If we're not in EDIT mode, reject keystrokes
        If Not okbtn2.Visible Then
            e.Handled = True
        End If
    End Sub

    Private Function SaveFornecedor() As Boolean
        Dim contact As New SecçaoC
        Try
            contact.Name = txtName2.Text
            contact.ID = txtMorada.Text
            contact.LojaNif = "154736509"
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        If adding Then
            SubmitContact(contact)
            ListBox1.Items.Add(contact)
        Else
            contact.Codigo = txtCodigo.Text
            ListBox1.Items(currentContact) = contact
        End If
        Return True
    End Function



    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            ShowFornecedor()
        End If
    End Sub

    ' Helper routines
    Sub LockControls()
        txtName2.ReadOnly = True
        txtMorada.ReadOnly = True
    End Sub

    Sub UnlockControls()
        txtName2.ReadOnly = False
        txtMorada.ReadOnly = False
    End Sub

    Sub ShowButtons()
        LockControls()
        addbtn2.Visible = True
        okbtn2.Visible = False
        cancelbtn2.Visible = False
    End Sub

    Sub ClearFields()
        txtName2.Text = ""
        txtMorada.Text = ""
        txtCodigo.Text = ""
    End Sub



    Sub HideButtons()
        UnlockControls()
        addbtn2.Visible = False
        okbtn2.Visible = True
        cancelbtn2.Visible = True
    End Sub

    Private Sub SubmitContact(ByVal C As SecçaoC)
        CMD.CommandText = "INSERT proj.Secçao (nome,loja_NIF,funcionario_num) " &
                          "VALUES (@Name, @LojaNif,@ID)"

        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@Name", C.Name)
        CMD.Parameters.AddWithValue("@LojaNif", C.LojaNif)
        CMD.Parameters.AddWithValue("@ID", C.ID)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to insert contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Eventos.Show()
        ListBox1.SelectedIndex = -1
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Funcionariosecçao.Show()
        ListBox1.SelectedIndex = -1
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Produtosecçao.Show()
        ListBox1.SelectedIndex = -1
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
    End Sub
End Class