<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.InitalScreen1 = New RentECar.InitalScreen()
        Me.OwnerMainScreen1 = New RentECar.OwnerMainScreen()
        Me.RiderMainScreen1 = New RentECar.RiderMainScreen()
        Me.MyCarScreen1 = New RentECar.MyCarScreen()
        Me.ClimateControlScreen1 = New RentECar.ClimateControlScreen()
        Me.AirControllScreen1 = New RentECar.AirControllScreen()
        Me.SuspendLayout()
        '
        'InitalScreen1
        '
        Me.InitalScreen1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.InitalScreen1.Location = New System.Drawing.Point(-4, 1)
        Me.InitalScreen1.Name = "InitalScreen1"
        Me.InitalScreen1.Size = New System.Drawing.Size(338, 644)
        Me.InitalScreen1.TabIndex = 0
        '
        'OwnerMainScreen1
        '
        Me.OwnerMainScreen1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.OwnerMainScreen1.Location = New System.Drawing.Point(0, 0)
        Me.OwnerMainScreen1.Name = "OwnerMainScreen1"
        Me.OwnerMainScreen1.Size = New System.Drawing.Size(335, 642)
        Me.OwnerMainScreen1.TabIndex = 1
        Me.OwnerMainScreen1.Visible = False
        '
        'RiderMainScreen1
        '
        Me.RiderMainScreen1.Location = New System.Drawing.Point(0, 0)
        Me.RiderMainScreen1.Name = "RiderMainScreen1"
        Me.RiderMainScreen1.Size = New System.Drawing.Size(335, 642)
        Me.RiderMainScreen1.TabIndex = 2
        Me.RiderMainScreen1.Visible = False
        '
        'MyCarScreen1
        '
        Me.MyCarScreen1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MyCarScreen1.Location = New System.Drawing.Point(0, 0)
        Me.MyCarScreen1.Name = "MyCarScreen1"
        Me.MyCarScreen1.Size = New System.Drawing.Size(333, 640)
        Me.MyCarScreen1.TabIndex = 3
        Me.MyCarScreen1.Visible = False
        '
        'ClimateControlScreen1
        '
        Me.ClimateControlScreen1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClimateControlScreen1.Location = New System.Drawing.Point(0, 0)
        Me.ClimateControlScreen1.Name = "ClimateControlScreen1"
        Me.ClimateControlScreen1.Size = New System.Drawing.Size(335, 641)
        Me.ClimateControlScreen1.TabIndex = 4
        Me.ClimateControlScreen1.Visible = False
        '
        'AirControllScreen1
        '
        Me.AirControllScreen1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AirControllScreen1.Location = New System.Drawing.Point(0, 0)
        Me.AirControllScreen1.Name = "AirControllScreen1"
        Me.AirControllScreen1.Size = New System.Drawing.Size(339, 642)
        Me.AirControllScreen1.TabIndex = 5
        Me.AirControllScreen1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(332, 644)
        Me.Controls.Add(Me.InitalScreen1)
        Me.Controls.Add(Me.OwnerMainScreen1)
        Me.Controls.Add(Me.RiderMainScreen1)
        Me.Controls.Add(Me.MyCarScreen1)
        Me.Controls.Add(Me.ClimateControlScreen1)
        Me.Controls.Add(Me.AirControllScreen1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(348, 683)
        Me.Name = "Form1"
        Me.Text = "RentECar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InitalScreen1 As InitalScreen
    Friend WithEvents OwnerMainScreen1 As OwnerMainScreen
    Friend WithEvents RiderMainScreen1 As RiderMainScreen
    Friend WithEvents MyCarScreen1 As MyCarScreen
    Friend WithEvents ClimateControlScreen1 As ClimateControlScreen
    Friend WithEvents AirControllScreen1 As AirControllScreen
End Class
