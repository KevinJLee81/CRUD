Public Class EmployeeDeletion
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tt As New ToolTip()
        tt.SetToolTip(btnExit, "Alt+X")

        Dim tu As New ToolTip()
        tu.SetToolTip(btnUndo, "Alt+U")

        Dim ts As New ToolTip()
        ts.SetToolTip(btnSubmit, "Alt+S")
    End Sub

    Private Sub txtEmployeeDeleteID_MouseHover(sender As Object, e As EventArgs) Handles txtEmployeeDeleteID.MouseHover
        'txtEmployeeDeleteID.Text = ": MouseHover"
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show(" Are you sure you want to exit the Application?", "Employee Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        MessageBox.Show("The undo was successful!", "",
         MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtEmployeeDeleteID.Text = ""
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("The deletion has been completed", "Employee Deletion",
         MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
        BackColor = Color.DeepSkyBlue
        'Form1.BackColor = Color.DeepSkyBlue
        ' Form2.BackColor = Color.DeepSkyBlue
        Me.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Me.ActiveControl.Font = New Font(Me.ActiveControl.Font, FontStyle.Bold)
    End Sub
End Class