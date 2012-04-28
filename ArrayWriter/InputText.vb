' Array Creator
' Author: Ian P [ippavlin]

Public Class InputText

    Private Sub cmdCreateArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreateArray.Click
        Try
            If Not txtArrayName.Text = Nothing And Not txtInput.Text = Nothing Then

                Dim wordlist As New List(Of String)

                For Each strLine As String In txtInput.Text.Split(vbNewLine)
                    wordlist.Add(strLine)
                Next

                txtOutput.Text = "Dim " & txtArrayName.Text & "(" & txtInput.Lines.Count - 1 & ") As String" & _
                Environment.NewLine & Environment.NewLine

                For i = 0 To wordlist.Count - 1
                    txtOutput.Text += txtArrayName.Text & "(" & i & ") = """ & wordlist.Item(i) & """" & _
                        Environment.NewLine
                Next

                cmdCopyOutput.Enabled = True
                MessageBox.Show(wordlist.Count & " words were converted to an array.", "Success!")
            Else
                MessageBox.Show("Please make sure that the input and array name textboxes contain text.", "Text missing")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub cmdCopyOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopyOutput.Click
        Clipboard.SetText(txtOutput.Text)
        MessageBox.Show("Output copied to clipboard.", "Output copied")
    End Sub

    Private Sub InputText_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class