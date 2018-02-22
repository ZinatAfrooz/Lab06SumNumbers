Public Class Form1
    Private Sub btnNumbers_Click(sender As Object, e As EventArgs) Handles btnNumbers.Click
        Dim strNumber As String
        Dim intNumber As Integer
        Dim intSum As Integer
        strNumber = InputBox("Input Needed", "Enter a positive integer value", "10")
        intNumber = CInt(strNumber)

        If intNumber < 0 Then
            MessageBox.Show("Negative is not allowed", "Error")
        Else
            intSum = (intNumber * (intNumber + 1)) / 2
            'MessageBox.Show(intSum, "Sum of Numbers")
            InputBox(MessageBox.Show("Sum of Numbers 1 through " & strNumber & " is " & (intSum), "The sum of numbers", MessageBoxButtons.OK))
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
