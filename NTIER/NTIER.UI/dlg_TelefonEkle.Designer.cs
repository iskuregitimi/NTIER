namespace NTIER.UI
{
    partial class dlg_TelefonEkle
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
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(48, 81);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(116, 42);
            this.btn_Kaydet.TabIndex = 3;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(34, 28);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(150, 20);
            this.txt_Phone.TabIndex = 4;
            // 
            // dlg_TelefonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 156);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.btn_Kaydet);
            this.Name = "dlg_TelefonEkle";
            this.Text = "dlg_TelefonEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.TextBox txt_Phone;
    }
}