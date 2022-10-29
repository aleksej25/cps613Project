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
        Me.OwnerButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RiderButton = New System.Windows.Forms.Button()
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
        Me.TitleLabel.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(39, 82)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(262, 35)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "Welcome to RentECar"
        '
        'OwnerButton
        '
        Me.OwnerButton.BackColor = System.Drawing.Color.Transparent
        Me.OwnerButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OwnerButton.Location = New System.Drawing.Point(97, 451)
        Me.OwnerButton.Name = "OwnerButton"
        Me.OwnerButton.Size = New System.Drawing.Size(144, 58)
        Me.OwnerButton.TabIndex = 2
        Me.OwnerButton.Text = "I'm a Owner"
        Me.OwnerButton.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RentECar.My.Resources.ProjectResources.start_screen_car
        Me.PictureBox2.Location = New System.Drawing.Point(72, 196)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(198, 177)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'RiderButton
        '
        Me.RiderButton.BackColor = System.Drawing.Color.Transparent
        Me.RiderButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RiderButton.Location = New System.Drawing.Point(97, 515)
        Me.RiderButton.Name = "RiderButton"
        Me.RiderButton.Size = New System.Drawing.Size(144, 58)
        Me.RiderButton.TabIndex = 5
        Me.RiderButton.Text = "I'm a Rider"
        Me.RiderButton.UseVisualStyleBackColor = False
        '
        'InitalScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.RiderButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.OwnerButton)
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
    Friend WithEvents OwnerButton As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RiderButton As Button
End Class
