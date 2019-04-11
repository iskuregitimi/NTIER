using NTIER.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTIER.UI
{
    public partial class dlg_TelefonEkle : Form
    {
        public int BusinessEntityId = 0;

        public dlg_TelefonEkle()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {

            string telefonDeseni = "^(05)[0-9][0-9][1-9]([0-9]){6}$";
            Regex regex = new Regex(telefonDeseni);

            if (regex.Match(txt_Phone.Text).Success)
            {
                MessageBox.Show("Telefon numarasi, desene uygundur");
            }

            try
            {
                EmployeeBLL.InsertEmployeePhoneBLL(BusinessEntityId, txt_Phone.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata " + ex.ToString());
            }
        }
    }
}
