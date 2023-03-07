Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Select your d3dx.ini in your GIMI folder"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "ini Files|*.ini"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog2.Title = "Select your GenshinImpact.exe"
        OpenFileDialog2.InitialDirectory = "C:\"
        OpenFileDialog2.Filter = "GenshinImpact.exe|*.exe"

        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
        End If

        If Not OpenFileDialog2.FileName() = "GenshinImpact.exe" Then
            MessageBox.Show("yes")
        Else

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim lines() = IO.File.ReadAllLines(OpenFileDialog1.FileName)
        For i = 0 To lines.Length - 1
            If lines(i).StartsWith("target =") Then
                lines(i) = "target = " + OpenFileDialog2.FileName
            End If
        Next
        System.IO.File.WriteAllLines(OpenFileDialog1.FileName, lines)
    End Sub
End Class
