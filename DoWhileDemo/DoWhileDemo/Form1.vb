Public Class Form1

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        picCarBlue.Left = 26
        picCarPink.Left = 26
        picCarGreen.Left = 26
        picCarYellow.Left = 26
        picCarOrange.Left = 26
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBalance.Text = 1000
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ' Clarify a random, integer, and a winner
        Dim intCount As Integer
        Dim rand As New Random
        Const dblWinner As Double = 605
        Dim numBet, numBalance As Double

        numBet = CDbl(txtBet.Text)
        numBalance = CDbl(lblBalance.Text)

        ' Randomizing all the cars between 26 to 480 and commented out all the repeated code.
        Dim intYellowCarRandom As Integer = rand.Next(125) + 450
        Dim intOrangeCarRandom As Integer = rand.Next(125) + 450
        Dim intPinkCarRandom As Integer = rand.Next(125) + 450
        Dim intGreenCarRandom As Integer = rand.Next(125) + 450
        Dim intBlueCarRandom As Integer = rand.Next(125) + 450
        For intCount = 36 To intYellowCarRandom
            picCarYellow.Left = intYellowCarRandom
        Next


        For intCount = 36 To intOrangeCarRandom
            picCarOrange.Left = intOrangeCarRandom
        Next


        For intCount = 36 To intPinkCarRandom
            picCarPink.Left = intPinkCarRandom
        Next


        For intCount = 36 To intGreenCarRandom
            picCarGreen.Left = intGreenCarRandom
        Next


        For intCount = 36 To intBlueCarRandom
            picCarBlue.Left = intBlueCarRandom
        Next
        ' Decide the winner and display it in a message box.

        If intPinkCarRandom > intBlueCarRandom And intGreenCarRandom And intOrangeCarRandom And intYellowCarRandom Then
            MessageBox.Show("Pink Car Wins")
            If rbPink.Checked = True Then
                lblBalance.Text = numBalance + (numBet * 5)

            ElseIf rbPink.Checked = False Then
                lblBalance.Text = numBalance - numBet
            End If

        ElseIf intBlueCarRandom > intPinkCarRandom And intGreenCarRandom And intOrangeCarRandom And intYellowCarRandom Then
            MessageBox.Show("Blue Car Wins")
            If rbBlue.Checked = True Then
                lblBalance.Text = numBalance + (numBet * 5)

            ElseIf rbBlue.Checked = False Then
                lblBalance.Text = numBalance - numBet
            End If

        ElseIf intGreenCarRandom > intBlueCarRandom And intPinkCarRandom And intOrangeCarRandom And intYellowCarRandom Then
            MessageBox.Show("Green Car Wins")
            If rbGreen.Checked = True Then
                lblBalance.Text = numBalance + (numBet * 5)

            ElseIf rbGreen.Checked = False Then
                lblBalance.Text = numBalance - numBet
            End If

        ElseIf intOrangeCarRandom > intBlueCarRandom And intGreenCarRandom And intPinkCarRandom And intYellowCarRandom Then
            MessageBox.Show("Orange Car Wins")
            If rbOrange.Checked = True Then
                lblBalance.Text = numBalance + (numBet * 5)

            ElseIf rbOrange.Checked = False Then
                lblBalance.Text = numBalance - numBet
            End If

        Else
            MessageBox.Show("Yellow Car Wins")
            If rbYellow.Checked = True Then
                lblBalance.Text = numBalance + (numBet * 5)

            ElseIf rbYellow.Checked = False Then
                lblBalance.Text = numBalance - numBet
            End If
        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MaxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaxToolStripMenuItem.Click

    End Sub
End Class
