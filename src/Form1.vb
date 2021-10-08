Public Class Form1
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(TextBox1.Lines)

        Dim variables As New Dictionary(Of String, String)()

        For Each apa In ListBox1.Items
            Dim input As String = apa.ToString
            Dim arguments() As String = Split(input)
            Dim command As String = arguments(0)

            'print command'
            If command = "print" Then
                MsgBox(arguments(1))
            End If

            'variable command'
            If command = "var" Then
                Dim variableName = arguments(1)
                Dim variableValue = arguments(2)
                variables(variableName) = variableValue
                Console.Out.WriteLine("storing " + variableName + ": " + variableValue)
            End If

            'print variable command
            If command = "getvar" Then
                Dim variableName = arguments(1)
                Dim variableValue = variables(variableName)
                MsgBox(variableValue)
            End If

            'makes a beep command'
            If command = "beep" Then
                Beep()
            End If

            'exit command'
            If command = "exit" Then
                End
            End If
        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
