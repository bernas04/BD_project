<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encomendas
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtDataPedido = New System.Windows.Forms.TextBox()
        Me.txtCodProds = New System.Windows.Forms.TextBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.okbtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Funcionalidades = New System.Windows.Forms.GroupBox()
        Me.txtId = New System.Windows.Forms.Label()
        Me.txtNifForne = New System.Windows.Forms.TextBox()
        Me.txtNumFunc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDataEntrega = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.delbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.Funcionalidades.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(441, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 22)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(702, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 22)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Data entrega"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.ForeColor = System.Drawing.Color.Black
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(6, 0)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(920, 504)
        Me.ListBox1.TabIndex = 0
        '
        'txtDataPedido
        '
        Me.txtDataPedido.Location = New System.Drawing.Point(143, 164)
        Me.txtDataPedido.Name = "txtDataPedido"
        Me.txtDataPedido.Size = New System.Drawing.Size(169, 27)
        Me.txtDataPedido.TabIndex = 20
        '
        'txtCodProds
        '
        Me.txtCodProds.Location = New System.Drawing.Point(143, 114)
        Me.txtCodProds.Name = "txtCodProds"
        Me.txtCodProds.Size = New System.Drawing.Size(169, 27)
        Me.txtCodProds.TabIndex = 19
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(143, 69)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(169, 27)
        Me.txtPreco.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(26, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 19)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Data Pedido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(6, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Codigo Produto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(81, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(384, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 22)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Id"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(378, 37)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(950, 553)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(39, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 19)
        Me.Label6.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(528, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 22)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Data encomenda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 19
        '
        'Funcionalidades
        '
        Me.Funcionalidades.Controls.Add(Me.txtId)
        Me.Funcionalidades.Controls.Add(Me.txtNifForne)
        Me.Funcionalidades.Controls.Add(Me.txtNumFunc)
        Me.Funcionalidades.Controls.Add(Me.Label11)
        Me.Funcionalidades.Controls.Add(Me.Label5)
        Me.Funcionalidades.Controls.Add(Me.txtDataEntrega)
        Me.Funcionalidades.Controls.Add(Me.Label13)
        Me.Funcionalidades.Controls.Add(Me.txtDataPedido)
        Me.Funcionalidades.Controls.Add(Me.txtCodProds)
        Me.Funcionalidades.Controls.Add(Me.txtPreco)
        Me.Funcionalidades.Controls.Add(Me.Label10)
        Me.Funcionalidades.Controls.Add(Me.Label4)
        Me.Funcionalidades.Controls.Add(Me.Label3)
        Me.Funcionalidades.Controls.Add(Me.cancelbtn)
        Me.Funcionalidades.Controls.Add(Me.editbtn)
        Me.Funcionalidades.Controls.Add(Me.delbtn)
        Me.Funcionalidades.Controls.Add(Me.Addbtn)
        Me.Funcionalidades.Controls.Add(Me.okbtn)
        Me.Funcionalidades.Controls.Add(Me.Label6)
        Me.Funcionalidades.Location = New System.Drawing.Point(14, 37)
        Me.Funcionalidades.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Funcionalidades.Name = "Funcionalidades"
        Me.Funcionalidades.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Funcionalidades.Size = New System.Drawing.Size(358, 541)
        Me.Funcionalidades.TabIndex = 20
        Me.Funcionalidades.TabStop = False
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.Location = New System.Drawing.Point(63, 356)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(61, 20)
        Me.txtId.TabIndex = 28
        Me.txtId.Text = "Label14"
        Me.txtId.Visible = False
        '
        'txtNifForne
        '
        Me.txtNifForne.Location = New System.Drawing.Point(144, 304)
        Me.txtNifForne.Name = "txtNifForne"
        Me.txtNifForne.Size = New System.Drawing.Size(169, 27)
        Me.txtNifForne.TabIndex = 27
        '
        'txtNumFunc
        '
        Me.txtNumFunc.Location = New System.Drawing.Point(144, 262)
        Me.txtNumFunc.Name = "txtNumFunc"
        Me.txtNumFunc.Size = New System.Drawing.Size(169, 27)
        Me.txtNumFunc.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(9, 308)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 19)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Nif Fornecedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(6, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 19)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Num Funcionário"
        '
        'txtDataEntrega
        '
        Me.txtDataEntrega.Location = New System.Drawing.Point(144, 210)
        Me.txtDataEntrega.Name = "txtDataEntrega"
        Me.txtDataEntrega.Size = New System.Drawing.Size(169, 27)
        Me.txtDataEntrega.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(27, 211)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 19)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Data Entrega"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(846, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 22)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Cod. Produto"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(1003, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 22)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Nº Funcionario"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(1172, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 22)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Nif Fornecedor"
        '
        'Encomendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1353, 600)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Funcionalidades)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Encomendas"
        Me.Text = "Encomendas"
        Me.GroupBox2.ResumeLayout(False)
        Me.Funcionalidades.ResumeLayout(False)
        Me.Funcionalidades.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtDataPedido As TextBox
    Friend WithEvents txtCodProds As TextBox
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cancelbtn As Button
    Friend WithEvents editbtn As Button
    Friend WithEvents Addbtn As Button
    Friend WithEvents okbtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Funcionalidades As GroupBox
    Friend WithEvents delbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDataEntrega As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNifForne As TextBox
    Friend WithEvents txtNumFunc As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtId As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
