<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogoQuestion2
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
          Me.EbayRadio = New System.Windows.Forms.RadioButton()
          Me.amazonRadio = New System.Windows.Forms.RadioButton()
          Me.WalMartRadio = New System.Windows.Forms.RadioButton()
          Me.bestBuyRadio = New System.Windows.Forms.RadioButton()
          Me.NextButton = New System.Windows.Forms.Button()
          Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
          Me.PictureBox1 = New System.Windows.Forms.PictureBox()
          Me.GroupBox1.SuspendLayout()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
          Me.SuspendLayout()
          '
          'Label1
          '
          Me.Label1.AutoSize = True
          Me.Label1.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.Label1.Location = New System.Drawing.Point(203, 33)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(236, 39)
          Me.Label1.TabIndex = 0
          Me.Label1.Text = "Identify the Logo"
          '
          'GroupBox1
          '
          Me.GroupBox1.Controls.Add(Me.EbayRadio)
          Me.GroupBox1.Controls.Add(Me.amazonRadio)
          Me.GroupBox1.Controls.Add(Me.WalMartRadio)
          Me.GroupBox1.Controls.Add(Me.bestBuyRadio)
          Me.GroupBox1.Location = New System.Drawing.Point(145, 325)
          Me.GroupBox1.Name = "GroupBox1"
          Me.GroupBox1.Size = New System.Drawing.Size(431, 249)
          Me.GroupBox1.TabIndex = 2
          Me.GroupBox1.TabStop = False
          '
          'EbayRadio
          '
          Me.EbayRadio.AutoSize = True
          Me.EbayRadio.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.EbayRadio.Location = New System.Drawing.Point(35, 191)
          Me.EbayRadio.Name = "EbayRadio"
          Me.EbayRadio.Size = New System.Drawing.Size(98, 43)
          Me.EbayRadio.TabIndex = 3
          Me.EbayRadio.TabStop = True
          Me.EbayRadio.Text = "Ebay"
          Me.EbayRadio.UseVisualStyleBackColor = True
          '
          'amazonRadio
          '
          Me.amazonRadio.AutoSize = True
          Me.amazonRadio.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.amazonRadio.Location = New System.Drawing.Point(35, 146)
          Me.amazonRadio.Name = "amazonRadio"
          Me.amazonRadio.Size = New System.Drawing.Size(140, 43)
          Me.amazonRadio.TabIndex = 2
          Me.amazonRadio.TabStop = True
          Me.amazonRadio.Text = "Amazon"
          Me.amazonRadio.UseVisualStyleBackColor = True
          '
          'WalMartRadio
          '
          Me.WalMartRadio.AutoSize = True
          Me.WalMartRadio.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.WalMartRadio.Location = New System.Drawing.Point(35, 92)
          Me.WalMartRadio.Name = "WalMartRadio"
          Me.WalMartRadio.Size = New System.Drawing.Size(157, 43)
          Me.WalMartRadio.TabIndex = 1
          Me.WalMartRadio.TabStop = True
          Me.WalMartRadio.Text = "Wal Mart"
          Me.WalMartRadio.UseVisualStyleBackColor = True
          '
          'bestBuyRadio
          '
          Me.bestBuyRadio.AutoSize = True
          Me.bestBuyRadio.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.bestBuyRadio.Location = New System.Drawing.Point(35, 41)
          Me.bestBuyRadio.Name = "bestBuyRadio"
          Me.bestBuyRadio.Size = New System.Drawing.Size(148, 43)
          Me.bestBuyRadio.TabIndex = 0
          Me.bestBuyRadio.TabStop = True
          Me.bestBuyRadio.Text = "Best Buy"
          Me.bestBuyRadio.UseVisualStyleBackColor = True
          '
          'NextButton
          '
          Me.NextButton.Font = New System.Drawing.Font("Segoe Marker", 19.8!, System.Drawing.FontStyle.Bold)
          Me.NextButton.Location = New System.Drawing.Point(304, 597)
          Me.NextButton.Name = "NextButton"
          Me.NextButton.Size = New System.Drawing.Size(100, 44)
          Me.NextButton.TabIndex = 3
          Me.NextButton.Text = "Next"
          Me.NextButton.UseVisualStyleBackColor = True
          '
          'Timer2
          '
          '
          'PictureBox1
          '
          Me.PictureBox1.Image = Global.project3_Amruta.My.Resources.Resources.Amazon_logo
          Me.PictureBox1.Location = New System.Drawing.Point(232, 104)
          Me.PictureBox1.Name = "PictureBox1"
          Me.PictureBox1.Size = New System.Drawing.Size(207, 200)
          Me.PictureBox1.TabIndex = 1
          Me.PictureBox1.TabStop = False
          '
          'LogoQuestion2
          '
          Me.AcceptButton = Me.NextButton
          Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.BackColor = System.Drawing.Color.Crimson
          Me.ClientSize = New System.Drawing.Size(682, 653)
          Me.Controls.Add(Me.NextButton)
          Me.Controls.Add(Me.GroupBox1)
          Me.Controls.Add(Me.PictureBox1)
          Me.Controls.Add(Me.Label1)
          Me.Name = "LogoQuestion2"
          Me.Text = "Logo Question 2"
          Me.GroupBox1.ResumeLayout(False)
          Me.GroupBox1.PerformLayout()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
     Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
     Friend WithEvents EbayRadio As System.Windows.Forms.RadioButton
     Friend WithEvents amazonRadio As System.Windows.Forms.RadioButton
     Friend WithEvents WalMartRadio As System.Windows.Forms.RadioButton
     Friend WithEvents bestBuyRadio As System.Windows.Forms.RadioButton
     Friend WithEvents NextButton As System.Windows.Forms.Button
     Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
