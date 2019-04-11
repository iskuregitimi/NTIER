namespace NTIER.UI
{
    partial class PersonDetails_form
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
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_JobTitle = new System.Windows.Forms.Label();
            this.lbl_HireDate = new System.Windows.Forms.Label();
            this.lbl_BirthDate = new System.Windows.Forms.Label();
            this.dgv_PersonDetails = new System.Windows.Forms.DataGridView();
            this.dgv_Adress = new System.Windows.Forms.DataGridView();
            this.dgv_PhoneNumbers = new System.Windows.Forms.DataGridView();
            this.dgv_emails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhoneNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Id.Location = new System.Drawing.Point(18, 9);
            this.lbl_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(31, 25);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Name.Location = new System.Drawing.Point(18, 67);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(64, 25);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Surname.Location = new System.Drawing.Point(18, 118);
            this.lbl_Surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(92, 25);
            this.lbl_Surname.TabIndex = 1;
            this.lbl_Surname.Text = "Surname";
            // 
            // lbl_JobTitle
            // 
            this.lbl_JobTitle.AutoSize = true;
            this.lbl_JobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_JobTitle.Location = new System.Drawing.Point(501, 9);
            this.lbl_JobTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_JobTitle.Name = "lbl_JobTitle";
            this.lbl_JobTitle.Size = new System.Drawing.Size(82, 25);
            this.lbl_JobTitle.TabIndex = 0;
            this.lbl_JobTitle.Text = "JobTitle";
            // 
            // lbl_HireDate
            // 
            this.lbl_HireDate.AutoSize = true;
            this.lbl_HireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_HireDate.Location = new System.Drawing.Point(501, 118);
            this.lbl_HireDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HireDate.Name = "lbl_HireDate";
            this.lbl_HireDate.Size = new System.Drawing.Size(88, 25);
            this.lbl_HireDate.TabIndex = 1;
            this.lbl_HireDate.Text = "HireDate";
            // 
            // lbl_BirthDate
            // 
            this.lbl_BirthDate.AutoSize = true;
            this.lbl_BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BirthDate.Location = new System.Drawing.Point(501, 67);
            this.lbl_BirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BirthDate.Name = "lbl_BirthDate";
            this.lbl_BirthDate.Size = new System.Drawing.Size(89, 25);
            this.lbl_BirthDate.TabIndex = 1;
            this.lbl_BirthDate.Text = "Birthdate";
            // 
            // dgv_PersonDetails
            // 
            this.dgv_PersonDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PersonDetails.Location = new System.Drawing.Point(22, 158);
            this.dgv_PersonDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_PersonDetails.Name = "dgv_PersonDetails";
            this.dgv_PersonDetails.RowTemplate.Height = 24;
            this.dgv_PersonDetails.Size = new System.Drawing.Size(1164, 143);
            this.dgv_PersonDetails.TabIndex = 2;
            // 
            // dgv_Adress
            // 
            this.dgv_Adress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Adress.Location = new System.Drawing.Point(25, 311);
            this.dgv_Adress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Adress.Name = "dgv_Adress";
            this.dgv_Adress.RowTemplate.Height = 24;
            this.dgv_Adress.Size = new System.Drawing.Size(1164, 143);
            this.dgv_Adress.TabIndex = 2;
            // 
            // dgv_PhoneNumbers
            // 
            this.dgv_PhoneNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhoneNumbers.Location = new System.Drawing.Point(25, 464);
            this.dgv_PhoneNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_PhoneNumbers.Name = "dgv_PhoneNumbers";
            this.dgv_PhoneNumbers.RowTemplate.Height = 24;
            this.dgv_PhoneNumbers.Size = new System.Drawing.Size(1164, 143);
            this.dgv_PhoneNumbers.TabIndex = 2;
            // 
            // dgv_emails
            // 
            this.dgv_emails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emails.Location = new System.Drawing.Point(25, 617);
            this.dgv_emails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_emails.Name = "dgv_emails";
            this.dgv_emails.RowTemplate.Height = 24;
            this.dgv_emails.Size = new System.Drawing.Size(1164, 143);
            this.dgv_emails.TabIndex = 2;
            // 
            // PersonDetails_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 1055);
            this.Controls.Add(this.dgv_emails);
            this.Controls.Add(this.dgv_PhoneNumbers);
            this.Controls.Add(this.dgv_Adress);
            this.Controls.Add(this.dgv_PersonDetails);
            this.Controls.Add(this.lbl_BirthDate);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_HireDate);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_JobTitle);
            this.Controls.Add(this.lbl_Id);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersonDetails_form";
            this.Text = "PersonDetails_form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhoneNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_JobTitle;
        private System.Windows.Forms.Label lbl_HireDate;
        private System.Windows.Forms.Label lbl_BirthDate;
        private System.Windows.Forms.DataGridView dgv_PersonDetails;
        private System.Windows.Forms.DataGridView dgv_Adress;
        private System.Windows.Forms.DataGridView dgv_PhoneNumbers;
        private System.Windows.Forms.DataGridView dgv_emails;
    }
}