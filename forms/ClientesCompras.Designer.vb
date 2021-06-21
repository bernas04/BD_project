<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesCompras
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 18.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(491, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Compras"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(26, 99)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(441, 444)
        Me.ListBox1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(26, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 27)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(128, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 27)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Preço"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(275, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 27)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(655, 496)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(716, 493)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PlaceholderText = "Preço Total"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(129, 27)
        Me.txtTotal.TabIndex = 20
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(716, 173)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(365, 104)
        Me.ListBox2.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Historic", 20.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(814, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 47)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Fatura"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(716, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Nome"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(766, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Preço"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(815, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 17)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Quantidade"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(716, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 31)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(992, 491)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 31)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Ok"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ClientesCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 565)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ClientesCompras"
        Me.Text = "ClientesCompras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
