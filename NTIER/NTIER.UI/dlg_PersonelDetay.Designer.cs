namespace NTIER.UI
{
    partial class dlg_PersonelDetay
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
			this.components = new System.ComponentModel.Container();
			this.dgv_Adres = new System.Windows.Forms.DataGridView();
			this.dgv_Tel = new System.Windows.Forms.DataGridView();
			this.dgv_Email = new System.Windows.Forms.DataGridView();
			this.lbl_Id = new System.Windows.Forms.Label();
			this.lbl_JobTitle = new System.Windows.Forms.Label();
			this.lbl_HireDate = new System.Windows.Forms.Label();
			this.lbl_Name = new System.Windows.Forms.Label();
			this.lbl_Surname = new System.Windows.Forms.Label();
			this.dgv_PersonelBilgileri = new System.Windows.Forms.DataGridView();
			this.lbl_BirthDate = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Adres)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Tel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Email)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelBilgileri)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv_Adres
			// 
			this.dgv_Adres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Adres.ContextMenuStrip = this.contextMenuStrip1;
			this.dgv_Adres.Location = new System.Drawing.Point(58, 211);
			this.dgv_Adres.Name = "dgv_Adres";
			this.dgv_Adres.Size = new System.Drawing.Size(589, 96);
			this.dgv_Adres.TabIndex = 1;
			// 
			// dgv_Tel
			// 
			this.dgv_Tel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Tel.ContextMenuStrip = this.contextMenuStrip1;
			this.dgv_Tel.Location = new System.Drawing.Point(58, 332);
			this.dgv_Tel.Name = "dgv_Tel";
			this.dgv_Tel.Size = new System.Drawing.Size(589, 96);
			this.dgv_Tel.TabIndex = 3;
			// 
			// dgv_Email
			// 
			this.dgv_Email.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Email.ContextMenuStrip = this.contextMenuStrip1;
			this.dgv_Email.Location = new System.Drawing.Point(58, 447);
			this.dgv_Email.Name = "dgv_Email";
			this.dgv_Email.Size = new System.Drawing.Size(589, 92);
			this.dgv_Email.TabIndex = 2;
			this.dgv_Email.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Email_CellContentClick);
			// 
			// lbl_Id
			// 
			this.lbl_Id.AutoSize = true;
			this.lbl_Id.Location = new System.Drawing.Point(87, 45);
			this.lbl_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_Id.Name = "lbl_Id";
			this.lbl_Id.Size = new System.Drawing.Size(35, 13);
			this.lbl_Id.TabIndex = 4;
			this.lbl_Id.Text = "label1";
			// 
			// lbl_JobTitle
			// 
			this.lbl_JobTitle.AutoSize = true;
			this.lbl_JobTitle.Location = new System.Drawing.Point(180, 45);
			this.lbl_JobTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_JobTitle.Name = "lbl_JobTitle";
			this.lbl_JobTitle.Size = new System.Drawing.Size(35, 13);
			this.lbl_JobTitle.TabIndex = 5;
			this.lbl_JobTitle.Text = "label2";
			// 
			// lbl_HireDate
			// 
			this.lbl_HireDate.AutoSize = true;
			this.lbl_HireDate.Location = new System.Drawing.Point(276, 45);
			this.lbl_HireDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_HireDate.Name = "lbl_HireDate";
			this.lbl_HireDate.Size = new System.Drawing.Size(35, 13);
			this.lbl_HireDate.TabIndex = 6;
			this.lbl_HireDate.Text = "label3";
			// 
			// lbl_Name
			// 
			this.lbl_Name.AutoSize = true;
			this.lbl_Name.Location = new System.Drawing.Point(362, 45);
			this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_Name.Name = "lbl_Name";
			this.lbl_Name.Size = new System.Drawing.Size(35, 13);
			this.lbl_Name.TabIndex = 7;
			this.lbl_Name.Text = "label4";
			// 
			// lbl_Surname
			// 
			this.lbl_Surname.AutoSize = true;
			this.lbl_Surname.Location = new System.Drawing.Point(452, 45);
			this.lbl_Surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_Surname.Name = "lbl_Surname";
			this.lbl_Surname.Size = new System.Drawing.Size(35, 13);
			this.lbl_Surname.TabIndex = 8;
			this.lbl_Surname.Text = "label5";
			// 
			// dgv_PersonelBilgileri
			// 
			this.dgv_PersonelBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_PersonelBilgileri.ContextMenuStrip = this.contextMenuStrip1;
			this.dgv_PersonelBilgileri.Location = new System.Drawing.Point(58, 91);
			this.dgv_PersonelBilgileri.Name = "dgv_PersonelBilgileri";
			this.dgv_PersonelBilgileri.Size = new System.Drawing.Size(589, 96);
			this.dgv_PersonelBilgileri.TabIndex = 10;
			// 
			// lbl_BirthDate
			// 
			this.lbl_BirthDate.AutoSize = true;
			this.lbl_BirthDate.Location = new System.Drawing.Point(561, 45);
			this.lbl_BirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_BirthDate.Name = "lbl_BirthDate";
			this.lbl_BirthDate.Size = new System.Drawing.Size(35, 13);
			this.lbl_BirthDate.TabIndex = 9;
			this.lbl_BirthDate.Text = "label6";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// silToolStripMenuItem
			// 
			this.silToolStripMenuItem.Name = "silToolStripMenuItem";
			this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.silToolStripMenuItem.Text = "Sil";
			this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
			// 
			// güncelleToolStripMenuItem
			// 
			this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
			this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.güncelleToolStripMenuItem.Text = "Güncelle";
			// 
			// dlg_PersonelDetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 568);
			this.Controls.Add(this.dgv_PersonelBilgileri);
			this.Controls.Add(this.lbl_BirthDate);
			this.Controls.Add(this.lbl_Surname);
			this.Controls.Add(this.lbl_Name);
			this.Controls.Add(this.lbl_HireDate);
			this.Controls.Add(this.lbl_JobTitle);
			this.Controls.Add(this.lbl_Id);
			this.Controls.Add(this.dgv_Tel);
			this.Controls.Add(this.dgv_Email);
			this.Controls.Add(this.dgv_Adres);
			this.Name = "dlg_PersonelDetay";
			this.Text = "Detaylar";
			this.Load += new System.EventHandler(this.dlg_PersonelDetay_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Adres)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Tel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Email)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelBilgileri)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Adres;
        private System.Windows.Forms.DataGridView dgv_Tel;
        private System.Windows.Forms.DataGridView dgv_Email;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_JobTitle;
        private System.Windows.Forms.Label lbl_HireDate;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.DataGridView dgv_PersonelBilgileri;
		private System.Windows.Forms.Label lbl_BirthDate;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
	}
}