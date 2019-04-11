using NTIER.BLL;
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
    public partial class frm_PersonelListesi : Form
    {
        public frm_PersonelListesi()
        {
            InitializeComponent();
        }

        private void frm_PersonelListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = EmployeeBLL.SearchEmployeeBLL(string.Empty);
            dgv_PersonelListesi.DataSource = dt;
        }

        private void txt_SearchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = EmployeeBLL.SearchEmployeeBLL(txt_SearchBox.Text);
                dgv_PersonelListesi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu " + ex.Message);
            }
        }

        private void emailEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_EmailEkle form = new dlg_EmailEkle();
            form.BusinessEntityId = int.Parse(dgv_PersonelListesi.SelectedRows[0].Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void adresEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_AdressEkle form = new dlg_AdressEkle();
            form.BusinessEntityId = int.Parse(dgv_PersonelListesi.SelectedRows[0].Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void telefonEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_TelefonEkle form = new dlg_TelefonEkle();
            form.BusinessEntityId = int.Parse(dgv_PersonelListesi.SelectedRows[0].Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void personelDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Details form = new Details();
            form.BusinessEntityID = int.Parse(dgv_PersonelListesi.SelectedRows[0].Cells[0].Value.ToString());
            form.ShowDialog();
        }
    }
}
