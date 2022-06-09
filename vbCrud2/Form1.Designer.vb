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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txtboxEmpID = New System.Windows.Forms.TextBox()
        Me.labelFirstname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxFname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxMname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtboxLname = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middle_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.is_deleted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 0
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.ColumnHeadersHeight = 29
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.employee_id, Me.first_name, Me.middle_name, Me.last_name, Me.is_deleted})
        Me.dgv.Location = New System.Drawing.Point(12, 137)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv.RowTemplate.Height = 29
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(775, 377)
        Me.dgv.TabIndex = 1
        '
        'txtboxEmpID
        '
        Me.txtboxEmpID.Location = New System.Drawing.Point(793, 167)
        Me.txtboxEmpID.Name = "txtboxEmpID"
        Me.txtboxEmpID.Size = New System.Drawing.Size(274, 27)
        Me.txtboxEmpID.TabIndex = 2
        '
        'labelFirstname
        '
        Me.labelFirstname.AutoSize = True
        Me.labelFirstname.Location = New System.Drawing.Point(793, 137)
        Me.labelFirstname.Name = "labelFirstname"
        Me.labelFirstname.Size = New System.Drawing.Size(94, 20)
        Me.labelFirstname.TabIndex = 3
        Me.labelFirstname.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(793, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "First Name"
        '
        'txtboxFname
        '
        Me.txtboxFname.Location = New System.Drawing.Point(793, 254)
        Me.txtboxFname.Name = "txtboxFname"
        Me.txtboxFname.Size = New System.Drawing.Size(274, 27)
        Me.txtboxFname.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(793, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Middle Name"
        '
        'txtboxMname
        '
        Me.txtboxMname.Location = New System.Drawing.Point(793, 343)
        Me.txtboxMname.Name = "txtboxMname"
        Me.txtboxMname.Size = New System.Drawing.Size(274, 27)
        Me.txtboxMname.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(793, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Last Name"
        '
        'txtboxLname
        '
        Me.txtboxLname.Location = New System.Drawing.Point(793, 419)
        Me.txtboxLname.Name = "txtboxLname"
        Me.txtboxLname.Size = New System.Drawing.Size(274, 27)
        Me.txtboxLname.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(793, 463)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(274, 51)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(12, 68)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(205, 51)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(223, 68)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(205, 51)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'employee_id
        '
        Me.employee_id.DataPropertyName = "employee_id"
        Me.employee_id.HeaderText = "EmployeeID"
        Me.employee_id.MinimumWidth = 6
        Me.employee_id.Name = "employee_id"
        Me.employee_id.Width = 125
        '
        'first_name
        '
        Me.first_name.DataPropertyName = "first_name"
        Me.first_name.HeaderText = "First Name"
        Me.first_name.MinimumWidth = 6
        Me.first_name.Name = "first_name"
        Me.first_name.Width = 125
        '
        'middle_name
        '
        Me.middle_name.DataPropertyName = "middle_name"
        Me.middle_name.HeaderText = "Middle Name"
        Me.middle_name.MinimumWidth = 6
        Me.middle_name.Name = "middle_name"
        Me.middle_name.Width = 125
        '
        'last_name
        '
        Me.last_name.DataPropertyName = "last_name"
        Me.last_name.HeaderText = "Last Name"
        Me.last_name.MinimumWidth = 6
        Me.last_name.Name = "last_name"
        Me.last_name.Width = 125
        '
        'is_deleted
        '
        Me.is_deleted.DataPropertyName = "is_deleted"
        Me.is_deleted.HeaderText = "Is Deleted"
        Me.is_deleted.MinimumWidth = 6
        Me.is_deleted.Name = "is_deleted"
        Me.is_deleted.Visible = False
        Me.is_deleted.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 526)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtboxLname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxMname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtboxFname)
        Me.Controls.Add(Me.labelFirstname)
        Me.Controls.Add(Me.txtboxEmpID)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents txtboxEmpID As TextBox
    Friend WithEvents labelFirstname As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxFname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxMname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxLname As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents employee_id As DataGridViewTextBoxColumn
    Friend WithEvents first_name As DataGridViewTextBoxColumn
    Friend WithEvents middle_name As DataGridViewTextBoxColumn
    Friend WithEvents last_name As DataGridViewTextBoxColumn
    Friend WithEvents is_deleted As DataGridViewTextBoxColumn
End Class
