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
    public partial class dlg_EmailEkle : Form
    {

        public int BusinessEntityId = 0;

        public dlg_EmailEkle()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {

            try
            {
                EmployeeBLL.InsertEmployeeEmailBLL(BusinessEntityId, txt_Email.Text);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata " + ex.ToString());

            }
        }
    }
}
