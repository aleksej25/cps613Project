<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyCarScreen
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
        Me.MediaControlBox = New System.Windows.Forms.PictureBox()
        Me.ClimateControlBox = New System.Windows.Forms.PictureBox()
        Me.TtileLabel = New System.Windows.Forms.Label()
        Me.MyCarBox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaControlBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClimateControlBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyCarBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MediaControlBox
        '
        Me.MediaControlBox.Image = Global.RentECar.My.Resources.ProjectResources.carMultiMedia
        Me.MediaControlBox.Location = New System.Drawing.Point(108, 446)
        Me.MediaControlBox.Name = "MediaControlBox"
        Me.MediaControlBox.Size = New System.Drawing.Size(120, 120)
        Me.MediaControlBox.TabIndex = 2
        Me.MediaControlBox.TabStop = False
        '
        'ClimateControlBox
        '
        Me.ClimateControlBox.Image = Global.RentECar.My.Resources.ProjectResources._257783_200
        Me.ClimateControlBox.Location = New System.Drawing.Point(108, 288)
        Me.ClimateControlBox.Name = "ClimateControlBox"
        Me.ClimateControlBox.Size = New System.Drawing.Size(120, 120)
        Me.ClimateControlBox.TabIndex = 3
        Me.ClimateControlBox.TabStop = False
        '
        'TtileLabel
        '
        Me.TtileLabel.AutoSize = True
        Me.TtileLabel.Font = New System.Drawing.Font("Sitka Heading", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TtileLabel.ForeColor = System.Drawing.Color.Transparent
        Me.TtileLabel.Location = New System.Drawing.Point(67, 71)
        Me.TtileLabel.Name = "TtileLabel"
        Me.TtileLabel.Size = New System.Drawing.Size(209, 39)
        Me.TtileLabel.TabIndex = 4
        Me.TtileLabel.Text = "Control MyECar"
        '
        'MyCarBox
        '
        Me.MyCarBox.Image = Global.RentECar.My.Resources.ProjectResources.Mini_Car
        Me.MyCarBox.Location = New System.Drawing.Point(108, 137)
        Me.MyCarBox.Name = "MyCarBox"
        Me.MyCarBox.Size = New System.Drawing.Size(120, 120)
        Me.MyCarBox.TabIndex = 5
        Me.MyCarBox.TabStop = False
        '
        'MyCarScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.MyCarBox)
        Me.Controls.Add(Me.TtileLabel)
        Me.Controls.Add(Me.ClimateControlBox)
        Me.Controls.Add(Me.MediaControlBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MyCarScreen"
        Me.Size = New System.Drawing.Size(333, 640)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaControlBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClimateControlBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyCarBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MediaControlBox As PictureBox
    Friend WithEvents ClimateControlBox As PictureBox
    Friend WithEvents TtileLabel As Label
    Friend WithEvents MyCarBox As PictureBox
End Class
