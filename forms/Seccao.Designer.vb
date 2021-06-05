<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Seccao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.delbtn = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.okbtn = New System.Windows.Forms.Button()
        Me.txtMorada = New System.Windows.Forms.TextBox()
        Me.txtNif = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Funcionalidades = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.Funcionalidades.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(630, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 27)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Morada"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(454, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 27)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "NIF"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(416, 40)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(485, 553)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.ForeColor = System.Drawing.Color.Black
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(38, 0)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(428, 504)
        Me.ListBox1.TabIndex = 0
        '
        'cancelbtn
        '
        Me.cancelbtn.Location = New System.Drawing.Point(75, 404)
        Me.cancelbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(86, 31)
        Me.cancelbtn.TabIndex = 13
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = True
        Me.cancelbtn.Visible = False
        '
        'editbtn
        '
        Me.editbtn.Location = New System.Drawing.Point(128, 404)
        Me.editbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(86, 31)
        Me.editbtn.TabIndex = 12
        Me.editbtn.Text = "Edit"
        Me.editbtn.UseVisualStyleBackColor = True
        '
        'delbtn
        '
        Me.delbtn.Location = New System.Drawing.Point(226, 404)
        Me.delbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.delbtn.Name = "delbtn"
        Me.delbtn.Size = New System.Drawing.Size(86, 31)
        Me.delbtn.TabIndex = 11
        Me.delbtn.Text = "Delete"
        Me.delbtn.UseVisualStyleBackColor = True
        '
        'Addbtn
        '
        Me.Addbtn.Location = New System.Drawing.Point(35, 404)
        Me.Addbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(86, 31)
        Me.Addbtn.TabIndex = 10
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = True
        '
        'okbtn
        '
        Me.okbtn.Location = New System.Drawing.Point(201, 404)
        Me.okbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.okbtn.Name = "okbtn"
        Me.okbtn.Size = New System.Drawing.Size(86, 31)
        Me.okbtn.TabIndex = 8
        Me.okbtn.Text = "Ok"
        Me.okbtn.UseVisualStyleBackColor = True
        Me.okbtn.Visible = False
        '
        'txtMorada
        '
        Me.txtMorada.Location = New System.Drawing.Point(83, 178)
        Me.txtMorada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMorada.Name = "txtMorada"
        Me.txtMorada.Size = New System.Drawing.Size(236, 27)
        Me.txtMorada.TabIndex = 6
        '
        'txtNif
        '
        Me.txtNif.Location = New System.Drawing.Point(83, 56)
        Me.txtNif.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNif.Name = "txtNif"
        Me.txtNif.Size = New System.Drawing.Size(236, 27)
        Me.txtNif.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(83, 114)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(236, 27)
        Me.txtName.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(7, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Morada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(7, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(7, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NIF Loja"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(536, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 27)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nome"
        '
        'Funcionalidades
        '
        Me.Funcionalidades.Controls.Add(Me.cancelbtn)
        Me.Funcionalidades.Controls.Add(Me.editbtn)
        Me.Funcionalidades.Controls.Add(Me.delbtn)
        Me.Funcionalidades.Controls.Add(Me.Addbtn)
        Me.Funcionalidades.Controls.Add(Me.okbtn)
        Me.Funcionalidades.Controls.Add(Me.txtMorada)
        Me.Funcionalidades.Controls.Add(Me.txtNif)
        Me.Funcionalidades.Controls.Add(Me.txtName)
        Me.Funcionalidades.Controls.Add(Me.Label5)
        Me.Funcionalidades.Controls.Add(Me.Label4)
        Me.Funcionalidades.Controls.Add(Me.Label3)
        Me.Funcionalidades.Controls.Add(Me.Label2)
        Me.Funcionalidades.Location = New System.Drawing.Point(14, 40)
        Me.Funcionalidades.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Funcionalidades.Name = "Funcionalidades"
        Me.Funcionalidades.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Funcionalidades.Size = New System.Drawing.Size(358, 541)
        Me.Funcionalidades.TabIndex = 7
        Me.Funcionalidades.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(350, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 6
        '
        'Seccao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Funcionalidades)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Seccao"
        Me.Text = "Seccao"
        Me.GroupBox2.ResumeLayout(False)
        Me.Funcionalidades.ResumeLayout(False)
        Me.Funcionalidades.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents cancelbtn As Button
    Friend WithEvents editbtn As Button
    Friend WithEvents delbtn As Button
    Friend WithEvents Addbtn As Button
    Friend WithEvents okbtn As Button
    Friend WithEvents txtMorada As TextBox
    Friend WithEvents txtNif As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Funcionalidades As GroupBox
    Friend WithEvents Label1 As Label
End Class
