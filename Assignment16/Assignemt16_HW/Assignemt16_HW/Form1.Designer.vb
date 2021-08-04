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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radManagment = New System.Windows.Forms.RadioButton()
        Me.radNonManagement = New System.Windows.Forms.RadioButton()
        Me.txtAirTravelCost = New System.Windows.Forms.TextBox()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtLodgingCost = New System.Windows.Forms.TextBox()
        Me.txtFoodCost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblEmployeeResponsible = New System.Windows.Forms.Label()
        Me.lblTotalTravelCost = New System.Windows.Forms.Label()
        Me.lblReimbursementbyCompany = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txtAirTravelCost)
        Me.GroupBox1.Controls.Add(Me.txtDays)
        Me.GroupBox1.Controls.Add(Me.txtLodgingCost)
        Me.GroupBox1.Controls.Add(Me.txtFoodCost)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Information"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radManagment)
        Me.GroupBox3.Controls.Add(Me.radNonManagement)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 67)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'radManagment
        '
        Me.radManagment.AutoSize = True
        Me.radManagment.Location = New System.Drawing.Point(88, 15)
        Me.radManagment.Name = "radManagment"
        Me.radManagment.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.radManagment.Size = New System.Drawing.Size(81, 17)
        Me.radManagment.TabIndex = 6
        Me.radManagment.Text = "Mangement"
        Me.radManagment.UseVisualStyleBackColor = True
        '
        'radNonManagement
        '
        Me.radNonManagement.AutoSize = True
        Me.radNonManagement.Checked = True
        Me.radNonManagement.Location = New System.Drawing.Point(65, 38)
        Me.radNonManagement.Name = "radNonManagement"
        Me.radNonManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.radNonManagement.Size = New System.Drawing.Size(104, 17)
        Me.radNonManagement.TabIndex = 5
        Me.radNonManagement.TabStop = True
        Me.radNonManagement.Text = "Non Managemnt"
        Me.radNonManagement.UseVisualStyleBackColor = True
        '
        'txtAirTravelCost
        '
        Me.txtAirTravelCost.Location = New System.Drawing.Point(94, 126)
        Me.txtAirTravelCost.Name = "txtAirTravelCost"
        Me.txtAirTravelCost.Size = New System.Drawing.Size(100, 20)
        Me.txtAirTravelCost.TabIndex = 12
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(94, 100)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(100, 20)
        Me.txtDays.TabIndex = 11
        '
        'txtLodgingCost
        '
        Me.txtLodgingCost.Location = New System.Drawing.Point(94, 153)
        Me.txtLodgingCost.Name = "txtLodgingCost"
        Me.txtLodgingCost.Size = New System.Drawing.Size(100, 20)
        Me.txtLodgingCost.TabIndex = 10
        '
        'txtFoodCost
        '
        Me.txtFoodCost.Location = New System.Drawing.Point(94, 179)
        Me.txtFoodCost.Name = "txtFoodCost"
        Me.txtFoodCost.Size = New System.Drawing.Size(100, 20)
        Me.txtFoodCost.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Air Travel Cost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Days"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Lodging Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Food Cost"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblEmployeeResponsible)
        Me.GroupBox2.Controls.Add(Me.lblTotalTravelCost)
        Me.GroupBox2.Controls.Add(Me.lblReimbursementbyCompany)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reimbursement"
        '
        'lblEmployeeResponsible
        '
        Me.lblEmployeeResponsible.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeResponsible.Location = New System.Drawing.Point(185, 77)
        Me.lblEmployeeResponsible.Name = "lblEmployeeResponsible"
        Me.lblEmployeeResponsible.Size = New System.Drawing.Size(54, 15)
        Me.lblEmployeeResponsible.TabIndex = 12
        '
        'lblTotalTravelCost
        '
        Me.lblTotalTravelCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTravelCost.Location = New System.Drawing.Point(185, 23)
        Me.lblTotalTravelCost.Name = "lblTotalTravelCost"
        Me.lblTotalTravelCost.Size = New System.Drawing.Size(54, 15)
        Me.lblTotalTravelCost.TabIndex = 14
        '
        'lblReimbursementbyCompany
        '
        Me.lblReimbursementbyCompany.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReimbursementbyCompany.Location = New System.Drawing.Point(185, 51)
        Me.lblReimbursementbyCompany.Name = "lblReimbursementbyCompany"
        Me.lblReimbursementbyCompany.Size = New System.Drawing.Size(54, 15)
        Me.lblReimbursementbyCompany.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Employee Responsible Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total Travel Cost "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Amount Reimbursed by Company"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(34, 388)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(214, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(124, 388)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Travel Expenses"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radManagment As RadioButton
    Friend WithEvents radNonManagement As RadioButton
    Friend WithEvents txtAirTravelCost As TextBox
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtLodgingCost As TextBox
    Friend WithEvents txtFoodCost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblEmployeeResponsible As Label
    Friend WithEvents lblTotalTravelCost As Label
    Friend WithEvents lblReimbursementbyCompany As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
End Class
