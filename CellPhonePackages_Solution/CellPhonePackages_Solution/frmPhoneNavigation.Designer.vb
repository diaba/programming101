<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhoneNavigation
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
        Me.btnIndividualPlan = New System.Windows.Forms.Button()
        Me.btnFamilyPlan = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIndividualPlan
        '
        Me.btnIndividualPlan.Location = New System.Drawing.Point(62, 45)
        Me.btnIndividualPlan.Name = "btnIndividualPlan"
        Me.btnIndividualPlan.Size = New System.Drawing.Size(161, 91)
        Me.btnIndividualPlan.TabIndex = 0
        Me.btnIndividualPlan.Text = "Individual Plan"
        Me.btnIndividualPlan.UseVisualStyleBackColor = True
        '
        'btnFamilyPlan
        '
        Me.btnFamilyPlan.Location = New System.Drawing.Point(62, 155)
        Me.btnFamilyPlan.Name = "btnFamilyPlan"
        Me.btnFamilyPlan.Size = New System.Drawing.Size(161, 91)
        Me.btnFamilyPlan.TabIndex = 1
        Me.btnFamilyPlan.Text = "Family Plan"
        Me.btnFamilyPlan.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(62, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(161, 91)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPhoneNavigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 399)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFamilyPlan)
        Me.Controls.Add(Me.btnIndividualPlan)
        Me.Name = "frmPhoneNavigation"
        Me.Text = "frmPhoneNavigation"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIndividualPlan As Button
    Friend WithEvents btnFamilyPlan As Button
    Friend WithEvents btnExit As Button
End Class
