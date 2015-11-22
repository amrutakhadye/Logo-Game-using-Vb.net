<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogoQuestion3
     Inherits System.Windows.Forms.Form

     'Form overrides dispose to clean up the component list.
     <System.Diagnostics.DebuggerNonUserCode()> _
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
     <System.Diagnostics.DebuggerStepThrough()> _
     Private Sub InitializeComponent()
          Me.components = New System.ComponentModel.Container()
          Me.Label1 = New System.Windows.Forms.Label()
          Me.NextButton = New System.Windows.Forms.Button()
          Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
          Me.NikiText = New System.Windows.Forms.TextBox()
          Me.PictureBox1 = New System.Windows.Forms.PictureBox()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
          Me.SuspendLayout()
          '
          'Label1
          '
          Me.Label1.AutoSize = True
          Me.Label1.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.Label1.Location = New System.Drawing.Point(220, 319)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(296, 39)
          Me.Label1.TabIndex = 0
          Me.Label1.Text = "Guess the Logo Name"
          '
          'NextButton
          '
          Me.NextButton.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.NextButton.Location = New System.Drawing.Point(316, 536)
          Me.NextButton.Name = "NextButton"
          Me.NextButton.Size = New System.Drawing.Size(111, 47)
          Me.NextButton.TabIndex = 3
          Me.NextButton.Text = "Next"
          Me.NextButton.UseVisualStyleBackColor = True
          '
          'Timer3
          '
          '
          'NikiText
          '
          Me.NikiText.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.NikiText.Location = New System.Drawing.Point(261, 412)
          Me.NikiText.Name = "NikiText"
          Me.NikiText.Size = New System.Drawing.Size(221, 46)
          Me.NikiText.TabIndex = 4
          '
          'PictureBox1
          '
          Me.PictureBox1.Image = Global.project3_Amruta.My.Resources.Resources.nike_swoosh
          Me.PictureBox1.Location = New System.Drawing.Point(212, 90)
          Me.PictureBox1.Name = "PictureBox1"
          Me.PictureBox1.Size = New System.Drawing.Size(315, 133)
          Me.PictureBox1.TabIndex = 1
          Me.PictureBox1.TabStop = False
          '
          'LogoQuestion3
          '
          Me.AcceptButton = Me.NextButton
          Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
          Me.ClientSize = New System.Drawing.Size(682, 653)
          Me.Controls.Add(Me.NikiText)
          Me.Controls.Add(Me.NextButton)
          Me.Controls.Add(Me.PictureBox1)
          Me.Controls.Add(Me.Label1)
          Me.Name = "LogoQuestion3"
          Me.Text = "Logo Question 3"
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
     Friend WithEvents NextButton As System.Windows.Forms.Button
     Friend WithEvents Timer3 As System.Windows.Forms.Timer
     Friend WithEvents NikiText As System.Windows.Forms.TextBox
End Class
