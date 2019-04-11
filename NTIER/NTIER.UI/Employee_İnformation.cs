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
    public partial class Employee_İnformation : Form
    {
        public Employee_İnformation()
        {
            InitializeComponent();
        }

        private void Employee_İnformation_Load(object sender, EventArgs e)
        {
            DataSet tb = DataContext.Employee_İnfromations(frm_PersonelListesi.BENİD);
            lblJopTitle.Text = tb.Tables[0].Rows[0].ToString();
            lblHiredDate.Text = tb.Tables[0].Rows[0].ToString();
            lblFirstName.Text = tb.Tables[0].Rows[0].ToString();
            lblLastName.Text = tb.Tables[0].Rows[0].ToString();
            lblBirthDate.Text = tb.Tables[0].Rows[0].ToString();

            dataGridView1.DataSource = tb.Tables[1];
            dataGridView2.DataSource = tb.Tables[2];
            dataGridView3.DataSource = tb.Tables[3];

        }
    }
}
