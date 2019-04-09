namespace NTIER.UI
{
    partial class dlg_AddEmployee
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
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_JobTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_LoginId = new System.Windows.Forms.TextBox();
            this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.txt_nationalID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(127, 19);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(325, 22);
            this.txt_firstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "İkinci Adı";
            // 
            // txt_MiddleName
            // 
            this.txt_MiddleName.Location = new System.Drawing.Point(127, 47);
            this.txt_MiddleName.Name = "txt_MiddleName";
            this.txt_MiddleName.Size = new System.Drawing.Size(325, 22);
            this.txt_MiddleName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyadı";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(127, 75);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(325, 22);
            this.txt_LastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Görevi";
            // 
            // txt_JobTitle
            // 
            this.txt_JobTitle.Location = new System.Drawing.Point(127, 103);
            this.txt_JobTitle.Name = "txt_JobTitle";
            this.txt_JobTitle.Size = new System.Drawing.Size(325, 22);
            this.txt_JobTitle.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "LoginID";
            // 
            // txt_LoginId
            // 
            this.txt_LoginId.Location = new System.Drawing.Point(127, 131);
            this.txt_LoginId.Name = "txt_LoginId";
            this.txt_LoginId.Size = new System.Drawing.Size(325, 22);
            this.txt_LoginId.TabIndex = 8;
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.Location = new System.Drawing.Point(127, 186);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.Size = new System.Drawing.Size(200, 22);
            this.dtp_BirthDate.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dogum Tarihi";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(288, 235);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(164, 27);
            this.btn_Kaydet.TabIndex = 11;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // txt_nationalID
            // 
            this.txt_nationalID.Location = new System.Drawing.Point(127, 158);
            this.txt_nationalID.MaxLength = 6;
            this.txt_nationalID.Name = "txt_nationalID";
            this.txt_nationalID.Size = new System.Drawing.Size(325, 22);
            this.txt_nationalID.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "National ID";
            // 
            // dlg_AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 309);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.dtp_BirthDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nationalID);
            this.Controls.Add(this.txt_LoginId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_JobTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MiddleName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_firstName);
            this.Name = "dlg_AddEmployee";
            this.Text = "dlg_AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_JobTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_LoginId;
        private System.Windows.Forms.DateTimePicker dtp_BirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.TextBox txt_nationalID;
        private System.Windows.Forms.Label label7;
    }
}