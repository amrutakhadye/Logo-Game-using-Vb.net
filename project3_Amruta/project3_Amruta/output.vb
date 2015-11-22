'Author Name     : Amruta Khadye
'Course Name     : CS 552-D- Windows Interface Design in Visual Basic
'Date of Project : 5/14/2015
'Assignment Name : Project 3
'Description     : It displays the sixth question of the logo game.
'                  On clicking on the next button the next question is displayed.
'                  The user should select one of the four correct images answers and click on next button,
'                  Otherwise the timer times out and moves to the next question

Public Class output

     'Description: output_Load procedure
     'This procedure is called when the user loads teh page
     'The username is displayed which was input by the user in the first page.
     'The count of correct no of answers is also displayed
     Private Sub output_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          userNameLabel.Text &= StartForm.username
          correctAns.Text = "You have " & StartForm.correctAnswer & " correct Answer."
     End Sub

     'Description: closeBnt_Click procedure
     'This procedure is called when the user clicks on close button.
     'The window closes.
     Private Sub closeBnt_Click(sender As Object, e As EventArgs) Handles closeBnt.Click
          End
     End Sub
End Class