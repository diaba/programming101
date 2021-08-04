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
        Me.txt = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radAAA = New System.Windows.Forms.RadioButton()
        Me.radAARP = New System.Windows.Forms.RadioButton()
        Me.chkRepeating = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.Days = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radPeak = New System.Windows.Forms.RadioButton()
        Me.radOff = New System.Windows.Forms.RadioButton()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txt.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.Controls.Add(Me.Label3)
        Me.txt.Controls.Add(Me.Label2)
        Me.txt.Controls.Add(Me.GroupBox1)
        Me.txt.Controls.Add(Me.chkRepeating)
        Me.txt.Controls.Add(Me.Label1)
        Me.txt.Controls.Add(Me.cboState)
        Me.txt.Controls.Add(Me.Days)
        Me.txt.Controls.Add(Me.GroupBox3)
        Me.txt.Controls.Add(Me.txtDays)
        Me.txt.Controls.Add(Me.txtLastName)
        Me.txt.Controls.Add(Me.txtFirstName)
        Me.txt.Location = New System.Drawing.Point(20, 14)
        Me.txt.Margin = New System.Windows.Forms.Padding(2)
        Me.txt.Name = "txt"
        Me.txt.Padding = New System.Windows.Forms.Padding(2)
        Me.txt.Size = New System.Drawing.Size(227, 319)
        Me.txt.TabIndex = 0
        Me.txt.TabStop = False
        Me.txt.Text = "Customer Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "First Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radAAA)
        Me.GroupBox1.Controls.Add(Me.radAARP)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 209)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 71)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discount"
        '
        'radAAA
        '
        Me.radAAA.AutoSize = True
        Me.radAAA.Location = New System.Drawing.Point(14, 19)
        Me.radAAA.Name = "radAAA"
        Me.radAAA.Size = New System.Drawing.Size(46, 17)
        Me.radAAA.TabIndex = 7
        Me.radAAA.TabStop = True
        Me.radAAA.Text = "AAA"
        Me.radAAA.UseVisualStyleBackColor = True
        '
        'radAARP
        '
        Me.radAARP.AutoSize = True
        Me.radAARP.Location = New System.Drawing.Point(14, 42)
        Me.radAARP.Name = "radAARP"
        Me.radAARP.Size = New System.Drawing.Size(54, 17)
        Me.radAARP.TabIndex = 8
        Me.radAARP.TabStop = True
        Me.radAARP.Text = "AARP"
        Me.radAARP.UseVisualStyleBackColor = True
        '
        'chkRepeating
        '
        Me.chkRepeating.AutoSize = True
        Me.chkRepeating.Location = New System.Drawing.Point(76, 286)
        Me.chkRepeating.Name = "chkRepeating"
        Me.chkRepeating.Size = New System.Drawing.Size(122, 17)
        Me.chkRepeating.TabIndex = 9
        Me.chkRepeating.Text = "Repeating Customer"
        Me.chkRepeating.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "State"
        '
        'cboState
        '
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"Kentuky", "Florida", "Ohio", "Indiana"})
        Me.cboState.Location = New System.Drawing.Point(130, 73)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(68, 21)
        Me.cboState.TabIndex = 5
        '
        'Days
        '
        Me.Days.Location = New System.Drawing.Point(16, 104)
        Me.Days.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Days.Name = "Days"
        Me.Days.Size = New System.Drawing.Size(67, 15)
        Me.Days.TabIndex = 4
        Me.Days.Text = "Days:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radPeak)
        Me.GroupBox3.Controls.Add(Me.radOff)
        Me.GroupBox3.Controls.Add(Me.radStandard)
        Me.GroupBox3.Location = New System.Drawing.Point(65, 123)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(133, 81)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Season"
        '
        'radPeak
        '
        Me.radPeak.AutoSize = True
        Me.radPeak.Location = New System.Drawing.Point(14, 56)
        Me.radPeak.Margin = New System.Windows.Forms.Padding(2)
        Me.radPeak.Name = "radPeak"
        Me.radPeak.Size = New System.Drawing.Size(89, 17)
        Me.radPeak.TabIndex = 2
        Me.radPeak.Text = "Peak Season"
        Me.radPeak.UseVisualStyleBackColor = True
        '
        'radOff
        '
        Me.radOff.AutoSize = True
        Me.radOff.Location = New System.Drawing.Point(14, 35)
        Me.radOff.Margin = New System.Windows.Forms.Padding(2)
        Me.radOff.Name = "radOff"
        Me.radOff.Size = New System.Drawing.Size(78, 17)
        Me.radOff.TabIndex = 1
        Me.radOff.Text = "Off Season"
        Me.radOff.UseVisualStyleBackColor = True
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Checked = True
        Me.radStandard.Location = New System.Drawing.Point(14, 17)
        Me.radStandard.Margin = New System.Windows.Forms.Padding(2)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(107, 17)
        Me.radStandard.TabIndex = 0
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard Season"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(130, 99)
        Me.txtDays.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(68, 20)
        Me.txtDays.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(130, 45)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(68, 20)
        Me.txtLastName.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(130, 16)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(68, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblTax)
        Me.GroupBox2.Controls.Add(Me.lblSubtotal)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 337)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(227, 112)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totals"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tax:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Subtotal:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(103, 77)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(67, 15)
        Me.lblTotal.TabIndex = 2
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(103, 52)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(67, 15)
        Me.lblTax.TabIndex = 1
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(103, 27)
        Me.lblSubtotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(67, 15)
        Me.lblSubtotal.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(20, 453)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(56, 19)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(105, 453)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(56, 19)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(190, 453)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 19)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 483)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Vacationers Data"
        Me.txt.ResumeLayout(False)
        Me.txt.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radPeak As RadioButton
    Friend WithEvents radOff As RadioButton
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Days As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboState As ComboBox
    Friend WithEvents chkRepeating As CheckBox
    Friend WithEvents radAARP As RadioButton
    Friend WithEvents radAAA As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
