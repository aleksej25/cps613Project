<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RiderMainScreen
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.RiderMainTitleLabel = New System.Windows.Forms.Label()
        Me.BookTripButton = New System.Windows.Forms.Button()
        Me.ModifyTripButton = New System.Windows.Forms.Button()
        Me.RiderCarControl = New System.Windows.Forms.Button()
        Me.RiderRatingsButton = New System.Windows.Forms.Button()
        Me.CurrentStatusLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(40, 38)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 9
        Me.BackBox.TabStop = False
        '
        'RiderMainTitleLabel
        '
        Me.RiderMainTitleLabel.AutoSize = True
        Me.RiderMainTitleLabel.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RiderMainTitleLabel.ForeColor = System.Drawing.Color.White
        Me.RiderMainTitleLabel.Location = New System.Drawing.Point(101, 43)
        Me.RiderMainTitleLabel.Name = "RiderMainTitleLabel"
        Me.RiderMainTitleLabel.Size = New System.Drawing.Size(195, 35)
        Me.RiderMainTitleLabel.TabIndex = 10
        Me.RiderMainTitleLabel.Text = "Welcome Rider!"
        '
        'BookTripButton
        '
        Me.BookTripButton.Location = New System.Drawing.Point(128, 231)
        Me.BookTripButton.Name = "BookTripButton"
        Me.BookTripButton.Size = New System.Drawing.Size(75, 23)
        Me.BookTripButton.TabIndex = 11
        Me.BookTripButton.Text = "Book a trip"
        Me.BookTripButton.UseVisualStyleBackColor = True
        '
        'ModifyTripButton
        '
        Me.ModifyTripButton.Location = New System.Drawing.Point(128, 289)
        Me.ModifyTripButton.Name = "ModifyTripButton"
        Me.ModifyTripButton.Size = New System.Drawing.Size(75, 23)
        Me.ModifyTripButton.TabIndex = 12
        Me.ModifyTripButton.Text = "Modify Trip"
        Me.ModifyTripButton.UseVisualStyleBackColor = True
        '
        'RiderCarControl
        '
        Me.RiderCarControl.Location = New System.Drawing.Point(128, 355)
        Me.RiderCarControl.Name = "RiderCarControl"
        Me.RiderCarControl.Size = New System.Drawing.Size(75, 23)
        Me.RiderCarControl.TabIndex = 13
        Me.RiderCarControl.Text = "Car controls"
        Me.RiderCarControl.UseVisualStyleBackColor = True
        '
        'RiderRatingsButton
        '
        Me.RiderRatingsButton.Location = New System.Drawing.Point(128, 427)
        Me.RiderRatingsButton.Name = "RiderRatingsButton"
        Me.RiderRatingsButton.Size = New System.Drawing.Size(75, 23)
        Me.RiderRatingsButton.TabIndex = 14
        Me.RiderRatingsButton.Text = "Ratings"
        Me.RiderRatingsButton.UseVisualStyleBackColor = True
        '
        'CurrentStatusLabel
        '
        Me.CurrentStatusLabel.AutoSize = True
        Me.CurrentStatusLabel.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CurrentStatusLabel.ForeColor = System.Drawing.Color.White
        Me.CurrentStatusLabel.Location = New System.Drawing.Point(40, 124)
        Me.CurrentStatusLabel.Name = "CurrentStatusLabel"
        Me.CurrentStatusLabel.Size = New System.Drawing.Size(146, 28)
        Me.CurrentStatusLabel.TabIndex = 15
        Me.CurrentStatusLabel.Text = "Current status:"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StatusLabel.ForeColor = System.Drawing.Color.Red
        Me.StatusLabel.Location = New System.Drawing.Point(187, 124)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(109, 28)
        Me.StatusLabel.TabIndex = 16
        Me.StatusLabel.Text = "Not on trip"
        '
        'RiderMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.CurrentStatusLabel)
        Me.Controls.Add(Me.RiderRatingsButton)
        Me.Controls.Add(Me.RiderCarControl)
        Me.Controls.Add(Me.ModifyTripButton)
        Me.Controls.Add(Me.BookTripButton)
        Me.Controls.Add(Me.RiderMainTitleLabel)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "RiderMainScreen"
        Me.Size = New System.Drawing.Size(338, 642)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackBox As PictureBox
    Friend WithEvents RiderMainTitleLabel As Label
    Friend WithEvents BookTripButton As Button
    Friend WithEvents ModifyTripButton As Button
    Friend WithEvents RiderCarControl As Button
    Friend WithEvents RiderRatingsButton As Button
    Friend WithEvents CurrentStatusLabel As Label
    Friend WithEvents StatusLabel As Label
End Class
