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
    public partial class Detay : Form
    {
        internal int businessEntityId;

        public Detay()
        {
            InitializeComponent();
        }

        public int BusinessEntityID;

        private void Detay_Load(object sender, EventArgs e)
        {
            DataSet ds = EmployeeBLL.GetDetailsBLL(BusinessEntityID);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView2.DataSource = ds.Tables[1];
            dataGridView3.DataSource = ds.Tables[2];
            dataGridView4.DataSource = ds.Tables[3];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int addressID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            EmployeeBLL.DELETE_ADRESSBLL(addressID);
            MessageBox.Show("Test");

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
