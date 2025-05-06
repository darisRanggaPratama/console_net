namespace C_connMySQL
{
	partial class FormDisplay
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnConnect = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.gridData = new System.Windows.Forms.DataGridView();
			this.btnDisplay = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
			this.SuspendLayout();
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(312, 384);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(88, 40);
			this.btnConnect.TabIndex = 0;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(8, 32);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(392, 342);
			this.listBox1.TabIndex = 1;
			// 
			// gridData
			// 
			this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridData.Location = new System.Drawing.Point(424, 32);
			this.gridData.Name = "gridData";
			this.gridData.Size = new System.Drawing.Size(368, 344);
			this.gridData.TabIndex = 2;
			// 
			// btnDisplay
			// 
			this.btnDisplay.Location = new System.Drawing.Point(712, 384);
			this.btnDisplay.Name = "btnDisplay";
			this.btnDisplay.Size = new System.Drawing.Size(80, 40);
			this.btnDisplay.TabIndex = 3;
			this.btnDisplay.Text = "Display";
			this.btnDisplay.UseVisualStyleBackColor = true;
			this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
			// 
			// FormDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDisplay);
			this.Controls.Add(this.gridData);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnConnect);
			this.Name = "FormDisplay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DisplayData";
			((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.DataGridView gridData;
		private System.Windows.Forms.Button btnDisplay;
	}
}

