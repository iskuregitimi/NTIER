namespace NTIER.UI
{
    partial class dlg_PersonDetails
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
            this.dgv_Person = new System.Windows.Forms.DataGridView();
            this.dgv_Phone = new System.Windows.Forms.DataGridView();
            this.dgv_Email = new System.Windows.Forms.DataGridView();
            this.dgv_Address = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Address)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Person
            // 
            this.dgv_Person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Person.Location = new System.Drawing.Point(0, 0);
            this.dgv_Person.Name = "dgv_Person";
            this.dgv_Person.Size = new System.Drawing.Size(800, 53);
            this.dgv_Person.TabIndex = 0;
            this.dgv_Person.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgv_Phone
            // 
            this.dgv_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Phone.Location = new System.Drawing.Point(0, 199);
            this.dgv_Phone.Name = "dgv_Phone";
            this.dgv_Phone.Size = new System.Drawing.Size(800, 53);
            this.dgv_Phone.TabIndex = 1;
            // 
            // dgv_Email
            // 
            this.dgv_Email.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Email.Location = new System.Drawing.Point(0, 296);
            this.dgv_Email.Name = "dgv_Email";
            this.dgv_Email.Size = new System.Drawing.Size(800, 53);
            this.dgv_Email.TabIndex = 2;
            // 
            // dgv_Address
            // 
            this.dgv_Address.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Address.Location = new System.Drawing.Point(0, 87);
            this.dgv_Address.Name = "dgv_Address";
            this.dgv_Address.Size = new System.Drawing.Size(800, 53);
            this.dgv_Address.TabIndex = 3;
            // 
            // dlg_PersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Address);
            this.Controls.Add(this.dgv_Email);
            this.Controls.Add(this.dgv_Phone);
            this.Controls.Add(this.dgv_Person);
            this.Name = "dlg_PersonDetails";
            this.Text = "dlg_PersonDetails";
            this.Load += new System.EventHandler(this.dlg_PersonDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Person)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Address)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Person;
        private System.Windows.Forms.DataGridView dgv_Phone;
        private System.Windows.Forms.DataGridView dgv_Email;
        private System.Windows.Forms.DataGridView dgv_Address;
    }
}