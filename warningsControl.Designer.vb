<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class warningsControl
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.errorDescLabel = New System.Windows.Forms.Label()
        Me.fixButton = New System.Windows.Forms.Button()
        Me.ignoreButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.repairingBox = New System.Windows.Forms.PictureBox()
        Me.notifyPoliceButton = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.insuranceButton = New System.Windows.Forms.Button()
        Me.notifyBothButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repairingBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(102, 74)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(117, 35)
        Me.TitleLabel.TabIndex = 10
        Me.TitleLabel.Text = "Warning"
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.Font = New System.Drawing.Font("Sitka Text", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.Location = New System.Drawing.Point(71, 127)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(26, 29)
        Me.errorLabel.TabIndex = 11
        Me.errorLabel.Text = "T"
        '
        'errorDescLabel
        '
        Me.errorDescLabel.AutoSize = True
        Me.errorDescLabel.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.errorDescLabel.ForeColor = System.Drawing.Color.White
        Me.errorDescLabel.Location = New System.Drawing.Point(36, 178)
        Me.errorDescLabel.Name = "errorDescLabel"
        Me.errorDescLabel.Size = New System.Drawing.Size(25, 28)
        Me.errorDescLabel.TabIndex = 12
        Me.errorDescLabel.Text = "T"
        Me.errorDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fixButton
        '
        Me.fixButton.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.fixButton.Location = New System.Drawing.Point(107, 464)
        Me.fixButton.Name = "fixButton"
        Me.fixButton.Size = New System.Drawing.Size(117, 43)
        Me.fixButton.TabIndex = 13
        Me.fixButton.Text = "Fix"
        Me.fixButton.UseVisualStyleBackColor = True
        '
        'ignoreButton
        '
        Me.ignoreButton.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ignoreButton.Location = New System.Drawing.Point(107, 513)
        Me.ignoreButton.Name = "ignoreButton"
        Me.ignoreButton.Size = New System.Drawing.Size(117, 43)
        Me.ignoreButton.TabIndex = 14
        Me.ignoreButton.Text = "Ignore"
        Me.ignoreButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'repairingBox
        '
        Me.repairingBox.Image = Global.RentECar.My.Resources.ProjectResources.repairing
        Me.repairingBox.Location = New System.Drawing.Point(46, 246)
        Me.repairingBox.Name = "repairingBox"
        Me.repairingBox.Size = New System.Drawing.Size(240, 180)
        Me.repairingBox.TabIndex = 15
        Me.repairingBox.TabStop = False
        Me.repairingBox.Visible = False
        '
        'notifyPoliceButton
        '
        Me.notifyPoliceButton.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.notifyPoliceButton.Location = New System.Drawing.Point(92, 464)
        Me.notifyPoliceButton.Name = "notifyPoliceButton"
        Me.notifyPoliceButton.Size = New System.Drawing.Size(152, 43)
        Me.notifyPoliceButton.TabIndex = 16
        Me.notifyPoliceButton.Text = "Notify Police"
        Me.notifyPoliceButton.UseVisualStyleBackColor = True
        Me.notifyPoliceButton.Visible = False
        '
        'Timer2
        '
        '
        'insuranceButton
        '
        Me.insuranceButton.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.insuranceButton.Location = New System.Drawing.Point(84, 464)
        Me.insuranceButton.Name = "insuranceButton"
        Me.insuranceButton.Size = New System.Drawing.Size(166, 43)
        Me.insuranceButton.TabIndex = 17
        Me.insuranceButton.Text = "Notify Insurance"
        Me.insuranceButton.UseVisualStyleBackColor = True
        Me.insuranceButton.Visible = False
        '
        'notifyBothButton
        '
        Me.notifyBothButton.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.notifyBothButton.Location = New System.Drawing.Point(84, 513)
        Me.notifyBothButton.Name = "notifyBothButton"
        Me.notifyBothButton.Size = New System.Drawing.Size(166, 43)
        Me.notifyBothButton.TabIndex = 18
        Me.notifyBothButton.Text = "Notify Both"
        Me.notifyBothButton.UseVisualStyleBackColor = True
        Me.notifyBothButton.Visible = False
        '
        'warningsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.notifyBothButton)
        Me.Controls.Add(Me.insuranceButton)
        Me.Controls.Add(Me.notifyPoliceButton)
        Me.Controls.Add(Me.repairingBox)
        Me.Controls.Add(Me.ignoreButton)
        Me.Controls.Add(Me.fixButton)
        Me.Controls.Add(Me.errorDescLabel)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "warningsControl"
        Me.Size = New System.Drawing.Size(334, 642)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repairingBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents errorLabel As Label
    Friend WithEvents errorDescLabel As Label
    Friend WithEvents fixButton As Button
    Friend WithEvents ignoreButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents repairingBox As PictureBox
    Friend WithEvents notifyPoliceButton As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents insuranceButton As Button
    Friend WithEvents notifyBothButton As Button
End Class
