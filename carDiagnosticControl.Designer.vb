<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carDiagnosticControl
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
        Me.components = New System.ComponentModel.Container()
        Me.gearsBox = New System.Windows.Forms.PictureBox()
        Me.diagnosticLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.diagnosticReport = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cameraBox = New System.Windows.Forms.PictureBox()
        Me.interiorButton = New System.Windows.Forms.RadioButton()
        Me.exteriorButton = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.mapBox = New System.Windows.Forms.PictureBox()
        Me.locationLabel = New System.Windows.Forms.Label()
        Me.summonBox = New System.Windows.Forms.PictureBox()
        Me.summonLabel = New System.Windows.Forms.Label()
        Me.kickOutBox = New System.Windows.Forms.PictureBox()
        Me.kickOutLabel = New System.Windows.Forms.Label()
        CType(Me.gearsBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cameraBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mapBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.summonBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kickOutBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gearsBox
        '
        Me.gearsBox.Image = Global.RentECar.My.Resources.ProjectResources.repairsIcon
        Me.gearsBox.Location = New System.Drawing.Point(41, 96)
        Me.gearsBox.Name = "gearsBox"
        Me.gearsBox.Size = New System.Drawing.Size(110, 110)
        Me.gearsBox.TabIndex = 10
        Me.gearsBox.TabStop = False
        '
        'diagnosticLabel
        '
        Me.diagnosticLabel.AutoSize = True
        Me.diagnosticLabel.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.diagnosticLabel.ForeColor = System.Drawing.Color.Transparent
        Me.diagnosticLabel.Location = New System.Drawing.Point(27, 209)
        Me.diagnosticLabel.Name = "diagnosticLabel"
        Me.diagnosticLabel.Size = New System.Drawing.Size(124, 23)
        Me.diagnosticLabel.TabIndex = 11
        Me.diagnosticLabel.Text = "Run Diagnostic"
        '
        'Timer1
        '
        '
        'diagnosticReport
        '
        Me.diagnosticReport.AutoSize = True
        Me.diagnosticReport.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.diagnosticReport.ForeColor = System.Drawing.Color.Transparent
        Me.diagnosticReport.Location = New System.Drawing.Point(27, 232)
        Me.diagnosticReport.Name = "diagnosticReport"
        Me.diagnosticReport.Size = New System.Drawing.Size(20, 23)
        Me.diagnosticReport.TabIndex = 12
        Me.diagnosticReport.Text = "T"
        Me.diagnosticReport.Visible = False
        '
        'Timer2
        '
        '
        'cameraBox
        '
        Me.cameraBox.Image = Global.RentECar.My.Resources.ProjectResources.cameraIcon
        Me.cameraBox.Location = New System.Drawing.Point(182, 96)
        Me.cameraBox.Name = "cameraBox"
        Me.cameraBox.Size = New System.Drawing.Size(110, 110)
        Me.cameraBox.TabIndex = 13
        Me.cameraBox.TabStop = False
        '
        'interiorButton
        '
        Me.interiorButton.AutoSize = True
        Me.interiorButton.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.interiorButton.ForeColor = System.Drawing.Color.Transparent
        Me.interiorButton.Location = New System.Drawing.Point(196, 207)
        Me.interiorButton.Name = "interiorButton"
        Me.interiorButton.Size = New System.Drawing.Size(81, 25)
        Me.interiorButton.TabIndex = 14
        Me.interiorButton.TabStop = True
        Me.interiorButton.Text = "Interior"
        Me.interiorButton.UseVisualStyleBackColor = True
        '
        'exteriorButton
        '
        Me.exteriorButton.AutoSize = True
        Me.exteriorButton.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.exteriorButton.ForeColor = System.Drawing.Color.Transparent
        Me.exteriorButton.Location = New System.Drawing.Point(196, 232)
        Me.exteriorButton.Name = "exteriorButton"
        Me.exteriorButton.Size = New System.Drawing.Size(84, 25)
        Me.exteriorButton.TabIndex = 15
        Me.exteriorButton.TabStop = True
        Me.exteriorButton.Text = "Exterior"
        Me.exteriorButton.UseVisualStyleBackColor = True
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
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(36, 32)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 9
        Me.BackBox.TabStop = False
        '
        'mapBox
        '
        Me.mapBox.Image = Global.RentECar.My.Resources.ProjectResources.mapIcon
        Me.mapBox.Location = New System.Drawing.Point(41, 272)
        Me.mapBox.Name = "mapBox"
        Me.mapBox.Size = New System.Drawing.Size(110, 110)
        Me.mapBox.TabIndex = 16
        Me.mapBox.TabStop = False
        '
        'locationLabel
        '
        Me.locationLabel.AutoSize = True
        Me.locationLabel.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.locationLabel.ForeColor = System.Drawing.Color.Transparent
        Me.locationLabel.Location = New System.Drawing.Point(41, 385)
        Me.locationLabel.Name = "locationLabel"
        Me.locationLabel.Size = New System.Drawing.Size(104, 23)
        Me.locationLabel.TabIndex = 17
        Me.locationLabel.Text = "Car Location"
        '
        'summonBox
        '
        Me.summonBox.Image = Global.RentECar.My.Resources.ProjectResources.returnHome
        Me.summonBox.Location = New System.Drawing.Point(182, 272)
        Me.summonBox.Name = "summonBox"
        Me.summonBox.Size = New System.Drawing.Size(110, 110)
        Me.summonBox.TabIndex = 18
        Me.summonBox.TabStop = False
        '
        'summonLabel
        '
        Me.summonLabel.AutoSize = True
        Me.summonLabel.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.summonLabel.ForeColor = System.Drawing.Color.Transparent
        Me.summonLabel.Location = New System.Drawing.Point(182, 385)
        Me.summonLabel.Name = "summonLabel"
        Me.summonLabel.Size = New System.Drawing.Size(123, 23)
        Me.summonLabel.TabIndex = 19
        Me.summonLabel.Text = "Summon Home"
        '
        'kickOutBox
        '
        Me.kickOutBox.Image = Global.RentECar.My.Resources.ProjectResources.kickOut
        Me.kickOutBox.Location = New System.Drawing.Point(111, 433)
        Me.kickOutBox.Name = "kickOutBox"
        Me.kickOutBox.Size = New System.Drawing.Size(110, 110)
        Me.kickOutBox.TabIndex = 20
        Me.kickOutBox.TabStop = False
        '
        'kickOutLabel
        '
        Me.kickOutLabel.AutoSize = True
        Me.kickOutLabel.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.kickOutLabel.ForeColor = System.Drawing.Color.Transparent
        Me.kickOutLabel.Location = New System.Drawing.Point(107, 546)
        Me.kickOutLabel.Name = "kickOutLabel"
        Me.kickOutLabel.Size = New System.Drawing.Size(117, 23)
        Me.kickOutLabel.TabIndex = 21
        Me.kickOutLabel.Text = "Kick Out Rider"
        '
        'carDiagnosticControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.kickOutLabel)
        Me.Controls.Add(Me.kickOutBox)
        Me.Controls.Add(Me.summonLabel)
        Me.Controls.Add(Me.summonBox)
        Me.Controls.Add(Me.locationLabel)
        Me.Controls.Add(Me.mapBox)
        Me.Controls.Add(Me.exteriorButton)
        Me.Controls.Add(Me.interiorButton)
        Me.Controls.Add(Me.cameraBox)
        Me.Controls.Add(Me.diagnosticReport)
        Me.Controls.Add(Me.diagnosticLabel)
        Me.Controls.Add(Me.gearsBox)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "carDiagnosticControl"
        Me.Size = New System.Drawing.Size(333, 641)
        CType(Me.gearsBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cameraBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mapBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.summonBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kickOutBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gearsBox As PictureBox
    Friend WithEvents diagnosticLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents diagnosticReport As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents cameraBox As PictureBox
    Friend WithEvents interiorButton As RadioButton
    Friend WithEvents exteriorButton As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackBox As PictureBox
    Friend WithEvents mapBox As PictureBox
    Friend WithEvents locationLabel As Label
    Friend WithEvents summonBox As PictureBox
    Friend WithEvents summonLabel As Label
    Friend WithEvents kickOutBox As PictureBox
    Friend WithEvents kickOutLabel As Label
End Class
