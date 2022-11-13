<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OwnerMainScreen
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
        Me.MyCarButton = New System.Windows.Forms.Button()
        Me.ScheduleButton = New System.Windows.Forms.Button()
        Me.RatingsButton = New System.Windows.Forms.Button()
        Me.BookingsButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.ownerBackground
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(68, 60)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(202, 35)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Welcome Owner"
        '
        'MyCarButton
        '
        Me.MyCarButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MyCarButton.Location = New System.Drawing.Point(105, 350)
        Me.MyCarButton.Name = "MyCarButton"
        Me.MyCarButton.Size = New System.Drawing.Size(134, 42)
        Me.MyCarButton.TabIndex = 3
        Me.MyCarButton.Text = "My Car"
        Me.MyCarButton.UseVisualStyleBackColor = True
        '
        'ScheduleButton
        '
        Me.ScheduleButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ScheduleButton.Location = New System.Drawing.Point(105, 413)
        Me.ScheduleButton.Name = "ScheduleButton"
        Me.ScheduleButton.Size = New System.Drawing.Size(134, 42)
        Me.ScheduleButton.TabIndex = 5
        Me.ScheduleButton.Text = "Schedule"
        Me.ScheduleButton.UseVisualStyleBackColor = True
        '
        'RatingsButton
        '
        Me.RatingsButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RatingsButton.Location = New System.Drawing.Point(105, 533)
        Me.RatingsButton.Name = "RatingsButton"
        Me.RatingsButton.Size = New System.Drawing.Size(134, 42)
        Me.RatingsButton.TabIndex = 6
        Me.RatingsButton.Text = "Ratings"
        Me.RatingsButton.UseVisualStyleBackColor = True
        '
        'BookingsButton
        '
        Me.BookingsButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BookingsButton.Location = New System.Drawing.Point(105, 473)
        Me.BookingsButton.Name = "BookingsButton"
        Me.BookingsButton.Size = New System.Drawing.Size(134, 42)
        Me.BookingsButton.TabIndex = 7
        Me.BookingsButton.Text = "Bookings"
        Me.BookingsButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'OwnerMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.BookingsButton)
        Me.Controls.Add(Me.RatingsButton)
        Me.Controls.Add(Me.ScheduleButton)
        Me.Controls.Add(Me.MyCarButton)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "OwnerMainScreen"
        Me.Size = New System.Drawing.Size(335, 642)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents MyCarButton As Button
    Friend WithEvents ScheduleButton As Button
    Friend WithEvents RatingsButton As Button
    Friend WithEvents BookingsButton As Button
    Friend WithEvents Timer1 As Timer
End Class
