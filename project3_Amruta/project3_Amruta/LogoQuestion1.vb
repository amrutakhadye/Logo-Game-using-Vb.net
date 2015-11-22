'Author Name     : Amruta Khadye
'Course Name     : CS 552-D- Windows Interface Design in Visual Basic
'Date of Project : 5/14/2015
'Assignment Name : Project 3
'Description     : It displays the first question of the logo game.
'                  On clciking on the next button the next question is displayed.
'                  The user should select one of the four correct answers and click on next button,
'                  Otherwise the timer times out and moves to the next question

Public Class LogoQuestion1

     'Description: NextButton_Click procedure
     'This procedure is called when the user clicks on next button.
     'It checks the radio button selected by the user against the correct answer and increments counter.
     'on clicking on next button, the next question is displayed.
     Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
          If MercedesRadio.Checked Then
               startForm.correctAnswer = startForm.correctAnswer + 1
          End If
          Me.Hide()
          Timer1.Enabled = False
          LogoQuestion2.ShowDialog()
     End Sub

     'Description: LogoQuestion1_Activated procedure
     'This procedure is called when the page is loaded
     'It disables all the radio buttons.
     Private Sub LogoQuestion1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
          MercedesRadio.Checked = False
          rangeRoverRadio.Checked = False
          porscheRadio.Checked = False
          fordRadio.Checked = False
     End Sub

     'Description: Question1_Load procedure
     'This procedure is called when the page is loaded
     'It sets the timer interval based on the radio button selected by the user on the start up page.
     Private Sub Question1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          If startForm.TimerSelected = 0 Then
               Timer1.Enabled = True
               Timer1.Interval = 60000
          ElseIf startForm.TimerSelected = 1 Then
               Timer1.Enabled = True
               Timer1.Interval = 30000
          End If
     End Sub

     'Description: Timer1_Tick procedure
     'This procedure is called when the timers clock ticked
     'It sets the timer to false and closes the current window and opens the next question.
     Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
          Timer1.Enabled = False
          If MercedesRadio.Checked Then
               StartForm.correctAnswer = StartForm.correctAnswer + 1
          End If
          Me.Hide()
          LogoQuestion2.ShowDialog()
     End Sub

End Class