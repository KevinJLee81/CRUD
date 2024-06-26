Imports System.Drawing
Public Class EmployeeCreation
    Dim idvalue = 1251
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim result = MessageBox.Show(" Are you sure you want to exit the Application?", "Employee Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If prgDiskSpace.Value = prgDiskSpace.Maximum Then
            MessageBox.Show("No more room on disk!", "Error",
          MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            MessageBox.Show("The entry has been completed", "Employee Entry",
         MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If

        '       If txtEmployeeId.Text = Integer Then
        '
        'end If

        prgDiskSpace.Increment(10)
        lblDiskPercent.Text = String.Format("{0:F2}%", ((prgDiskSpace.Value / prgDiskSpace.Maximum) * 100))


        If txtEmployeeId.Text = idvalue Then
            idvalue = idvalue + 1
        End If

        If prgDiskSpace.Value = prgDiskSpace.Maximum Then
            idvalue = idvalue - 1
        End If

        txtEmployeeId.Text = idvalue
        lblDiskPercent.Text = String.Format("{0:F2}%", ((prgDiskSpace.Value / prgDiskSpace.Maximum) * 100))
        '  If prgDiskSpace.Value = prgDiskSpace.Maximum Then
        '  MessageBox.Show("Disk Space is full!", "Warning!",
        '  MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        '  End If






    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDiskPercent.Text = "0.00%"
        txtEmployeeId.Text = "1251"

        Dim tt As New ToolTip()
        tt.SetToolTip(btnExit, "Alt+X")

        Dim tu As New ToolTip()
        tu.SetToolTip(btnUndo, "Alt+U")

        Dim ts As New ToolTip()
        ts.SetToolTip(btnSubmit, "Alt+S")


    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        If prgDiskSpace.Value = prgDiskSpace.Minimum Then
            MessageBox.Show("There is nothing to undo!", "Employee Entry",
          MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("The undo was successful!", "Employee Entry",
          MessageBoxButtons.OK, MessageBoxIcon.Information)
            prgDiskSpace.Increment(-10)
            If prgDiskSpace.Value = prgDiskSpace.Maximum Then

                idvalue = idvalue + 1
            Else
                idvalue = idvalue - 1
            End If
        End If


        txtEmployeeId.Text = idvalue
        lblDiskPercent.Text = String.Format("{0:F2}%", ((prgDiskSpace.Value / prgDiskSpace.Maximum) * 100))
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' form_background(Me)
        BackColor = Color.Maroon
        Me.BackColor = Color.Maroon
        ' Form2.BackColor = Color.Maroon
        ' Form3.BackColor = Color.Maroon

        Me.ActiveControl.ForeColor = Color.White

    End Sub

    Private Sub BlueErToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueErToolStripMenuItem.Click
        BackColor = Color.DeepSkyBlue
        Me.BackColor = Color.DeepSkyBlue
        '  Form2.BackColor = Color.DeepSkyBlue
        ' Form3.BackColor = Color.DeepSkyBlue
    End Sub

End Class