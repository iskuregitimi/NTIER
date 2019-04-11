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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        public int BusinessEntityID = 0;

        private void Details_Load(object sender, EventArgs e)
        {
            DataSet ds= EmployeeBLL.GetDetailsBLL(BusinessEntityID);
            dgv_Employee.DataSource = ds.Tables[0];
            dgv_Address.DataSource = ds.Tables[1];
            dgv_Phone.DataSource = ds.Tables[2];
            dgv_Emil.DataSource = ds.Tables[3];

        }
    }
}
