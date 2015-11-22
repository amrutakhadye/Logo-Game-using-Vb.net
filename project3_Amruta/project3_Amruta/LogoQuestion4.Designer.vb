<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogoQuestion4
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
          Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogoQuestion4))
          Me.Label1 = New System.Windows.Forms.Label()
          Me.GroupBox1 = New System.Windows.Forms.GroupBox()
          Me.FirefoxRadio = New System.Windows.Forms.RadioButton()
          Me.yamahaRadio = New System.Windows.Forms.RadioButton()
          Me.unicefRadio = New System.Windows.Forms.RadioButton()
          Me.timberlandRadio = New System.Windows.Forms.RadioButton()
          Me.NextButton = New System.Windows.Forms.Button()
          Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
          Me.GroupBox1.SuspendLayout()
          Me.SuspendLayout()
          '
          'Label1
          '
          Me.Label1.AutoSize = True
          Me.Label1.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.Label1.Location = New System.Drawing.Point(105, 25)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(437, 39)
          Me.Label1.TabIndex = 0
          Me.Label1.Text = "Identify the Logo for Timberland"
          '
          'GroupBox1
          '
          Me.GroupBox1.Controls.Add(Me.FirefoxRadio)
          Me.GroupBox1.Controls.Add(Me.yamahaRadio)
          Me.GroupBox1.Controls.Add(Me.unicefRadio)
          Me.GroupBox1.Controls.Add(Me.timberlandRadio)
          Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
          Me.GroupBox1.Name = "GroupBox1"
          Me.GroupBox1.Size = New System.Drawing.Size(635, 493)
          Me.GroupBox1.TabIndex = 2
          Me.GroupBox1.TabStop = False
          '
          'FirefoxRadio
          '
          Me.FirefoxRadio.AutoSize = True
          Me.FirefoxRadio.Image = Global.project3_Amruta.My.Resources.Resources.fireFox
          Me.FirefoxRadio.Location = New System.Drawing.Point(30, 281)
          Me.FirefoxRadio.Name = "FirefoxRadio"
          Me.FirefoxRadio.Size = New System.Drawing.Size(217, 188)
          Me.FirefoxRadio.TabIndex = 3
          Me.FirefoxRadio.TabStop = True
          Me.FirefoxRadio.UseVisualStyleBackColor = True
          '
          'yamahaRadio
          '
          Me.yamahaRadio.AutoSize = True
          Me.yamahaRadio.Image = Global.project3_Amruta.My.Resources.Resources.yahama
          Me.yamahaRadio.Location = New System.Drawing.Point(401, 281)
          Me.yamahaRadio.Name = "yamahaRadio"
          Me.yamahaRadio.Size = New System.Drawing.Size(217, 193)
          Me.yamahaRadio.TabIndex = 2
          Me.yamahaRadio.TabStop = True
          Me.yamahaRadio.UseVisualStyleBackColor = True
          '
          'unicefRadio
          '
          Me.unicefRadio.Image = Global.project3_Amruta.My.Resources.Resources.unicef
          Me.unicefRadio.Location = New System.Drawing.Point(376, 21)
          Me.unicefRadio.Name = "unicefRadio"
          Me.unicefRadio.Size = New System.Drawing.Size(242, 217)
          Me.unicefRadio.TabIndex = 1
          Me.unicefRadio.TabStop = True
          Me.unicefRadio.UseVisualStyleBackColor = True
          '
          'timberlandRadio
          '
          Me.timberlandRadio.Image = CType(resources.GetObject("timberlandRadio.Image"), System.Drawing.Image)
          Me.timberlandRadio.Location = New System.Drawing.Point(6, 12)
          Me.timberlandRadio.Name = "timberlandRadio"
          Me.timberlandRadio.Size = New System.Drawing.Size(254, 244)
          Me.timberlandRadio.TabIndex = 0
          Me.timberlandRadio.TabStop = True
          Me.timberlandRadio.UseVisualStyleBackColor = True
          '
          'NextButton
          '
          Me.NextButton.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.NextButton.Location = New System.Drawing.Point(282, 577)
          Me.NextButton.Name = "NextButton"
          Me.NextButton.Size = New System.Drawing.Size(92, 64)
          Me.NextButton.TabIndex = 3
          Me.NextButton.Text = "Next"
          Me.NextButton.UseVisualStyleBackColor = True
          '
          'Timer4
          '
          '
          'LogoQuestion4
          '
          Me.AcceptButton = Me.NextButton
          Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
          Me.ClientSize = New System.Drawing.Size(682, 653)
          Me.Controls.Add(Me.NextButton)
          Me.Controls.Add(Me.GroupBox1)
          Me.Controls.Add(Me.Label1)
          Me.Name = "LogoQuestion4"
          Me.Text = "Logo Question 4"
          Me.GroupBox1.ResumeLayout(False)
          Me.GroupBox1.PerformLayout()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
     Friend WithEvents FirefoxRadio As System.Windows.Forms.RadioButton
     Friend WithEvents yamahaRadio As System.Windows.Forms.RadioButton
     Friend WithEvents unicefRadio As System.Windows.Forms.RadioButton
     Friend WithEvents timberlandRadio As System.Windows.Forms.RadioButton
     Friend WithEvents NextButton As System.Windows.Forms.Button
     Friend WithEvents Timer4 As System.Windows.Forms.Timer
End Class
