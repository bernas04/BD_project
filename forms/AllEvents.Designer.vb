<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllEvents
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtEventoID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(12, 100)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(776, 344)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(247, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lista de Eventos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(51, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(130, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hora"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(194, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cód. Secção"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(324, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Preço"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(395, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 28)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Vagas"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Participantes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtEventoID
        '
        Me.txtEventoID.AutoSize = True
        Me.txtEventoID.Location = New System.Drawing.Point(590, 27)
        Me.txtEventoID.Name = "txtEventoID"
        Me.txtEventoID.Size = New System.Drawing.Size(0, 20)
        Me.txtEventoID.TabIndex = 9
        Me.txtEventoID.Visible = False
        '
        'AllEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtEventoID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "AllEvents"
        Me.Text = "AllEvents"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtEventoID As Label
End Class
