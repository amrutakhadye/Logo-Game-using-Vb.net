<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogoQuestion6
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
          Me.McdonalRadio = New System.Windows.Forms.RadioButton()
          Me.pizzaHutRadio = New System.Windows.Forms.RadioButton()
          Me.starBucksRadio = New System.Windows.Forms.RadioButton()
          Me.dominosRadio = New System.Windows.Forms.RadioButton()
          Me.NextButton = New System.Windows.Forms.Button()
          Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
          Me.GroupBox1.SuspendLayout()
          Me.SuspendLayout()
          '
          'Label1
          '
          Me.Label1.AutoSize = True
          Me.Label1.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.Label1.Location = New System.Drawing.Point(153, 9)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(415, 39)
          Me.Label1.TabIndex = 0
          Me.Label1.Text = "Identify the Logo for Starbucks"
          '
          'GroupBox1
          '
          Me.GroupBox1.Controls.Add(Me.McdonalRadio)
          Me.GroupBox1.Controls.Add(Me.pizzaHutRadio)
          Me.GroupBox1.Controls.Add(Me.starBucksRadio)
          Me.GroupBox1.Controls.Add(Me.dominosRadio)
          Me.GroupBox1.Location = New System.Drawing.Point(33, 65)
          Me.GroupBox1.Name = "GroupBox1"
          Me.GroupBox1.Size = New System.Drawing.Size(598, 493)
          Me.GroupBox1.TabIndex = 2
          Me.GroupBox1.TabStop = False
          '
          'McdonalRadio
          '
          Me.McdonalRadio.AutoSize = True
          Me.McdonalRadio.Image = Global.project3_Amruta.My.Resources.Resources.mcdonals
          Me.McdonalRadio.Location = New System.Drawing.Point(22, 274)
          Me.McdonalRadio.Name = "McdonalRadio"
          Me.McdonalRadio.Size = New System.Drawing.Size(217, 195)
          Me.McdonalRadio.TabIndex = 3
          Me.McdonalRadio.TabStop = True
          Me.McdonalRadio.UseVisualStyleBackColor = True
          '
          'pizzaHutRadio
          '
          Me.pizzaHutRadio.AutoSize = True
          Me.pizzaHutRadio.Image = Global.project3_Amruta.My.Resources.Resources.pizzahut
          Me.pizzaHutRadio.Location = New System.Drawing.Point(368, 284)
          Me.pizzaHutRadio.Name = "pizzaHutRadio"
          Me.pizzaHutRadio.Size = New System.Drawing.Size(217, 200)
          Me.pizzaHutRadio.TabIndex = 2
          Me.pizzaHutRadio.TabStop = True
          Me.pizzaHutRadio.UseVisualStyleBackColor = True
          '
          'starBucksRadio
          '
          Me.starBucksRadio.Image = Global.project3_Amruta.My.Resources.Resources.Starbucks
          Me.starBucksRadio.Location = New System.Drawing.Point(354, 15)
          Me.starBucksRadio.Name = "starBucksRadio"
          Me.starBucksRadio.Size = New System.Drawing.Size(242, 217)
          Me.starBucksRadio.TabIndex = 1
          Me.starBucksRadio.TabStop = True
          Me.starBucksRadio.UseVisualStyleBackColor = True
          '
          'dominosRadio
          '
          Me.dominosRadio.Image = Global.project3_Amruta.My.Resources.Resources.DominosPizza
          Me.dominosRadio.Location = New System.Drawing.Point(6, 1)
          Me.dominosRadio.Name = "dominosRadio"
          Me.dominosRadio.Size = New System.Drawing.Size(254, 244)
          Me.dominosRadio.TabIndex = 0
          Me.dominosRadio.TabStop = True
          Me.dominosRadio.UseVisualStyleBackColor = True
          '
          'NextButton
          '
          Me.NextButton.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.NextButton.Location = New System.Drawing.Point(262, 582)
          Me.NextButton.Name = "NextButton"
          Me.NextButton.Size = New System.Drawing.Size(110, 45)
          Me.NextButton.TabIndex = 3
          Me.NextButton.Text = "Next"
          Me.NextButton.UseVisualStyleBackColor = True
          '
          'Timer6
          '
          '
          'LogoQuestion6
          '
          Me.AcceptButton = Me.NextButton
          Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
          Me.ClientSize = New System.Drawing.Size(682, 653)
          Me.Controls.Add(Me.NextButton)
          Me.Controls.Add(Me.GroupBox1)
          Me.Controls.Add(Me.Label1)
          Me.Name = "LogoQuestion6"
          Me.Text = "Logo Question 6"
          Me.GroupBox1.ResumeLayout(False)
          Me.GroupBox1.PerformLayout()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
     Friend WithEvents McdonalRadio As System.Windows.Forms.RadioButton
     Friend WithEvents pizzaHutRadio As System.Windows.Forms.RadioButton
     Friend WithEvents starBucksRadio As System.Windows.Forms.RadioButton
     Friend WithEvents dominosRadio As System.Windows.Forms.RadioButton
     Friend WithEvents NextButton As System.Windows.Forms.Button
     Friend WithEvents Timer6 As System.Windows.Forms.Timer
End Class
