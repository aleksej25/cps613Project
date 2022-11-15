<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyTripControl
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToLocationBox = New System.Windows.Forms.ComboBox()
        Me.EndTimeBox = New System.Windows.Forms.ComboBox()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(35, 34)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 13
        Me.BackBox.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(91, 59)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(153, 35)
        Me.TitleLabel.TabIndex = 14
        Me.TitleLabel.Text = "Modify trip"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "New destination:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "New end time:"
        '
        'ToLocationBox
        '
        Me.ToLocationBox.FormattingEnabled = True
        Me.ToLocationBox.Location = New System.Drawing.Point(179, 173)
        Me.ToLocationBox.Name = "ToLocationBox"
        Me.ToLocationBox.Size = New System.Drawing.Size(121, 23)
        Me.ToLocationBox.TabIndex = 17
        '
        'EndTimeBox
        '
        Me.EndTimeBox.FormattingEnabled = True
        Me.EndTimeBox.Location = New System.Drawing.Point(179, 227)
        Me.EndTimeBox.Name = "EndTimeBox"
        Me.EndTimeBox.Size = New System.Drawing.Size(121, 23)
        Me.EndTimeBox.TabIndex = 18
        '
        'ChangeButton
        '
        Me.ChangeButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ChangeButton.Location = New System.Drawing.Point(110, 290)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(122, 66)
        Me.ChangeButton.TabIndex = 19
        Me.ChangeButton.Text = "Confirm Change"
        Me.ChangeButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 642)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'ModifyTripControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.ChangeButton)
        Me.Controls.Add(Me.EndTimeBox)
        Me.Controls.Add(Me.ToLocationBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ModifyTripControl"
        Me.Size = New System.Drawing.Size(339, 642)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBox As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToLocationBox As ComboBox
    Friend WithEvents EndTimeBox As ComboBox
    Friend WithEvents ChangeButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
