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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_Tel = new System.Windows.Forms.DataGridView();
            this.dgv_Email = new System.Windows.Forms.DataGridView();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_HireDate = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_BirthDate = new System.Windows.Forms.Label();
            this.txt_JobTitle = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adres)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Email)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Adres
            // 
            this.dgv_Adres.AllowUserToAddRows = false;
            this.dgv_Adres.AllowUserToDeleteRows = false;
            this.dgv_Adres.AllowUserToOrderColumns = true;
            this.dgv_Adres.AllowUserToResizeRows = false;
            this.dgv_Adres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Adres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Adres.Location = new System.Drawing.Point(77, 260);
            this.dgv_Adres.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Adres.Name = "dgv_Adres";
            this.dgv_Adres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Adres.Size = new System.Drawing.Size(785, 118);
            this.dgv_Adres.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            // 
            // dgv_Tel
            // 
            this.dgv_Tel.AllowUserToAddRows = false;
            this.dgv_Tel.AllowUserToDeleteRows = false;
            this.dgv_Tel.AllowUserToOrderColumns = true;
            this.dgv_Tel.AllowUserToResizeRows = false;
            this.dgv_Tel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Tel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tel.Location = new System.Drawing.Point(77, 409);
            this.dgv_Tel.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Tel.Name = "dgv_Tel";
            this.dgv_Tel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Tel.Size = new System.Drawing.Size(785, 118);
            this.dgv_Tel.TabIndex = 3;
            // 
            // dgv_Email
            // 
            this.dgv_Email.AllowUserToAddRows = false;
            this.dgv_Email.AllowUserToDeleteRows = false;
            this.dgv_Email.AllowUserToOrderColumns = true;
            this.dgv_Email.AllowUserToResizeRows = false;
            this.dgv_Email.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Email.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Email.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Email.Location = new System.Drawing.Point(77, 550);
            this.dgv_Email.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Email.Name = "dgv_Email";
            this.dgv_Email.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Email.Size = new System.Drawing.Size(785, 113);
            this.dgv_Email.TabIndex = 2;

            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(77, 55);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(41, 17);
            this.lbl_Id.TabIndex = 4;
            this.lbl_Id.Text = "lbl_Id";
            // 
            // lbl_HireDate
            // 
            this.lbl_HireDate.AutoSize = true;
            this.lbl_HireDate.Location = new System.Drawing.Point(77, 139);
            this.lbl_HireDate.Name = "lbl_HireDate";
            this.lbl_HireDate.Size = new System.Drawing.Size(46, 17);
            this.lbl_HireDate.TabIndex = 6;
            this.lbl_HireDate.Text = "label3";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(77, 83);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(46, 17);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "label4";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(77, 111);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(46, 17);
            this.lbl_Surname.TabIndex = 8;
            this.lbl_Surname.Text = "label5";
            // 
            // lbl_BirthDate
            // 
            this.lbl_BirthDate.AutoSize = true;
            this.lbl_BirthDate.Location = new System.Drawing.Point(77, 167);
            this.lbl_BirthDate.Name = "lbl_BirthDate";
            this.lbl_BirthDate.Size = new System.Drawing.Size(46, 17);
            this.lbl_BirthDate.TabIndex = 9;
            this.lbl_BirthDate.Text = "label6";
            // 
            // txt_JobTitle
            // 
            this.txt_JobTitle.Location = new System.Drawing.Point(77, 195);
            this.txt_JobTitle.Name = "txt_JobTitle";
            this.txt_JobTitle.Size = new System.Drawing.Size(337, 22);
            this.txt_JobTitle.TabIndex = 11;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(325, 230);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(89, 23);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Kaydet";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dlg_PersonelDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 699);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_JobTitle);
            this.Controls.Add(this.lbl_BirthDate);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_HireDate);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.dgv_Tel);
            this.Controls.Add(this.dgv_Email);
            this.Controls.Add(this.dgv_Adres);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dlg_PersonelDetay";
            this.Text = "Detaylar";
            this.Load += new System.EventHandler(this.dlg_PersonelDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adres)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Email)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Adres;
        private System.Windows.Forms.DataGridView dgv_Tel;
        private System.Windows.Forms.DataGridView dgv_Email;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_HireDate;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Surname;
		private System.Windows.Forms.Label lbl_BirthDate;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_JobTitle;
        private System.Windows.Forms.Button btn_Update;
    }
}