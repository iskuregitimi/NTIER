namespace NTIER.UI
{
    partial class dlg_adresekle
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
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.btn_adresekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(183, 68);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(357, 20);
            this.txt_adres.TabIndex = 0;
            // 
            // btn_adresekle
            // 
            this.btn_adresekle.Location = new System.Drawing.Point(259, 132);
            this.btn_adresekle.Name = "btn_adresekle";
            this.btn_adresekle.Size = new System.Drawing.Size(189, 23);
            this.btn_adresekle.TabIndex = 1;
            this.btn_adresekle.Text = "adresekle";
            this.btn_adresekle.UseVisualStyleBackColor = true;
            this.btn_adresekle.Click += new System.EventHandler(this.btn_adresekle_Click);
            // 
            // dlg_adresekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_adresekle);
            this.Controls.Add(this.txt_adres);
            this.Name = "dlg_adresekle";
            this.Text = "dlg_adresekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Button btn_adresekle;
    }
}