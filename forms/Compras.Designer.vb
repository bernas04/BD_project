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
        Me.DetalhesComprasButton = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.Label()
        Me.txtClienteId = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Funcionalidades.Controls.Add(Me.DetalhesComprasButton)
        Me.Funcionalidades.Controls.Add(Me.txtId)
        Me.Funcionalidades.Controls.Add(Me.txtClienteId)
        Me.Funcionalidades.Controls.Add(Me.txtData)
        Me.Funcionalidades.Controls.Add(Me.txtTotal)
        Me.Funcionalidades.Controls.Add(Me.Label11)
        Me.Funcionalidades.Controls.Add(Me.Label10)
        Me.Funcionalidades.Controls.Add(Me.Label3)
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
        'DetalhesComprasButton
        '
        Me.DetalhesComprasButton.Location = New System.Drawing.Point(39, 377)
        Me.DetalhesComprasButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DetalhesComprasButton.Name = "DetalhesComprasButton"
        Me.DetalhesComprasButton.Size = New System.Drawing.Size(273, 31)
        Me.DetalhesComprasButton.TabIndex = 18
        Me.DetalhesComprasButton.Text = "Detalhes de Compra"
        Me.DetalhesComprasButton.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.Location = New System.Drawing.Point(144, 291)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(61, 20)
        Me.txtId.TabIndex = 22
        Me.txtId.Text = "Label12"
        Me.txtId.Visible = False
        '
        'txtClienteId
        '
        Me.txtClienteId.Location = New System.Drawing.Point(143, 220)
        Me.txtClienteId.Name = "txtClienteId"
        Me.txtClienteId.Size = New System.Drawing.Size(169, 27)
        Me.txtClienteId.TabIndex = 21
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(143, 164)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(169, 27)
        Me.txtData.TabIndex = 20
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(143, 109)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(81, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(123, 251)
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
        Me.Label9.Location = New System.Drawing.Point(454, 13)
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
        Me.Label7.Location = New System.Drawing.Point(799, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Preço Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(690, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Id Cliente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(563, 13)
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtClienteId As TextBox
    Friend WithEvents txtData As TextBox
    Friend WithEvents txtCodProd As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtId As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DetalhesComprasButton As Button
End Class
