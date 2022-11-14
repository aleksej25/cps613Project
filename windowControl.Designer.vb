<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class windowControl
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
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.passBLDown = New System.Windows.Forms.PictureBox()
        Me.passBLUp = New System.Windows.Forms.PictureBox()
        Me.passBLTrackBar = New System.Windows.Forms.TrackBar()
        Me.passBRDown = New System.Windows.Forms.PictureBox()
        Me.passBRUp = New System.Windows.Forms.PictureBox()
        Me.passBRTrackBar = New System.Windows.Forms.TrackBar()
        Me.passFDown = New System.Windows.Forms.PictureBox()
        Me.passFUp = New System.Windows.Forms.PictureBox()
        Me.passFTrackBar = New System.Windows.Forms.TrackBar()
        Me.driverDown = New System.Windows.Forms.PictureBox()
        Me.driveUp = New System.Windows.Forms.PictureBox()
        Me.driverTrackBar = New System.Windows.Forms.TrackBar()
        Me.passengerBLWLabel = New System.Windows.Forms.Label()
        Me.passengerBRWLabel = New System.Windows.Forms.Label()
        Me.passengerWLabel = New System.Windows.Forms.Label()
        Me.driverWLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passBLDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passBLUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passBLTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passBRDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passBRUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passBRTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passFDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passFUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passFTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.driverDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.driveUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.driverTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(35, 28)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 30
        Me.BackBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'passBLDown
        '
        Me.passBLDown.Image = Global.RentECar.My.Resources.ProjectResources.windowDown
        Me.passBLDown.Location = New System.Drawing.Point(193, 362)
        Me.passBLDown.Name = "passBLDown"
        Me.passBLDown.Size = New System.Drawing.Size(100, 50)
        Me.passBLDown.TabIndex = 39
        Me.passBLDown.TabStop = False
        '
        'passBLUp
        '
        Me.passBLUp.Image = Global.RentECar.My.Resources.ProjectResources.windowUp
        Me.passBLUp.Location = New System.Drawing.Point(193, 311)
        Me.passBLUp.Name = "passBLUp"
        Me.passBLUp.Size = New System.Drawing.Size(100, 50)
        Me.passBLUp.TabIndex = 38
        Me.passBLUp.TabStop = False
        '
        'passBLTrackBar
        '
        Me.passBLTrackBar.Enabled = False
        Me.passBLTrackBar.Location = New System.Drawing.Point(166, 308)
        Me.passBLTrackBar.Name = "passBLTrackBar"
        Me.passBLTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.passBLTrackBar.Size = New System.Drawing.Size(45, 104)
        Me.passBLTrackBar.TabIndex = 47
        Me.passBLTrackBar.Value = 10
        '
        'passBRDown
        '
        Me.passBRDown.Image = Global.RentECar.My.Resources.ProjectResources.windowDown
        Me.passBRDown.Location = New System.Drawing.Point(60, 362)
        Me.passBRDown.Name = "passBRDown"
        Me.passBRDown.Size = New System.Drawing.Size(100, 50)
        Me.passBRDown.TabIndex = 37
        Me.passBRDown.TabStop = False
        '
        'passBRUp
        '
        Me.passBRUp.Image = Global.RentECar.My.Resources.ProjectResources.windowUp
        Me.passBRUp.Location = New System.Drawing.Point(60, 311)
        Me.passBRUp.Name = "passBRUp"
        Me.passBRUp.Size = New System.Drawing.Size(100, 50)
        Me.passBRUp.TabIndex = 36
        Me.passBRUp.TabStop = False
        '
        'passBRTrackBar
        '
        Me.passBRTrackBar.Enabled = False
        Me.passBRTrackBar.Location = New System.Drawing.Point(30, 311)
        Me.passBRTrackBar.Name = "passBRTrackBar"
        Me.passBRTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.passBRTrackBar.Size = New System.Drawing.Size(45, 104)
        Me.passBRTrackBar.TabIndex = 46
        Me.passBRTrackBar.Value = 10
        '
        'passFDown
        '
        Me.passFDown.Image = Global.RentECar.My.Resources.ProjectResources.windowDown
        Me.passFDown.Location = New System.Drawing.Point(193, 221)
        Me.passFDown.Name = "passFDown"
        Me.passFDown.Size = New System.Drawing.Size(100, 50)
        Me.passFDown.TabIndex = 35
        Me.passFDown.TabStop = False
        '
        'passFUp
        '
        Me.passFUp.Image = Global.RentECar.My.Resources.ProjectResources.windowUp
        Me.passFUp.Location = New System.Drawing.Point(193, 170)
        Me.passFUp.Name = "passFUp"
        Me.passFUp.Size = New System.Drawing.Size(100, 50)
        Me.passFUp.TabIndex = 34
        Me.passFUp.TabStop = False
        '
        'passFTrackBar
        '
        Me.passFTrackBar.Enabled = False
        Me.passFTrackBar.Location = New System.Drawing.Point(162, 170)
        Me.passFTrackBar.Name = "passFTrackBar"
        Me.passFTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.passFTrackBar.Size = New System.Drawing.Size(45, 104)
        Me.passFTrackBar.TabIndex = 45
        Me.passFTrackBar.Value = 10
        '
        'driverDown
        '
        Me.driverDown.Image = Global.RentECar.My.Resources.ProjectResources.windowDown
        Me.driverDown.Location = New System.Drawing.Point(60, 221)
        Me.driverDown.Name = "driverDown"
        Me.driverDown.Size = New System.Drawing.Size(100, 50)
        Me.driverDown.TabIndex = 33
        Me.driverDown.TabStop = False
        '
        'driveUp
        '
        Me.driveUp.Image = Global.RentECar.My.Resources.ProjectResources.windowUp
        Me.driveUp.Location = New System.Drawing.Point(60, 170)
        Me.driveUp.Name = "driveUp"
        Me.driveUp.Size = New System.Drawing.Size(100, 50)
        Me.driveUp.TabIndex = 32
        Me.driveUp.TabStop = False
        '
        'driverTrackBar
        '
        Me.driverTrackBar.Enabled = False
        Me.driverTrackBar.Location = New System.Drawing.Point(30, 170)
        Me.driverTrackBar.Name = "driverTrackBar"
        Me.driverTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.driverTrackBar.Size = New System.Drawing.Size(45, 104)
        Me.driverTrackBar.TabIndex = 44
        Me.driverTrackBar.Value = 10
        '
        'passengerBLWLabel
        '
        Me.passengerBLWLabel.AutoSize = True
        Me.passengerBLWLabel.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.passengerBLWLabel.ForeColor = System.Drawing.Color.Transparent
        Me.passengerBLWLabel.Location = New System.Drawing.Point(193, 287)
        Me.passengerBLWLabel.Name = "passengerBLWLabel"
        Me.passengerBLWLabel.Size = New System.Drawing.Size(79, 21)
        Me.passengerBLWLabel.TabIndex = 43
        Me.passengerBLWLabel.Text = "Passenger"
        '
        'passengerBRWLabel
        '
        Me.passengerBRWLabel.AutoSize = True
        Me.passengerBRWLabel.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.passengerBRWLabel.ForeColor = System.Drawing.Color.Transparent
        Me.passengerBRWLabel.Location = New System.Drawing.Point(61, 287)
        Me.passengerBRWLabel.Name = "passengerBRWLabel"
        Me.passengerBRWLabel.Size = New System.Drawing.Size(79, 21)
        Me.passengerBRWLabel.TabIndex = 42
        Me.passengerBRWLabel.Text = "Passenger"
        '
        'passengerWLabel
        '
        Me.passengerWLabel.AutoSize = True
        Me.passengerWLabel.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.passengerWLabel.ForeColor = System.Drawing.Color.Transparent
        Me.passengerWLabel.Location = New System.Drawing.Point(193, 146)
        Me.passengerWLabel.Name = "passengerWLabel"
        Me.passengerWLabel.Size = New System.Drawing.Size(79, 21)
        Me.passengerWLabel.TabIndex = 41
        Me.passengerWLabel.Text = "Passenger"
        '
        'driverWLabel
        '
        Me.driverWLabel.AutoSize = True
        Me.driverWLabel.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.driverWLabel.ForeColor = System.Drawing.Color.Transparent
        Me.driverWLabel.Location = New System.Drawing.Point(61, 146)
        Me.driverWLabel.Name = "driverWLabel"
        Me.driverWLabel.Size = New System.Drawing.Size(54, 21)
        Me.driverWLabel.TabIndex = 40
        Me.driverWLabel.Text = "Driver"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Sitka Heading", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Location = New System.Drawing.Point(61, 71)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(200, 35)
        Me.TitleLabel.TabIndex = 48
        Me.TitleLabel.Text = "Window Controls"
        '
        'windowControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.passBLDown)
        Me.Controls.Add(Me.passBLUp)
        Me.Controls.Add(Me.passBLTrackBar)
        Me.Controls.Add(Me.passBRDown)
        Me.Controls.Add(Me.passBRUp)
        Me.Controls.Add(Me.passBRTrackBar)
        Me.Controls.Add(Me.passFDown)
        Me.Controls.Add(Me.passFUp)
        Me.Controls.Add(Me.passFTrackBar)
        Me.Controls.Add(Me.driverDown)
        Me.Controls.Add(Me.driveUp)
        Me.Controls.Add(Me.driverTrackBar)
        Me.Controls.Add(Me.passengerBLWLabel)
        Me.Controls.Add(Me.passengerBRWLabel)
        Me.Controls.Add(Me.passengerWLabel)
        Me.Controls.Add(Me.driverWLabel)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "windowControl"
        Me.Size = New System.Drawing.Size(337, 643)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passBLDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passBLUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passBLTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passBRDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passBRUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passBRTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passFDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passFUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passFTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.driverDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.driveUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.driverTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents passBLDown As PictureBox
    Friend WithEvents passBLUp As PictureBox
    Friend WithEvents passBLTrackBar As TrackBar
    Friend WithEvents passBRDown As PictureBox
    Friend WithEvents passBRUp As PictureBox
    Friend WithEvents passBRTrackBar As TrackBar
    Friend WithEvents passFDown As PictureBox
    Friend WithEvents passFUp As PictureBox
    Friend WithEvents passFTrackBar As TrackBar
    Friend WithEvents driverDown As PictureBox
    Friend WithEvents driveUp As PictureBox
    Friend WithEvents driverTrackBar As TrackBar
    Friend WithEvents passengerBLWLabel As Label
    Friend WithEvents passengerBRWLabel As Label
    Friend WithEvents passengerWLabel As Label
    Friend WithEvents driverWLabel As Label
    Friend WithEvents TitleLabel As Label
End Class
