﻿namespace NTIER.UI
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
            this.dgv_PersonelBilgileri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Adres
            // 
            this.dgv_Adres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Adres.Location = new System.Drawing.Point(78, 260);
            this.dgv_Adres.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Adres.Name = "dgv_Adres";
            this.dgv_Adres.Size = new System.Drawing.Size(785, 118);
            this.dgv_Adres.TabIndex = 1;
            // 
            // dgv_Tel
            // 
            this.dgv_Tel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tel.Location = new System.Drawing.Point(78, 409);
            this.dgv_Tel.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Tel.Name = "dgv_Tel";
            this.dgv_Tel.Size = new System.Drawing.Size(785, 118);
            this.dgv_Tel.TabIndex = 3;
            // 
            // dgv_Email
            // 
            this.dgv_Email.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Email.Location = new System.Drawing.Point(78, 550);
            this.dgv_Email.Margin = new System.Windows.Forms.Padding(4);
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
            // dgv_PersonelBilgileri
            // 
            this.dgv_PersonelBilgileri.AllowUserToAddRows = false;
            this.dgv_PersonelBilgileri.AllowUserToDeleteRows = false;
            this.dgv_PersonelBilgileri.AllowUserToOrderColumns = true;
            this.dgv_PersonelBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PersonelBilgileri.Location = new System.Drawing.Point(78, 112);
            this.dgv_PersonelBilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_PersonelBilgileri.Name = "dgv_PersonelBilgileri";
            this.dgv_PersonelBilgileri.Size = new System.Drawing.Size(785, 118);
            this.dgv_PersonelBilgileri.TabIndex = 10;
            // 
            // dlg_PersonelDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 699);
            this.Controls.Add(this.dgv_PersonelBilgileri);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.dgv_Tel);
            this.Controls.Add(this.dgv_Email);
            this.Controls.Add(this.dgv_Adres);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dlg_PersonelDetay";
            this.Text = "Detaylar";
            this.Load += new System.EventHandler(this.dlg_PersonelDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Adres;
        private System.Windows.Forms.DataGridView dgv_Tel;
        private System.Windows.Forms.DataGridView dgv_Email;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.DataGridView dgv_PersonelBilgileri;
    }
}