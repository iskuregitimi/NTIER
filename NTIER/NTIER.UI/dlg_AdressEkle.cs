using NTIER.BLL;
using NTIER.ENTITY;
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
    public partial class dlg_AdressEkle : Form
    {
        public dlg_AdressEkle()
        {
            InitializeComponent();
        }

        public int BusinessEntityId = 0;

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Address adres = new Address
                {
                    AddressLine1 = txt_AddressLine1.Text,
                    AddressLine2 = txt_AddressLine2.Text,
                    City = txt_City.Text,
                    PostalCode = int.Parse(txt_PostCode.Text),
                    StateProvinceID = (int)cmb_StateProvince.SelectedValue

                };
                EmployeeBLL.InsertEmployeeAdressBLL(BusinessEntityId,adres);
                MessageBox.Show("Adres eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.ToString());
            }
        }

        private void dlg_AdressEkle_Load(object sender, EventArgs e)
        {
            DataTable dt = EmployeeBLL.GetStateProvincesBLL(string.Empty);
            cmb_StateProvince.DataSource = dt;
            cmb_StateProvince.DisplayMember = "Name";
            cmb_StateProvince.ValueMember = "StateProvinceID";

        }
    }
}
