' Array Creator
' Author: Ian P [ippavlin]

Public Class Startup
    Private Sub cmdFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFile.Click
        InputFile.Show()
    End Sub

    Private Sub cmdText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdText.Click
        InputText.Show()
    End Sub
End Class