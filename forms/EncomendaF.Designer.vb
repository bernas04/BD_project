<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EncomendaF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFornecedor = New System.Windows.Forms.Label()
        Me.txtidProd = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.txtQuantidade = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFornecedor
        '
        Me.txtFornecedor.AutoSize = True
        Me.txtFornecedor.Location = New System.Drawing.Point(85, 42)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(53, 20)
        Me.txtFornecedor.TabIndex = 1
        Me.txtFornecedor.Text = "Label1"
        '
        'txtidProd
        '
        Me.txtidProd.AutoSize = True
        Me.txtidProd.Location = New System.Drawing.Point(84, 78)
        Me.txtidProd.Name = "txtidProd"
        Me.txtidProd.Size = New System.Drawing.Size(53, 20)
        Me.txtidProd.TabIndex = 2
        Me.txtidProd.Text = "Label1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(51, 131)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(343, 424)
        Me.ListBox1.TabIndex = 3
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(424, 160)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(339, 384)
        Me.ListBox2.TabIndex = 4
        '
        'txtQuantidade
        '
        Me.txtQuantidade.AutoSize = True
        Me.txtQuantidade.Location = New System.Drawing.Point(93, 106)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(53, 20)
        Me.txtQuantidade.TabIndex = 5
        Me.txtQuantidade.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(864, 528)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 27)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Encomendar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EncomendaF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 592)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtidProd)
        Me.Controls.Add(Me.txtFornecedor)
        Me.Name = "EncomendaF"
        Me.Text = "EncomendaF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFornecedor As Label
    Friend WithEvents txtidProd As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents txtQuantidade As Label
    Friend WithEvents Button1 As Button
End Class
