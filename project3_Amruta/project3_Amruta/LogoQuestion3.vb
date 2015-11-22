'Author Name     : Amruta Khadye
'Course Name     : CS 552-D- Windows Interface Design in Visual Basic
'Date of Project : 5/14/2015
'Assignment Name : Project 3
'Description     : It displays the third question of the logo game.
'                  On clicking on the next button the next question is displayed.
'                  The user should enter the logo name of the logo displayed.

Public Class LogoQuestion3

     'Description: NextButton_Click procedure
     'This procedure is called when the user clicks on next button.
     'It checks the radio button selected by the user against the correct answer and increments counter.
     'on clicking on next button, the next question is displayed.
     Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
          If NikiText.Text = "Nike" Or NikiText.Text = "nike" Then
               startForm.correctAnswer = startForm.correctAnswer + 1
          End If

          Me.Hide()
          Timer3.Enabled = False
          LogoQuestion4.ShowDialog()
     End Sub

     'Description: Question3_Load procedure
     'This procedure is called when the page is loaded
     'It sets the timer interval based on the radio button selected by the user on the start up page.
     Private Sub Question3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          If startForm.TimerSelected = 0 Then
               Timer3.Enabled = True
               Timer3.Interval = 60000
          ElseIf startForm.TimerSelected = 1 Then
               Timer3.Enabled = True
               Timer3.Interval = 30000
          End If
     End Sub


     'Description: Timer3_Tick procedure
     'This procedure is called when the timers clock ticked
     'It sets the timer to false and closes the current window and opens the next question.
     Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
          If NikiText.Text = "Nike" Or NikiText.Text = "nike" Then
               StartForm.correctAnswer = StartForm.correctAnswer + 1
          End If
          Timer3.Enabled = False
          Me.Hide()
          LogoQuestion4.ShowDialog()
     End Sub


End Class