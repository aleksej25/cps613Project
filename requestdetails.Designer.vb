<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class requestdetails
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.tripdetails = New System.Windows.Forms.TextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Goback = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Sitka Banner", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichTextBox1.Location = New System.Drawing.Point(33, 82)
        Me.RichTextBox1.Multiline = False
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(254, 46)
        Me.RichTextBox1.TabIndex = 14
        Me.RichTextBox1.Text = "REQUEST DETAILS"
        '
        'tripdetails
        '
        Me.tripdetails.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tripdetails.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tripdetails.Location = New System.Drawing.Point(30, 151)
        Me.tripdetails.Multiline = True
        Me.tripdetails.Name = "tripdetails"
        Me.tripdetails.Size = New System.Drawing.Size(270, 184)
        Me.tripdetails.TabIndex = 15
        Me.tripdetails.Text = "Location: SLC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Destinations: Union Station, Yorkdale Mall" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Time of departure: 2:0" &
    "0 PM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Final arrival: SLC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number of passengers: 2"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Sitka Heading", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichTextBox2.ForeColor = System.Drawing.Color.DarkRed
        Me.RichTextBox2.Location = New System.Drawing.Point(29, 355)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(265, 115)
        Me.RichTextBox2.TabIndex = 16
        Me.RichTextBox2.Text = "This trip was approved by the system"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Goback
        '
        Me.Goback.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Goback.Location = New System.Drawing.Point(95, 497)
        Me.Goback.Name = "Goback"
        Me.Goback.Size = New System.Drawing.Size(134, 42)
        Me.Goback.TabIndex = 20
        Me.Goback.Text = "Go Back"
        Me.Goback.UseVisualStyleBackColor = True
        '
        'requestdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Goback)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.tripdetails)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "requestdetails"
        Me.Size = New System.Drawing.Size(333, 640)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents tripdetails As TextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Goback As Button
End Class
