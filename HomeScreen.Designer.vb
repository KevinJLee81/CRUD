<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeScreen
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
        Me.btnDeleteEmployee = New System.Windows.Forms.Button()
        Me.lblDisplayUserName = New System.Windows.Forms.Label()
        Me.lblDisplayComputerName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCreateEmployee = New System.Windows.Forms.Button()
        Me.btnReadEmployee = New System.Windows.Forms.Button()
        Me.btnUpdateEmployee = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDeleteEmployee
        '
        Me.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteEmployee.ForeColor = System.Drawing.Color.DarkRed
        Me.btnDeleteEmployee.Location = New System.Drawing.Point(54, 193)
        Me.btnDeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteEmployee.Name = "btnDeleteEmployee"
        Me.btnDeleteEmployee.Size = New System.Drawing.Size(178, 28)
        Me.btnDeleteEmployee.TabIndex = 11
        Me.btnDeleteEmployee.Text = "Delete Employee"
        Me.btnDeleteEmployee.UseVisualStyleBackColor = True
        '
        'lblDisplayUserName
        '
        Me.lblDisplayUserName.AutoSize = True
        Me.lblDisplayUserName.Location = New System.Drawing.Point(181, 309)
        Me.lblDisplayUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayUserName.Name = "lblDisplayUserName"
        Me.lblDisplayUserName.Size = New System.Drawing.Size(39, 13)
        Me.lblDisplayUserName.TabIndex = 10
        Me.lblDisplayUserName.Text = "Label3"
        '
        'lblDisplayComputerName
        '
        Me.lblDisplayComputerName.AutoSize = True
        Me.lblDisplayComputerName.Location = New System.Drawing.Point(51, 309)
        Me.lblDisplayComputerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayComputerName.Name = "lblDisplayComputerName"
        Me.lblDisplayComputerName.Size = New System.Drawing.Size(39, 13)
        Me.lblDisplayComputerName.TabIndex = 9
        Me.lblDisplayComputerName.Text = "Label2"
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(54, 246)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(178, 28)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 36)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Welcome"
        '
        'btnCreateEmployee
        '
        Me.btnCreateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateEmployee.ForeColor = System.Drawing.Color.Green
        Me.btnCreateEmployee.Location = New System.Drawing.Point(54, 85)
        Me.btnCreateEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateEmployee.Name = "btnCreateEmployee"
        Me.btnCreateEmployee.Size = New System.Drawing.Size(178, 28)
        Me.btnCreateEmployee.TabIndex = 6
        Me.btnCreateEmployee.Text = "Create Employee"
        Me.btnCreateEmployee.UseVisualStyleBackColor = True
        '
        'btnReadEmployee
        '
        Me.btnReadEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReadEmployee.ForeColor = System.Drawing.Color.MediumPurple
        Me.btnReadEmployee.Location = New System.Drawing.Point(54, 121)
        Me.btnReadEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReadEmployee.Name = "btnReadEmployee"
        Me.btnReadEmployee.Size = New System.Drawing.Size(178, 28)
        Me.btnReadEmployee.TabIndex = 12
        Me.btnReadEmployee.Text = "Read Employee"
        Me.btnReadEmployee.UseVisualStyleBackColor = True
        '
        'btnUpdateEmployee
        '
        Me.btnUpdateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateEmployee.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnUpdateEmployee.Location = New System.Drawing.Point(54, 157)
        Me.btnUpdateEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateEmployee.Name = "btnUpdateEmployee"
        Me.btnUpdateEmployee.Size = New System.Drawing.Size(178, 28)
        Me.btnUpdateEmployee.TabIndex = 13
        Me.btnUpdateEmployee.Text = "Update Employee"
        Me.btnUpdateEmployee.UseVisualStyleBackColor = True
        '
        'HomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.btnUpdateEmployee)
        Me.Controls.Add(Me.btnReadEmployee)
        Me.Controls.Add(Me.btnDeleteEmployee)
        Me.Controls.Add(Me.lblDisplayUserName)
        Me.Controls.Add(Me.lblDisplayComputerName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HomeScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomeScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeleteEmployee As Button
    Friend WithEvents lblDisplayUserName As Label
    Friend WithEvents lblDisplayComputerName As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreateEmployee As Button
    Friend WithEvents btnReadEmployee As Button
    Friend WithEvents btnUpdateEmployee As Button
End Class
