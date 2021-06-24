<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClienteInscreveEvento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonOkInscreve = New System.Windows.Forms.Button()
        Me.nifCliente = New System.Windows.Forms.Label()
        Me.idEvento = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVagas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(28, 143)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1064, 324)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(356, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 44)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lista de Eventos Futuros"
        '
        'ButtonOkInscreve
        '
        Me.ButtonOkInscreve.Location = New System.Drawing.Point(28, 481)
        Me.ButtonOkInscreve.Name = "ButtonOkInscreve"
        Me.ButtonOkInscreve.Size = New System.Drawing.Size(80, 34)
        Me.ButtonOkInscreve.TabIndex = 3
        Me.ButtonOkInscreve.Text = "Ok"
        Me.ButtonOkInscreve.UseVisualStyleBackColor = True
        '
        'nifCliente
        '
        Me.nifCliente.AutoSize = True
        Me.nifCliente.Location = New System.Drawing.Point(74, 27)
        Me.nifCliente.Name = "nifCliente"
        Me.nifCliente.Size = New System.Drawing.Size(0, 20)
        Me.nifCliente.TabIndex = 4
        Me.nifCliente.Visible = False
        '
        'idEvento
        '
        Me.idEvento.AutoSize = True
        Me.idEvento.Location = New System.Drawing.Point(70, 68)
        Me.idEvento.Name = "idEvento"
        Me.idEvento.Size = New System.Drawing.Size(0, 20)
        Me.idEvento.TabIndex = 5
        Me.idEvento.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(28, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nº Evento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(161, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(238, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 28)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Data"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(333, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Vagas"
        '
        'txtVagas
        '
        Me.txtVagas.AutoSize = True
        Me.txtVagas.Location = New System.Drawing.Point(862, 48)
        Me.txtVagas.Name = "txtVagas"
        Me.txtVagas.Size = New System.Drawing.Size(53, 20)
        Me.txtVagas.TabIndex = 10
        Me.txtVagas.Text = "Label6"
        Me.txtVagas.Visible = False
        '
        'ClienteInscreveEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 527)
        Me.Controls.Add(Me.txtVagas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idEvento)
        Me.Controls.Add(Me.nifCliente)
        Me.Controls.Add(Me.ButtonOkInscreve)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "ClienteInscreveEvento"
        Me.Text = "ClienteInscreveEvento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonOkInscreve As Button
    Friend WithEvents nifCliente As Label
    Friend WithEvents idEvento As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVagas As Label
End Class
