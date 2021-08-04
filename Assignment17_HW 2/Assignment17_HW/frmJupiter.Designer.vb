<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJupiter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Jupiter = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Jupiter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Jupiter
        '
        Me.Jupiter.Controls.Add(Me.btnExit)
        Me.Jupiter.Controls.Add(Me.Label8)
        Me.Jupiter.Controls.Add(Me.Label7)
        Me.Jupiter.Controls.Add(Me.Label6)
        Me.Jupiter.Controls.Add(Me.Label5)
        Me.Jupiter.Controls.Add(Me.Label4)
        Me.Jupiter.Controls.Add(Me.Label3)
        Me.Jupiter.Controls.Add(Me.Label2)
        Me.Jupiter.Controls.Add(Me.Label1)
        Me.Jupiter.Location = New System.Drawing.Point(12, 12)
        Me.Jupiter.Name = "Jupiter"
        Me.Jupiter.Size = New System.Drawing.Size(355, 253)
        Me.Jupiter.TabIndex = 2
        Me.Jupiter.TabStop = False
        Me.Jupiter.Text = "Jupiter"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(137, 212)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(189, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "-110°C "
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(189, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "1.899 X 10^27 kg "
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(189, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "5.2028 AU"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(189, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jovian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Surface temperature"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mass"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Average Distance From the sun"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type"
        '
        'frmJupiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 278)
        Me.Controls.Add(Me.Jupiter)
        Me.Name = "frmJupiter"
        Me.Text = "frmJupiter"
        Me.Jupiter.ResumeLayout(False)
        Me.Jupiter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Jupiter As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
