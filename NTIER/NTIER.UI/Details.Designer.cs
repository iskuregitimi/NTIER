namespace NTIER.UI
{
    partial class Details
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
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.dgv_Phone = new System.Windows.Forms.DataGridView();
            this.dgv_Emil = new System.Windows.Forms.DataGridView();
            this.dgv_Address = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Address)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.AllowUserToAddRows = false;
            this.dgv_Employee.AllowUserToDeleteRows = false;
            this.dgv_Employee.AllowUserToResizeColumns = false;
            this.dgv_Employee.AllowUserToResizeRows = false;
            this.dgv_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee.Location = new System.Drawing.Point(12, 12);
            this.dgv_Employee.MultiSelect = false;
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Employee.Size = new System.Drawing.Size(776, 84);
            this.dgv_Employee.TabIndex = 0;
            // 
            // dgv_Phone
            // 
            this.dgv_Phone.AllowUserToAddRows = false;
            this.dgv_Phone.AllowUserToDeleteRows = false;
            this.dgv_Phone.AllowUserToResizeColumns = false;
            this.dgv_Phone.AllowUserToResizeRows = false;
            this.dgv_Phone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Phone.Location = new System.Drawing.Point(12, 199);
            this.dgv_Phone.Name = "dgv_Phone";
            this.dgv_Phone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Phone.Size = new System.Drawing.Size(375, 88);
            this.dgv_Phone.TabIndex = 1;
            // 
            // dgv_Emil
            // 
            this.dgv_Emil.AllowUserToAddRows = false;
            this.dgv_Emil.AllowUserToDeleteRows = false;
            this.dgv_Emil.AllowUserToResizeColumns = false;
            this.dgv_Emil.AllowUserToResizeRows = false;
            this.dgv_Emil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Emil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Emil.Location = new System.Drawing.Point(393, 199);
            this.dgv_Emil.Name = "dgv_Emil";
            this.dgv_Emil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Emil.Size = new System.Drawing.Size(395, 88);
            this.dgv_Emil.TabIndex = 2;
            // 
            // dgv_Address
            // 
            this.dgv_Address.AllowUserToAddRows = false;
            this.dgv_Address.AllowUserToDeleteRows = false;
            this.dgv_Address.AllowUserToResizeColumns = false;
            this.dgv_Address.AllowUserToResizeRows = false;
            this.dgv_Address.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Address.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Address.Location = new System.Drawing.Point(12, 102);
            this.dgv_Address.Name = "dgv_Address";
            this.dgv_Address.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Address.Size = new System.Drawing.Size(776, 91);
            this.dgv_Address.TabIndex = 3;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 302);
            this.Controls.Add(this.dgv_Address);
            this.Controls.Add(this.dgv_Emil);
            this.Controls.Add(this.dgv_Phone);
            this.Controls.Add(this.dgv_Employee);
            this.Name = "Details";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Address)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Employee;
        private System.Windows.Forms.DataGridView dgv_Phone;
        private System.Windows.Forms.DataGridView dgv_Emil;
        private System.Windows.Forms.DataGridView dgv_Address;
    }
}