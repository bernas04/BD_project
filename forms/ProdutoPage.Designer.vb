<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProdutoPage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.caixaNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.caixaStock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.caixaDesc = New System.Windows.Forms.TextBox()
        Me.caixaPrec = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.caixaSeccao = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.caixaTipo_Prod = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(690, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome do Produto"
        '
        'caixaNome
        '
        Me.caixaNome.Location = New System.Drawing.Point(161, 65)
        Me.caixaNome.Name = "caixaNome"
        Me.caixaNome.Size = New System.Drawing.Size(100, 23)
        Me.caixaNome.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Quantidade em stock"
        '
        'caixaStock
        '
        Me.caixaStock.Location = New System.Drawing.Point(161, 112)
        Me.caixaStock.Name = "caixaStock"
        Me.caixaStock.Size = New System.Drawing.Size(100, 23)
        Me.caixaStock.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Descrição"
        '
        'caixaDesc
        '
        Me.caixaDesc.Location = New System.Drawing.Point(476, 65)
        Me.caixaDesc.Name = "caixaDesc"
        Me.caixaDesc.Size = New System.Drawing.Size(185, 23)
        Me.caixaDesc.TabIndex = 6
        '
        'caixaPrec
        '
        Me.caixaPrec.Location = New System.Drawing.Point(476, 115)
        Me.caixaPrec.Name = "caixaPrec"
        Me.caixaPrec.Size = New System.Drawing.Size(100, 23)
        Me.caixaPrec.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(390, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Preço"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Código da Secção"
        '
        'caixaSeccao
        '
        Me.caixaSeccao.Location = New System.Drawing.Point(161, 158)
        Me.caixaSeccao.Name = "caixaSeccao"
        Me.caixaSeccao.Size = New System.Drawing.Size(100, 23)
        Me.caixaSeccao.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(310, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Código do Tipo de Produto"
        '
        'caixaTipo_Prod
        '
        Me.caixaTipo_Prod.Location = New System.Drawing.Point(476, 158)
        Me.caixaTipo_Prod.Name = "caixaTipo_Prod"
        Me.caixaTipo_Prod.Size = New System.Drawing.Size(100, 23)
        Me.caixaTipo_Prod.TabIndex = 12
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(564, 229)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(190, 154)
        Me.ListBox1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(554, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(243, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Caso tenhas dúvidas de que tipo é o produto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(124, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Add product"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(648, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(124, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Save Changes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(310, 229)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(214, 154)
        Me.ListBox2.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(310, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(190, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Caso tenhas dúvidas qual a Secção"
        '
        'ProdutoPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.caixaTipo_Prod)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.caixaSeccao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.caixaPrec)
        Me.Controls.Add(Me.caixaDesc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.caixaStock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.caixaNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ProdutoPage"
        Me.Text = "ProdutoPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents caixaNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents caixaStock As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents caixaDesc As TextBox
    Friend WithEvents caixaPrec As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents caixaSeccao As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents caixaTipo_Prod As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label10 As Label
End Class
