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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(25, 402)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(153, 402)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(266, 403)
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
        Me.GroupBox1.Location = New System.Drawing.Point(153, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seasons"
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Checked = True
        Me.radStandard.Location = New System.Drawing.Point(22, 77)
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
        Me.radPeakSeaon.Location = New System.Drawing.Point(22, 48)
        Me.radPeakSeaon.Name = "radPeakSeaon"
        Me.radPeakSeaon.Size = New System.Drawing.Size(89, 17)
        Me.radPeakSeaon.TabIndex = 1
        Me.radPeakSeaon.Text = "Peak Season"
        Me.radPeakSeaon.UseVisualStyleBackColor = True
        '
        'radOffSeason
        '
        Me.radOffSeason.AutoSize = True
        Me.radOffSeason.Location = New System.Drawing.Point(22, 19)
        Me.radOffSeason.Name = "radOffSeason"
        Me.radOffSeason.Size = New System.Drawing.Size(78, 17)
        Me.radOffSeason.TabIndex = 0
        Me.radOffSeason.Text = "Off Season"
        Me.radOffSeason.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Rental days"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sub Total"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(153, 118)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(147, 20)
        Me.txtFirstName.TabIndex = 10
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(153, 149)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(147, 20)
        Me.txtLastName.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(153, 180)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(147, 20)
        Me.txtEmail.TabIndex = 12
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(153, 211)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(147, 20)
        Me.txtPhone.TabIndex = 13
        '
        'txtRentalDays
        '
        Me.txtRentalDays.Location = New System.Drawing.Point(153, 251)
        Me.txtRentalDays.Name = "txtRentalDays"
        Me.txtRentalDays.Size = New System.Drawing.Size(147, 20)
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
        Me.GroupBox2.Location = New System.Drawing.Point(45, 279)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(273, 100)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(108, 68)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(147, 23)
        Me.lblTotal.TabIndex = 14
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(108, 42)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(147, 23)
        Me.lblTax.TabIndex = 13
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(108, 16)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(147, 23)
        Me.lblSubTotal.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Final Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tax"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 447)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtRentalDays)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form1"
        Me.Text = "Vacation Rental"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
