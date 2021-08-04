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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PercentOff = New System.Windows.Forms.Label()
        Me.txtOriginalPrice = New System.Windows.Forms.TextBox()
        Me.txtPercentOff = New System.Windows.Forms.TextBox()
        Me.txtSalePrice = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Original Price"
        '
        'PercentOff
        '
        Me.PercentOff.AutoSize = True
        Me.PercentOff.Location = New System.Drawing.Point(51, 105)
        Me.PercentOff.Name = "PercentOff"
        Me.PercentOff.Size = New System.Drawing.Size(61, 13)
        Me.PercentOff.TabIndex = 1
        Me.PercentOff.Text = "Percent Off"
        '
        'txtOriginalPrice
        '
        Me.txtOriginalPrice.Location = New System.Drawing.Point(167, 51)
        Me.txtOriginalPrice.Name = "txtOriginalPrice"
        Me.txtOriginalPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtOriginalPrice.TabIndex = 2
        '
        'txtPercentOff
        '
        Me.txtPercentOff.Location = New System.Drawing.Point(167, 98)
        Me.txtPercentOff.Name = "txtPercentOff"
        Me.txtPercentOff.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentOff.TabIndex = 3
        '
        'txtSalePrice
        '
        Me.txtSalePrice.Enabled = False
        Me.txtSalePrice.Location = New System.Drawing.Point(80, 160)
        Me.txtSalePrice.Multiline = True
        Me.txtSalePrice.Name = "txtSalePrice"
        Me.txtSalePrice.Size = New System.Drawing.Size(165, 48)
        Me.txtSalePrice.TabIndex = 4
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(51, 271)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(144, 271)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(234, 271)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 334)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtSalePrice)
        Me.Controls.Add(Me.txtPercentOff)
        Me.Controls.Add(Me.txtOriginalPrice)
        Me.Controls.Add(Me.PercentOff)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Sale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PercentOff As Label
    Friend WithEvents txtOriginalPrice As TextBox
    Friend WithEvents txtPercentOff As TextBox
    Friend WithEvents txtSalePrice As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
