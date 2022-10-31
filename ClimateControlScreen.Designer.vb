<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClimateControlScreen
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
        Me.TtileLabel = New System.Windows.Forms.Label()
        Me.FrontDefrost = New System.Windows.Forms.PictureBox()
        Me.rearDefrost = New System.Windows.Forms.PictureBox()
        Me.FrontDefrostLabel = New System.Windows.Forms.Label()
        Me.RearDefrostLabel = New System.Windows.Forms.Label()
        Me.InsideTempLabel = New System.Windows.Forms.Label()
        Me.OutsideTempLabel = New System.Windows.Forms.Label()
        Me.TemperatureSlider = New System.Windows.Forms.TrackBar()
        Me.LowerTempLabel = New System.Windows.Forms.Label()
        Me.UpperTempLabel = New System.Windows.Forms.Label()
        Me.SettingClimateLabel = New System.Windows.Forms.Label()
        Me.DriverSeat = New System.Windows.Forms.PictureBox()
        Me.PassengerSeat = New System.Windows.Forms.PictureBox()
        Me.BackLeftPass = New System.Windows.Forms.PictureBox()
        Me.BackRightPass = New System.Windows.Forms.PictureBox()
        Me.PassBLLabel = New System.Windows.Forms.Label()
        Me.PassBRLabel = New System.Windows.Forms.Label()
        Me.PassFRLabel = New System.Windows.Forms.Label()
        Me.DriverLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrontDefrost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rearDefrost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TemperatureSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverSeat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassengerSeat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackLeftPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackRightPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TtileLabel
        '
        Me.TtileLabel.AutoSize = True
        Me.TtileLabel.Font = New System.Drawing.Font("Sitka Heading", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TtileLabel.ForeColor = System.Drawing.Color.Transparent
        Me.TtileLabel.Location = New System.Drawing.Point(63, 40)
        Me.TtileLabel.Name = "TtileLabel"
        Me.TtileLabel.Size = New System.Drawing.Size(206, 39)
        Me.TtileLabel.TabIndex = 5
        Me.TtileLabel.Text = "Climate Control"
        '
        'FrontDefrost
        '
        Me.FrontDefrost.Image = Global.RentECar.My.Resources.ProjectResources.frontDefrost
        Me.FrontDefrost.Location = New System.Drawing.Point(41, 82)
        Me.FrontDefrost.Name = "FrontDefrost"
        Me.FrontDefrost.Size = New System.Drawing.Size(100, 100)
        Me.FrontDefrost.TabIndex = 6
        Me.FrontDefrost.TabStop = False
        '
        'rearDefrost
        '
        Me.rearDefrost.Image = Global.RentECar.My.Resources.ProjectResources.rearDefrost
        Me.rearDefrost.Location = New System.Drawing.Point(186, 83)
        Me.rearDefrost.Name = "rearDefrost"
        Me.rearDefrost.Size = New System.Drawing.Size(100, 100)
        Me.rearDefrost.TabIndex = 7
        Me.rearDefrost.TabStop = False
        '
        'FrontDefrostLabel
        '
        Me.FrontDefrostLabel.AutoSize = True
        Me.FrontDefrostLabel.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FrontDefrostLabel.ForeColor = System.Drawing.Color.Transparent
        Me.FrontDefrostLabel.Location = New System.Drawing.Point(63, 186)
        Me.FrontDefrostLabel.Name = "FrontDefrostLabel"
        Me.FrontDefrostLabel.Size = New System.Drawing.Size(55, 24)
        Me.FrontDefrostLabel.TabIndex = 8
        Me.FrontDefrostLabel.Text = "Front"
        '
        'RearDefrostLabel
        '
        Me.RearDefrostLabel.AutoSize = True
        Me.RearDefrostLabel.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RearDefrostLabel.ForeColor = System.Drawing.Color.Transparent
        Me.RearDefrostLabel.Location = New System.Drawing.Point(213, 186)
        Me.RearDefrostLabel.Name = "RearDefrostLabel"
        Me.RearDefrostLabel.Size = New System.Drawing.Size(47, 24)
        Me.RearDefrostLabel.TabIndex = 9
        Me.RearDefrostLabel.Text = "Rear"
        '
        'InsideTempLabel
        '
        Me.InsideTempLabel.AutoSize = True
        Me.InsideTempLabel.Font = New System.Drawing.Font("Sitka Heading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InsideTempLabel.ForeColor = System.Drawing.Color.Transparent
        Me.InsideTempLabel.Location = New System.Drawing.Point(41, 219)
        Me.InsideTempLabel.Name = "InsideTempLabel"
        Me.InsideTempLabel.Size = New System.Drawing.Size(24, 28)
        Me.InsideTempLabel.TabIndex = 10
        Me.InsideTempLabel.Text = "T"
        '
        'OutsideTempLabel
        '
        Me.OutsideTempLabel.AutoSize = True
        Me.OutsideTempLabel.Font = New System.Drawing.Font("Sitka Heading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OutsideTempLabel.ForeColor = System.Drawing.Color.Transparent
        Me.OutsideTempLabel.Location = New System.Drawing.Point(41, 257)
        Me.OutsideTempLabel.Name = "OutsideTempLabel"
        Me.OutsideTempLabel.Size = New System.Drawing.Size(24, 28)
        Me.OutsideTempLabel.TabIndex = 11
        Me.OutsideTempLabel.Text = "T"
        '
        'TemperatureSlider
        '
        Me.TemperatureSlider.Location = New System.Drawing.Point(48, 291)
        Me.TemperatureSlider.Maximum = 28
        Me.TemperatureSlider.Minimum = 16
        Me.TemperatureSlider.Name = "TemperatureSlider"
        Me.TemperatureSlider.Size = New System.Drawing.Size(230, 45)
        Me.TemperatureSlider.TabIndex = 12
        Me.TemperatureSlider.Value = 20
        '
        'LowerTempLabel
        '
        Me.LowerTempLabel.AutoSize = True
        Me.LowerTempLabel.Font = New System.Drawing.Font("Sitka Heading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LowerTempLabel.ForeColor = System.Drawing.Color.Transparent
        Me.LowerTempLabel.Location = New System.Drawing.Point(42, 324)
        Me.LowerTempLabel.Name = "LowerTempLabel"
        Me.LowerTempLabel.Size = New System.Drawing.Size(42, 28)
        Me.LowerTempLabel.TabIndex = 13
        Me.LowerTempLabel.Text = "16C"
        '
        'UpperTempLabel
        '
        Me.UpperTempLabel.AutoSize = True
        Me.UpperTempLabel.Font = New System.Drawing.Font("Sitka Heading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpperTempLabel.ForeColor = System.Drawing.Color.Transparent
        Me.UpperTempLabel.Location = New System.Drawing.Point(245, 324)
        Me.UpperTempLabel.Name = "UpperTempLabel"
        Me.UpperTempLabel.Size = New System.Drawing.Size(44, 28)
        Me.UpperTempLabel.TabIndex = 14
        Me.UpperTempLabel.Text = "28C"
        '
        'SettingClimateLabel
        '
        Me.SettingClimateLabel.AutoSize = True
        Me.SettingClimateLabel.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SettingClimateLabel.ForeColor = System.Drawing.Color.Transparent
        Me.SettingClimateLabel.Location = New System.Drawing.Point(41, 350)
        Me.SettingClimateLabel.Name = "SettingClimateLabel"
        Me.SettingClimateLabel.Size = New System.Drawing.Size(20, 23)
        Me.SettingClimateLabel.TabIndex = 15
        Me.SettingClimateLabel.Text = "T"
        Me.SettingClimateLabel.Visible = False
        '
        'DriverSeat
        '
        Me.DriverSeat.Image = Global.RentECar.My.Resources.ProjectResources.heatedSeatOff
        Me.DriverSeat.Location = New System.Drawing.Point(64, 381)
        Me.DriverSeat.Name = "DriverSeat"
        Me.DriverSeat.Size = New System.Drawing.Size(80, 80)
        Me.DriverSeat.TabIndex = 16
        Me.DriverSeat.TabStop = False
        '
        'PassengerSeat
        '
        Me.PassengerSeat.Image = Global.RentECar.My.Resources.ProjectResources.heatedSeatOff
        Me.PassengerSeat.Location = New System.Drawing.Point(186, 381)
        Me.PassengerSeat.Name = "PassengerSeat"
        Me.PassengerSeat.Size = New System.Drawing.Size(80, 80)
        Me.PassengerSeat.TabIndex = 17
        Me.PassengerSeat.TabStop = False
        '
        'BackLeftPass
        '
        Me.BackLeftPass.Image = Global.RentECar.My.Resources.ProjectResources.heatedSeatOff
        Me.BackLeftPass.Location = New System.Drawing.Point(64, 484)
        Me.BackLeftPass.Name = "BackLeftPass"
        Me.BackLeftPass.Size = New System.Drawing.Size(80, 80)
        Me.BackLeftPass.TabIndex = 18
        Me.BackLeftPass.TabStop = False
        '
        'BackRightPass
        '
        Me.BackRightPass.Image = Global.RentECar.My.Resources.ProjectResources.heatedSeatOff
        Me.BackRightPass.Location = New System.Drawing.Point(186, 484)
        Me.BackRightPass.Name = "BackRightPass"
        Me.BackRightPass.Size = New System.Drawing.Size(80, 80)
        Me.BackRightPass.TabIndex = 19
        Me.BackRightPass.TabStop = False
        '
        'PassBLLabel
        '
        Me.PassBLLabel.AutoSize = True
        Me.PassBLLabel.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PassBLLabel.ForeColor = System.Drawing.Color.Transparent
        Me.PassBLLabel.Location = New System.Drawing.Point(73, 567)
        Me.PassBLLabel.Name = "PassBLLabel"
        Me.PassBLLabel.Size = New System.Drawing.Size(68, 19)
        Me.PassBLLabel.TabIndex = 22
        Me.PassBLLabel.Text = "Passenger"
        '
        'PassBRLabel
        '
        Me.PassBRLabel.AutoSize = True
        Me.PassBRLabel.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PassBRLabel.ForeColor = System.Drawing.Color.Transparent
        Me.PassBRLabel.Location = New System.Drawing.Point(192, 567)
        Me.PassBRLabel.Name = "PassBRLabel"
        Me.PassBRLabel.Size = New System.Drawing.Size(68, 19)
        Me.PassBRLabel.TabIndex = 23
        Me.PassBRLabel.Text = "Passenger"
        '
        'PassFRLabel
        '
        Me.PassFRLabel.AutoSize = True
        Me.PassFRLabel.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PassFRLabel.ForeColor = System.Drawing.Color.Transparent
        Me.PassFRLabel.Location = New System.Drawing.Point(192, 462)
        Me.PassFRLabel.Name = "PassFRLabel"
        Me.PassFRLabel.Size = New System.Drawing.Size(68, 19)
        Me.PassFRLabel.TabIndex = 24
        Me.PassFRLabel.Text = "Passenger"
        '
        'DriverLabel
        '
        Me.DriverLabel.AutoSize = True
        Me.DriverLabel.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DriverLabel.ForeColor = System.Drawing.Color.Transparent
        Me.DriverLabel.Location = New System.Drawing.Point(82, 462)
        Me.DriverLabel.Name = "DriverLabel"
        Me.DriverLabel.Size = New System.Drawing.Size(47, 19)
        Me.DriverLabel.TabIndex = 25
        Me.DriverLabel.Text = "Driver"
        '
        'ClimateControlScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.DriverLabel)
        Me.Controls.Add(Me.PassFRLabel)
        Me.Controls.Add(Me.PassBRLabel)
        Me.Controls.Add(Me.PassBLLabel)
        Me.Controls.Add(Me.BackRightPass)
        Me.Controls.Add(Me.BackLeftPass)
        Me.Controls.Add(Me.PassengerSeat)
        Me.Controls.Add(Me.DriverSeat)
        Me.Controls.Add(Me.SettingClimateLabel)
        Me.Controls.Add(Me.UpperTempLabel)
        Me.Controls.Add(Me.LowerTempLabel)
        Me.Controls.Add(Me.TemperatureSlider)
        Me.Controls.Add(Me.OutsideTempLabel)
        Me.Controls.Add(Me.InsideTempLabel)
        Me.Controls.Add(Me.RearDefrostLabel)
        Me.Controls.Add(Me.FrontDefrostLabel)
        Me.Controls.Add(Me.rearDefrost)
        Me.Controls.Add(Me.FrontDefrost)
        Me.Controls.Add(Me.TtileLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ClimateControlScreen"
        Me.Size = New System.Drawing.Size(335, 641)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrontDefrost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rearDefrost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TemperatureSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverSeat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassengerSeat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackLeftPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackRightPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TtileLabel As Label
    Friend WithEvents FrontDefrost As PictureBox
    Friend WithEvents rearDefrost As PictureBox
    Friend WithEvents FrontDefrostLabel As Label
    Friend WithEvents RearDefrostLabel As Label
    Friend WithEvents InsideTempLabel As Label
    Friend WithEvents OutsideTempLabel As Label
    Friend WithEvents TemperatureSlider As TrackBar
    Friend WithEvents LowerTempLabel As Label
    Friend WithEvents UpperTempLabel As Label
    Friend WithEvents SettingClimateLabel As Label
    Friend WithEvents DriverSeat As PictureBox
    Friend WithEvents PassengerSeat As PictureBox
    Friend WithEvents BackLeftPass As PictureBox
    Friend WithEvents BackRightPass As PictureBox
    Friend WithEvents PassBLLabel As Label
    Friend WithEvents PassBRLabel As Label
    Friend WithEvents PassFRLabel As Label
    Friend WithEvents DriverLabel As Label
End Class
