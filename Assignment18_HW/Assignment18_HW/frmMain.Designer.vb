<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFamilyPlan = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIndividualPlan
        '
        Me.btnIndividualPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIndividualPlan.Location = New System.Drawing.Point(207, 80)
        Me.btnIndividualPlan.Name = "btnIndividualPlan"
        Me.btnIndividualPlan.Size = New System.Drawing.Size(158, 55)
        Me.btnIndividualPlan.TabIndex = 0
        Me.btnIndividualPlan.Text = "Individual Plan"
        Me.btnIndividualPlan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnFamilyPlan)
        Me.GroupBox1.Controls.Add(Me.btnIndividualPlan)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 304)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a plan"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 75)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "The Family Plan allows you to purchase multiple cell phones of the same model. wi" &
    "th each phone sharing one monthly package."
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 55)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "The Individual Plan provides one cell phone and a variety of monthly packages."
        '
        'btnFamilyPlan
        '
        Me.btnFamilyPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFamilyPlan.Location = New System.Drawing.Point(207, 174)
        Me.btnFamilyPlan.Name = "btnFamilyPlan"
        Me.btnFamilyPlan.Size = New System.Drawing.Size(158, 55)
        Me.btnFamilyPlan.TabIndex = 2
        Me.btnFamilyPlan.Text = "Family Plan"
        Me.btnFamilyPlan.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(239, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(158, 55)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 483)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Form1"
        Me.Text = "Cell Phone Packages"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIndividualPlan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFamilyPlan As Button
    Friend WithEvents btnExit As Button
End Class
