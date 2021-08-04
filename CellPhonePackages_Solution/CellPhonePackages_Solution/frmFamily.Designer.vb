<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamily
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotalMonthly = New System.Windows.Forms.Label()
        Me.lblPackageCharge = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblPhoneTotal = New System.Windows.Forms.Label()
        Me.lbltax = New System.Windows.Forms.Label()
        Me.lblPhoneSubTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radUnlimited = New System.Windows.Forms.RadioButton()
        Me.rad1500Minutes = New System.Windows.Forms.RadioButton()
        Me.rad800Minutes = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkText = New System.Windows.Forms.CheckBox()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radModel200 = New System.Windows.Forms.RadioButton()
        Me.radModel110 = New System.Windows.Forms.RadioButton()
        Me.radModel100 = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtNumberofPhones = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(21, 545)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(264, 76)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotalMonthly)
        Me.GroupBox4.Controls.Add(Me.lblPackageCharge)
        Me.GroupBox4.Controls.Add(Me.lblOptions)
        Me.GroupBox4.Controls.Add(Me.lblPhoneTotal)
        Me.GroupBox4.Controls.Add(Me.lbltax)
        Me.GroupBox4.Controls.Add(Me.lblPhoneSubTotal)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(320, 275)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(286, 358)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Plan Total"
        '
        'lblTotalMonthly
        '
        Me.lblTotalMonthly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalMonthly.Location = New System.Drawing.Point(147, 281)
        Me.lblTotalMonthly.Name = "lblTotalMonthly"
        Me.lblTotalMonthly.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalMonthly.TabIndex = 11
        '
        'lblPackageCharge
        '
        Me.lblPackageCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackageCharge.Location = New System.Drawing.Point(147, 231)
        Me.lblPackageCharge.Name = "lblPackageCharge"
        Me.lblPackageCharge.Size = New System.Drawing.Size(100, 23)
        Me.lblPackageCharge.TabIndex = 10
        '
        'lblOptions
        '
        Me.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptions.Location = New System.Drawing.Point(147, 182)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(100, 23)
        Me.lblOptions.TabIndex = 9
        '
        'lblPhoneTotal
        '
        Me.lblPhoneTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneTotal.Location = New System.Drawing.Point(147, 130)
        Me.lblPhoneTotal.Name = "lblPhoneTotal"
        Me.lblPhoneTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblPhoneTotal.TabIndex = 8
        '
        'lbltax
        '
        Me.lbltax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltax.Location = New System.Drawing.Point(147, 81)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(100, 23)
        Me.lbltax.TabIndex = 7
        '
        'lblPhoneSubTotal
        '
        Me.lblPhoneSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneSubTotal.Location = New System.Drawing.Point(147, 39)
        Me.lblPhoneSubTotal.Name = "lblPhoneSubTotal"
        Me.lblPhoneSubTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblPhoneSubTotal.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Monthly"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Package Charge"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Options"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Phone Sub Total"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radUnlimited)
        Me.GroupBox3.Controls.Add(Me.rad1500Minutes)
        Me.GroupBox3.Controls.Add(Me.rad800Minutes)
        Me.GroupBox3.Location = New System.Drawing.Point(320, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(286, 172)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select a Package"
        '
        'radUnlimited
        '
        Me.radUnlimited.AutoSize = True
        Me.radUnlimited.Location = New System.Drawing.Point(38, 115)
        Me.radUnlimited.Name = "radUnlimited"
        Me.radUnlimited.Size = New System.Drawing.Size(237, 24)
        Me.radUnlimited.TabIndex = 2
        Me.radUnlimited.Text = "Unlimited Minutes Per Month"
        Me.radUnlimited.UseVisualStyleBackColor = True
        '
        'rad1500Minutes
        '
        Me.rad1500Minutes.AutoSize = True
        Me.rad1500Minutes.Location = New System.Drawing.Point(38, 69)
        Me.rad1500Minutes.Name = "rad1500Minutes"
        Me.rad1500Minutes.Size = New System.Drawing.Size(206, 24)
        Me.rad1500Minutes.TabIndex = 1
        Me.rad1500Minutes.Text = "1500 Minutes per Month"
        Me.rad1500Minutes.UseVisualStyleBackColor = True
        '
        'rad800Minutes
        '
        Me.rad800Minutes.AutoSize = True
        Me.rad800Minutes.Checked = True
        Me.rad800Minutes.Location = New System.Drawing.Point(39, 25)
        Me.rad800Minutes.Name = "rad800Minutes"
        Me.rad800Minutes.Size = New System.Drawing.Size(198, 24)
        Me.rad800Minutes.TabIndex = 0
        Me.rad800Minutes.TabStop = True
        Me.rad800Minutes.Text = "800 Minutes Per Month"
        Me.rad800Minutes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkText)
        Me.GroupBox2.Controls.Add(Me.chkEmail)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 124)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Options"
        '
        'chkText
        '
        Me.chkText.AutoSize = True
        Me.chkText.Location = New System.Drawing.Point(59, 79)
        Me.chkText.Name = "chkText"
        Me.chkText.Size = New System.Drawing.Size(146, 24)
        Me.chkText.TabIndex = 1
        Me.chkText.Text = "Text Messaging"
        Me.chkText.UseVisualStyleBackColor = True
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(59, 36)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(78, 24)
        Me.chkEmail.TabIndex = 0
        Me.chkEmail.Text = "Email "
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radModel200)
        Me.GroupBox1.Controls.Add(Me.radModel110)
        Me.GroupBox1.Controls.Add(Me.radModel100)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 165)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Phone"
        '
        'radModel200
        '
        Me.radModel200.AutoSize = True
        Me.radModel200.Location = New System.Drawing.Point(59, 115)
        Me.radModel200.Name = "radModel200"
        Me.radModel200.Size = New System.Drawing.Size(108, 24)
        Me.radModel200.TabIndex = 2
        Me.radModel200.Text = "Model 200"
        Me.radModel200.UseVisualStyleBackColor = True
        '
        'radModel110
        '
        Me.radModel110.AutoSize = True
        Me.radModel110.Location = New System.Drawing.Point(59, 69)
        Me.radModel110.Name = "radModel110"
        Me.radModel110.Size = New System.Drawing.Size(108, 24)
        Me.radModel110.TabIndex = 1
        Me.radModel110.Text = "Model 110"
        Me.radModel110.UseVisualStyleBackColor = True
        '
        'radModel100
        '
        Me.radModel100.AutoSize = True
        Me.radModel100.Checked = True
        Me.radModel100.Location = New System.Drawing.Point(59, 26)
        Me.radModel100.Name = "radModel100"
        Me.radModel100.Size = New System.Drawing.Size(108, 24)
        Me.radModel100.TabIndex = 0
        Me.radModel100.TabStop = True
        Me.radModel100.Text = "Model 100"
        Me.radModel100.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(21, 439)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(264, 77)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtNumberofPhones
        '
        Me.txtNumberofPhones.Location = New System.Drawing.Point(168, 19)
        Me.txtNumberofPhones.Name = "txtNumberofPhones"
        Me.txtNumberofPhones.Size = New System.Drawing.Size(100, 26)
        Me.txtNumberofPhones.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Number of Phones:"
        '
        'frmFamily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 649)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNumberofPhones)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmFamily"
        Me.Text = "Family Plan"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblTotalMonthly As Label
    Friend WithEvents lblPackageCharge As Label
    Friend WithEvents lblOptions As Label
    Friend WithEvents lblPhoneTotal As Label
    Friend WithEvents lbltax As Label
    Friend WithEvents lblPhoneSubTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radUnlimited As RadioButton
    Friend WithEvents rad1500Minutes As RadioButton
    Friend WithEvents rad800Minutes As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkText As CheckBox
    Friend WithEvents chkEmail As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radModel200 As RadioButton
    Friend WithEvents radModel110 As RadioButton
    Friend WithEvents radModel100 As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtNumberofPhones As TextBox
    Friend WithEvents Label7 As Label
End Class
