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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.FrontDefrost = New System.Windows.Forms.PictureBox()
        Me.rearDefrost = New System.Windows.Forms.PictureBox()
        Me.FrontDefrostLabel = New System.Windows.Forms.Label()
        Me.RearDefrostLabel = New System.Windows.Forms.Label()
        Me.DriverSeat = New System.Windows.Forms.PictureBox()
        Me.PassengerSeat = New System.Windows.Forms.PictureBox()
        Me.BackLeftPass = New System.Windows.Forms.PictureBox()
        Me.BackRightPass = New System.Windows.Forms.PictureBox()
        Me.PassBLLabel = New System.Windows.Forms.Label()
        Me.PassBRLabel = New System.Windows.Forms.Label()
        Me.PassFRLabel = New System.Windows.Forms.Label()
        Me.DriverLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrontDefrost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rearDefrost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverSeat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassengerSeat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackLeftPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackRightPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Sitka Heading", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Location = New System.Drawing.Point(64, 52)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(206, 39)
        Me.TitleLabel.TabIndex = 5
        Me.TitleLabel.Text = "Climate Control"
        '
        'FrontDefrost
        '
        Me.FrontDefrost.Image = Global.RentECar.My.Resources.ProjectResources.frontDefrost
        Me.FrontDefrost.Location = New System.Drawing.Point(44, 221)
        Me.FrontDefrost.Name = "FrontDefrost"
        Me.FrontDefrost.Size = New System.Drawing.Size(100, 100)
        Me.FrontDefrost.TabIndex = 6
        Me.FrontDefrost.TabStop = False
        '
        'rearDefrost
        '
        Me.rearDefrost.Image = Global.RentECar.My.Resources.ProjectResources.rearDefrost
        Me.rearDefrost.Location = New System.Drawing.Point(189, 222)
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
        Me.FrontDefrostLabel.Location = New System.Drawing.Point(66, 325)
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
        Me.RearDefrostLabel.Location = New System.Drawing.Point(216, 325)
        Me.RearDefrostLabel.Name = "RearDefrostLabel"
        Me.RearDefrostLabel.Size = New System.Drawing.Size(47, 24)
        Me.RearDefrostLabel.TabIndex = 9
        Me.RearDefrostLabel.Text = "Rear"
        '
        'DriverSeat
        '
        Me.DriverSeat.Image = Global.RentECar.My.Resources.ProjectResources.heatedSeatOff
        Me.DriverSeat.Location = New System.Drawing.Point(64, 360)
        Me.DriverSeat.Name = "DriverSeat"
        Me.DriverSeat.Size = New System.Drawing.Size(80, 80)
        Me.DriverSeat.TabIndex = 16
        Me.DriverSeat.TabStop = False
        '
        'PassengerSeat
        '
        Me.PassengerSeat.Image = Global.RentECar.My.Resources.ProjectResources.heatedSeatOff
        Me.PassengerSeat.Location = New System.Drawing.Point(186, 360)
        Me.PassengerSeat.Name = "PassengerSeat"
        Me.PassengerSeat.Size = New System.Drawing.Size(80, 80)
        Me.PassengerSeat.TabIndex = 17
        Me.PassengerSeat.TabStop = False
        '
        'BackLeftPass
        '
        Me.BackLeftPass.Image = Global.RentECar.My.Resources.ProjectResources.heatedSeatOff
        Me.BackLeftPass.Location = New System.Drawing.Point(64, 463)
        Me.BackLeftPass.Name = "BackLeftPass"
        Me.BackLeftPass.Size = New System.Drawing.Size(80, 80)
        Me.BackLeftPass.TabIndex = 18
        Me.BackLeftPass.TabStop = False
        '
        'BackRightPass
        '
        Me.BackRightPass.Image = Global.RentECar.My.Resources.ProjectResources.heatedSeatOff
        Me.BackRightPass.Location = New System.Drawing.Point(186, 463)
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
        Me.PassBLLabel.Location = New System.Drawing.Point(73, 546)
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
        Me.PassBRLabel.Location = New System.Drawing.Point(192, 546)
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
        Me.PassFRLabel.Location = New System.Drawing.Point(192, 441)
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
        Me.DriverLabel.Location = New System.Drawing.Point(82, 441)
        Me.DriverLabel.Name = "DriverLabel"
        Me.DriverLabel.Size = New System.Drawing.Size(47, 19)
        Me.DriverLabel.TabIndex = 25
        Me.DriverLabel.Text = "Driver"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RentECar.My.Resources.ProjectResources.ac_icon
        Me.PictureBox2.Location = New System.Drawing.Point(111, 98)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'ClimateControlScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DriverLabel)
        Me.Controls.Add(Me.PassFRLabel)
        Me.Controls.Add(Me.PassBRLabel)
        Me.Controls.Add(Me.PassBLLabel)
        Me.Controls.Add(Me.BackRightPass)
        Me.Controls.Add(Me.BackLeftPass)
        Me.Controls.Add(Me.PassengerSeat)
        Me.Controls.Add(Me.DriverSeat)
        Me.Controls.Add(Me.RearDefrostLabel)
        Me.Controls.Add(Me.FrontDefrostLabel)
        Me.Controls.Add(Me.rearDefrost)
        Me.Controls.Add(Me.FrontDefrost)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ClimateControlScreen"
        Me.Size = New System.Drawing.Size(335, 641)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrontDefrost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rearDefrost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverSeat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassengerSeat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackLeftPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackRightPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents FrontDefrost As PictureBox
    Friend WithEvents rearDefrost As PictureBox
    Friend WithEvents FrontDefrostLabel As Label
    Friend WithEvents RearDefrostLabel As Label
    Friend WithEvents DriverSeat As PictureBox
    Friend WithEvents PassengerSeat As PictureBox
    Friend WithEvents BackLeftPass As PictureBox
    Friend WithEvents BackRightPass As PictureBox
    Friend WithEvents PassBLLabel As Label
    Friend WithEvents PassBRLabel As Label
    Friend WithEvents PassFRLabel As Label
    Friend WithEvents DriverLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
