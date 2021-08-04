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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblPhoneTotal = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblPackageChange = New System.Windows.Forms.Label()
        Me.lblTotalMonthly = New System.Windows.Forms.Label()
        Me.lblPhoneSubTotql = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radUnlimitedMinutes = New System.Windows.Forms.RadioButton()
        Me.rad1500Minutes = New System.Windows.Forms.RadioButton()
        Me.rad800Minutes = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckbTextMessaging = New System.Windows.Forms.CheckBox()
        Me.ckbEmail = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radModel200 = New System.Windows.Forms.RadioButton()
        Me.radModel110 = New System.Windows.Forms.RadioButton()
        Me.radModel100 = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNumberOfPhones = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(30, 384)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(164, 51)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(30, 451)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(164, 51)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTax)
        Me.GroupBox4.Controls.Add(Me.lblPhoneTotal)
        Me.GroupBox4.Controls.Add(Me.lblOptions)
        Me.GroupBox4.Controls.Add(Me.lblPackageChange)
        Me.GroupBox4.Controls.Add(Me.lblTotalMonthly)
        Me.GroupBox4.Controls.Add(Me.lblPhoneSubTotql)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(223, 268)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(225, 234)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Plan Totals"
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(109, 58)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(96, 19)
        Me.lblTax.TabIndex = 11
        '
        'lblPhoneTotal
        '
        Me.lblPhoneTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneTotal.Location = New System.Drawing.Point(109, 92)
        Me.lblPhoneTotal.Name = "lblPhoneTotal"
        Me.lblPhoneTotal.Size = New System.Drawing.Size(96, 19)
        Me.lblPhoneTotal.TabIndex = 10
        '
        'lblOptions
        '
        Me.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptions.Location = New System.Drawing.Point(109, 126)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(96, 19)
        Me.lblOptions.TabIndex = 9
        '
        'lblPackageChange
        '
        Me.lblPackageChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackageChange.Location = New System.Drawing.Point(109, 160)
        Me.lblPackageChange.Name = "lblPackageChange"
        Me.lblPackageChange.Size = New System.Drawing.Size(96, 19)
        Me.lblPackageChange.TabIndex = 8
        '
        'lblTotalMonthly
        '
        Me.lblTotalMonthly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalMonthly.Location = New System.Drawing.Point(109, 194)
        Me.lblTotalMonthly.Name = "lblTotalMonthly"
        Me.lblTotalMonthly.Size = New System.Drawing.Size(96, 19)
        Me.lblTotalMonthly.TabIndex = 7
        '
        'lblPhoneSubTotql
        '
        Me.lblPhoneSubTotql.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneSubTotql.Location = New System.Drawing.Point(109, 24)
        Me.lblPhoneSubTotql.Name = "lblPhoneSubTotql"
        Me.lblPhoneSubTotql.Size = New System.Drawing.Size(96, 19)
        Me.lblPhoneSubTotql.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Phone Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Options"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Package Change"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Monthly"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Phone Sub Total"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radUnlimitedMinutes)
        Me.GroupBox3.Controls.Add(Me.rad1500Minutes)
        Me.GroupBox3.Controls.Add(Me.rad800Minutes)
        Me.GroupBox3.Location = New System.Drawing.Point(223, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(225, 160)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select a Package"
        '
        'radUnlimitedMinutes
        '
        Me.radUnlimitedMinutes.AutoSize = True
        Me.radUnlimitedMinutes.Location = New System.Drawing.Point(16, 127)
        Me.radUnlimitedMinutes.Name = "radUnlimitedMinutes"
        Me.radUnlimitedMinutes.Size = New System.Drawing.Size(163, 17)
        Me.radUnlimitedMinutes.TabIndex = 2
        Me.radUnlimitedMinutes.TabStop = True
        Me.radUnlimitedMinutes.Text = "Unlimitted Minutes Per Month"
        Me.radUnlimitedMinutes.UseVisualStyleBackColor = True
        '
        'rad1500Minutes
        '
        Me.rad1500Minutes.AutoSize = True
        Me.rad1500Minutes.Location = New System.Drawing.Point(16, 81)
        Me.rad1500Minutes.Name = "rad1500Minutes"
        Me.rad1500Minutes.Size = New System.Drawing.Size(140, 17)
        Me.rad1500Minutes.TabIndex = 1
        Me.rad1500Minutes.TabStop = True
        Me.rad1500Minutes.Text = "1500 Minutes per Month"
        Me.rad1500Minutes.UseVisualStyleBackColor = True
        '
        'rad800Minutes
        '
        Me.rad800Minutes.AutoSize = True
        Me.rad800Minutes.Checked = True
        Me.rad800Minutes.Location = New System.Drawing.Point(16, 41)
        Me.rad800Minutes.Name = "rad800Minutes"
        Me.rad800Minutes.Size = New System.Drawing.Size(134, 17)
        Me.rad800Minutes.TabIndex = 0
        Me.rad800Minutes.TabStop = True
        Me.rad800Minutes.Text = "800 Minutes per Month"
        Me.rad800Minutes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckbTextMessaging)
        Me.GroupBox2.Controls.Add(Me.ckbEmail)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 268)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 101)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Options"
        '
        'ckbTextMessaging
        '
        Me.ckbTextMessaging.AutoSize = True
        Me.ckbTextMessaging.Location = New System.Drawing.Point(16, 64)
        Me.ckbTextMessaging.Name = "ckbTextMessaging"
        Me.ckbTextMessaging.Size = New System.Drawing.Size(101, 17)
        Me.ckbTextMessaging.TabIndex = 1
        Me.ckbTextMessaging.Text = "Text Messaging"
        Me.ckbTextMessaging.UseVisualStyleBackColor = True
        '
        'ckbEmail
        '
        Me.ckbEmail.AutoSize = True
        Me.ckbEmail.Location = New System.Drawing.Point(16, 30)
        Me.ckbEmail.Name = "ckbEmail"
        Me.ckbEmail.Size = New System.Drawing.Size(51, 17)
        Me.ckbEmail.TabIndex = 0
        Me.ckbEmail.Text = "Email"
        Me.ckbEmail.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radModel200)
        Me.GroupBox1.Controls.Add(Me.radModel110)
        Me.GroupBox1.Controls.Add(Me.radModel100)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 159)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Phone"
        '
        'radModel200
        '
        Me.radModel200.AutoSize = True
        Me.radModel200.Location = New System.Drawing.Point(16, 127)
        Me.radModel200.Name = "radModel200"
        Me.radModel200.Size = New System.Drawing.Size(72, 17)
        Me.radModel200.TabIndex = 2
        Me.radModel200.TabStop = True
        Me.radModel200.Text = "Model200"
        Me.radModel200.UseVisualStyleBackColor = True
        '
        'radModel110
        '
        Me.radModel110.AutoSize = True
        Me.radModel110.Location = New System.Drawing.Point(16, 81)
        Me.radModel110.Name = "radModel110"
        Me.radModel110.Size = New System.Drawing.Size(72, 17)
        Me.radModel110.TabIndex = 1
        Me.radModel110.TabStop = True
        Me.radModel110.Text = "Model110"
        Me.radModel110.UseVisualStyleBackColor = True
        '
        'radModel100
        '
        Me.radModel100.AutoSize = True
        Me.radModel100.Checked = True
        Me.radModel100.Location = New System.Drawing.Point(16, 40)
        Me.radModel100.Name = "radModel100"
        Me.radModel100.Size = New System.Drawing.Size(75, 17)
        Me.radModel100.TabIndex = 0
        Me.radModel100.TabStop = True
        Me.radModel100.Text = "Model 100"
        Me.radModel100.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(112, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Number of Phones"
        '
        'txtNumberOfPhones
        '
        Me.txtNumberOfPhones.Location = New System.Drawing.Point(223, 31)
        Me.txtNumberOfPhones.Name = "txtNumberOfPhones"
        Me.txtNumberOfPhones.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfPhones.TabIndex = 12
        '
        'frmFamily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 526)
        Me.Controls.Add(Me.txtNumberOfPhones)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
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

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblTax As Label
    Friend WithEvents lblPhoneTotal As Label
    Friend WithEvents lblOptions As Label
    Friend WithEvents lblPackageChange As Label
    Friend WithEvents lblTotalMonthly As Label
    Friend WithEvents lblPhoneSubTotql As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radUnlimitedMinutes As RadioButton
    Friend WithEvents rad1500Minutes As RadioButton
    Friend WithEvents rad800Minutes As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ckbTextMessaging As CheckBox
    Friend WithEvents ckbEmail As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radModel200 As RadioButton
    Friend WithEvents radModel110 As RadioButton
    Friend WithEvents radModel100 As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNumberOfPhones As TextBox
End Class
