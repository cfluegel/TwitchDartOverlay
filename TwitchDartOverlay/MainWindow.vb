Public Class MainWindow
    Private Sub EnablePlayers(count As Integer)
        tbPlayerName1.Enabled = count >= 1
        tbPlayerName2.Enabled = count >= 2
        tbPlayerName3.Enabled = count >= 3
        tbPlayerName4.Enabled = count >= 4
        tbPlayerName5.Enabled = count >= 5
    End Sub

    Private Sub DisablePlayerList()
        tbPlayerName1.Enabled = False
        tbPlayerName2.Enabled = False
        tbPlayerName3.Enabled = False
        tbPlayerName4.Enabled = False
        tbPlayerName5.Enabled = False
    End Sub

    Private Sub NUDPlayerCount_ValueChanged(sender As Object, e As EventArgs) Handles NUDPlayerCount.ValueChanged
        EnablePlayers(NUDPlayerCount.Value)
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbGameMode.SelectedIndex = 1
    End Sub

    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        If cbGameMode.Text Is "" Then
            MessageBox.Show("Error: Game Mode was not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        For playercount As Integer = 1 To NUDPlayerCount.Value
            Dim tb As TextBox = CType(gpPlayerList.Controls("tbPlayerPointsLeft" + playercount.ToString()), TextBox)
            ' tbPlayerPointsLeft1
            tb.Text = cbGameMode.Text
        Next

        btnStartGame.Enabled = False
        NUDPlayerCount.Enabled = False
        cbGameMode.Enabled = False

        btnStopGame.Enabled = True

        gpCurrentPlayer.Visible = True
        gpRoundCounter.Visible = True
        gpDartPoints.Visible = True
        gpThrows.Visible = True
        btnStorno.Visible = True
        btnNext.Visible = True

        DisablePlayerList()

    End Sub


    Private Sub btnStopGame_Click(sender As Object, e As EventArgs) Handles btnStopGame.Click
        lblCurrentPlayer.Text = ""
        lblRoundCount.Text = 0
        btnStartGame.Enabled = True

        cbGameMode.Enabled = True
        NUDPlayerCount.Enabled = True

        gpCurrentPlayer.Visible = False
        gpRoundCounter.Visible = False
        gpDartPoints.Visible = False
        gpThrows.Visible = False
        btnStorno.Visible = False
        btnNext.Visible = False

        EnablePlayers(NUDPlayerCount.Value)
    End Sub
End Class
