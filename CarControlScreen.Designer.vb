<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarControlScreen
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
        Me.TtileLabel = New System.Windows.Forms.Label()
        Me.trunkBox = New System.Windows.Forms.PictureBox()
        Me.trunkOCLabel = New System.Windows.Forms.Label()
        Me.driveUp = New System.Windows.Forms.PictureBox()
        Me.driverDown = New System.Windows.Forms.PictureBox()
        Me.passFDown = New System.Windows.Forms.PictureBox()
        Me.passFUp = New System.Windows.Forms.PictureBox()
        Me.passBRDown = New System.Windows.Forms.PictureBox()
        Me.passBRUp = New System.Windows.Forms.PictureBox()
        Me.passBLDown = New System.Windows.Forms.PictureBox()
        Me.passBLUp = New System.Windows.Forms.PictureBox()
        Me.driverWLabel = New System.Windows.Forms.Label()
        Me.passengerWLabel = New System.Windows.Forms.Label()
        Me.passengerBRWLabel = New System.Windows.Forms.Label()
        Me.passengerBLWLabel = New System.Windows.Forms.Label()
        Me.driverTrackBar = New System.Windows.Forms.TrackBar()
        Me.passFTrackBar = New System.Windows.Forms.TrackBar()
        Me.passBRTrackBar = New System.Windows.Forms.TrackBar()
        Me.passBLTrackBar = New System.Windows.Forms.TrackBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trunkBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.driveUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.driverDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passFDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passFUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passBRDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passBRUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passBLDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passBLUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.driverTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passFTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passBRTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passBLTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(36, 32)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 7
        Me.BackBox.TabStop = False
        '
        'TtileLabel
        '
        Me.TtileLabel.AutoSize = True
        Me.TtileLabel.Font = New System.Drawing.Font("Sitka Heading", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TtileLabel.ForeColor = System.Drawing.Color.Transparent
        Me.TtileLabel.Location = New System.Drawing.Point(72, 65)
        Me.TtileLabel.Name = "TtileLabel"
        Me.TtileLabel.Size = New System.Drawing.Size(184, 39)
        Me.TtileLabel.TabIndex = 13
        Me.TtileLabel.Text = "ECar Controls"
        '
        'trunkBox
        '
        Me.trunkBox.Image = Global.RentECar.My.Resources.ProjectResources.openTrunk
        Me.trunkBox.Location = New System.Drawing.Point(105, 107)
        Me.trunkBox.Name = "trunkBox"
        Me.trunkBox.Size = New System.Drawing.Size(110, 110)
        Me.trunkBox.TabIndex = 14
        Me.trunkBox.TabStop = False
        '
        'trunkOCLabel
        '
        Me.trunkOCLabel.AutoSize = True
        Me.trunkOCLabel.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.trunkOCLabel.ForeColor = System.Drawing.Color.Transparent
        Me.trunkOCLabel.Location = New System.Drawing.Point(108, 220)
        Me.trunkOCLabel.Name = "trunkOCLabel"
        Me.trunkOCLabel.Size = New System.Drawing.Size(104, 23)
        Me.trunkOCLabel.TabIndex = 15
        Me.trunkOCLabel.Text = "Trunk Closed"
        '
        'driveUp
        '
        Me.driveUp.Image = Global.RentECar.My.Resources.ProjectResources.windowUp
        Me.driveUp.Location = New System.Drawing.Point(57, 296)
        Me.driveUp.Name = "driveUp"
        Me.driveUp.Size = New System.Drawing.Size(100, 50)
        Me.driveUp.TabIndex = 16
        Me.driveUp.TabStop = False
        '
        'driverDown
        '
        Me.driverDown.Image = Global.RentECar.My.Resources.ProjectResources.windowDown
        Me.driverDown.Location = New System.Drawing.Point(57, 347)
        Me.driverDown.Name = "driverDown"
        Me.driverDown.Size = New System.Drawing.Size(100, 50)
        Me.driverDown.TabIndex = 17
        Me.driverDown.TabStop = False
        '
        'passFDown
        '
        Me.passFDown.Image = Global.RentECar.My.Resources.ProjectResources.windowDown
        Me.passFDown.Location = New System.Drawing.Point(190, 347)
        Me.passFDown.Name = "passFDown"
        Me.passFDown.Size = New System.Drawing.Size(100, 50)
        Me.passFDown.TabIndex = 19
        Me.passFDown.TabStop = False
        '
        'passFUp
        '
        Me.passFUp.Image = Global.RentECar.My.Resources.ProjectResources.windowUp
        Me.passFUp.Location = New System.Drawing.Point(190, 296)
        Me.passFUp.Name = "passFUp"
        Me.passFUp.Size = New System.Drawing.Size(100, 50)
        Me.passFUp.TabIndex = 18
        Me.passFUp.TabStop = False
        '
        'passBRDown
        '
        Me.passBRDown.Image = Global.RentECar.My.Resources.ProjectResources.windowDown
        Me.passBRDown.Location = New System.Drawing.Point(57, 488)
        Me.passBRDown.Name = "passBRDown"
        Me.passBRDown.Size = New System.Drawing.Size(100, 50)
        Me.passBRDown.TabIndex = 21
        Me.passBRDown.TabStop = False
        '
        'passBRUp
        '
        Me.passBRUp.Image = Global.RentECar.My.Resources.ProjectResources.windowUp
        Me.passBRUp.Location = New System.Drawing.Point(57, 437)
        Me.passBRUp.Name = "passBRUp"
        Me.passBRUp.Size = New System.Drawing.Size(100, 50)
        Me.passBRUp.TabIndex = 20
        Me.passBRUp.TabStop = False
        '
        'passBLDown
        '
        Me.passBLDown.Image = Global.RentECar.My.Resources.ProjectResources.windowDown
        Me.passBLDown.Location = New System.Drawing.Point(190, 488)
        Me.passBLDown.Name = "passBLDown"
        Me.passBLDown.Size = New System.Drawing.Size(100, 50)
        Me.passBLDown.TabIndex = 23
        Me.passBLDown.TabStop = False
        '
        'passBLUp
        '
        Me.passBLUp.Image = Global.RentECar.My.Resources.ProjectResources.windowUp
        Me.passBLUp.Location = New System.Drawing.Point(190, 437)
        Me.passBLUp.Name = "passBLUp"
        Me.passBLUp.Size = New System.Drawing.Size(100, 50)
        Me.passBLUp.TabIndex = 22
        Me.passBLUp.TabStop = False
        '
        'driverWLabel
        '
        Me.driverWLabel.AutoSize = True
        Me.driverWLabel.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.driverWLabel.ForeColor = System.Drawing.Color.Transparent
        Me.driverWLabel.Location = New System.Drawing.Point(58, 272)
        Me.driverWLabel.Name = "driverWLabel"
        Me.driverWLabel.Size = New System.Drawing.Size(54, 21)
        Me.driverWLabel.TabIndex = 24
        Me.driverWLabel.Text = "Driver"
        '
        'passengerWLabel
        '
        Me.passengerWLabel.AutoSize = True
        Me.passengerWLabel.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.passengerWLabel.ForeColor = System.Drawing.Color.Transparent
        Me.passengerWLabel.Location = New System.Drawing.Point(190, 272)
        Me.passengerWLabel.Name = "passengerWLabel"
        Me.passengerWLabel.Size = New System.Drawing.Size(79, 21)
        Me.passengerWLabel.TabIndex = 25
        Me.passengerWLabel.Text = "Passenger"
        '
        'passengerBRWLabel
        '
        Me.passengerBRWLabel.AutoSize = True
        Me.passengerBRWLabel.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.passengerBRWLabel.ForeColor = System.Drawing.Color.Transparent
        Me.passengerBRWLabel.Location = New System.Drawing.Point(58, 413)
        Me.passengerBRWLabel.Name = "passengerBRWLabel"
        Me.passengerBRWLabel.Size = New System.Drawing.Size(79, 21)
        Me.passengerBRWLabel.TabIndex = 26
        Me.passengerBRWLabel.Text = "Passenger"
        '
        'passengerBLWLabel
        '
        Me.passengerBLWLabel.AutoSize = True
        Me.passengerBLWLabel.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.passengerBLWLabel.ForeColor = System.Drawing.Color.Transparent
        Me.passengerBLWLabel.Location = New System.Drawing.Point(190, 413)
        Me.passengerBLWLabel.Name = "passengerBLWLabel"
        Me.passengerBLWLabel.Size = New System.Drawing.Size(79, 21)
        Me.passengerBLWLabel.TabIndex = 27
        Me.passengerBLWLabel.Text = "Passenger"
        '
        'driverTrackBar
        '
        Me.driverTrackBar.Enabled = False
        Me.driverTrackBar.Location = New System.Drawing.Point(27, 296)
        Me.driverTrackBar.Name = "driverTrackBar"
        Me.driverTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.driverTrackBar.Size = New System.Drawing.Size(45, 104)
        Me.driverTrackBar.TabIndex = 28
        Me.driverTrackBar.Value = 10
        '
        'passFTrackBar
        '
        Me.passFTrackBar.Enabled = False
        Me.passFTrackBar.Location = New System.Drawing.Point(159, 296)
        Me.passFTrackBar.Name = "passFTrackBar"
        Me.passFTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.passFTrackBar.Size = New System.Drawing.Size(45, 104)
        Me.passFTrackBar.TabIndex = 29
        Me.passFTrackBar.Value = 10
        '
        'passBRTrackBar
        '
        Me.passBRTrackBar.Enabled = False
        Me.passBRTrackBar.Location = New System.Drawing.Point(27, 434)
        Me.passBRTrackBar.Name = "passBRTrackBar"
        Me.passBRTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.passBRTrackBar.Size = New System.Drawing.Size(45, 104)
        Me.passBRTrackBar.TabIndex = 30
        Me.passBRTrackBar.Value = 10
        '
        'passBLTrackBar
        '
        Me.passBLTrackBar.Enabled = False
        Me.passBLTrackBar.Location = New System.Drawing.Point(163, 434)
        Me.passBLTrackBar.Name = "passBLTrackBar"
        Me.passBLTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.passBLTrackBar.Size = New System.Drawing.Size(45, 104)
        Me.passBLTrackBar.TabIndex = 31
        Me.passBLTrackBar.Value = 10
        '
        'CarControlScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
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
        Me.Controls.Add(Me.trunkOCLabel)
        Me.Controls.Add(Me.trunkBox)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.TtileLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CarControlScreen"
        Me.Size = New System.Drawing.Size(335, 642)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trunkBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.driveUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.driverDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passFDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passFUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passBRDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passBRUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passBLDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passBLUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.driverTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passFTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passBRTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passBLTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackBox As PictureBox
    Friend WithEvents TtileLabel As Label
    Friend WithEvents trunkBox As PictureBox
    Friend WithEvents trunkOCLabel As Label
    Friend WithEvents driveUp As PictureBox
    Friend WithEvents driverDown As PictureBox
    Friend WithEvents passFDown As PictureBox
    Friend WithEvents passFUp As PictureBox
    Friend WithEvents passBRDown As PictureBox
    Friend WithEvents passBRUp As PictureBox
    Friend WithEvents passBLDown As PictureBox
    Friend WithEvents passBLUp As PictureBox
    Friend WithEvents driverWLabel As Label
    Friend WithEvents passengerWLabel As Label
    Friend WithEvents passengerBRWLabel As Label
    Friend WithEvents passengerBLWLabel As Label
    Friend WithEvents driverTrackBar As TrackBar
    Friend WithEvents passFTrackBar As TrackBar
    Friend WithEvents passBRTrackBar As TrackBar
    Friend WithEvents passBLTrackBar As TrackBar
End Class
