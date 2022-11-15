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
        Me.riderButton = New System.Windows.Forms.Button()
        Me.ownerButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'riderButton
        '
        Me.riderButton.Font = New System.Drawing.Font("Sitka Display", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.riderButton.Location = New System.Drawing.Point(110, 504)
        Me.riderButton.Name = "riderButton"
        Me.riderButton.Size = New System.Drawing.Size(111, 51)
        Me.riderButton.TabIndex = 7
        Me.riderButton.Text = "Rider"
        Me.riderButton.UseVisualStyleBackColor = True
        '
        'ownerButton
        '
        Me.ownerButton.Font = New System.Drawing.Font("Sitka Display", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ownerButton.Location = New System.Drawing.Point(110, 433)
        Me.ownerButton.Name = "ownerButton"
        Me.ownerButton.Size = New System.Drawing.Size(111, 51)
        Me.ownerButton.TabIndex = 8
        Me.ownerButton.Text = "Owner"
        Me.ownerButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(129, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "I'm a"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'InitalScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ownerButton)
        Me.Controls.Add(Me.riderButton)
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
    Friend WithEvents riderButton As Button
    Friend WithEvents ownerButton As Button
    Friend WithEvents Label1 As Label
End Class
