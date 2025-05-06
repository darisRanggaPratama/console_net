<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grade
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
		Me.txtScore = New System.Windows.Forms.TextBox()
		Me.lbScorel = New System.Windows.Forms.Label()
		Me.btnGrade = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'txtScore
		'
		Me.txtScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtScore.Location = New System.Drawing.Point(329, 69)
		Me.txtScore.MaxLength = 3
		Me.txtScore.Name = "txtScore"
		Me.txtScore.Size = New System.Drawing.Size(242, 22)
		Me.txtScore.TabIndex = 0
		'
		'lbScorel
		'
		Me.lbScorel.AutoSize = true
		Me.lbScorel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbScorel.Location = New System.Drawing.Point(240, 72)
		Me.lbScorel.Name = "lbScorel"
		Me.lbScorel.Size = New System.Drawing.Size(43, 16)
		Me.lbScorel.TabIndex = 1
		Me.lbScorel.Text = "Score"
		'
		'btnGrade
		'
		Me.btnGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnGrade.Location = New System.Drawing.Point(329, 135)
		Me.btnGrade.Name = "btnGrade"
		Me.btnGrade.Size = New System.Drawing.Size(242, 23)
		Me.btnGrade.TabIndex = 2
		Me.btnGrade.Text = "Grade"
		Me.btnGrade.UseVisualStyleBackColor = true
		'
		'Grade
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnGrade)
		Me.Controls.Add(Me.lbScorel)
		Me.Controls.Add(Me.txtScore)
		Me.Name = "Grade"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Grade"
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents txtScore As TextBox
	Friend WithEvents lbScorel As Label
	Friend WithEvents btnGrade As Button
End Class
