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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.txtNumber3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSum1 = New System.Windows.Forms.Label()
        Me.lblSum2 = New System.Windows.Forms.Label()
        Me.lblSum3 = New System.Windows.Forms.Label()
        Me.lblRunningTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNumber3)
        Me.GroupBox1.Controls.Add(Me.txtNumber2)
        Me.GroupBox1.Controls.Add(Me.txtNumber1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number 3"
        '
        'txtNumber1
        '
        Me.txtNumber1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtNumber1.Location = New System.Drawing.Point(82, 13)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber1.TabIndex = 3
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(82, 45)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber2.TabIndex = 4
        '
        'txtNumber3
        '
        Me.txtNumber3.Location = New System.Drawing.Point(82, 77)
        Me.txtNumber3.Name = "txtNumber3"
        Me.txtNumber3.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Number 1 + Number 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Number 1 + Number 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Number 2 + Number 3"
        '
        'lblSum1
        '
        Me.lblSum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSum1.Location = New System.Drawing.Point(183, 184)
        Me.lblSum1.Name = "lblSum1"
        Me.lblSum1.Size = New System.Drawing.Size(100, 20)
        Me.lblSum1.TabIndex = 4
        '
        'lblSum2
        '
        Me.lblSum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSum2.Location = New System.Drawing.Point(183, 225)
        Me.lblSum2.Name = "lblSum2"
        Me.lblSum2.Size = New System.Drawing.Size(100, 20)
        Me.lblSum2.TabIndex = 5
        '
        'lblSum3
        '
        Me.lblSum3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSum3.Location = New System.Drawing.Point(183, 266)
        Me.lblSum3.Name = "lblSum3"
        Me.lblSum3.Size = New System.Drawing.Size(100, 20)
        Me.lblSum3.TabIndex = 6
        '
        'lblRunningTotal
        '
        Me.lblRunningTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRunningTotal.Location = New System.Drawing.Point(183, 324)
        Me.lblRunningTotal.Name = "lblRunningTotal"
        Me.lblRunningTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblRunningTotal.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(103, 324)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Running Total"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(222, 377)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(61, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(44, 377)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(61, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(133, 377)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(61, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 451)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblRunningTotal)
        Me.Controls.Add(Me.lblSum3)
        Me.Controls.Add(Me.lblSum2)
        Me.Controls.Add(Me.lblSum1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Running Total"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumber3 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSum1 As Label
    Friend WithEvents lblSum2 As Label
    Friend WithEvents lblSum3 As Label
    Friend WithEvents lblRunningTotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
