<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrentTripControl
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartDestinationLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DestinationLabel = New System.Windows.Forms.Label()
        Me.ModifyTripButton = New System.Windows.Forms.Button()
        Me.CarControlButton = New System.Windows.Forms.Button()
        Me.StopTripButton = New System.Windows.Forms.Button()
        Me.ContactOwnerButton = New System.Windows.Forms.Button()
        Me.ManualDrivingButton = New System.Windows.Forms.Button()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(40, 56)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 12
        Me.BackBox.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(86, 68)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(200, 28)
        Me.TitleLabel.TabIndex = 13
        Me.TitleLabel.Text = "You are on your way!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(86, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 28)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Start destination:"
        '
        'StartDestinationLabel
        '
        Me.StartDestinationLabel.AutoSize = True
        Me.StartDestinationLabel.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StartDestinationLabel.ForeColor = System.Drawing.Color.White
        Me.StartDestinationLabel.Location = New System.Drawing.Point(98, 163)
        Me.StartDestinationLabel.Name = "StartDestinationLabel"
        Me.StartDestinationLabel.Size = New System.Drawing.Size(132, 28)
        Me.StartDestinationLabel.TabIndex = 15
        Me.StartDestinationLabel.Text = "TemplateText"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(110, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 28)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Riding to:"
        '
        'DestinationLabel
        '
        Me.DestinationLabel.AutoSize = True
        Me.DestinationLabel.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DestinationLabel.ForeColor = System.Drawing.Color.White
        Me.DestinationLabel.Location = New System.Drawing.Point(98, 241)
        Me.DestinationLabel.Name = "DestinationLabel"
        Me.DestinationLabel.Size = New System.Drawing.Size(132, 28)
        Me.DestinationLabel.TabIndex = 17
        Me.DestinationLabel.Text = "TemplateText"
        '
        'ModifyTripButton
        '
        Me.ModifyTripButton.Location = New System.Drawing.Point(126, 353)
        Me.ModifyTripButton.Name = "ModifyTripButton"
        Me.ModifyTripButton.Size = New System.Drawing.Size(75, 23)
        Me.ModifyTripButton.TabIndex = 18
        Me.ModifyTripButton.Text = "Modify trip"
        Me.ModifyTripButton.UseVisualStyleBackColor = True
        '
        'CarControlButton
        '
        Me.CarControlButton.Location = New System.Drawing.Point(126, 408)
        Me.CarControlButton.Name = "CarControlButton"
        Me.CarControlButton.Size = New System.Drawing.Size(75, 23)
        Me.CarControlButton.TabIndex = 19
        Me.CarControlButton.Text = "Car controls"
        Me.CarControlButton.UseVisualStyleBackColor = True
        '
        'StopTripButton
        '
        Me.StopTripButton.Location = New System.Drawing.Point(126, 561)
        Me.StopTripButton.Name = "StopTripButton"
        Me.StopTripButton.Size = New System.Drawing.Size(75, 23)
        Me.StopTripButton.TabIndex = 20
        Me.StopTripButton.Text = "Stop trip"
        Me.StopTripButton.UseVisualStyleBackColor = True
        '
        'ContactOwnerButton
        '
        Me.ContactOwnerButton.Location = New System.Drawing.Point(126, 512)
        Me.ContactOwnerButton.Name = "ContactOwnerButton"
        Me.ContactOwnerButton.Size = New System.Drawing.Size(75, 23)
        Me.ContactOwnerButton.TabIndex = 21
        Me.ContactOwnerButton.Text = "Chat with owner"
        Me.ContactOwnerButton.UseVisualStyleBackColor = True
        '
        'ManualDrivingButton
        '
        Me.ManualDrivingButton.Location = New System.Drawing.Point(126, 454)
        Me.ManualDrivingButton.Name = "ManualDrivingButton"
        Me.ManualDrivingButton.Size = New System.Drawing.Size(75, 23)
        Me.ManualDrivingButton.TabIndex = 22
        Me.ManualDrivingButton.Text = "Manual driving mode"
        Me.ManualDrivingButton.UseVisualStyleBackColor = True
        '
        'CurrentTripControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.ManualDrivingButton)
        Me.Controls.Add(Me.ContactOwnerButton)
        Me.Controls.Add(Me.StopTripButton)
        Me.Controls.Add(Me.CarControlButton)
        Me.Controls.Add(Me.ModifyTripButton)
        Me.Controls.Add(Me.DestinationLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StartDestinationLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.BackBox)
        Me.Name = "CurrentTripControl"
        Me.Size = New System.Drawing.Size(339, 642)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBox As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents StartDestinationLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DestinationLabel As Label
    Friend WithEvents ModifyTripButton As Button
    Friend WithEvents CarControlButton As Button
    Friend WithEvents StopTripButton As Button
    Friend WithEvents ContactOwnerButton As Button
    Friend WithEvents ManualDrivingButton As Button
End Class
