<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MediaControls
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
        Me.components = New System.ComponentModel.Container()
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TtileLabel = New System.Windows.Forms.Label()
        Me.ConnectingLabel = New System.Windows.Forms.Label()
        Me.ConnectionProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.AudioBox = New System.Windows.Forms.PictureBox()
        Me.RadioStationLabel = New System.Windows.Forms.Label()
        Me.plusBox = New System.Windows.Forms.PictureBox()
        Me.minusBox = New System.Windows.Forms.PictureBox()
        Me.radioPlayingBox = New System.Windows.Forms.PictureBox()
        Me.audioLevelLabel = New System.Windows.Forms.Label()
        Me.bluetoothBox = New System.Windows.Forms.Button()
        Me.RadioBox = New System.Windows.Forms.Button()
        Me.zeroLabel = New System.Windows.Forms.Label()
        Me.tenLabel = New System.Windows.Forms.Label()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AudioBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plusBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minusBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioPlayingBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(36, 32)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 9
        Me.BackBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TtileLabel
        '
        Me.TtileLabel.AutoSize = True
        Me.TtileLabel.Font = New System.Drawing.Font("Sitka Heading", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TtileLabel.ForeColor = System.Drawing.Color.Transparent
        Me.TtileLabel.Location = New System.Drawing.Point(82, 57)
        Me.TtileLabel.Name = "TtileLabel"
        Me.TtileLabel.Size = New System.Drawing.Size(187, 39)
        Me.TtileLabel.TabIndex = 12
        Me.TtileLabel.Text = "Media Control"
        '
        'ConnectingLabel
        '
        Me.ConnectingLabel.AutoSize = True
        Me.ConnectingLabel.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ConnectingLabel.ForeColor = System.Drawing.Color.Transparent
        Me.ConnectingLabel.Location = New System.Drawing.Point(103, 195)
        Me.ConnectingLabel.Name = "ConnectingLabel"
        Me.ConnectingLabel.Size = New System.Drawing.Size(20, 23)
        Me.ConnectingLabel.TabIndex = 13
        Me.ConnectingLabel.Text = "T"
        Me.ConnectingLabel.Visible = False
        '
        'ConnectionProgressBar
        '
        Me.ConnectionProgressBar.Location = New System.Drawing.Point(112, 225)
        Me.ConnectionProgressBar.Maximum = 60
        Me.ConnectionProgressBar.Name = "ConnectionProgressBar"
        Me.ConnectionProgressBar.Size = New System.Drawing.Size(103, 23)
        Me.ConnectionProgressBar.TabIndex = 14
        Me.ConnectionProgressBar.Visible = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(63, 258)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(206, 45)
        Me.TrackBar1.TabIndex = 15
        '
        'AudioBox
        '
        Me.AudioBox.Image = Global.RentECar.My.Resources.ProjectResources.audioMute
        Me.AudioBox.Location = New System.Drawing.Point(121, 300)
        Me.AudioBox.Name = "AudioBox"
        Me.AudioBox.Size = New System.Drawing.Size(85, 85)
        Me.AudioBox.TabIndex = 16
        Me.AudioBox.TabStop = False
        '
        'RadioStationLabel
        '
        Me.RadioStationLabel.AutoSize = True
        Me.RadioStationLabel.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioStationLabel.ForeColor = System.Drawing.Color.Transparent
        Me.RadioStationLabel.Location = New System.Drawing.Point(154, 441)
        Me.RadioStationLabel.Name = "RadioStationLabel"
        Me.RadioStationLabel.Size = New System.Drawing.Size(20, 23)
        Me.RadioStationLabel.TabIndex = 18
        Me.RadioStationLabel.Text = "T"
        Me.RadioStationLabel.Visible = False
        '
        'plusBox
        '
        Me.plusBox.Image = Global.RentECar.My.Resources.ProjectResources.plusButton
        Me.plusBox.Location = New System.Drawing.Point(230, 399)
        Me.plusBox.Name = "plusBox"
        Me.plusBox.Size = New System.Drawing.Size(65, 65)
        Me.plusBox.TabIndex = 19
        Me.plusBox.TabStop = False
        Me.plusBox.Visible = False
        '
        'minusBox
        '
        Me.minusBox.Image = Global.RentECar.My.Resources.ProjectResources.minusButton
        Me.minusBox.Location = New System.Drawing.Point(230, 516)
        Me.minusBox.Name = "minusBox"
        Me.minusBox.Size = New System.Drawing.Size(65, 65)
        Me.minusBox.TabIndex = 20
        Me.minusBox.TabStop = False
        Me.minusBox.Visible = False
        '
        'radioPlayingBox
        '
        Me.radioPlayingBox.Image = Global.RentECar.My.Resources.ProjectResources.radioPlaying
        Me.radioPlayingBox.Location = New System.Drawing.Point(35, 399)
        Me.radioPlayingBox.Name = "radioPlayingBox"
        Me.radioPlayingBox.Size = New System.Drawing.Size(65, 65)
        Me.radioPlayingBox.TabIndex = 21
        Me.radioPlayingBox.TabStop = False
        Me.radioPlayingBox.Visible = False
        '
        'audioLevelLabel
        '
        Me.audioLevelLabel.AutoSize = True
        Me.audioLevelLabel.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.audioLevelLabel.ForeColor = System.Drawing.Color.Transparent
        Me.audioLevelLabel.Location = New System.Drawing.Point(92, 388)
        Me.audioLevelLabel.Name = "audioLevelLabel"
        Me.audioLevelLabel.Size = New System.Drawing.Size(20, 23)
        Me.audioLevelLabel.TabIndex = 22
        Me.audioLevelLabel.Text = "T"
        '
        'bluetoothBox
        '
        Me.bluetoothBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bluetoothBox.Image = Global.RentECar.My.Resources.ProjectResources.bluetoothOff
        Me.bluetoothBox.Location = New System.Drawing.Point(121, 102)
        Me.bluetoothBox.Name = "bluetoothBox"
        Me.bluetoothBox.Size = New System.Drawing.Size(90, 90)
        Me.bluetoothBox.TabIndex = 23
        Me.bluetoothBox.UseVisualStyleBackColor = False
        '
        'RadioBox
        '
        Me.RadioBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RadioBox.Image = Global.RentECar.My.Resources.ProjectResources.radio
        Me.RadioBox.Location = New System.Drawing.Point(116, 441)
        Me.RadioBox.Name = "RadioBox"
        Me.RadioBox.Size = New System.Drawing.Size(99, 105)
        Me.RadioBox.TabIndex = 24
        Me.RadioBox.UseVisualStyleBackColor = False
        '
        'zeroLabel
        '
        Me.zeroLabel.AutoSize = True
        Me.zeroLabel.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.zeroLabel.ForeColor = System.Drawing.Color.Transparent
        Me.zeroLabel.Location = New System.Drawing.Point(67, 292)
        Me.zeroLabel.Name = "zeroLabel"
        Me.zeroLabel.Size = New System.Drawing.Size(19, 23)
        Me.zeroLabel.TabIndex = 25
        Me.zeroLabel.Text = "0"
        '
        'tenLabel
        '
        Me.tenLabel.AutoSize = True
        Me.tenLabel.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tenLabel.ForeColor = System.Drawing.Color.Transparent
        Me.tenLabel.Location = New System.Drawing.Point(250, 292)
        Me.tenLabel.Name = "tenLabel"
        Me.tenLabel.Size = New System.Drawing.Size(26, 23)
        Me.tenLabel.TabIndex = 26
        Me.tenLabel.Text = "10"
        '
        'MediaControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.tenLabel)
        Me.Controls.Add(Me.zeroLabel)
        Me.Controls.Add(Me.RadioBox)
        Me.Controls.Add(Me.bluetoothBox)
        Me.Controls.Add(Me.audioLevelLabel)
        Me.Controls.Add(Me.radioPlayingBox)
        Me.Controls.Add(Me.minusBox)
        Me.Controls.Add(Me.plusBox)
        Me.Controls.Add(Me.RadioStationLabel)
        Me.Controls.Add(Me.AudioBox)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.ConnectionProgressBar)
        Me.Controls.Add(Me.ConnectingLabel)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.TtileLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MediaControls"
        Me.Size = New System.Drawing.Size(336, 642)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AudioBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plusBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minusBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioPlayingBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TtileLabel As Label
    Friend WithEvents ConnectingLabel As Label
    Friend WithEvents ConnectionProgressBar As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents AudioBox As PictureBox
    Friend WithEvents RadioStationLabel As Label
    Friend WithEvents plusBox As PictureBox
    Friend WithEvents minusBox As PictureBox
    Friend WithEvents radioPlayingBox As PictureBox
    Friend WithEvents audioLevelLabel As Label
    Friend WithEvents bluetoothBox As Button
    Friend WithEvents RadioBox As Button
    Friend WithEvents zeroLabel As Label
    Friend WithEvents tenLabel As Label
End Class
