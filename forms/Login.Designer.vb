<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txtEmail = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.Label()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Registar = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.AutoSize = True
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmail.Location = New System.Drawing.Point(136, 50)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(48, 20)
        Me.txtEmail.TabIndex = 0
        Me.txtEmail.Text = "Email"
        '
        'txtPassword
        '
        Me.txtPassword.AutoSize = True
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Control
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPassword.Location = New System.Drawing.Point(97, 100)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(78, 20)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = "Password"
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(205, 50)
        Me.txtmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.PlaceholderText = "exemple@exemple.com"
        Me.txtmail.Size = New System.Drawing.Size(176, 23)
        Me.txtmail.TabIndex = 2
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(205, 98)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtpass.PlaceholderText = "Palavra-Passe"
        Me.txtpass.Size = New System.Drawing.Size(176, 23)
        Me.txtpass.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 5
        '
        'Registar
        '
        Me.Registar.AutoSize = True
        Me.Registar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Registar.Location = New System.Drawing.Point(72, 146)
        Me.Registar.Name = "Registar"
        Me.Registar.Size = New System.Drawing.Size(49, 15)
        Me.Registar.TabIndex = 4
        Me.Registar.TabStop = True
        Me.Registar.Text = "Registar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(363, 148)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 25)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 182)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Registar)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmail As Label
    Friend WithEvents txtPassword As Label
    Friend WithEvents txtmail As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Registar As LinkLabel
    Friend WithEvents Button1 As Button
End Class
