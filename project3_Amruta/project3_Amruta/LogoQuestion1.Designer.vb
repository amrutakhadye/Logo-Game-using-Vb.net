<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogoQuestion1
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
          Me.GroupBox1 = New System.Windows.Forms.GroupBox()
          Me.fordRadio = New System.Windows.Forms.RadioButton()
          Me.porscheRadio = New System.Windows.Forms.RadioButton()
          Me.rangeRoverRadio = New System.Windows.Forms.RadioButton()
          Me.MercedesRadio = New System.Windows.Forms.RadioButton()
          Me.NextButton = New System.Windows.Forms.Button()
          Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
          Me.PictureBox1 = New System.Windows.Forms.PictureBox()
          Me.GroupBox1.SuspendLayout()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
          Me.SuspendLayout()
          '
          'Label1
          '
          Me.Label1.AutoSize = True
          Me.Label1.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.Label1.Location = New System.Drawing.Point(219, 28)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(236, 39)
          Me.Label1.TabIndex = 0
          Me.Label1.Text = "Identify the Logo"
          '
          'GroupBox1
          '
          Me.GroupBox1.Controls.Add(Me.fordRadio)
          Me.GroupBox1.Controls.Add(Me.porscheRadio)
          Me.GroupBox1.Controls.Add(Me.rangeRoverRadio)
          Me.GroupBox1.Controls.Add(Me.MercedesRadio)
          Me.GroupBox1.Location = New System.Drawing.Point(116, 322)
          Me.GroupBox1.Name = "GroupBox1"
          Me.GroupBox1.Size = New System.Drawing.Size(503, 251)
          Me.GroupBox1.TabIndex = 2
          Me.GroupBox1.TabStop = False
          '
          'fordRadio
          '
          Me.fordRadio.AutoSize = True
          Me.fordRadio.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.fordRadio.Location = New System.Drawing.Point(35, 191)
          Me.fordRadio.Name = "fordRadio"
          Me.fordRadio.Size = New System.Drawing.Size(96, 43)
          Me.fordRadio.TabIndex = 3
          Me.fordRadio.TabStop = True
          Me.fordRadio.Text = "Ford"
          Me.fordRadio.UseVisualStyleBackColor = True
          '
          'porscheRadio
          '
          Me.porscheRadio.AutoSize = True
          Me.porscheRadio.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.porscheRadio.Location = New System.Drawing.Point(35, 146)
          Me.porscheRadio.Name = "porscheRadio"
          Me.porscheRadio.Size = New System.Drawing.Size(138, 43)
          Me.porscheRadio.TabIndex = 2
          Me.porscheRadio.TabStop = True
          Me.porscheRadio.Text = "Porsche"
          Me.porscheRadio.UseVisualStyleBackColor = True
          '
          'rangeRoverRadio
          '
          Me.rangeRoverRadio.AutoSize = True
          Me.rangeRoverRadio.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.rangeRoverRadio.Location = New System.Drawing.Point(35, 92)
          Me.rangeRoverRadio.Name = "rangeRoverRadio"
          Me.rangeRoverRadio.Size = New System.Drawing.Size(200, 43)
          Me.rangeRoverRadio.TabIndex = 1
          Me.rangeRoverRadio.TabStop = True
          Me.rangeRoverRadio.Text = "Range Rover"
          Me.rangeRoverRadio.UseVisualStyleBackColor = True
          '
          'MercedesRadio
          '
          Me.MercedesRadio.AutoSize = True
          Me.MercedesRadio.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.MercedesRadio.Location = New System.Drawing.Point(35, 41)
          Me.MercedesRadio.Name = "MercedesRadio"
          Me.MercedesRadio.Size = New System.Drawing.Size(161, 43)
          Me.MercedesRadio.TabIndex = 0
          Me.MercedesRadio.TabStop = True
          Me.MercedesRadio.Text = "Mercedes"
          Me.MercedesRadio.UseVisualStyleBackColor = True
          '
          'NextButton
          '
          Me.NextButton.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.NextButton.Location = New System.Drawing.Point(315, 591)
          Me.NextButton.Name = "NextButton"
          Me.NextButton.Size = New System.Drawing.Size(119, 50)
          Me.NextButton.TabIndex = 3
          Me.NextButton.Text = "Next"
          Me.NextButton.UseVisualStyleBackColor = True
          '
          'Timer1
          '
          '
          'PictureBox1
          '
          Me.PictureBox1.Image = Global.project3_Amruta.My.Resources.Resources.MercedesLogo
          Me.PictureBox1.Location = New System.Drawing.Point(226, 103)
          Me.PictureBox1.Name = "PictureBox1"
          Me.PictureBox1.Size = New System.Drawing.Size(240, 194)
          Me.PictureBox1.TabIndex = 1
          Me.PictureBox1.TabStop = False
          '
          'LogoQuestion1
          '
          Me.AcceptButton = Me.NextButton
          Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.BackgroundImage = Global.project3_Amruta.My.Resources.Resources.mer
          Me.ClientSize = New System.Drawing.Size(682, 653)
          Me.Controls.Add(Me.NextButton)
          Me.Controls.Add(Me.GroupBox1)
          Me.Controls.Add(Me.PictureBox1)
          Me.Controls.Add(Me.Label1)
          Me.Name = "LogoQuestion1"
          Me.Text = "Logo Question 1"
          Me.GroupBox1.ResumeLayout(False)
          Me.GroupBox1.PerformLayout()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
     Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
     Friend WithEvents fordRadio As System.Windows.Forms.RadioButton
     Friend WithEvents porscheRadio As System.Windows.Forms.RadioButton
     Friend WithEvents rangeRoverRadio As System.Windows.Forms.RadioButton
     Friend WithEvents MercedesRadio As System.Windows.Forms.RadioButton
     Friend WithEvents NextButton As System.Windows.Forms.Button
     Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
