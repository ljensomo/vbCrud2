Public Class Form1

    Public Sub loadTable()
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        Dim sql As String = "SELECT * FROM tbl_employees WHERE is_deleted = 1"

        Call connect()
        da = New Odbc.OdbcDataAdapter(sql, con)
        da.Fill(dt)
        dgv.DataSource = dt

        con.Close()
    End Sub

    Public Sub cleaner()
        txtboxEmpID.Text = ""
        txtboxFname.Text = ""
        txtboxMname.Text = ""
        txtboxLname.Text = ""
        dgv.Tag = 0
        toggle(False)
    End Sub

    Public Sub loadEmployeeRecord(id As Integer)
        Dim cmd As Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        Dim sql As String = "SELECT * FROM tbl_employees WHERE id = ?"

        cmd = New Odbc.OdbcCommand(sql, con)
        cmd.Parameters.AddWithValue("@", id)
        da.SelectCommand = cmd
        da.Fill(dt)

        txtboxEmpID.Text = dt.Rows(0)(1)
        txtboxFname.Text = dt.Rows(0)(2)
        txtboxMname.Text = dt.Rows(0)(3)
        txtboxLname.Text = dt.Rows(0)(4)

        con.Close()

    End Sub

    Public Sub toggle(status As Boolean)
        groupboxEmployee.Enabled = status
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
        toggle(False)

        dgv.CurrentCell.Selected = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtboxEmpID.Text = "" Then
            MsgBox("Please input employee ID!", vbExclamation, "Ooops!")
            txtboxEmpID.Focus()
        ElseIf txtboxFname.Text = "" Then
            MsgBox("Please input First Name!", vbExclamation, "Ooops!")
            txtboxFname.Focus()
        ElseIf txtboxLname.Text = "" Then
            MsgBox("Please input Last Name!", vbExclamation, "Ooops!")
            txtboxLname.Focus()
        Else
            Call connect()
            Dim cmd As Odbc.OdbcCommand
            Dim sql As String

            If Val(dgv.Tag) > 0 Then
                ' update record
                sql = "UPDATE tbl_employees SET employee_id = ?, first_name = ?, middle_name = ?, last_name = ? WHERE id = ?"

                cmd = New Odbc.OdbcCommand(sql, con)
                cmd.Parameters.AddWithValue("@", txtboxEmpID.Text)
                cmd.Parameters.AddWithValue("@", txtboxFname.Text)
                cmd.Parameters.AddWithValue("@", txtboxMname.Text)
                cmd.Parameters.AddWithValue("@", txtboxLname.Text)
                cmd.Parameters.AddWithValue("@", dgv.Tag)
                cmd.ExecuteNonQuery()
            Else
                ' insert record
                sql = "INSERT INTO tbl_employees (employee_id, first_name, middle_name, last_name) VALUES (?, ?, ?, ?)"

                cmd = New Odbc.OdbcCommand(sql, con)
                cmd.Parameters.AddWithValue("@", txtboxEmpID.Text)
                cmd.Parameters.AddWithValue("@", txtboxFname.Text)
                cmd.Parameters.AddWithValue("@", txtboxMname.Text)
                cmd.Parameters.AddWithValue("@", txtboxLname.Text)
                cmd.ExecuteNonQuery()
            End If

            con.Close()

            loadTable()
            cleaner()

        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If (e.RowIndex >= 0) Then
            dgv.Tag = dgv.Item(0, e.RowIndex).Value
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Val(dgv.Tag) > 0 Then
            loadEmployeeRecord(Val(dgv.Tag))
            toggle(True)
        Else
            MsgBox("Please select a record!", vbExclamation, "Ooops!")
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Val(dgv.Tag) > 0 Then
            If MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion, "Delete Record") = vbYes Then
                Call connect()

                Dim cmd As Odbc.OdbcCommand
                Dim sql As String = "UPDATE tbl_employees SET is_deleted = 0 WHERE id = ?"
                cmd = New Odbc.OdbcCommand(sql, con)
                cmd.Parameters.AddWithValue("@", dgv.Tag)
                cmd.ExecuteNonQuery()
                con.Close()

                loadTable()
                cleaner()

            End If
        Else
            MsgBox("Please select a record!", vbExclamation, "Ooops!")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call cleaner()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        toggle(True)
    End Sub
End Class
