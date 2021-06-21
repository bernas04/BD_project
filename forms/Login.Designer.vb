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
        Me.txtEmail.Location = New System.Drawing.Point(155, 67)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(60, 25)
        Me.txtEmail.TabIndex = 0
        Me.txtEmail.Text = "Email"
        '
        'txtPassword
        '
        Me.txtPassword.AutoSize = True
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Control
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPassword.Location = New System.Drawing.Point(111, 133)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(98, 25)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = "Password"
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(234, 67)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.PlaceholderText = "exemple@exemple.com"
        Me.txtmail.Size = New System.Drawing.Size(201, 27)
        Me.txtmail.TabIndex = 2
        Me.txtmail.Text = "dictum@Integer.edu"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(234, 131)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtpass.PlaceholderText = "Palavra-Passe"
        Me.txtpass.Size = New System.Drawing.Size(201, 27)
        Me.txtpass.TabIndex = 3
        Me.txtpass.Text = "func3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 5
        '
        'Registar
        '
        Me.Registar.AutoSize = True
        Me.Registar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Registar.Location = New System.Drawing.Point(82, 195)
        Me.Registar.Name = "Registar"
        Me.Registar.Size = New System.Drawing.Size(63, 20)
        Me.Registar.TabIndex = 4
        Me.Registar.TabStop = True
        Me.Registar.Text = "Registar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(415, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 243)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Registar)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
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
