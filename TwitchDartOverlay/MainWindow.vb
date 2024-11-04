Imports System.Linq.Expressions

Public Class MainWindow
    Dim cntDartThrows As Integer = 1
    Dim CurrentPlayerId As Integer = 1

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

    Private Sub CheckThrowForWin()

    End Sub

    Private Sub DartThrow(value As Integer)
        ' Dim tmpSum As Integer = tbplay

        Select Case cntDartThrows
            Case 1
                TBThrow1.Text = value
            Case 2
                TBThrow2.Text = value
            Case 3
                TBThrow3.Text = value
            Case Else
                ' All Throws are made 
                Return
        End Select


    End Sub


    Private Sub NUDPlayerCount_ValueChanged(sender As Object, e As EventArgs) Handles NUDPlayerCount.ValueChanged
        EnablePlayers(NUDPlayerCount.Value)
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbGameMode.SelectedIndex = 1
    End Sub
    Private Sub SetActivePlayer()
        Dim tb As TextBox = CType(gpPlayerList.Controls("tbPlayerName" + CurrentPlayerId.ToString()), TextBox)
        lblCurrentPlayer.Text = tb.Text
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

        SetActivePlayer()

        btnStopGame.Enabled = True
        btnStartGame.Enabled = False

        For Each ctrl As Control In gpGameOptions.Controls
            ctrl.Enabled = False
        Next

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

        For Each ctrl As Control In gpGameOptions.Controls
            ctrl.Enabled = True
        Next

        gpCurrentPlayer.Visible = False
        gpRoundCounter.Visible = False
        gpDartPoints.Visible = False
        gpThrows.Visible = False
        btnStorno.Visible = False
        btnNext.Visible = False

        CurrentPlayerId = 1
        EnablePlayers(NUDPlayerCount.Value)
    End Sub
    Private Sub IncreaseRoundCount()
        Dim counter As Integer = Integer.Parse(lblRoundCount.Text)
        counter += 1
        lblRoundCount.Text = counter.ToString()
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Reset the dart throws on switching to the next player 
        cntDartThrows = 1

        ' Increase the round counter 
        IncreaseRoundCount()

        If Integer.Parse(lblRoundCount.Text) >= 21 And cbGameMode.Text = "501" Then
            MessageBox.Show(lblCurrentPlayer.Text, "Winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Integer.Parse(lblRoundCount.Text) >= 15 And cbGameMode.Text = "301" Then
            MessageBox.Show(lblCurrentPlayer.Text, "Winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        ' Increase the CurrentPlayerId to the next player, if there is more than one 
        If CurrentPlayerId < NUDPlayerCount.Value Then
            CurrentPlayerId = CurrentPlayerId + 1
            SetActivePlayer()
        ElseIf CurrentPlayerId = NUDPlayerCount.Value Then
            CurrentPlayerId = 1
            SetActivePlayer()
        End If
    End Sub
End Class
