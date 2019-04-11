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
            this.dgv_Adres = new System.Windows.Forms.DataGridView();
            this.dgv_Tel = new System.Windows.Forms.DataGridView();
            this.dgv_Email = new System.Windows.Forms.DataGridView();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_JobTitle = new System.Windows.Forms.Label();
            this.lbl_HireDate = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_BirthDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Email)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Adres
            // 
            this.dgv_Adres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Adres.Location = new System.Drawing.Point(82, 103);
            this.dgv_Adres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Adres.Name = "dgv_Adres";
            this.dgv_Adres.Size = new System.Drawing.Size(785, 118);
            this.dgv_Adres.TabIndex = 1;
            // 
            // dgv_Tel
            // 
            this.dgv_Tel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tel.Location = new System.Drawing.Point(82, 252);
            this.dgv_Tel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Tel.Name = "dgv_Tel";
            this.dgv_Tel.Size = new System.Drawing.Size(785, 118);
            this.dgv_Tel.TabIndex = 3;
            // 
            // dgv_Email
            // 
            this.dgv_Email.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Email.Location = new System.Drawing.Point(82, 393);
            this.dgv_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Email.Name = "dgv_Email";
            this.dgv_Email.Size = new System.Drawing.Size(785, 113);
            this.dgv_Email.TabIndex = 2;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(116, 55);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(46, 17);
            this.lbl_Id.TabIndex = 4;
            this.lbl_Id.Text = "label1";
            // 
            // lbl_JobTitle
            // 
            this.lbl_JobTitle.AutoSize = true;
            this.lbl_JobTitle.Location = new System.Drawing.Point(240, 55);
            this.lbl_JobTitle.Name = "lbl_JobTitle";
            this.lbl_JobTitle.Size = new System.Drawing.Size(46, 17);
            this.lbl_JobTitle.TabIndex = 5;
            this.lbl_JobTitle.Text = "label2";
            // 
            // lbl_HireDate
            // 
            this.lbl_HireDate.AutoSize = true;
            this.lbl_HireDate.Location = new System.Drawing.Point(368, 55);
            this.lbl_HireDate.Name = "lbl_HireDate";
            this.lbl_HireDate.Size = new System.Drawing.Size(46, 17);
            this.lbl_HireDate.TabIndex = 6;
            this.lbl_HireDate.Text = "label3";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(482, 55);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(46, 17);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "label4";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(602, 55);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(46, 17);
            this.lbl_Surname.TabIndex = 8;
            this.lbl_Surname.Text = "label5";
            // 
            // lbl_BirthDate
            // 
            this.lbl_BirthDate.AutoSize = true;
            this.lbl_BirthDate.Location = new System.Drawing.Point(748, 55);
            this.lbl_BirthDate.Name = "lbl_BirthDate";
            this.lbl_BirthDate.Size = new System.Drawing.Size(46, 17);
            this.lbl_BirthDate.TabIndex = 9;
            this.lbl_BirthDate.Text = "label6";
            // 
            // dlg_PersonelDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 558);
            this.Controls.Add(this.lbl_BirthDate);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_HireDate);
            this.Controls.Add(this.lbl_JobTitle);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.dgv_Tel);
            this.Controls.Add(this.dgv_Email);
            this.Controls.Add(this.dgv_Adres);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "dlg_PersonelDetay";
            this.Text = "Detaylar";
            this.Load += new System.EventHandler(this.dlg_PersonelDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adres)).EndInit();
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
        private System.Windows.Forms.Label lbl_JobTitle;
        private System.Windows.Forms.Label lbl_HireDate;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_BirthDate;
    }
}