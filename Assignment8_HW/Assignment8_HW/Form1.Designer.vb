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
        Me.Software = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optPurchase = New System.Windows.Forms.RadioButton()
        Me.optLease = New System.Windows.Forms.RadioButton()
        Me.chkSupport = New System.Windows.Forms.CheckBox()
        Me.chkTraining = New System.Windows.Forms.CheckBox()
        Me.chkBackupServer = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFirstYear = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOngoingPrice = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Software.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Software
        '
        Me.Software.Controls.Add(Me.optLease)
        Me.Software.Controls.Add(Me.optPurchase)
        Me.Software.Location = New System.Drawing.Point(23, 38)
        Me.Software.Name = "Software"
        Me.Software.Size = New System.Drawing.Size(151, 75)
        Me.Software.TabIndex = 0
        Me.Software.TabStop = False
        Me.Software.Text = "Software"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkBackupServer)
        Me.GroupBox2.Controls.Add(Me.chkTraining)
        Me.GroupBox2.Controls.Add(Me.chkSupport)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 101)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'optPurchase
        '
        Me.optPurchase.AutoSize = True
        Me.optPurchase.Location = New System.Drawing.Point(7, 20)
        Me.optPurchase.Name = "optPurchase"
        Me.optPurchase.Size = New System.Drawing.Size(70, 17)
        Me.optPurchase.TabIndex = 0
        Me.optPurchase.Text = "Purchase"
        Me.optPurchase.UseVisualStyleBackColor = True
        '
        'optLease
        '
        Me.optLease.AutoSize = True
        Me.optLease.Checked = True
        Me.optLease.Location = New System.Drawing.Point(7, 44)
        Me.optLease.Name = "optLease"
        Me.optLease.Size = New System.Drawing.Size(54, 17)
        Me.optLease.TabIndex = 1
        Me.optLease.TabStop = True
        Me.optLease.Text = "Lease"
        Me.optLease.UseVisualStyleBackColor = True
        '
        'chkSupport
        '
        Me.chkSupport.AutoSize = True
        Me.chkSupport.Location = New System.Drawing.Point(7, 20)
        Me.chkSupport.Name = "chkSupport"
        Me.chkSupport.Size = New System.Drawing.Size(89, 17)
        Me.chkSupport.TabIndex = 0
        Me.chkSupport.Text = "24/7 Support"
        Me.chkSupport.UseVisualStyleBackColor = True
        '
        'chkTraining
        '
        Me.chkTraining.AutoSize = True
        Me.chkTraining.Location = New System.Drawing.Point(7, 44)
        Me.chkTraining.Name = "chkTraining"
        Me.chkTraining.Size = New System.Drawing.Size(64, 17)
        Me.chkTraining.TabIndex = 1
        Me.chkTraining.Text = "Training"
        Me.chkTraining.UseVisualStyleBackColor = True
        '
        'chkBackupServer
        '
        Me.chkBackupServer.AutoSize = True
        Me.chkBackupServer.Location = New System.Drawing.Point(7, 68)
        Me.chkBackupServer.Name = "chkBackupServer"
        Me.chkBackupServer.Size = New System.Drawing.Size(97, 17)
        Me.chkBackupServer.TabIndex = 2
        Me.chkBackupServer.Text = "Backup Server"
        Me.chkBackupServer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First year intial check"
        '
        'lblFirstYear
        '
        Me.lblFirstYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirstYear.Location = New System.Drawing.Point(319, 103)
        Me.lblFirstYear.Name = "lblFirstYear"
        Me.lblFirstYear.Size = New System.Drawing.Size(100, 23)
        Me.lblFirstYear.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Outgoing annual price"
        '
        'lblOngoingPrice
        '
        Me.lblOngoingPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOngoingPrice.Location = New System.Drawing.Point(319, 155)
        Me.lblOngoingPrice.Name = "lblOngoingPrice"
        Me.lblOngoingPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblOngoingPrice.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(38, 270)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(191, 270)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(344, 270)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 336)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblOngoingPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFirstYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Software)
        Me.Name = "Form1"
        Me.Text = "Ongoing cost"
        Me.Software.ResumeLayout(False)
        Me.Software.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Software As GroupBox
    Friend WithEvents optLease As RadioButton
    Friend WithEvents optPurchase As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkBackupServer As CheckBox
    Friend WithEvents chkTraining As CheckBox
    Friend WithEvents chkSupport As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFirstYear As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblOngoingPrice As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
