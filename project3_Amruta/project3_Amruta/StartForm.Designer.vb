<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
          Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
          Me.Label1 = New System.Windows.Forms.Label()
          Me.playerName = New System.Windows.Forms.TextBox()
          Me.GroupBox1 = New System.Windows.Forms.GroupBox()
          Me.hardRadio = New System.Windows.Forms.RadioButton()
          Me.easyRadio = New System.Windows.Forms.RadioButton()
          Me.PictureBox1 = New System.Windows.Forms.PictureBox()
          Me.startBnt = New System.Windows.Forms.Button()
          Me.Label = New System.Windows.Forms.Label()
          Me.Label2 = New System.Windows.Forms.Label()
          Me.Label3 = New System.Windows.Forms.Label()
          Me.GroupBox1.SuspendLayout()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
          Me.SuspendLayout()
          '
          'Label1
          '
          Me.Label1.AutoSize = True
          Me.Label1.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.Label1.Location = New System.Drawing.Point(64, 384)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(181, 39)
          Me.Label1.TabIndex = 2
          Me.Label1.Text = "Player Name"
          '
          'playerName
          '
          Me.playerName.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.playerName.Location = New System.Drawing.Point(286, 384)
          Me.playerName.Name = "playerName"
          Me.playerName.Size = New System.Drawing.Size(250, 46)
          Me.playerName.TabIndex = 3
          '
          'GroupBox1
          '
          Me.GroupBox1.Controls.Add(Me.hardRadio)
          Me.GroupBox1.Controls.Add(Me.easyRadio)
          Me.GroupBox1.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.GroupBox1.Location = New System.Drawing.Point(33, 422)
          Me.GroupBox1.Name = "GroupBox1"
          Me.GroupBox1.Size = New System.Drawing.Size(576, 145)
          Me.GroupBox1.TabIndex = 4
          Me.GroupBox1.TabStop = False
          '
          'hardRadio
          '
          Me.hardRadio.Image = CType(resources.GetObject("hardRadio.Image"), System.Drawing.Image)
          Me.hardRadio.Location = New System.Drawing.Point(344, 42)
          Me.hardRadio.Name = "hardRadio"
          Me.hardRadio.Size = New System.Drawing.Size(124, 99)
          Me.hardRadio.TabIndex = 1
          Me.hardRadio.TabStop = True
          Me.hardRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
          Me.hardRadio.UseVisualStyleBackColor = True
          '
          'easyRadio
          '
          Me.easyRadio.AutoSize = True
          Me.easyRadio.Checked = True
          Me.easyRadio.Image = CType(resources.GetObject("easyRadio.Image"), System.Drawing.Image)
          Me.easyRadio.Location = New System.Drawing.Point(40, 42)
          Me.easyRadio.Name = "easyRadio"
          Me.easyRadio.Size = New System.Drawing.Size(117, 99)
          Me.easyRadio.TabIndex = 0
          Me.easyRadio.TabStop = True
          Me.easyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
          Me.easyRadio.UseVisualStyleBackColor = True
          '
          'PictureBox1
          '
          Me.PictureBox1.Image = Global.project3_Amruta.My.Resources.Resources.gameZonel
          Me.PictureBox1.Location = New System.Drawing.Point(121, 22)
          Me.PictureBox1.Name = "PictureBox1"
          Me.PictureBox1.Size = New System.Drawing.Size(381, 147)
          Me.PictureBox1.TabIndex = 5
          Me.PictureBox1.TabStop = False
          '
          'startBnt
          '
          Me.startBnt.Image = Global.project3_Amruta.My.Resources.Resources.start
          Me.startBnt.Location = New System.Drawing.Point(237, 583)
          Me.startBnt.Name = "startBnt"
          Me.startBnt.Size = New System.Drawing.Size(132, 58)
          Me.startBnt.TabIndex = 1
          Me.startBnt.UseVisualStyleBackColor = True
          '
          'Label
          '
          Me.Label.AutoSize = True
          Me.Label.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.Label.Location = New System.Drawing.Point(45, 181)
          Me.Label.Name = "Label"
          Me.Label.Size = New System.Drawing.Size(183, 39)
          Me.Label.TabIndex = 0
          Me.Label.Text = "Instructions: "
          '
          'Label2
          '
          Me.Label2.AutoSize = True
          Me.Label2.Font = New System.Drawing.Font("Segoe Marker", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.Label2.Location = New System.Drawing.Point(46, 234)
          Me.Label2.Name = "Label2"
          Me.Label2.Size = New System.Drawing.Size(443, 33)
          Me.Label2.TabIndex = 6
          Me.Label2.Text = "1.Select the correct Logo to win the Game."
          '
          'Label3
          '
          Me.Label3.Font = New System.Drawing.Font("Segoe Marker", 16.2!)
          Me.Label3.Location = New System.Drawing.Point(46, 284)
          Me.Label3.Name = "Label3"
          Me.Label3.Size = New System.Drawing.Size(579, 83)
          Me.Label3.TabIndex = 7
          Me.Label3.Text = "2. Select the level of difficulty to start the game. Easy has a 60 sec timer and " & _
    "Hard has a 30 sec timer."
          '
          'StartForm
          '
          Me.AcceptButton = Me.startBnt
          Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
          Me.ClientSize = New System.Drawing.Size(682, 653)
          Me.Controls.Add(Me.Label3)
          Me.Controls.Add(Me.Label2)
          Me.Controls.Add(Me.PictureBox1)
          Me.Controls.Add(Me.GroupBox1)
          Me.Controls.Add(Me.playerName)
          Me.Controls.Add(Me.Label1)
          Me.Controls.Add(Me.startBnt)
          Me.Controls.Add(Me.Label)
          Me.Name = "StartForm"
          Me.Text = "Logo Game"
          Me.GroupBox1.ResumeLayout(False)
          Me.GroupBox1.PerformLayout()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents startBnt As System.Windows.Forms.Button
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents playerName As System.Windows.Forms.TextBox
     Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
     Friend WithEvents hardRadio As System.Windows.Forms.RadioButton
     Friend WithEvents easyRadio As System.Windows.Forms.RadioButton
     Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
     Friend WithEvents Label As System.Windows.Forms.Label
     Friend WithEvents Label2 As System.Windows.Forms.Label
     Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
