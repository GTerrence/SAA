Public Class FormMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RbOn1.Checked = True
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        If CbMode.Text = "Add" Then
            If RbOn1.Checked = True Then
                LibLeft.Items.Add(TbData.Text)
            Else
                LibRight.Items.Add(TbData.Text)
            End If
        ElseIf CbMode.Text = "Replace" Then
            If RbOn1.Checked = True Then
                If LibLeft.SelectedItems.Count = 1 Then
                    LibLeft.Items.Insert(LibLeft.SelectedIndex, TbData.Text)
                    LibLeft.Items.RemoveAt(LibLeft.SelectedIndex)
                Else
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                If LibRight.SelectedItems.Count = 1 Then
                    LibRight.Items.Insert(LibRight.SelectedIndex, TbData.Text)
                    LibRight.Items.RemoveAt(LibRight.SelectedIndex)
                Else
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Else
            MessageBox.Show("Mode Belum Dipilih", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnAR_Click(sender As Object, e As EventArgs) Handles BtnAR.Click
        For i = 0 To LibLeft.Items.Count - 1
            LibRight.Items.Add(LibLeft.Items(i))
        Next
        LibLeft.Items.Clear()
    End Sub

    Private Sub BtnR_Click(sender As Object, e As EventArgs) Handles BtnR.Click
        For i = 0 To LibLeft.SelectedItems.Count - 1
            Try
                LibRight.Items.Add(LibLeft.Items(LibLeft.SelectedIndex))
                LibLeft.Items.RemoveAt(LibLeft.SelectedIndex)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub

    Private Sub BtnL_Click(sender As Object, e As EventArgs) Handles BtnL.Click
        For i = 0 To LibRight.SelectedItems.Count - 1
            Try
                LibLeft.Items.Add(LibRight.Items(LibRight.SelectedIndex))
                LibRight.Items.RemoveAt(LibRight.SelectedIndex)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub

    Private Sub BtnAL_Click(sender As Object, e As EventArgs) Handles BtnAL.Click
        For i = 0 To LibRight.Items.Count - 1
            LibLeft.Items.Add(LibRight.Items(i))
        Next
        LibRight.Items.Clear()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If RbOn1.Checked = True Then
            For i = 0 To LibLeft.SelectedItems.Count - 1
                LibLeft.Items.RemoveAt(LibLeft.SelectedIndex)
            Next
        ElseIf RbOn2.Checked = True Then
            For i = 0 To LibRight.SelectedItems.Count - 1
                LibRight.Items.RemoveAt(LibRight.SelectedIndex)
            Next
        End If
    End Sub

    Private Sub ChBlock_CheckedChanged(sender As Object, e As EventArgs) Handles ChBlock.CheckedChanged
        If ChBlock.Checked = True Then
            BtnAL.Enabled = False
            BtnAR.Enabled = False
            BtnL.Enabled = False
            BtnR.Enabled = False
            BtnHapus.Enabled = False
        Else
            BtnAL.Enabled = True
            BtnAR.Enabled = True
            BtnL.Enabled = True
            BtnR.Enabled = True
            BtnHapus.Enabled = True
        End If
    End Sub
End Class
