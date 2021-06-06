<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Funcionalidades = New System.Windows.Forms.GroupBox()
        Me.txtId1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.txtCodProd1 = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.delbtn = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.okbtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Funcionalidades.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 12
        '
        'Funcionalidades
        '
        Me.Funcionalidades.Controls.Add(Me.txtId1)
        Me.Funcionalidades.Controls.Add(Me.txtId)
        Me.Funcionalidades.Controls.Add(Me.txtData)
        Me.Funcionalidades.Controls.Add(Me.txtCodProd1)
        Me.Funcionalidades.Controls.Add(Me.txtTotal)
        Me.Funcionalidades.Controls.Add(Me.Label11)
        Me.Funcionalidades.Controls.Add(Me.Label10)
        Me.Funcionalidades.Controls.Add(Me.Label4)
        Me.Funcionalidades.Controls.Add(Me.Label3)
        Me.Funcionalidades.Controls.Add(Me.cancelbtn)
        Me.Funcionalidades.Controls.Add(Me.editbtn)
        Me.Funcionalidades.Controls.Add(Me.delbtn)
        Me.Funcionalidades.Controls.Add(Me.Addbtn)
        Me.Funcionalidades.Controls.Add(Me.okbtn)
        Me.Funcionalidades.Controls.Add(Me.Label5)
        Me.Funcionalidades.Controls.Add(Me.Label6)
        Me.Funcionalidades.Location = New System.Drawing.Point(14, 40)
        Me.Funcionalidades.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Funcionalidades.Name = "Funcionalidades"
        Me.Funcionalidades.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Funcionalidades.Size = New System.Drawing.Size(358, 541)
        Me.Funcionalidades.TabIndex = 13
        Me.Funcionalidades.TabStop = False
        '
        'txtId1
        '
        Me.txtId1.AutoSize = True
        Me.txtId1.Location = New System.Drawing.Point(144, 290)
        Me.txtId1.Name = "txtId1"
        Me.txtId1.Size = New System.Drawing.Size(61, 20)
        Me.txtId1.TabIndex = 22
        Me.txtId1.Text = "Label12"
        Me.txtId1.Visible = False
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(143, 220)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(169, 27)
        Me.txtId.TabIndex = 21
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(143, 164)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(169, 27)
        Me.txtData.TabIndex = 20
        '
        'txtCodProd1
        '
        Me.txtCodProd1.Location = New System.Drawing.Point(143, 114)
        Me.txtCodProd1.Name = "txtCodProd1"
        Me.txtCodProd1.Size = New System.Drawing.Size(169, 27)
        Me.txtCodProd1.TabIndex = 19
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(143, 69)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(169, 27)
        Me.txtTotal.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(48, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 19)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Id Cliente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(26, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 19)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Data Compra"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(6, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Codigo Produto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(81, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Total"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(39, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 19)
        Me.Label6.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(454, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 22)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Id"
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
        Me.GroupBox2.TabIndex = 14
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(799, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Preço Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(690, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Id Cliente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(563, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 22)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Data"
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Funcionalidades)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Compras"
        Me.Text = "Compras"
        Me.Funcionalidades.ResumeLayout(False)
        Me.Funcionalidades.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Funcionalidades As GroupBox
    Friend WithEvents cancelbtn As Button
    Friend WithEvents editbtn As Button
    Friend WithEvents delbtn As Button
    Friend WithEvents Addbtn As Button
    Friend WithEvents okbtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtData As TextBox
    Friend WithEvents txtCodProd As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtId1 As Label
    Friend WithEvents txtCodProd1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
End Class
