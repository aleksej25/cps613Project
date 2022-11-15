<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CurrentTripControl
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartDestinationLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DestinationLabel = New System.Windows.Forms.Label()
        Me.ModifyTripButton = New System.Windows.Forms.Button()
        Me.CarControlButton = New System.Windows.Forms.Button()
        Me.StopTripButton = New System.Windows.Forms.Button()
        Me.ContactOwnerButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ArrivedLabel = New System.Windows.Forms.Label()
        Me.NextDestIndicator = New System.Windows.Forms.Label()
        Me.ModifiedDestLabel = New System.Windows.Forms.Label()
        Me.ContinueTripButton = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(86, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Start destination:"
        '
        'StartDestinationLabel
        '
        Me.StartDestinationLabel.AutoSize = True
        Me.StartDestinationLabel.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StartDestinationLabel.ForeColor = System.Drawing.Color.White
        Me.StartDestinationLabel.Location = New System.Drawing.Point(88, 152)
        Me.StartDestinationLabel.Name = "StartDestinationLabel"
        Me.StartDestinationLabel.Size = New System.Drawing.Size(110, 23)
        Me.StartDestinationLabel.TabIndex = 15
        Me.StartDestinationLabel.Text = "TemplateText"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Riding to:"
        '
        'DestinationLabel
        '
        Me.DestinationLabel.AutoSize = True
        Me.DestinationLabel.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DestinationLabel.ForeColor = System.Drawing.Color.White
        Me.DestinationLabel.Location = New System.Drawing.Point(88, 231)
        Me.DestinationLabel.Name = "DestinationLabel"
        Me.DestinationLabel.Size = New System.Drawing.Size(110, 23)
        Me.DestinationLabel.TabIndex = 17
        Me.DestinationLabel.Text = "TemplateText"
        '
        'ModifyTripButton
        '
        Me.ModifyTripButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ModifyTripButton.Location = New System.Drawing.Point(59, 427)
        Me.ModifyTripButton.Name = "ModifyTripButton"
        Me.ModifyTripButton.Size = New System.Drawing.Size(96, 51)
        Me.ModifyTripButton.TabIndex = 18
        Me.ModifyTripButton.Text = "Modify trip"
        Me.ModifyTripButton.UseVisualStyleBackColor = True
        '
        'CarControlButton
        '
        Me.CarControlButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CarControlButton.Location = New System.Drawing.Point(59, 509)
        Me.CarControlButton.Name = "CarControlButton"
        Me.CarControlButton.Size = New System.Drawing.Size(96, 51)
        Me.CarControlButton.TabIndex = 19
        Me.CarControlButton.Text = "Car controls"
        Me.CarControlButton.UseVisualStyleBackColor = True
        '
        'StopTripButton
        '
        Me.StopTripButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StopTripButton.Location = New System.Drawing.Point(190, 509)
        Me.StopTripButton.Name = "StopTripButton"
        Me.StopTripButton.Size = New System.Drawing.Size(96, 51)
        Me.StopTripButton.TabIndex = 20
        Me.StopTripButton.Text = "Stop trip"
        Me.StopTripButton.UseVisualStyleBackColor = True
        '
        'ContactOwnerButton
        '
        Me.ContactOwnerButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ContactOwnerButton.Location = New System.Drawing.Point(190, 427)
        Me.ContactOwnerButton.Name = "ContactOwnerButton"
        Me.ContactOwnerButton.Size = New System.Drawing.Size(96, 51)
        Me.ContactOwnerButton.TabIndex = 21
        Me.ContactOwnerButton.Text = "Contact owner"
        Me.ContactOwnerButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 642)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'ArrivedLabel
        '
        Me.ArrivedLabel.AutoSize = True
        Me.ArrivedLabel.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ArrivedLabel.ForeColor = System.Drawing.Color.White
        Me.ArrivedLabel.Location = New System.Drawing.Point(86, 274)
        Me.ArrivedLabel.Name = "ArrivedLabel"
        Me.ArrivedLabel.Size = New System.Drawing.Size(168, 28)
        Me.ArrivedLabel.TabIndex = 23
        Me.ArrivedLabel.Text = "You have arrived!"
        Me.ArrivedLabel.Visible = False
        '
        'NextDestIndicator
        '
        Me.NextDestIndicator.AutoSize = True
        Me.NextDestIndicator.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NextDestIndicator.ForeColor = System.Drawing.Color.White
        Me.NextDestIndicator.Location = New System.Drawing.Point(40, 320)
        Me.NextDestIndicator.Name = "NextDestIndicator"
        Me.NextDestIndicator.Size = New System.Drawing.Size(140, 23)
        Me.NextDestIndicator.TabIndex = 24
        Me.NextDestIndicator.Text = "Next destination:"
        Me.NextDestIndicator.Visible = False
        '
        'ModifiedDestLabel
        '
        Me.ModifiedDestLabel.AutoSize = True
        Me.ModifiedDestLabel.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ModifiedDestLabel.ForeColor = System.Drawing.Color.White
        Me.ModifiedDestLabel.Location = New System.Drawing.Point(186, 320)
        Me.ModifiedDestLabel.Name = "ModifiedDestLabel"
        Me.ModifiedDestLabel.Size = New System.Drawing.Size(110, 23)
        Me.ModifiedDestLabel.TabIndex = 25
        Me.ModifiedDestLabel.Text = "TemplateText"
        '
        'ContinueTripButton
        '
        Me.ContinueTripButton.Enabled = False
        Me.ContinueTripButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ContinueTripButton.Location = New System.Drawing.Point(118, 359)
        Me.ContinueTripButton.Name = "ContinueTripButton"
        Me.ContinueTripButton.Size = New System.Drawing.Size(96, 51)
        Me.ContinueTripButton.TabIndex = 26
        Me.ContinueTripButton.Text = "Continue trip"
        Me.ContinueTripButton.UseVisualStyleBackColor = True
        Me.ContinueTripButton.Visible = False
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'CurrentTripControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.ContinueTripButton)
        Me.Controls.Add(Me.ModifiedDestLabel)
        Me.Controls.Add(Me.NextDestIndicator)
        Me.Controls.Add(Me.ArrivedLabel)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CurrentTripControl"
        Me.Size = New System.Drawing.Size(339, 642)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ArrivedLabel As Label
    Friend WithEvents NextDestIndicator As Label
    Friend WithEvents ModifiedDestLabel As Label
    Friend WithEvents ContinueTripButton As Button
    Friend WithEvents Timer As Timer
End Class
