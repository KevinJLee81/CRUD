<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReadEmployees
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CRUDdbDataSet1 = New CRUD.CRUDdbDataSet1()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StartingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecurityLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRUDdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIdDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.SecurityLevelDataGridViewTextBoxColumn, Me.StartingDateDataGridViewTextBoxColumn})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(555, 338)
        Me.DataGridView1.TabIndex = 0
        '
        'CRUDdbDataSet1
        '
        Me.CRUDdbDataSet1.DataSetName = "CRUDdbDataSet1"
        Me.CRUDdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.CRUDdbDataSet1
        '
        'StartingDateDataGridViewTextBoxColumn
        '
        Me.StartingDateDataGridViewTextBoxColumn.DataPropertyName = "Starting Date"
        Me.StartingDateDataGridViewTextBoxColumn.HeaderText = "Starting Date"
        Me.StartingDateDataGridViewTextBoxColumn.Name = "StartingDateDataGridViewTextBoxColumn"
        '
        'SecurityLevelDataGridViewTextBoxColumn
        '
        Me.SecurityLevelDataGridViewTextBoxColumn.DataPropertyName = "Security Level"
        Me.SecurityLevelDataGridViewTextBoxColumn.HeaderText = "Security Level"
        Me.SecurityLevelDataGridViewTextBoxColumn.Name = "SecurityLevelDataGridViewTextBoxColumn"
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        '
        'EmployeeIdDataGridViewTextBoxColumn
        '
        Me.EmployeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId"
        Me.EmployeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId"
        Me.EmployeeIdDataGridViewTextBoxColumn.Name = "EmployeeIdDataGridViewTextBoxColumn"
        '
        'ReadEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 362)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ReadEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReadEmployees"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRUDdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EmployeeIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SecurityLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CRUDdbDataSet1 As CRUDdbDataSet1
    Friend WithEvents EmployeesBindingSource As BindingSource
End Class
