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
    public partial class dlg_telefon : Form
    {
        public object EmployeeBll { get; private set; }

        public dlg_telefon()
        {
            InitializeComponent();
        }

        private void dlg_telefon_Load(object sender, EventArgs e)
        {

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {

            try
            {
                EmployeeBll.INSERT_EMPLOYEE_PHONE_NUMBERS(BussinesEntityID, txt_Tel);
              

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata " + ex.ToString());

            }
        }
    }
}
