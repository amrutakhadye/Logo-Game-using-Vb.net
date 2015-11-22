<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class output
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
          Me.userNameLabel = New System.Windows.Forms.Label()
          Me.correctAns = New System.Windows.Forms.Label()
          Me.closeBnt = New System.Windows.Forms.Button()
          Me.PictureBox1 = New System.Windows.Forms.PictureBox()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
          Me.SuspendLayout()
          '
          'userNameLabel
          '
          Me.userNameLabel.AutoSize = True
          Me.userNameLabel.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.userNameLabel.Location = New System.Drawing.Point(219, 288)
          Me.userNameLabel.Name = "userNameLabel"
          Me.userNameLabel.Size = New System.Drawing.Size(93, 39)
          Me.userNameLabel.TabIndex = 0
          Me.userNameLabel.Text = "Hello "
          '
          'correctAns
          '
          Me.correctAns.AutoSize = True
          Me.correctAns.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.correctAns.Location = New System.Drawing.Point(120, 387)
          Me.correctAns.Name = "correctAns"
          Me.correctAns.Size = New System.Drawing.Size(263, 39)
          Me.correctAns.TabIndex = 1
          Me.correctAns.Text = "correct Answer No."
          '
          'closeBnt
          '
          Me.closeBnt.DialogResult = System.Windows.Forms.DialogResult.Cancel
          Me.closeBnt.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.closeBnt.Location = New System.Drawing.Point(261, 530)
          Me.closeBnt.Name = "closeBnt"
          Me.closeBnt.Size = New System.Drawing.Size(122, 55)
          Me.closeBnt.TabIndex = 3
          Me.closeBnt.Text = "Close"
          Me.closeBnt.UseVisualStyleBackColor = True
          '
          'PictureBox1
          '
          Me.PictureBox1.Image = Global.project3_Amruta.My.Resources.Resources.gameOver
          Me.PictureBox1.Location = New System.Drawing.Point(226, 79)
          Me.PictureBox1.Name = "PictureBox1"
          Me.PictureBox1.Size = New System.Drawing.Size(203, 152)
          Me.PictureBox1.TabIndex = 4
          Me.PictureBox1.TabStop = False
          '
          'output
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
          Me.CancelButton = Me.closeBnt
          Me.ClientSize = New System.Drawing.Size(682, 653)
          Me.Controls.Add(Me.PictureBox1)
          Me.Controls.Add(Me.closeBnt)
          Me.Controls.Add(Me.correctAns)
          Me.Controls.Add(Me.userNameLabel)
          Me.Name = "output"
          Me.Text = "output"
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents userNameLabel As System.Windows.Forms.Label
     Friend WithEvents correctAns As System.Windows.Forms.Label
     Friend WithEvents closeBnt As System.Windows.Forms.Button
     Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
