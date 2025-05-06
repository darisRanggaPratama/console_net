namespace CRUD_MYSQL
{
	partial class Display
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
			this.dgvContacts = new System.Windows.Forms.DataGridView();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.lblPhone = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnUpload = new System.Windows.Forms.Button();
			this.btnDownload = new System.Windows.Forms.Button();
			this.nudPageSize = new System.Windows.Forms.NumericUpDown();
			this.btnNextPage = new System.Windows.Forms.Button();
			this.btnPrevPage = new System.Windows.Forms.Button();
			this.lblPageSize = new System.Windows.Forms.Label();
			this.lblPageInfo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPageSize)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvContacts
			// 
			this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContacts.Location = new System.Drawing.Point(8, 104);
			this.dgvContacts.Name = "dgvContacts";
			this.dgvContacts.Size = new System.Drawing.Size(784, 624);
			this.dgvContacts.TabIndex = 0;
			this.dgvContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellContentClick);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(8, 24);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(45, 17);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(72, 16);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(136, 23);
			this.txtName.TabIndex = 2;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(224, 56);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.Location = new System.Drawing.Point(72, 56);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(136, 23);
			this.txtPhone.TabIndex = 5;
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhone.Location = new System.Drawing.Point(8, 64);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(49, 17);
			this.lblPhone.TabIndex = 4;
			this.lblPhone.Text = "Phone";
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(224, 16);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(320, 56);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(320, 16);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 8;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(416, 16);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 9;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnUpload
			// 
			this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpload.Location = new System.Drawing.Point(512, 16);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(112, 23);
			this.btnUpload.TabIndex = 10;
			this.btnUpload.Text = "UploadCSV";
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// btnDownload
			// 
			this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDownload.Location = new System.Drawing.Point(512, 56);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(112, 23);
			this.btnDownload.TabIndex = 11;
			this.btnDownload.Text = "DownloadCSV";
			this.btnDownload.UseVisualStyleBackColor = true;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// nudPageSize
			// 
			this.nudPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudPageSize.Location = new System.Drawing.Point(664, 56);
			this.nudPageSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudPageSize.Name = "nudPageSize";
			this.nudPageSize.Size = new System.Drawing.Size(120, 23);
			this.nudPageSize.TabIndex = 12;
			this.nudPageSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudPageSize.ValueChanged += new System.EventHandler(this.nudPageSize_ValueChanged);
			// 
			// btnNextPage
			// 
			this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNextPage.Location = new System.Drawing.Point(440, 736);
			this.btnNextPage.Name = "btnNextPage";
			this.btnNextPage.Size = new System.Drawing.Size(75, 23);
			this.btnNextPage.TabIndex = 13;
			this.btnNextPage.Text = "Next";
			this.btnNextPage.UseVisualStyleBackColor = true;
			this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
			// 
			// btnPrevPage
			// 
			this.btnPrevPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrevPage.Location = new System.Drawing.Point(336, 736);
			this.btnPrevPage.Name = "btnPrevPage";
			this.btnPrevPage.Size = new System.Drawing.Size(75, 23);
			this.btnPrevPage.TabIndex = 14;
			this.btnPrevPage.Text = "Previous";
			this.btnPrevPage.UseVisualStyleBackColor = true;
			this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
			// 
			// lblPageSize
			// 
			this.lblPageSize.AutoSize = true;
			this.lblPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPageSize.Location = new System.Drawing.Point(664, 16);
			this.lblPageSize.Name = "lblPageSize";
			this.lblPageSize.Size = new System.Drawing.Size(72, 17);
			this.lblPageSize.TabIndex = 15;
			this.lblPageSize.Text = "Page Size";
			// 
			// lblPageInfo
			// 
			this.lblPageInfo.AutoSize = true;
			this.lblPageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPageInfo.Location = new System.Drawing.Point(16, 744);
			this.lblPageInfo.Name = "lblPageInfo";
			this.lblPageInfo.Size = new System.Drawing.Size(155, 17);
			this.lblPageInfo.TabIndex = 16;
			this.lblPageInfo.Text = "Page 1 of 1 (0 records)";
			// 
			// Display
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 776);
			this.Controls.Add(this.lblPageInfo);
			this.Controls.Add(this.lblPageSize);
			this.Controls.Add(this.btnPrevPage);
			this.Controls.Add(this.btnNextPage);
			this.Controls.Add(this.nudPageSize);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.lblPhone);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.dgvContacts);
			this.Name = "Display";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CRUD";
			this.Load += new System.EventHandler(this.Display_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPageSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvContacts;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.NumericUpDown nudPageSize;
		private System.Windows.Forms.Button btnNextPage;
		private System.Windows.Forms.Button btnPrevPage;
		private System.Windows.Forms.Label lblPageSize;
		private System.Windows.Forms.Label lblPageInfo;
	}
}

