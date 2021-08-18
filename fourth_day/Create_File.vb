Imports System.IO
Public Class Create_File


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            System.Diagnostics.Process.Start(OpenFileDialog1.FileName)


        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim file As StreamWriter
        Dim path_file As String
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            path_file = OpenFileDialog1.FileName
        End If
        file = My.Computer.FileSystem.OpenTextFileWriter(path_file, True)
        Dim text = writeTextBox1.Text
        file.WriteLine(text)
        file.Close()
        MessageBox.Show("the saved file successfully!", "Save SuccessFully", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
