<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarControlScreen
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
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.TtileLabel = New System.Windows.Forms.Label()
        Me.trunkBox = New System.Windows.Forms.PictureBox()
        Me.trunkOCLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trunkBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CarControlScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackBox As PictureBox
    Friend WithEvents TtileLabel As Label
    Friend WithEvents trunkBox As PictureBox
    Friend WithEvents trunkOCLabel As Label
End Class
