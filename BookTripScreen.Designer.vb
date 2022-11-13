<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookTripScreen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FromLocationBox = New System.Windows.Forms.ComboBox()
        Me.ToLocationBox = New System.Windows.Forms.ComboBox()
        Me.PeopleComboBox = New System.Windows.Forms.ComboBox()
        Me.NowRadioButton = New System.Windows.Forms.RadioButton()
        Me.LaterRadioButton = New System.Windows.Forms.RadioButton()
        Me.FromTimeLabel = New System.Windows.Forms.Label()
        Me.EndTimeLabel = New System.Windows.Forms.Label()
        Me.StartTimeBox = New System.Windows.Forms.ComboBox()
        Me.EndTimeBox = New System.Windows.Forms.ComboBox()
        Me.BookButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(340, 639)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(29, 39)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 10
        Me.BackBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(144, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Book a Trip"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(53, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(53, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(38, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Number of people:"
        '
        'FromLocationBox
        '
        Me.FromLocationBox.FormattingEnabled = True
        Me.FromLocationBox.Location = New System.Drawing.Point(169, 140)
        Me.FromLocationBox.Name = "FromLocationBox"
        Me.FromLocationBox.Size = New System.Drawing.Size(121, 23)
        Me.FromLocationBox.TabIndex = 15
        '
        'ToLocationBox
        '
        Me.ToLocationBox.FormattingEnabled = True
        Me.ToLocationBox.Location = New System.Drawing.Point(169, 207)
        Me.ToLocationBox.Name = "ToLocationBox"
        Me.ToLocationBox.Size = New System.Drawing.Size(121, 23)
        Me.ToLocationBox.TabIndex = 16
        '
        'PeopleComboBox
        '
        Me.PeopleComboBox.FormattingEnabled = True
        Me.PeopleComboBox.Location = New System.Drawing.Point(169, 273)
        Me.PeopleComboBox.Name = "PeopleComboBox"
        Me.PeopleComboBox.Size = New System.Drawing.Size(121, 23)
        Me.PeopleComboBox.TabIndex = 17
        '
        'NowRadioButton
        '
        Me.NowRadioButton.AutoSize = True
        Me.NowRadioButton.ForeColor = System.Drawing.Color.White
        Me.NowRadioButton.Location = New System.Drawing.Point(38, 336)
        Me.NowRadioButton.Name = "NowRadioButton"
        Me.NowRadioButton.Size = New System.Drawing.Size(50, 19)
        Me.NowRadioButton.TabIndex = 18
        Me.NowRadioButton.TabStop = True
        Me.NowRadioButton.Text = "Now"
        Me.NowRadioButton.UseVisualStyleBackColor = True
        '
        'LaterRadioButton
        '
        Me.LaterRadioButton.AutoSize = True
        Me.LaterRadioButton.ForeColor = System.Drawing.Color.White
        Me.LaterRadioButton.Location = New System.Drawing.Point(183, 336)
        Me.LaterRadioButton.Name = "LaterRadioButton"
        Me.LaterRadioButton.Size = New System.Drawing.Size(51, 19)
        Me.LaterRadioButton.TabIndex = 19
        Me.LaterRadioButton.TabStop = True
        Me.LaterRadioButton.Text = "Later"
        Me.LaterRadioButton.UseVisualStyleBackColor = True
        '
        'FromTimeLabel
        '
        Me.FromTimeLabel.AutoSize = True
        Me.FromTimeLabel.ForeColor = System.Drawing.Color.White
        Me.FromTimeLabel.Location = New System.Drawing.Point(31, 392)
        Me.FromTimeLabel.Name = "FromTimeLabel"
        Me.FromTimeLabel.Size = New System.Drawing.Size(61, 15)
        Me.FromTimeLabel.TabIndex = 20
        Me.FromTimeLabel.Text = "Start time:"
        '
        'EndTimeLabel
        '
        Me.EndTimeLabel.AutoSize = True
        Me.EndTimeLabel.ForeColor = System.Drawing.Color.White
        Me.EndTimeLabel.Location = New System.Drawing.Point(31, 458)
        Me.EndTimeLabel.Name = "EndTimeLabel"
        Me.EndTimeLabel.Size = New System.Drawing.Size(57, 15)
        Me.EndTimeLabel.TabIndex = 21
        Me.EndTimeLabel.Text = "End time:"
        '
        'StartTimeBox
        '
        Me.StartTimeBox.FormattingEnabled = True
        Me.StartTimeBox.Location = New System.Drawing.Point(169, 392)
        Me.StartTimeBox.Name = "StartTimeBox"
        Me.StartTimeBox.Size = New System.Drawing.Size(121, 23)
        Me.StartTimeBox.TabIndex = 22
        '
        'EndTimeBox
        '
        Me.EndTimeBox.FormattingEnabled = True
        Me.EndTimeBox.Location = New System.Drawing.Point(169, 455)
        Me.EndTimeBox.Name = "EndTimeBox"
        Me.EndTimeBox.Size = New System.Drawing.Size(121, 23)
        Me.EndTimeBox.TabIndex = 23
        '
        'BookButton
        '
        Me.BookButton.Location = New System.Drawing.Point(118, 514)
        Me.BookButton.Name = "BookButton"
        Me.BookButton.Size = New System.Drawing.Size(75, 23)
        Me.BookButton.TabIndex = 24
        Me.BookButton.Text = "Book"
        Me.BookButton.UseVisualStyleBackColor = True
        '
        'BookTripScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.BookButton)
        Me.Controls.Add(Me.EndTimeBox)
        Me.Controls.Add(Me.StartTimeBox)
        Me.Controls.Add(Me.EndTimeLabel)
        Me.Controls.Add(Me.FromTimeLabel)
        Me.Controls.Add(Me.LaterRadioButton)
        Me.Controls.Add(Me.NowRadioButton)
        Me.Controls.Add(Me.PeopleComboBox)
        Me.Controls.Add(Me.ToLocationBox)
        Me.Controls.Add(Me.FromLocationBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "BookTripScreen"
        Me.Size = New System.Drawing.Size(339, 642)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FromLocationBox As ComboBox
    Friend WithEvents ToLocationBox As ComboBox
    Friend WithEvents PeopleComboBox As ComboBox
    Friend WithEvents NowRadioButton As RadioButton
    Friend WithEvents LaterRadioButton As RadioButton
    Friend WithEvents FromTimeLabel As Label
    Friend WithEvents EndTimeLabel As Label
    Friend WithEvents StartTimeBox As ComboBox
    Friend WithEvents EndTimeBox As ComboBox
    Friend WithEvents BookButton As Button
End Class
