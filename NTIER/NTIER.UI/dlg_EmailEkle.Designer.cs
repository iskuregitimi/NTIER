﻿namespace NTIER.UI
{
    partial class dlg_EmailEkle
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(9, 10);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(354, 20);
            this.txt_Email.TabIndex = 0;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(252, 45);
            this.btn_Kaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(106, 29);
            this.btn_Kaydet.TabIndex = 1;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // dlg_EmailEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 84);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_Email);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "dlg_EmailEkle";
            this.Text = "dlg_EmailEkle";
            this.Load += new System.EventHandler(this.dlg_EmailEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_Kaydet;
    }
}