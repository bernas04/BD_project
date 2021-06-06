<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestaoPes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestaoPes))
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clientes_txt = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(74, 106)
        Me.PictureBox12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(76, 81)
        Me.PictureBox12.TabIndex = 18
        Me.PictureBox12.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(74, 202)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 15)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Funcionários"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 30
        '
        'clientes_txt
        '
        Me.clientes_txt.AutoSize = True
        Me.clientes_txt.Location = New System.Drawing.Point(361, 121)
        Me.clientes_txt.Name = "clientes_txt"
        Me.clientes_txt.Size = New System.Drawing.Size(0, 15)
        Me.clientes_txt.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(333, 202)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 15)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Clientes"
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(333, 106)
        Me.PictureBox14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(60, 81)
        Me.PictureBox14.TabIndex = 27
        Me.PictureBox14.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(534, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Não Clientes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(534, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 81)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'GestaoPes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clientes_txt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox12)
        Me.Name = "GestaoPes"
        Me.Text = "GestaoPes"
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents clientes_txt As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
