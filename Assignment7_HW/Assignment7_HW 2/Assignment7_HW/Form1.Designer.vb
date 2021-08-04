<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BilPhone
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
        Me.optUnlimitedTalk = New System.Windows.Forms.RadioButton()
        Me.opt1500 = New System.Windows.Forms.RadioButton()
        Me.opt800 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optCustomerPhone = New System.Windows.Forms.RadioButton()
        Me.optSimsong = New System.Windows.Forms.RadioButton()
        Me.optIpound = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkUnlimitedText = New System.Windows.Forms.CheckBox()
        Me.chkVideoChat = New System.Windows.Forms.CheckBox()
        Me.lblMonthlSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblMonthlyTotal = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optUnlimitedTalk)
        Me.GroupBox1.Controls.Add(Me.opt1500)
        Me.GroupBox1.Controls.Add(Me.opt800)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(44, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plans"
        '
        'optUnlimitedTalk
        '
        Me.optUnlimitedTalk.AutoSize = True
        Me.optUnlimitedTalk.Location = New System.Drawing.Point(19, 67)
        Me.optUnlimitedTalk.Name = "optUnlimitedTalk"
        Me.optUnlimitedTalk.Size = New System.Drawing.Size(92, 17)
        Me.optUnlimitedTalk.TabIndex = 3
        Me.optUnlimitedTalk.Text = "Unlimited Talk"
        Me.optUnlimitedTalk.UseVisualStyleBackColor = True
        '
        'opt1500
        '
        Me.opt1500.AutoSize = True
        Me.opt1500.Location = New System.Drawing.Point(19, 43)
        Me.opt1500.Name = "opt1500"
        Me.opt1500.Size = New System.Drawing.Size(88, 17)
        Me.opt1500.TabIndex = 2
        Me.opt1500.Text = "1500 minutes"
        Me.opt1500.UseVisualStyleBackColor = True
        '
        'opt800
        '
        Me.opt800.AutoSize = True
        Me.opt800.Checked = True
        Me.opt800.Location = New System.Drawing.Point(19, 19)
        Me.opt800.Name = "opt800"
        Me.opt800.Size = New System.Drawing.Size(82, 17)
        Me.opt800.TabIndex = 1
        Me.opt800.TabStop = True
        Me.opt800.Text = "800 minutes"
        Me.opt800.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optCustomerPhone)
        Me.GroupBox2.Controls.Add(Me.optSimsong)
        Me.GroupBox2.Controls.Add(Me.optIpound)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(254, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Phones"
        '
        'optCustomerPhone
        '
        Me.optCustomerPhone.AutoSize = True
        Me.optCustomerPhone.Checked = True
        Me.optCustomerPhone.Location = New System.Drawing.Point(15, 67)
        Me.optCustomerPhone.Name = "optCustomerPhone"
        Me.optCustomerPhone.Size = New System.Drawing.Size(103, 17)
        Me.optCustomerPhone.TabIndex = 2
        Me.optCustomerPhone.TabStop = True
        Me.optCustomerPhone.Text = "Customer Phone"
        Me.optCustomerPhone.UseVisualStyleBackColor = True
        '
        'optSimsong
        '
        Me.optSimsong.AutoSize = True
        Me.optSimsong.Location = New System.Drawing.Point(15, 19)
        Me.optSimsong.Name = "optSimsong"
        Me.optSimsong.Size = New System.Drawing.Size(83, 17)
        Me.optSimsong.TabIndex = 0
        Me.optSimsong.Text = "Simsong AG"
        Me.optSimsong.UseVisualStyleBackColor = True
        '
        'optIpound
        '
        Me.optIpound.AutoSize = True
        Me.optIpound.Location = New System.Drawing.Point(15, 43)
        Me.optIpound.Name = "optIpound"
        Me.optIpound.Size = New System.Drawing.Size(75, 17)
        Me.optIpound.TabIndex = 1
        Me.optIpound.Text = "Ipound XV"
        Me.optIpound.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkUnlimitedText)
        Me.GroupBox3.Controls.Add(Me.chkVideoChat)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(44, 192)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'chkUnlimitedText
        '
        Me.chkUnlimitedText.AutoSize = True
        Me.chkUnlimitedText.Location = New System.Drawing.Point(16, 30)
        Me.chkUnlimitedText.Name = "chkUnlimitedText"
        Me.chkUnlimitedText.Size = New System.Drawing.Size(93, 17)
        Me.chkUnlimitedText.TabIndex = 13
        Me.chkUnlimitedText.Text = "Unlimited Text"
        Me.chkUnlimitedText.UseVisualStyleBackColor = True
        '
        'chkVideoChat
        '
        Me.chkVideoChat.AutoSize = True
        Me.chkVideoChat.Location = New System.Drawing.Point(16, 67)
        Me.chkVideoChat.Name = "chkVideoChat"
        Me.chkVideoChat.Size = New System.Drawing.Size(78, 17)
        Me.chkVideoChat.TabIndex = 12
        Me.chkVideoChat.Text = "Video Chat"
        Me.chkVideoChat.UseVisualStyleBackColor = True
        '
        'lblMonthlSubTotal
        '
        Me.lblMonthlSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthlSubTotal.Location = New System.Drawing.Point(298, 191)
        Me.lblMonthlSubTotal.Name = "lblMonthlSubTotal"
        Me.lblMonthlSubTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblMonthlSubTotal.TabIndex = 3
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(298, 230)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 4
        '
        'lblMonthlyTotal
        '
        Me.lblMonthlyTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthlyTotal.Location = New System.Drawing.Point(298, 269)
        Me.lblMonthlyTotal.Name = "lblMonthlyTotal"
        Me.lblMonthlyTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblMonthlyTotal.TabIndex = 5
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(216, 269)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(76, 13)
        Me.label.TabIndex = 8
        Me.label.Text = "Momthly Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Monthly subTotal:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(31, 361)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(177, 361)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(323, 361)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'BilPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 412)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblMonthlyTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblMonthlSubTotal)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BilPhone"
        Me.Text = "Phone Bill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optUnlimitedTalk As RadioButton
    Friend WithEvents opt1500 As RadioButton
    Friend WithEvents opt800 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optCustomerPhone As RadioButton
    Friend WithEvents optSimsong As RadioButton
    Friend WithEvents optIpound As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblMonthlSubTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblMonthlyTotal As Label
    Friend WithEvents label As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkUnlimitedText As CheckBox
    Friend WithEvents chkVideoChat As CheckBox
End Class
