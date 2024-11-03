Public Class MainWindow
    Private Sub gpPlayerList_Enter(sender As Object, e As EventArgs) Handles gpPlayerList.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGameMode.SelectedIndexChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Select Case NumericUpDown1.Value
            Case 1
                tbPlayerName1.Enabled = True
                tbPlayerName2.Enabled = False
                tbPlayerName3.Enabled = False
                tbPlayerName4.Enabled = False
                tbPlayerName5.Enabled = False
            Case 2
                tbPlayerName1.Enabled = True
                tbPlayerName2.Enabled = True
                tbPlayerName3.Enabled = False
                tbPlayerName4.Enabled = False
                tbPlayerName5.Enabled = False
            Case 3
                tbPlayerName1.Enabled = True
                tbPlayerName2.Enabled = True
                tbPlayerName3.Enabled = True
                tbPlayerName4.Enabled = False
                tbPlayerName5.Enabled = False
            Case 4
                tbPlayerName1.Enabled = True
                tbPlayerName2.Enabled = True
                tbPlayerName3.Enabled = True
                tbPlayerName4.Enabled = True
                tbPlayerName5.Enabled = False
            Case 5
                tbPlayerName1.Enabled = True
                tbPlayerName2.Enabled = True
                tbPlayerName3.Enabled = True
                tbPlayerName4.Enabled = True
                tbPlayerName5.Enabled = True
        End Select
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        If cbGameMode.Text Is "" Then
            MessageBox.Show("Error: Game Mode was not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        For playercount As Integer = 1 To NumericUpDown1.Value
            Dim tb As TextBox = CType(gpPlayerList.Controls("tbPlayerPointsLeft" + playercount.ToString()), TextBox)
            ' tbPlayerPointsLeft1
            tb.Text = cbGameMode.Text

        Next

    End Sub
End Class
