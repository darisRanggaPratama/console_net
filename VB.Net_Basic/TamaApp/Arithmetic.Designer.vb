<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arithmetic
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
		Me.lblNumber1 = New System.Windows.Forms.Label()
		Me.txtNumber1 = New System.Windows.Forms.TextBox()
		Me.txtNumber2 = New System.Windows.Forms.TextBox()
		Me.lblNumber2 = New System.Windows.Forms.Label()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'lblNumber1
		'
		Me.lblNumber1.AutoSize = true
		Me.lblNumber1.Font = New System.Drawing.Font("JetBrains Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblNumber1.Location = New System.Drawing.Point(213, 59)
		Me.lblNumber1.Name = "lblNumber1"
		Me.lblNumber1.Size = New System.Drawing.Size(72, 17)
		Me.lblNumber1.TabIndex = 0
		Me.lblNumber1.Text = "Number 1"
		'
		'txtNumber1
		'
		Me.txtNumber1.Font = New System.Drawing.Font("JetBrains Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNumber1.Location = New System.Drawing.Point(291, 59)
		Me.txtNumber1.Name = "txtNumber1"
		Me.txtNumber1.Size = New System.Drawing.Size(251, 25)
		Me.txtNumber1.TabIndex = 1
		'
		'txtNumber2
		'
		Me.txtNumber2.Font = New System.Drawing.Font("JetBrains Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNumber2.Location = New System.Drawing.Point(291, 114)
		Me.txtNumber2.Name = "txtNumber2"
		Me.txtNumber2.Size = New System.Drawing.Size(251, 25)
		Me.txtNumber2.TabIndex = 3
		'
		'lblNumber2
		'
		Me.lblNumber2.AutoSize = true
		Me.lblNumber2.Font = New System.Drawing.Font("JetBrains Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblNumber2.Location = New System.Drawing.Point(213, 114)
		Me.lblNumber2.Name = "lblNumber2"
		Me.lblNumber2.Size = New System.Drawing.Size(72, 17)
		Me.lblNumber2.TabIndex = 2
		Me.lblNumber2.Text = "Number 2"
		'
		'btnCalculate
		'
		Me.btnCalculate.Font = New System.Drawing.Font("JetBrains Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnCalculate.Location = New System.Drawing.Point(291, 178)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(251, 40)
		Me.btnCalculate.TabIndex = 4
		Me.btnCalculate.Text = "Calculate"
		Me.btnCalculate.UseVisualStyleBackColor = true
		'
		'Arithmetic
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.txtNumber2)
		Me.Controls.Add(Me.lblNumber2)
		Me.Controls.Add(Me.txtNumber1)
		Me.Controls.Add(Me.lblNumber1)
		Me.Name = "Arithmetic"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Arithmetic"
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents lblNumber1 As Label
	Friend WithEvents txtNumber1 As TextBox
	Friend WithEvents txtNumber2 As TextBox
	Friend WithEvents lblNumber2 As Label
	Friend WithEvents btnCalculate As Button
End Class
