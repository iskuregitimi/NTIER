using NTIER.BLL;
using NTIER.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTIER.UI
{
    public partial class dlg_PersonelDetay : Form
    {
        public dlg_PersonelDetay()
        {
            InitializeComponent();
        }

        public int BusinessEntityID=0;
		public int EmailAdressId = 0;

        private void dlg_PersonelDetay_Load(object sender, EventArgs e)
        {
            DataSet ds = EmployeeBLL.SelectEmployeeDetails(BusinessEntityID);

            lbl_Id.Text = BusinessEntityID.ToString();

			//lbl_JobTitle.Text = ds.Tables[0].Rows[0][1].ToString();
			//lbl_HireDate.Text = ds.Tables[0].Rows[0][2].ToString();
			//lbl_Name.Text = ds.Tables[0].Rows[0][3].ToString();
			//lbl_Surname.Text = ds.Tables[0].Rows[0][4].ToString();
			

			dgv_PersonelBilgileri.DataSource = null;
            dgv_PersonelBilgileri.DataSource = ds.Tables[0];

            dgv_Adres.DataSource = null;
            dgv_Adres.DataSource = ds.Tables[1];

            dgv_Tel.DataSource = null;
            dgv_Tel.DataSource = ds.Tables[2];

            dgv_Email.DataSource = null;
            dgv_Email.DataSource = ds.Tables[3];




        }

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

		}

		private void dgv_Email_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void silToolStripMenuItem_Click(object sender, EventArgs e)
		{
	
			EmailAdressId = int.Parse(dgv_Email.SelectedRows[0].Cells[1].Value.ToString());
			EmployeeBLL.EmailSil_BLL(EmailAdressId);
			MessageBox.Show("Email adresi Silindi");

			//dlg_PersonelDetay_Load(null,null);

			dgv_Email.Rows.Remove(dgv_Email.SelectedRows[0]);
			dgv_Email.Refresh();
		}
	}
}
