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
    public partial class dlg_PersonDetails : Form
    {
        public dlg_PersonDetails()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dlg_PersonDetails_Load(object sender, EventArgs e)
        {
            DataTable dt = EmployeeBLL.SearchEmployeeBLL(string.Empty);
            dgv_Person.DataSource = dt;
        }
    }
}
