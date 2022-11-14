<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InitalScreen
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.UserNameBox = New System.Windows.Forms.TextBox()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.InvalidLoginLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(36, 82)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(271, 35)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "Welcome to RentECar"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RentECar.My.Resources.ProjectResources.start_screen_car
        Me.PictureBox2.Location = New System.Drawing.Point(73, 168)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(198, 177)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'UserNameBox
        '
        Me.UserNameBox.Location = New System.Drawing.Point(89, 383)
        Me.UserNameBox.Name = "UserNameBox"
        Me.UserNameBox.PlaceholderText = "Username"
        Me.UserNameBox.Size = New System.Drawing.Size(156, 23)
        Me.UserNameBox.TabIndex = 5
        '
        'PasswordBox
        '
        Me.PasswordBox.Location = New System.Drawing.Point(89, 427)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox.PlaceholderText = "Password"
        Me.PasswordBox.Size = New System.Drawing.Size(156, 23)
        Me.PasswordBox.TabIndex = 6
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LoginButton.Location = New System.Drawing.Point(109, 470)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(111, 51)
        Me.LoginButton.TabIndex = 7
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'InvalidLoginLabel
        '
        Me.InvalidLoginLabel.AutoSize = True
        Me.InvalidLoginLabel.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InvalidLoginLabel.ForeColor = System.Drawing.Color.Red
        Me.InvalidLoginLabel.Location = New System.Drawing.Point(28, 537)
        Me.InvalidLoginLabel.Name = "InvalidLoginLabel"
        Me.InvalidLoginLabel.Size = New System.Drawing.Size(279, 28)
        Me.InvalidLoginLabel.TabIndex = 8
        Me.InvalidLoginLabel.Text = "Invalid Username/Password"
        Me.InvalidLoginLabel.Visible = False
        '
        'InitalScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.InvalidLoginLabel)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.UserNameBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "InitalScreen"
        Me.Size = New System.Drawing.Size(338, 644)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents UserNameBox As TextBox
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents InvalidLoginLabel As Label
End Class
