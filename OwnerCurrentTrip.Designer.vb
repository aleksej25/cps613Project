<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OwnerCurrentTrip
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
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StartDestLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OwnerDestLabel = New System.Windows.Forms.Label()
        Me.OwnerModifyTripButton = New System.Windows.Forms.Button()
        Me.OwnerCarControlsBtn = New System.Windows.Forms.Button()
        Me.ManualDrivingButton = New System.Windows.Forms.Button()
        Me.OwnerStopTrip = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OwnerArrivedLabel = New System.Windows.Forms.Label()
        Me.OwnerTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(38, 49)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 12
        Me.BackBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(94, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 28)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "You are on the way!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(94, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 28)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Start destination:"
        '
        'StartDestLabel
        '
        Me.StartDestLabel.AutoSize = True
        Me.StartDestLabel.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StartDestLabel.ForeColor = System.Drawing.Color.White
        Me.StartDestLabel.Location = New System.Drawing.Point(94, 158)
        Me.StartDestLabel.Name = "StartDestLabel"
        Me.StartDestLabel.Size = New System.Drawing.Size(132, 28)
        Me.StartDestLabel.TabIndex = 15
        Me.StartDestLabel.Text = "TemplateText"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(94, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 28)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "End destination:"
        '
        'OwnerDestLabel
        '
        Me.OwnerDestLabel.AutoSize = True
        Me.OwnerDestLabel.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OwnerDestLabel.ForeColor = System.Drawing.Color.White
        Me.OwnerDestLabel.Location = New System.Drawing.Point(94, 255)
        Me.OwnerDestLabel.Name = "OwnerDestLabel"
        Me.OwnerDestLabel.Size = New System.Drawing.Size(132, 28)
        Me.OwnerDestLabel.TabIndex = 17
        Me.OwnerDestLabel.Text = "TemplateText"
        '
        'OwnerModifyTripButton
        '
        Me.OwnerModifyTripButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OwnerModifyTripButton.Location = New System.Drawing.Point(68, 394)
        Me.OwnerModifyTripButton.Name = "OwnerModifyTripButton"
        Me.OwnerModifyTripButton.Size = New System.Drawing.Size(84, 49)
        Me.OwnerModifyTripButton.TabIndex = 18
        Me.OwnerModifyTripButton.Text = "Modify trip"
        Me.OwnerModifyTripButton.UseVisualStyleBackColor = True
        '
        'OwnerCarControlsBtn
        '
        Me.OwnerCarControlsBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OwnerCarControlsBtn.Location = New System.Drawing.Point(68, 478)
        Me.OwnerCarControlsBtn.Name = "OwnerCarControlsBtn"
        Me.OwnerCarControlsBtn.Size = New System.Drawing.Size(84, 49)
        Me.OwnerCarControlsBtn.TabIndex = 19
        Me.OwnerCarControlsBtn.Text = "Car controls"
        Me.OwnerCarControlsBtn.UseVisualStyleBackColor = True
        '
        'ManualDrivingButton
        '
        Me.ManualDrivingButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ManualDrivingButton.Location = New System.Drawing.Point(186, 394)
        Me.ManualDrivingButton.Name = "ManualDrivingButton"
        Me.ManualDrivingButton.Size = New System.Drawing.Size(84, 49)
        Me.ManualDrivingButton.TabIndex = 20
        Me.ManualDrivingButton.Text = "Manual driving"
        Me.ManualDrivingButton.UseVisualStyleBackColor = True
        '
        'OwnerStopTrip
        '
        Me.OwnerStopTrip.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OwnerStopTrip.Location = New System.Drawing.Point(186, 478)
        Me.OwnerStopTrip.Name = "OwnerStopTrip"
        Me.OwnerStopTrip.Size = New System.Drawing.Size(84, 49)
        Me.OwnerStopTrip.TabIndex = 21
        Me.OwnerStopTrip.Text = "Stop trip"
        Me.OwnerStopTrip.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 642)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'OwnerArrivedLabel
        '
        Me.OwnerArrivedLabel.AutoSize = True
        Me.OwnerArrivedLabel.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OwnerArrivedLabel.ForeColor = System.Drawing.Color.White
        Me.OwnerArrivedLabel.Location = New System.Drawing.Point(83, 312)
        Me.OwnerArrivedLabel.Name = "OwnerArrivedLabel"
        Me.OwnerArrivedLabel.Size = New System.Drawing.Size(168, 28)
        Me.OwnerArrivedLabel.TabIndex = 23
        Me.OwnerArrivedLabel.Text = "You have arrived!"
        Me.OwnerArrivedLabel.Visible = False
        '
        'OwnerTimer
        '
        Me.OwnerTimer.Interval = 1000
        '
        'OwnerCurrentTrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.OwnerArrivedLabel)
        Me.Controls.Add(Me.OwnerStopTrip)
        Me.Controls.Add(Me.ManualDrivingButton)
        Me.Controls.Add(Me.OwnerCarControlsBtn)
        Me.Controls.Add(Me.OwnerModifyTripButton)
        Me.Controls.Add(Me.OwnerDestLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StartDestLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "OwnerCurrentTrip"
        Me.Size = New System.Drawing.Size(339, 642)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StartDestLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OwnerDestLabel As Label
    Friend WithEvents OwnerModifyTripButton As Button
    Friend WithEvents OwnerCarControlsBtn As Button
    Friend WithEvents ManualDrivingButton As Button
    Friend WithEvents OwnerStopTrip As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OwnerArrivedLabel As Label
    Friend WithEvents OwnerTimer As Timer
End Class
