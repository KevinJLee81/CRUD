
Public Class HomeScreen
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCreateEmployee_Click(sender As Object, e As EventArgs) Handles btnCreateEmployee.Click
        My.Forms.EmployeeCreation.Text = Now.ToString
        My.Forms.EmployeeCreation.Show()


    End Sub

    Private Sub HomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisplayComputerName.Text = System.Environment.MachineName
        lblDisplayUserName.Text = System.Environment.UserName
    End Sub

    Private Sub btnDeleteEmployee_Click(sender As Object, e As EventArgs) Handles btnDeleteEmployee.Click
        My.Forms.EmployeeDeletion.Show()
    End Sub

    Private Sub btnReadEmployee_Click(sender As Object, e As EventArgs) Handles btnReadEmployee.Click
        My.Forms.ReadEmployees.Show()
    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        My.Forms.UpdateEmployees.Show()
    End Sub
End Class