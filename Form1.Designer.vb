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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 644)
        Me.Controls.Add(Me.InitalScreen1)
        Me.Controls.Add(Me.OwnerMainScreen1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InitalScreen1 As InitalScreen
    Friend WithEvents OwnerMainScreen1 As OwnerMainScreen
End Class
