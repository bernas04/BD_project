<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NaoClientesvb
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Funcionalidades = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.okbtn = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNif = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.Funcionalidades.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(551, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Morada"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(469, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nome"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(397, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "NIF"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(424, 415)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.ForeColor = System.Drawing.Color.Black
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(33, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(391, 379)
        Me.ListBox1.TabIndex = 0
        '
        'Funcionalidades
        '
        Me.Funcionalidades.Controls.Add(Me.Button2)
        Me.Funcionalidades.Controls.Add(Me.DateTimePicker1)
        Me.Funcionalidades.Controls.Add(Me.txtTelefone)
        Me.Funcionalidades.Controls.Add(Me.Label11)
        Me.Funcionalidades.Controls.Add(Me.Label10)
        Me.Funcionalidades.Controls.Add(Me.txtGenero)
        Me.Funcionalidades.Controls.Add(Me.Label9)
        Me.Funcionalidades.Controls.Add(Me.Button1)
        Me.Funcionalidades.Controls.Add(Me.cancelbtn)
        Me.Funcionalidades.Controls.Add(Me.editbtn)
        Me.Funcionalidades.Controls.Add(Me.Addbtn)
        Me.Funcionalidades.Controls.Add(Me.okbtn)
        Me.Funcionalidades.Controls.Add(Me.txtEmail)
        Me.Funcionalidades.Controls.Add(Me.txtNif)
        Me.Funcionalidades.Controls.Add(Me.txtName)
        Me.Funcionalidades.Controls.Add(Me.Label5)
        Me.Funcionalidades.Controls.Add(Me.Label4)
        Me.Funcionalidades.Controls.Add(Me.Label3)
        Me.Funcionalidades.Controls.Add(Me.Label2)
        Me.Funcionalidades.Location = New System.Drawing.Point(12, 12)
        Me.Funcionalidades.Name = "Funcionalidades"
        Me.Funcionalidades.Size = New System.Drawing.Size(379, 427)
        Me.Funcionalidades.TabIndex = 7
        Me.Funcionalidades.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(113, 226)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker1.TabIndex = 19
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(66, 269)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(185, 23)
        Me.txtTelefone.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Telefone"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Data Nascimento"
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(66, 179)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(207, 23)
        Me.txtGenero.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Género"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(66, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Inscrever evento/Meus eventos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cancelbtn
        '
        Me.cancelbtn.Location = New System.Drawing.Point(69, 333)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelbtn.TabIndex = 13
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = True
        Me.cancelbtn.Visible = False
        '
        'editbtn
        '
        Me.editbtn.Location = New System.Drawing.Point(130, 333)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(75, 23)
        Me.editbtn.TabIndex = 12
        Me.editbtn.Text = "Edit"
        Me.editbtn.UseVisualStyleBackColor = True
        '
        'Addbtn
        '
        Me.Addbtn.Location = New System.Drawing.Point(15, 333)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(75, 23)
        Me.Addbtn.TabIndex = 10
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = True
        '
        'okbtn
        '
        Me.okbtn.Location = New System.Drawing.Point(191, 333)
        Me.okbtn.Name = "okbtn"
        Me.okbtn.Size = New System.Drawing.Size(75, 23)
        Me.okbtn.TabIndex = 8
        Me.okbtn.Text = "Ok"
        Me.okbtn.UseVisualStyleBackColor = True
        Me.okbtn.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(66, 133)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(207, 23)
        Me.txtEmail.TabIndex = 6
        '
        'txtNif
        '
        Me.txtNif.Location = New System.Drawing.Point(66, 41)
        Me.txtNif.Name = "txtNif"
        Me.txtNif.Size = New System.Drawing.Size(160, 23)
        Me.txtNif.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(66, 83)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(207, 23)
        Me.txtName.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 15)
        Me.Label5.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(6, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(6, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NIF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(306, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(73, 403)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Faz a tua primeira compra"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NaoClientesvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Funcionalidades)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NaoClientesvb"
        Me.Text = "NaoClientesvb"
        Me.GroupBox2.ResumeLayout(False)
        Me.Funcionalidades.ResumeLayout(False)
        Me.Funcionalidades.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Funcionalidades As GroupBox
    Friend WithEvents cancelbtn As Button
    Friend WithEvents editbtn As Button
    Friend WithEvents Addbtn As Button
    Friend WithEvents okbtn As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNif As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
End Class
