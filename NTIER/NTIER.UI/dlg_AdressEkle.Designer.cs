namespace NTIER.UI
{
    partial class dlg_AdressEkle
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
            this.txt_AddressLine1 = new System.Windows.Forms.TextBox();
            this.txt_AddressLine2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_StateProvince = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_PostCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_AddressLine1
            // 
            this.txt_AddressLine1.Location = new System.Drawing.Point(130, 28);
            this.txt_AddressLine1.MaxLength = 60;
            this.txt_AddressLine1.Multiline = true;
            this.txt_AddressLine1.Name = "txt_AddressLine1";
            this.txt_AddressLine1.Size = new System.Drawing.Size(350, 58);
            this.txt_AddressLine1.TabIndex = 0;
            // 
            // txt_AddressLine2
            // 
            this.txt_AddressLine2.Location = new System.Drawing.Point(130, 92);
            this.txt_AddressLine2.MaxLength = 60;
            this.txt_AddressLine2.Multiline = true;
            this.txt_AddressLine2.Name = "txt_AddressLine2";
            this.txt_AddressLine2.Size = new System.Drawing.Size(350, 58);
            this.txt_AddressLine2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address Line 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address Line 2";
            // 
            // cmb_StateProvince
            // 
            this.cmb_StateProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_StateProvince.FormattingEnabled = true;
            this.cmb_StateProvince.Location = new System.Drawing.Point(130, 156);
            this.cmb_StateProvince.Name = "cmb_StateProvince";
            this.cmb_StateProvince.Size = new System.Drawing.Size(250, 24);
            this.cmb_StateProvince.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "State Province";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(130, 186);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(250, 22);
            this.txt_City.TabIndex = 3;
            // 
            // txt_PostCode
            // 
            this.txt_PostCode.Location = new System.Drawing.Point(130, 214);
            this.txt_PostCode.Name = "txt_PostCode";
            this.txt_PostCode.Size = new System.Drawing.Size(250, 22);
            this.txt_PostCode.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Post Code";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(303, 256);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(177, 36);
            this.btn_Kaydet.TabIndex = 4;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // dlg_AdressEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 304);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_PostCode);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.cmb_StateProvince);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_AddressLine2);
            this.Controls.Add(this.txt_AddressLine1);
            this.Name = "dlg_AdressEkle";
            this.Text = "dlg_AdressEkle";
            this.Load += new System.EventHandler(this.dlg_AdressEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AddressLine1;
        private System.Windows.Forms.TextBox txt_AddressLine2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_StateProvince;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_PostCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Kaydet;
    }
}