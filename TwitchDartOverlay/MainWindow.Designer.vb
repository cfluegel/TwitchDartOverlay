<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        gpDartPoints = New GroupBox()
        RBTriple = New RadioButton()
        RBDouble = New RadioButton()
        RBSingle = New RadioButton()
        btnHalfBull = New Button()
        btnBull = New Button()
        Button19 = New Button()
        Button18 = New Button()
        Button17 = New Button()
        Button16 = New Button()
        Button15 = New Button()
        Button14 = New Button()
        Button13 = New Button()
        Button12 = New Button()
        Button11 = New Button()
        Button10 = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        btnPoint6 = New Button()
        btnPoint5 = New Button()
        btnPoint4 = New Button()
        btnPoint3 = New Button()
        btnPoint2 = New Button()
        btnPoint1 = New Button()
        btnMiss = New Button()
        lblWurf1 = New Label()
        lblWurf2 = New Label()
        lblWurf3 = New Label()
        gpThrows = New GroupBox()
        TBThrow3 = New TextBox()
        TBThrow2 = New TextBox()
        TBThrow1 = New TextBox()
        btnStorno = New Button()
        btnNext = New Button()
        gpPlayerList = New GroupBox()
        tbPlayerPointsLeft5 = New TextBox()
        tbPlayerPointsLeft4 = New TextBox()
        tbPlayerPointsLeft3 = New TextBox()
        tbPlayerPointsLeft2 = New TextBox()
        tbPlayerPointsLeft1 = New TextBox()
        tbPlayerName5 = New TextBox()
        tbPlayerName4 = New TextBox()
        tbPlayerName3 = New TextBox()
        tbPlayerName2 = New TextBox()
        tbPlayerName1 = New TextBox()
        lblCurrentPlayer = New Label()
        gpGameOptions = New GroupBox()
        RBMasterOut = New RadioButton()
        RBDoubleOut = New RadioButton()
        RBSingleOut = New RadioButton()
        Label2 = New Label()
        Label1 = New Label()
        NUDPlayerCount = New NumericUpDown()
        cbGameMode = New ComboBox()
        gpCurrentPlayer = New GroupBox()
        btnStartGame = New Button()
        btnStopGame = New Button()
        lblRoundCount = New Label()
        gpRoundCounter = New GroupBox()
        gpDartPoints.SuspendLayout()
        gpThrows.SuspendLayout()
        gpPlayerList.SuspendLayout()
        gpGameOptions.SuspendLayout()
        CType(NUDPlayerCount, ComponentModel.ISupportInitialize).BeginInit()
        gpCurrentPlayer.SuspendLayout()
        gpRoundCounter.SuspendLayout()
        SuspendLayout()
        ' 
        ' gpDartPoints
        ' 
        gpDartPoints.Controls.Add(RBTriple)
        gpDartPoints.Controls.Add(RBDouble)
        gpDartPoints.Controls.Add(RBSingle)
        gpDartPoints.Controls.Add(btnHalfBull)
        gpDartPoints.Controls.Add(btnBull)
        gpDartPoints.Controls.Add(Button19)
        gpDartPoints.Controls.Add(Button18)
        gpDartPoints.Controls.Add(Button17)
        gpDartPoints.Controls.Add(Button16)
        gpDartPoints.Controls.Add(Button15)
        gpDartPoints.Controls.Add(Button14)
        gpDartPoints.Controls.Add(Button13)
        gpDartPoints.Controls.Add(Button12)
        gpDartPoints.Controls.Add(Button11)
        gpDartPoints.Controls.Add(Button10)
        gpDartPoints.Controls.Add(Button9)
        gpDartPoints.Controls.Add(Button8)
        gpDartPoints.Controls.Add(Button7)
        gpDartPoints.Controls.Add(Button6)
        gpDartPoints.Controls.Add(btnPoint6)
        gpDartPoints.Controls.Add(btnPoint5)
        gpDartPoints.Controls.Add(btnPoint4)
        gpDartPoints.Controls.Add(btnPoint3)
        gpDartPoints.Controls.Add(btnPoint2)
        gpDartPoints.Controls.Add(btnPoint1)
        gpDartPoints.Controls.Add(btnMiss)
        gpDartPoints.Location = New Point(12, 408)
        gpDartPoints.Name = "gpDartPoints"
        gpDartPoints.Size = New Size(186, 219)
        gpDartPoints.TabIndex = 0
        gpDartPoints.TabStop = False
        gpDartPoints.Text = "Dart Points"
        gpDartPoints.Visible = False
        ' 
        ' RBTriple
        ' 
        RBTriple.AutoSize = True
        RBTriple.Location = New Point(6, 72)
        RBTriple.Name = "RBTriple"
        RBTriple.Size = New Size(53, 19)
        RBTriple.TabIndex = 27
        RBTriple.TabStop = True
        RBTriple.Text = "Triple"
        RBTriple.UseVisualStyleBackColor = True
        ' 
        ' RBDouble
        ' 
        RBDouble.AutoSize = True
        RBDouble.Location = New Point(6, 47)
        RBDouble.Name = "RBDouble"
        RBDouble.Size = New Size(63, 19)
        RBDouble.TabIndex = 26
        RBDouble.TabStop = True
        RBDouble.Text = "Double"
        RBDouble.UseVisualStyleBackColor = True
        ' 
        ' RBSingle
        ' 
        RBSingle.AutoSize = True
        RBSingle.Location = New Point(6, 22)
        RBSingle.Name = "RBSingle"
        RBSingle.Size = New Size(57, 19)
        RBSingle.TabIndex = 25
        RBSingle.TabStop = True
        RBSingle.Text = "Single"
        RBSingle.UseVisualStyleBackColor = True
        ' 
        ' btnHalfBull
        ' 
        btnHalfBull.BackColor = Color.LimeGreen
        btnHalfBull.Location = New Point(114, 70)
        btnHalfBull.Name = "btnHalfBull"
        btnHalfBull.Size = New Size(30, 23)
        btnHalfBull.TabIndex = 24
        btnHalfBull.Text = " 25"
        btnHalfBull.UseVisualStyleBackColor = False
        ' 
        ' btnBull
        ' 
        btnBull.BackColor = Color.Red
        btnBull.Location = New Point(150, 70)
        btnBull.Name = "btnBull"
        btnBull.Size = New Size(30, 23)
        btnBull.TabIndex = 23
        btnBull.Text = "50"
        btnBull.UseVisualStyleBackColor = False
        ' 
        ' Button19
        ' 
        Button19.Location = New Point(150, 186)
        Button19.Name = "Button19"
        Button19.Size = New Size(30, 23)
        Button19.TabIndex = 22
        Button19.Text = "20"
        Button19.UseVisualStyleBackColor = True
        ' 
        ' Button18
        ' 
        Button18.Location = New Point(114, 186)
        Button18.Name = "Button18"
        Button18.Size = New Size(30, 23)
        Button18.TabIndex = 21
        Button18.Text = "19"
        Button18.UseVisualStyleBackColor = True
        ' 
        ' Button17
        ' 
        Button17.Location = New Point(78, 186)
        Button17.Name = "Button17"
        Button17.Size = New Size(30, 23)
        Button17.TabIndex = 20
        Button17.Text = "18"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Location = New Point(42, 186)
        Button16.Name = "Button16"
        Button16.Size = New Size(30, 23)
        Button16.TabIndex = 19
        Button16.Text = "17"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Location = New Point(6, 186)
        Button15.Name = "Button15"
        Button15.Size = New Size(30, 23)
        Button15.TabIndex = 18
        Button15.Text = "16"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Location = New Point(150, 157)
        Button14.Name = "Button14"
        Button14.Size = New Size(30, 23)
        Button14.TabIndex = 17
        Button14.Text = "15"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Location = New Point(114, 157)
        Button13.Name = "Button13"
        Button13.Size = New Size(30, 23)
        Button13.TabIndex = 16
        Button13.Text = "14"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Location = New Point(78, 157)
        Button12.Name = "Button12"
        Button12.Size = New Size(30, 23)
        Button12.TabIndex = 15
        Button12.Text = "13"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(42, 157)
        Button11.Name = "Button11"
        Button11.Size = New Size(30, 23)
        Button11.TabIndex = 14
        Button11.Text = "12"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(6, 157)
        Button10.Name = "Button10"
        Button10.Size = New Size(30, 23)
        Button10.TabIndex = 13
        Button10.Text = "11"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(150, 128)
        Button9.Name = "Button9"
        Button9.Size = New Size(30, 23)
        Button9.TabIndex = 12
        Button9.Text = "10"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(114, 128)
        Button8.Name = "Button8"
        Button8.Size = New Size(30, 23)
        Button8.TabIndex = 11
        Button8.Text = "9"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(78, 128)
        Button7.Name = "Button7"
        Button7.Size = New Size(30, 23)
        Button7.TabIndex = 10
        Button7.Text = "8"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(42, 128)
        Button6.Name = "Button6"
        Button6.Size = New Size(30, 23)
        Button6.TabIndex = 9
        Button6.Text = "7"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' btnPoint6
        ' 
        btnPoint6.Location = New Point(6, 128)
        btnPoint6.Name = "btnPoint6"
        btnPoint6.Size = New Size(30, 23)
        btnPoint6.TabIndex = 8
        btnPoint6.Text = "6"
        btnPoint6.UseVisualStyleBackColor = True
        ' 
        ' btnPoint5
        ' 
        btnPoint5.Location = New Point(150, 99)
        btnPoint5.Name = "btnPoint5"
        btnPoint5.Size = New Size(30, 23)
        btnPoint5.TabIndex = 7
        btnPoint5.Text = "5"
        btnPoint5.UseVisualStyleBackColor = True
        ' 
        ' btnPoint4
        ' 
        btnPoint4.Location = New Point(114, 99)
        btnPoint4.Name = "btnPoint4"
        btnPoint4.Size = New Size(30, 23)
        btnPoint4.TabIndex = 6
        btnPoint4.Text = "4"
        btnPoint4.UseVisualStyleBackColor = True
        ' 
        ' btnPoint3
        ' 
        btnPoint3.Location = New Point(78, 99)
        btnPoint3.Name = "btnPoint3"
        btnPoint3.Size = New Size(30, 23)
        btnPoint3.TabIndex = 5
        btnPoint3.Text = "3"
        btnPoint3.UseVisualStyleBackColor = True
        ' 
        ' btnPoint2
        ' 
        btnPoint2.Location = New Point(42, 99)
        btnPoint2.Name = "btnPoint2"
        btnPoint2.Size = New Size(30, 23)
        btnPoint2.TabIndex = 4
        btnPoint2.Text = "2"
        btnPoint2.UseVisualStyleBackColor = True
        ' 
        ' btnPoint1
        ' 
        btnPoint1.Location = New Point(6, 99)
        btnPoint1.Name = "btnPoint1"
        btnPoint1.Size = New Size(30, 23)
        btnPoint1.TabIndex = 3
        btnPoint1.Text = "1"
        btnPoint1.UseVisualStyleBackColor = True
        ' 
        ' btnMiss
        ' 
        btnMiss.Location = New Point(132, 22)
        btnMiss.Name = "btnMiss"
        btnMiss.Size = New Size(48, 29)
        btnMiss.TabIndex = 0
        btnMiss.Text = "Miss"
        btnMiss.UseVisualStyleBackColor = True
        ' 
        ' lblWurf1
        ' 
        lblWurf1.AutoSize = True
        lblWurf1.Location = New Point(6, 29)
        lblWurf1.Name = "lblWurf1"
        lblWurf1.Size = New Size(52, 15)
        lblWurf1.TabIndex = 1
        lblWurf1.Text = "Throw 1:"
        ' 
        ' lblWurf2
        ' 
        lblWurf2.AutoSize = True
        lblWurf2.Location = New Point(6, 52)
        lblWurf2.Name = "lblWurf2"
        lblWurf2.Size = New Size(52, 15)
        lblWurf2.TabIndex = 2
        lblWurf2.Text = "Throw 2:"
        ' 
        ' lblWurf3
        ' 
        lblWurf3.AutoSize = True
        lblWurf3.Location = New Point(6, 76)
        lblWurf3.Name = "lblWurf3"
        lblWurf3.Size = New Size(52, 15)
        lblWurf3.TabIndex = 3
        lblWurf3.Text = "Throw 3:"
        ' 
        ' gpThrows
        ' 
        gpThrows.Controls.Add(TBThrow3)
        gpThrows.Controls.Add(TBThrow2)
        gpThrows.Controls.Add(TBThrow1)
        gpThrows.Controls.Add(lblWurf1)
        gpThrows.Controls.Add(lblWurf3)
        gpThrows.Controls.Add(lblWurf2)
        gpThrows.Location = New Point(204, 408)
        gpThrows.Name = "gpThrows"
        gpThrows.Size = New Size(154, 117)
        gpThrows.TabIndex = 4
        gpThrows.TabStop = False
        gpThrows.Text = "Throws"
        gpThrows.Visible = False
        ' 
        ' TBThrow3
        ' 
        TBThrow3.BorderStyle = BorderStyle.None
        TBThrow3.Location = New Point(64, 75)
        TBThrow3.Name = "TBThrow3"
        TBThrow3.ReadOnly = True
        TBThrow3.Size = New Size(81, 16)
        TBThrow3.TabIndex = 6
        ' 
        ' TBThrow2
        ' 
        TBThrow2.BorderStyle = BorderStyle.None
        TBThrow2.Location = New Point(64, 52)
        TBThrow2.Name = "TBThrow2"
        TBThrow2.ReadOnly = True
        TBThrow2.Size = New Size(81, 16)
        TBThrow2.TabIndex = 5
        ' 
        ' TBThrow1
        ' 
        TBThrow1.BorderStyle = BorderStyle.None
        TBThrow1.Location = New Point(64, 29)
        TBThrow1.Name = "TBThrow1"
        TBThrow1.ReadOnly = True
        TBThrow1.Size = New Size(81, 16)
        TBThrow1.TabIndex = 4
        ' 
        ' btnStorno
        ' 
        btnStorno.Location = New Point(204, 531)
        btnStorno.Name = "btnStorno"
        btnStorno.Size = New Size(154, 45)
        btnStorno.TabIndex = 5
        btnStorno.Text = "Storno"
        btnStorno.UseVisualStyleBackColor = True
        btnStorno.Visible = False
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(204, 582)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(154, 45)
        btnNext.TabIndex = 6
        btnNext.Text = "Next Player"
        btnNext.UseVisualStyleBackColor = True
        btnNext.Visible = False
        ' 
        ' gpPlayerList
        ' 
        gpPlayerList.Controls.Add(tbPlayerPointsLeft5)
        gpPlayerList.Controls.Add(tbPlayerPointsLeft4)
        gpPlayerList.Controls.Add(tbPlayerPointsLeft3)
        gpPlayerList.Controls.Add(tbPlayerPointsLeft2)
        gpPlayerList.Controls.Add(tbPlayerPointsLeft1)
        gpPlayerList.Controls.Add(tbPlayerName5)
        gpPlayerList.Controls.Add(tbPlayerName4)
        gpPlayerList.Controls.Add(tbPlayerName3)
        gpPlayerList.Controls.Add(tbPlayerName2)
        gpPlayerList.Controls.Add(tbPlayerName1)
        gpPlayerList.Location = New Point(12, 109)
        gpPlayerList.Name = "gpPlayerList"
        gpPlayerList.Size = New Size(340, 136)
        gpPlayerList.TabIndex = 8
        gpPlayerList.TabStop = False
        gpPlayerList.Text = "Player List"
        ' 
        ' tbPlayerPointsLeft5
        ' 
        tbPlayerPointsLeft5.BorderStyle = BorderStyle.None
        tbPlayerPointsLeft5.Location = New Point(198, 110)
        tbPlayerPointsLeft5.Name = "tbPlayerPointsLeft5"
        tbPlayerPointsLeft5.ReadOnly = True
        tbPlayerPointsLeft5.Size = New Size(33, 16)
        tbPlayerPointsLeft5.TabIndex = 9
        tbPlayerPointsLeft5.TextAlign = HorizontalAlignment.Center
        ' 
        ' tbPlayerPointsLeft4
        ' 
        tbPlayerPointsLeft4.BorderStyle = BorderStyle.None
        tbPlayerPointsLeft4.Location = New Point(198, 88)
        tbPlayerPointsLeft4.Name = "tbPlayerPointsLeft4"
        tbPlayerPointsLeft4.ReadOnly = True
        tbPlayerPointsLeft4.Size = New Size(33, 16)
        tbPlayerPointsLeft4.TabIndex = 8
        tbPlayerPointsLeft4.TextAlign = HorizontalAlignment.Center
        ' 
        ' tbPlayerPointsLeft3
        ' 
        tbPlayerPointsLeft3.BorderStyle = BorderStyle.None
        tbPlayerPointsLeft3.Location = New Point(198, 66)
        tbPlayerPointsLeft3.Name = "tbPlayerPointsLeft3"
        tbPlayerPointsLeft3.ReadOnly = True
        tbPlayerPointsLeft3.Size = New Size(33, 16)
        tbPlayerPointsLeft3.TabIndex = 7
        tbPlayerPointsLeft3.TextAlign = HorizontalAlignment.Center
        ' 
        ' tbPlayerPointsLeft2
        ' 
        tbPlayerPointsLeft2.BorderStyle = BorderStyle.None
        tbPlayerPointsLeft2.Location = New Point(198, 44)
        tbPlayerPointsLeft2.Name = "tbPlayerPointsLeft2"
        tbPlayerPointsLeft2.ReadOnly = True
        tbPlayerPointsLeft2.Size = New Size(33, 16)
        tbPlayerPointsLeft2.TabIndex = 6
        tbPlayerPointsLeft2.TextAlign = HorizontalAlignment.Center
        ' 
        ' tbPlayerPointsLeft1
        ' 
        tbPlayerPointsLeft1.BorderStyle = BorderStyle.None
        tbPlayerPointsLeft1.Location = New Point(198, 22)
        tbPlayerPointsLeft1.Name = "tbPlayerPointsLeft1"
        tbPlayerPointsLeft1.ReadOnly = True
        tbPlayerPointsLeft1.Size = New Size(33, 16)
        tbPlayerPointsLeft1.TabIndex = 5
        tbPlayerPointsLeft1.TextAlign = HorizontalAlignment.Center
        ' 
        ' tbPlayerName5
        ' 
        tbPlayerName5.BorderStyle = BorderStyle.None
        tbPlayerName5.Location = New Point(8, 110)
        tbPlayerName5.Name = "tbPlayerName5"
        tbPlayerName5.Size = New Size(172, 16)
        tbPlayerName5.TabIndex = 4
        tbPlayerName5.Text = "Player Name 5"
        ' 
        ' tbPlayerName4
        ' 
        tbPlayerName4.BorderStyle = BorderStyle.None
        tbPlayerName4.Location = New Point(8, 88)
        tbPlayerName4.Name = "tbPlayerName4"
        tbPlayerName4.Size = New Size(172, 16)
        tbPlayerName4.TabIndex = 3
        tbPlayerName4.Text = "Player Name 4"
        ' 
        ' tbPlayerName3
        ' 
        tbPlayerName3.BorderStyle = BorderStyle.None
        tbPlayerName3.Location = New Point(8, 66)
        tbPlayerName3.Name = "tbPlayerName3"
        tbPlayerName3.Size = New Size(172, 16)
        tbPlayerName3.TabIndex = 2
        tbPlayerName3.Text = "Player Name 3"
        ' 
        ' tbPlayerName2
        ' 
        tbPlayerName2.BorderStyle = BorderStyle.None
        tbPlayerName2.Location = New Point(8, 44)
        tbPlayerName2.Name = "tbPlayerName2"
        tbPlayerName2.Size = New Size(172, 16)
        tbPlayerName2.TabIndex = 1
        tbPlayerName2.Text = "Player Name 2"
        ' 
        ' tbPlayerName1
        ' 
        tbPlayerName1.BorderStyle = BorderStyle.None
        tbPlayerName1.Location = New Point(8, 22)
        tbPlayerName1.Name = "tbPlayerName1"
        tbPlayerName1.Size = New Size(172, 16)
        tbPlayerName1.TabIndex = 0
        tbPlayerName1.Text = "Player Name 1"
        ' 
        ' lblCurrentPlayer
        ' 
        lblCurrentPlayer.AutoSize = True
        lblCurrentPlayer.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCurrentPlayer.Location = New Point(6, 19)
        lblCurrentPlayer.Name = "lblCurrentPlayer"
        lblCurrentPlayer.Size = New Size(236, 37)
        lblCurrentPlayer.TabIndex = 9
        lblCurrentPlayer.Text = "No Game Running"
        ' 
        ' gpGameOptions
        ' 
        gpGameOptions.Controls.Add(RBMasterOut)
        gpGameOptions.Controls.Add(RBDoubleOut)
        gpGameOptions.Controls.Add(RBSingleOut)
        gpGameOptions.Controls.Add(Label2)
        gpGameOptions.Controls.Add(Label1)
        gpGameOptions.Controls.Add(NUDPlayerCount)
        gpGameOptions.Controls.Add(cbGameMode)
        gpGameOptions.Location = New Point(12, 16)
        gpGameOptions.Name = "gpGameOptions"
        gpGameOptions.Size = New Size(340, 85)
        gpGameOptions.TabIndex = 10
        gpGameOptions.TabStop = False
        gpGameOptions.Text = "Game Options"
        ' 
        ' RBMasterOut
        ' 
        RBMasterOut.AutoSize = True
        RBMasterOut.Location = New Point(248, 22)
        RBMasterOut.Name = "RBMasterOut"
        RBMasterOut.Size = New Size(86, 19)
        RBMasterOut.TabIndex = 6
        RBMasterOut.Text = "Master-Out"
        RBMasterOut.UseVisualStyleBackColor = True
        ' 
        ' RBDoubleOut
        ' 
        RBDoubleOut.AutoSize = True
        RBDoubleOut.Location = New Point(160, 47)
        RBDoubleOut.Name = "RBDoubleOut"
        RBDoubleOut.Size = New Size(88, 19)
        RBDoubleOut.TabIndex = 5
        RBDoubleOut.Text = "Double-Out"
        RBDoubleOut.UseVisualStyleBackColor = True
        ' 
        ' RBSingleOut
        ' 
        RBSingleOut.AutoSize = True
        RBSingleOut.Checked = True
        RBSingleOut.Location = New Point(160, 22)
        RBSingleOut.Name = "RBSingleOut"
        RBSingleOut.Size = New Size(82, 19)
        RBSingleOut.TabIndex = 4
        RBSingleOut.TabStop = True
        RBSingleOut.Text = "Single-Out"
        RBSingleOut.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 3
        Label2.Text = "Player Count"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 2
        Label1.Text = "GameMode"
        ' 
        ' NUDPlayerCount
        ' 
        NUDPlayerCount.Location = New Point(87, 22)
        NUDPlayerCount.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        NUDPlayerCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NUDPlayerCount.Name = "NUDPlayerCount"
        NUDPlayerCount.Size = New Size(38, 23)
        NUDPlayerCount.TabIndex = 1
        NUDPlayerCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' cbGameMode
        ' 
        cbGameMode.DropDownStyle = ComboBoxStyle.DropDownList
        cbGameMode.FormattingEnabled = True
        cbGameMode.ImeMode = ImeMode.Off
        cbGameMode.Items.AddRange(New Object() {"301", "501"})
        cbGameMode.Location = New Point(87, 50)
        cbGameMode.Name = "cbGameMode"
        cbGameMode.Size = New Size(66, 23)
        cbGameMode.TabIndex = 0
        ' 
        ' gpCurrentPlayer
        ' 
        gpCurrentPlayer.Controls.Add(lblCurrentPlayer)
        gpCurrentPlayer.Location = New Point(12, 330)
        gpCurrentPlayer.Name = "gpCurrentPlayer"
        gpCurrentPlayer.Size = New Size(283, 72)
        gpCurrentPlayer.TabIndex = 11
        gpCurrentPlayer.TabStop = False
        gpCurrentPlayer.Text = "Current Player"
        gpCurrentPlayer.Visible = False
        ' 
        ' btnStartGame
        ' 
        btnStartGame.Location = New Point(12, 251)
        btnStartGame.Name = "btnStartGame"
        btnStartGame.Size = New Size(115, 48)
        btnStartGame.TabIndex = 12
        btnStartGame.Text = "Start Game"
        btnStartGame.UseVisualStyleBackColor = True
        ' 
        ' btnStopGame
        ' 
        btnStopGame.Enabled = False
        btnStopGame.Location = New Point(237, 251)
        btnStopGame.Name = "btnStopGame"
        btnStopGame.Size = New Size(115, 48)
        btnStopGame.TabIndex = 13
        btnStopGame.Text = "Stop Game"
        btnStopGame.UseVisualStyleBackColor = True
        ' 
        ' lblRoundCount
        ' 
        lblRoundCount.AutoSize = True
        lblRoundCount.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRoundCount.Location = New Point(6, 19)
        lblRoundCount.Name = "lblRoundCount"
        lblRoundCount.Size = New Size(32, 37)
        lblRoundCount.TabIndex = 14
        lblRoundCount.Text = "0"
        ' 
        ' gpRoundCounter
        ' 
        gpRoundCounter.Controls.Add(lblRoundCount)
        gpRoundCounter.Location = New Point(301, 330)
        gpRoundCounter.Name = "gpRoundCounter"
        gpRoundCounter.Size = New Size(57, 72)
        gpRoundCounter.TabIndex = 15
        gpRoundCounter.TabStop = False
        gpRoundCounter.Text = "Round"
        gpRoundCounter.Visible = False
        ' 
        ' MainWindow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(368, 639)
        Controls.Add(gpRoundCounter)
        Controls.Add(btnStopGame)
        Controls.Add(btnStartGame)
        Controls.Add(gpCurrentPlayer)
        Controls.Add(gpGameOptions)
        Controls.Add(gpPlayerList)
        Controls.Add(btnNext)
        Controls.Add(btnStorno)
        Controls.Add(gpThrows)
        Controls.Add(gpDartPoints)
        Name = "MainWindow"
        Text = "Twicht Dart Overalay - Main Window"
        gpDartPoints.ResumeLayout(False)
        gpDartPoints.PerformLayout()
        gpThrows.ResumeLayout(False)
        gpThrows.PerformLayout()
        gpPlayerList.ResumeLayout(False)
        gpPlayerList.PerformLayout()
        gpGameOptions.ResumeLayout(False)
        gpGameOptions.PerformLayout()
        CType(NUDPlayerCount, ComponentModel.ISupportInitialize).EndInit()
        gpCurrentPlayer.ResumeLayout(False)
        gpCurrentPlayer.PerformLayout()
        gpRoundCounter.ResumeLayout(False)
        gpRoundCounter.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gpDartPoints As GroupBox
    Friend WithEvents btnMiss As Button
    Friend WithEvents btnPoint1 As Button
    Friend WithEvents btnHalfBull As Button
    Friend WithEvents btnBull As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btnPoint6 As Button
    Friend WithEvents btnPoint5 As Button
    Friend WithEvents btnPoint4 As Button
    Friend WithEvents btnPoint3 As Button
    Friend WithEvents btnPoint2 As Button
    Friend WithEvents lblWurf1 As Label
    Friend WithEvents lblWurf2 As Label
    Friend WithEvents lblWurf3 As Label
    Friend WithEvents gpThrows As GroupBox
    Friend WithEvents TBThrow3 As TextBox
    Friend WithEvents TBThrow2 As TextBox
    Friend WithEvents TBThrow1 As TextBox
    Friend WithEvents btnStorno As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents gpPlayerList As GroupBox
    Friend WithEvents tbPlayerName1 As TextBox
    Friend WithEvents tbPlayerName5 As TextBox
    Friend WithEvents tbPlayerName4 As TextBox
    Friend WithEvents tbPlayerName3 As TextBox
    Friend WithEvents tbPlayerName2 As TextBox
    Friend WithEvents tbPlayerPointsLeft1 As TextBox
    Friend WithEvents tbPlayerPointsLeft5 As TextBox
    Friend WithEvents tbPlayerPointsLeft4 As TextBox
    Friend WithEvents tbPlayerPointsLeft3 As TextBox
    Friend WithEvents tbPlayerPointsLeft2 As TextBox
    Friend WithEvents lblCurrentPlayer As Label
    Friend WithEvents gpGameOptions As GroupBox
    Friend WithEvents cbGameMode As ComboBox
    Friend WithEvents NUDPlayerCount As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gpCurrentPlayer As GroupBox
    Friend WithEvents btnStartGame As Button
    Friend WithEvents btnStopGame As Button
    Friend WithEvents lblRoundCount As Label
    Friend WithEvents gpRoundCounter As GroupBox
    Friend WithEvents RBSingleOut As RadioButton
    Friend WithEvents RBDoubleOut As RadioButton
    Friend WithEvents RBMasterOut As RadioButton
    Friend WithEvents RBSingle As RadioButton
    Friend WithEvents RBTriple As RadioButton
    Friend WithEvents RBDouble As RadioButton

End Class
