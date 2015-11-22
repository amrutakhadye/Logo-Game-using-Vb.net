'Author Name     : Amruta Khadye
'Course Name     : CS 552-D- Windows Interface Design in Visual Basic
'Date of Project : 5/14/2015
'Assignment Name : Project 3
'Description     : It displays the fourth question of the logo game.
'                  On clicking on the next button the next question is displayed.
'                  The user should select one of the four correct images answers and click on next button,
'                  Otherwise the timer times out and moves to the next question

Public Class LogoQuestion4

     'Description: NextButton_Click procedure
     'This procedure is called when the user clicks on next button.
     'It checks the radio button selected by the user against the correct answer and increments counter.
     'on clicking on next button, the next question is displayed.
     Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
          If timberlandRadio.Checked Then
               startForm.correctAnswer = startForm.correctAnswer + 1
          End If

          Me.Hide()
          Timer4.Enabled = False
          LogoQuestion5.ShowDialog()
     End Sub

     'Description: LogoQuestion4_Activated procedure
     'This procedure is called when the page is loaded
     'It disables all the radio buttons.
     Private Sub LogoQuestion4_Activated(sender As Object, e As EventArgs) Handles Me.Activated
          timberlandRadio.Checked = False
          FirefoxRadio.Checked = False
          unicefRadio.Checked = False
          yamahaRadio.Checked = False

     End Sub

     'Description: Question4_Load procedure
     'This procedure is called when the page is loaded
     'It sets the timer interval based on the radio button selected by the user on the start up page.
     Private Sub Question4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          If startForm.TimerSelected = 0 Then
               Timer4.Enabled = True
               Timer4.Interval = 60000
          ElseIf startForm.TimerSelected = 1 Then
               Timer4.Enabled = True
               Timer4.Interval = 30000
          End If
     End Sub

     'Description: Timer4_Tick procedure
     'This procedure is called when the timers clock ticked
     'It sets the timer to false and closes the current window and opens the next question.
     Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
          If timberlandRadio.Checked Then
               StartForm.correctAnswer = StartForm.correctAnswer + 1
          End If
          Timer4.Enabled = False
          Me.Hide()
          LogoQuestion5.ShowDialog()
     End Sub
End Class