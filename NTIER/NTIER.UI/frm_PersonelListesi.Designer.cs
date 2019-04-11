namespace NTIER.UI
{
    partial class frm_PersonelListesi
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
            this.components = new System.ComponentModel.Container();
            this.dgv_PersonelListesi = new System.Windows.Forms.DataGridView();
            this.cms_Personel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.emailEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adresEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_SearchBox = new System.Windows.Forms.TextBox();
            this.detayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelListesi)).BeginInit();
            this.cms_Personel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_PersonelListesi
            // 
            this.dgv_PersonelListesi.AllowUserToAddRows = false;
            this.dgv_PersonelListesi.AllowUserToDeleteRows = false;
            this.dgv_PersonelListesi.AllowUserToResizeRows = false;
            this.dgv_PersonelListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PersonelListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PersonelListesi.ContextMenuStrip = this.cms_Personel;
            this.dgv_PersonelListesi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_PersonelListesi.Location = new System.Drawing.Point(12, 40);
            this.dgv_PersonelListesi.MultiSelect = false;
            this.dgv_PersonelListesi.Name = "dgv_PersonelListesi";
            this.dgv_PersonelListesi.RowTemplate.Height = 24;
            this.dgv_PersonelListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PersonelListesi.Size = new System.Drawing.Size(776, 398);
            this.dgv_PersonelListesi.TabIndex = 0;
            // 
            // cms_Personel
            // 
            this.cms_Personel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_Personel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailEkleToolStripMenuItem,
            this.adresEkleToolStripMenuItem,
            this.detayToolStripMenuItem});
            this.cms_Personel.Name = "cms_Personel";
            this.cms_Personel.Size = new System.Drawing.Size(211, 104);
            // 
            // emailEkleToolStripMenuItem
            // 
            this.emailEkleToolStripMenuItem.Name = "emailEkleToolStripMenuItem";
            this.emailEkleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.emailEkleToolStripMenuItem.Text = "Email Ekle";
            this.emailEkleToolStripMenuItem.Click += new System.EventHandler(this.emailEkleToolStripMenuItem_Click);
            // 
            // adresEkleToolStripMenuItem
            // 
            this.adresEkleToolStripMenuItem.Name = "adresEkleToolStripMenuItem";
            this.adresEkleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.adresEkleToolStripMenuItem.Text = "Adres Ekle";
            this.adresEkleToolStripMenuItem.Click += new System.EventHandler(this.adresEkleToolStripMenuItem_Click);
            // 
            // txt_SearchBox
            // 
            this.txt_SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchBox.Location = new System.Drawing.Point(12, 12);
            this.txt_SearchBox.Name = "txt_SearchBox";
            this.txt_SearchBox.Size = new System.Drawing.Size(776, 22);
            this.txt_SearchBox.TabIndex = 1;
            this.txt_SearchBox.TextChanged += new System.EventHandler(this.txt_SearchBox_TextChanged);
            // 
            // detayToolStripMenuItem
            // 
            this.detayToolStripMenuItem.Name = "detayToolStripMenuItem";
            this.detayToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.detayToolStripMenuItem.Text = "Detay";
            this.detayToolStripMenuItem.Click += new System.EventHandler(this.detayToolStripMenuItem_Click);
            // 
            // frm_PersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_SearchBox);
            this.Controls.Add(this.dgv_PersonelListesi);
            this.Name = "frm_PersonelListesi";
            this.Text = "frm_PersonelListesi";
            this.Load += new System.EventHandler(this.frm_PersonelListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelListesi)).EndInit();
            this.cms_Personel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PersonelListesi;
        private System.Windows.Forms.TextBox txt_SearchBox;
        private System.Windows.Forms.ContextMenuStrip cms_Personel;
        private System.Windows.Forms.ToolStripMenuItem emailEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adresEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detayToolStripMenuItem;
    }
}