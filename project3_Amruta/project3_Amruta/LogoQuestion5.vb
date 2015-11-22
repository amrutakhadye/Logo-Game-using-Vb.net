'Author Name     : Amruta Khadye
'Course Name     : CS 552-D- Windows Interface Design in Visual Basic
'Date of Project : 5/14/2015
'Assignment Name : Project 3
'Description     : It displays the fifth question of the logo game.
'                  On clciking on the next button the next question is displayed.
'                  The user should enter the logo name of the logo displayed.

Public Class LogoQuestion5

     'Description: NextButton_Click procedure
     'This procedure is called when the user clicks on next button.
     'It checks the radio button selected by the user against the correct answer and increments counter.
     'on clicking on next button, the next question is displayed.
     Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
          If pepsiText.Text = "Pepsi" Or pepsiText.Text = "pepsi" Then
               startForm.correctAnswer = startForm.correctAnswer + 1
          End If

          Me.Hide()
          Timer5.Enabled = False
          LogoQuestion6.ShowDialog()
     End Sub

     'Description: Question5_Load procedure
     'This procedure is called when the page is loaded
     'It sets the timer interval based on the radio button selected by the user on the start up page.
     Private Sub Question5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          If startForm.TimerSelected = 0 Then
               Timer5.Enabled = True
               Timer5.Interval = 60000
          ElseIf startForm.TimerSelected = 1 Then
               Timer5.Enabled = True
               Timer5.Interval = 30000
          End If
     End Sub

     'Description: Timer5_Tick procedure
     'This procedure is called when the timers clock ticked
     'It sets the timer to false and closes the current window and opens the next question.
     Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
          If pepsiText.Text = "Pepsi" Or pepsiText.Text = "pepsi" Then
               StartForm.correctAnswer = StartForm.correctAnswer + 1
          End If
          Timer5.Enabled = False
          Me.Hide()
          LogoQuestion6.ShowDialog()
     End Sub


End Class