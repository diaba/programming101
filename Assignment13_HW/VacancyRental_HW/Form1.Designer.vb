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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.radPeakSeaon = New System.Windows.Forms.RadioButton()
        Me.radOffSeason = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtRentalDays = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbDiscount = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(84, 327)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(199, 327)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(314, 327)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radStandard)
        Me.GroupBox1.Controls.Add(Me.radPeakSeaon)
        Me.GroupBox1.Controls.Add(Me.radOffSeason)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 84)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seasons"
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Checked = True
        Me.radStandard.Location = New System.Drawing.Point(25, 61)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(68, 17)
        Me.radStandard.TabIndex = 2
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'radPeakSeaon
        '
        Me.radPeakSeaon.AutoSize = True
        Me.radPeakSeaon.Location = New System.Drawing.Point(25, 38)
        Me.radPeakSeaon.Name = "radPeakSeaon"
        Me.radPeakSeaon.Size = New System.Drawing.Size(89, 17)
        Me.radPeakSeaon.TabIndex = 1
        Me.radPeakSeaon.Text = "Peak Season"
        Me.radPeakSeaon.UseVisualStyleBackColor = True
        '
        'radOffSeason
        '
        Me.radOffSeason.AutoSize = True
        Me.radOffSeason.Location = New System.Drawing.Point(25, 15)
        Me.radOffSeason.Name = "radOffSeason"
        Me.radOffSeason.Size = New System.Drawing.Size(78, 17)
        Me.radOffSeason.TabIndex = 0
        Me.radOffSeason.Text = "Off Season"
        Me.radOffSeason.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Rental days"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sub Total"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(96, 28)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(74, 20)
        Me.txtFirstName.TabIndex = 10
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(96, 54)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(74, 20)
        Me.txtLastName.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(96, 107)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(74, 20)
        Me.txtEmail.TabIndex = 12
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(97, 133)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(74, 20)
        Me.txtPhone.TabIndex = 13
        '
        'txtRentalDays
        '
        Me.txtRentalDays.Location = New System.Drawing.Point(105, 51)
        Me.txtRentalDays.Name = "txtRentalDays"
        Me.txtRentalDays.Size = New System.Drawing.Size(74, 20)
        Me.txtRentalDays.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblTax)
        Me.GroupBox2.Controls.Add(Me.lblSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 100)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Charges"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(221, 67)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(147, 23)
        Me.lblTotal.TabIndex = 14
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(221, 41)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(147, 23)
        Me.lblTax.TabIndex = 13
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(221, 15)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(147, 23)
        Me.lblSubTotal.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(137, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Final Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(168, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tax"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cmbState)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtPhone)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtEmail)
        Me.GroupBox3.Controls.Add(Me.txtLastName)
        Me.GroupBox3.Controls.Add(Me.txtFirstName)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(193, 181)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Renter Information"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(59, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "State"
        '
        'cmbState
        '
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(96, 80)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(74, 21)
        Me.cmbState.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Discount Program"
        '
        'cmbDiscount
        '
        Me.cmbDiscount.FormattingEnabled = True
        Me.cmbDiscount.Location = New System.Drawing.Point(105, 25)
        Me.cmbDiscount.Name = "cmbDiscount"
        Me.cmbDiscount.Size = New System.Drawing.Size(74, 21)
        Me.cmbDiscount.TabIndex = 16
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.cmbDiscount)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtRentalDays)
        Me.GroupBox4.Location = New System.Drawing.Point(244, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(193, 181)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rental Information"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 360)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form1"
        Me.Text = "Vacation Rental"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents radPeakSeaon As RadioButton
    Friend WithEvents radOffSeason As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtRentalDays As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbDiscount As ComboBox
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
