﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ECarControls = New RentECar.ECarControls()
        Me.ClimateControlScreen1 = New RentECar.ClimateControlScreen()
        Me.AirControllScreen1 = New RentECar.AirControllScreen()
        Me.MediaControls1 = New RentECar.MediaControls()
        Me.CarDiagnosticControl1 = New RentECar.carDiagnosticControl()
        Me.CameraViewControl1 = New RentECar.cameraViewControl()
        Me.cameraFailureBox = New System.Windows.Forms.PictureBox()
        Me.ErrorFixScreenControl1 = New RentECar.warningsControl()
        Me.breakInBox = New System.Windows.Forms.PictureBox()
        Me.collisionBox = New System.Windows.Forms.PictureBox()
        Me.WindowControl1 = New RentECar.windowControl()
        Me.RatingsControl1 = New RentECar.ratingsControl()
        Me.BookTripScreen1 = New RentECar.BookTripScreen()
        CType(Me.cameraFailureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.breakInBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.collisionBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RiderMainScreen1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RiderMainScreen1.Location = New System.Drawing.Point(0, 0)
        Me.RiderMainScreen1.Name = "RiderMainScreen1"
        Me.RiderMainScreen1.Size = New System.Drawing.Size(335, 642)
        Me.RiderMainScreen1.TabIndex = 2
        Me.RiderMainScreen1.Visible = False
        '
        'ECarControls
        '
        Me.ECarControls.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ECarControls.Location = New System.Drawing.Point(0, 0)
        Me.ECarControls.Name = "ECarControls"
        Me.ECarControls.Size = New System.Drawing.Size(333, 640)
        Me.ECarControls.TabIndex = 3
        Me.ECarControls.Visible = False
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
        'MediaControls1
        '
        Me.MediaControls1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MediaControls1.Location = New System.Drawing.Point(0, 0)
        Me.MediaControls1.Name = "MediaControls1"
        Me.MediaControls1.Size = New System.Drawing.Size(336, 642)
        Me.MediaControls1.TabIndex = 7
        Me.MediaControls1.Visible = False
        '
        'CarDiagnosticControl1
        '
        Me.CarDiagnosticControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CarDiagnosticControl1.Location = New System.Drawing.Point(0, 0)
        Me.CarDiagnosticControl1.Name = "CarDiagnosticControl1"
        Me.CarDiagnosticControl1.Size = New System.Drawing.Size(333, 641)
        Me.CarDiagnosticControl1.TabIndex = 8
        Me.CarDiagnosticControl1.Visible = False
        '
        'CameraViewControl1
        '
        Me.CameraViewControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CameraViewControl1.Location = New System.Drawing.Point(0, 0)
        Me.CameraViewControl1.Name = "CameraViewControl1"
        Me.CameraViewControl1.Size = New System.Drawing.Size(335, 640)
        Me.CameraViewControl1.TabIndex = 9
        Me.CameraViewControl1.Visible = False
        '
        'cameraFailureBox
        '
        Me.cameraFailureBox.Image = Global.RentECar.My.Resources.ProjectResources.cameraWarning
        Me.cameraFailureBox.Location = New System.Drawing.Point(21, 52)
        Me.cameraFailureBox.Name = "cameraFailureBox"
        Me.cameraFailureBox.Size = New System.Drawing.Size(285, 120)
        Me.cameraFailureBox.TabIndex = 12
        Me.cameraFailureBox.TabStop = False
        Me.cameraFailureBox.Visible = False
        '
        'ErrorFixScreenControl1
        '
        Me.ErrorFixScreenControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ErrorFixScreenControl1.Location = New System.Drawing.Point(0, 0)
        Me.ErrorFixScreenControl1.Name = "ErrorFixScreenControl1"
        Me.ErrorFixScreenControl1.Size = New System.Drawing.Size(334, 642)
        Me.ErrorFixScreenControl1.TabIndex = 13
        Me.ErrorFixScreenControl1.Visible = False
        '
        'breakInBox
        '
        Me.breakInBox.Image = Global.RentECar.My.Resources.ProjectResources.breakInWarning
        Me.breakInBox.Location = New System.Drawing.Point(21, 52)
        Me.breakInBox.Name = "breakInBox"
        Me.breakInBox.Size = New System.Drawing.Size(285, 120)
        Me.breakInBox.TabIndex = 14
        Me.breakInBox.TabStop = False
        Me.breakInBox.Visible = False
        '
        'collisionBox
        '
        Me.collisionBox.Image = Global.RentECar.My.Resources.ProjectResources.collisionWarning
        Me.collisionBox.Location = New System.Drawing.Point(21, 52)
        Me.collisionBox.Name = "collisionBox"
        Me.collisionBox.Size = New System.Drawing.Size(285, 120)
        Me.collisionBox.TabIndex = 15
        Me.collisionBox.TabStop = False
        Me.collisionBox.Visible = False
        '
        'WindowControl1
        '
        Me.WindowControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.WindowControl1.Location = New System.Drawing.Point(0, 0)
        Me.WindowControl1.Name = "WindowControl1"
        Me.WindowControl1.Size = New System.Drawing.Size(337, 643)
        Me.WindowControl1.TabIndex = 16
        Me.WindowControl1.Visible = False
        '
        'RatingsControl1
        '
        Me.RatingsControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RatingsControl1.Location = New System.Drawing.Point(0, 0)
        Me.RatingsControl1.Name = "RatingsControl1"
        Me.RatingsControl1.Size = New System.Drawing.Size(336, 642)
        Me.RatingsControl1.TabIndex = 17
        Me.RatingsControl1.Visible = False
        '
        'BookTripScreen1
        '
        Me.BookTripScreen1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BookTripScreen1.Location = New System.Drawing.Point(0, 0)
        Me.BookTripScreen1.Name = "BookTripScreen1"
        Me.BookTripScreen1.Size = New System.Drawing.Size(339, 642)
        Me.BookTripScreen1.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(332, 644)
        Me.Controls.Add(Me.collisionBox)
        Me.Controls.Add(Me.cameraFailureBox)
        Me.Controls.Add(Me.breakInBox)
        Me.Controls.Add(Me.ErrorFixScreenControl1)
        Me.Controls.Add(Me.InitalScreen1)
        Me.Controls.Add(Me.OwnerMainScreen1)
        Me.Controls.Add(Me.RiderMainScreen1)
        Me.Controls.Add(Me.ECarControls)
        Me.Controls.Add(Me.ClimateControlScreen1)
        Me.Controls.Add(Me.AirControllScreen1)
        Me.Controls.Add(Me.MediaControls1)
        Me.Controls.Add(Me.CarDiagnosticControl1)
        Me.Controls.Add(Me.CameraViewControl1)
        Me.Controls.Add(Me.WindowControl1)
        Me.Controls.Add(Me.RatingsControl1)
        Me.Controls.Add(Me.BookTripScreen1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(348, 683)
        Me.Name = "Form1"
        Me.Text = "RentECar"
        CType(Me.cameraFailureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.breakInBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.collisionBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InitalScreen1 As InitalScreen
    Friend WithEvents OwnerMainScreen1 As OwnerMainScreen
    Friend WithEvents RiderMainScreen1 As RiderMainScreen
    Friend WithEvents ECarControls As ECarControls
    Friend WithEvents ClimateControlScreen1 As ClimateControlScreen
    Friend WithEvents AirControllScreen1 As AirControllScreen
    Friend WithEvents MediaControls1 As MediaControls
    Friend WithEvents CarDiagnosticControl1 As carDiagnosticControl
    Friend WithEvents CameraViewControl1 As cameraViewControl
    Friend WithEvents cameraFailureBox As PictureBox
    Friend WithEvents ErrorFixScreenControl1 As warningsControl
    Friend WithEvents breakInBox As PictureBox
    Friend WithEvents collisionBox As PictureBox
    Friend WithEvents WindowControl1 As windowControl
    Friend WithEvents RatingsControl1 As ratingsControl
    Friend WithEvents BookTripScreen1 As BookTripScreen
End Class
