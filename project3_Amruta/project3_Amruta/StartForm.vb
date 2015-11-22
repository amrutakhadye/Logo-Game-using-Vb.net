'Author Name     : Amruta Khadye
'Course Name     : CS 552-D- Windows Interface Design in Visual Basic
'Date of Project : 5/14/2015
'Assignment Name : Project 3
'Description     : The project is a logo Game. It displays two radio buttons, clicking on which changes
'                  the timer timing according to the selected radio button.The player enters his/her name
'                  in the text box. Validation is done for the player name. If the player name is empty , a pop up appears.
Public Class StartForm

     Public username As String
     Public TimerSelected As Integer
     Public correctAnswer As Integer


     'Description: startBnt_Click procedure
     'This procedure is called when the user clicks on start button.
     'It checks if the player name is empty or not. If not it checks the radio button selected 
     'and sets the varibale value to 0 or 1. And displays the first question.
     Private Sub startBnt_Click(sender As Object, e As EventArgs) Handles startBnt.Click
          If playerName.Text = "" Then
               MessageBox.Show("Please enter Player Name")
          Else
               username = playerName.Text
               If easyRadio.Checked Then
                    TimerSelected = 0
               ElseIf hardRadio.Checked Then
                    TimerSelected = 1
               End If
               Me.Hide()
               LogoQuestion1.ShowDialog()
          End If

     End Sub
End Class
