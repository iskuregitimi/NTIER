using NTIER.BLL;
using NTIER.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTIER.UI
{
    public partial class dlg_adresekle : Form
    {
        public dlg_adresekle()
        {
            InitializeComponent();
        }

        private void btn_adresekle_Click(object sender, EventArgs e)
        {
            try
            {
                AdresEntity adress = new AdresEntity
                {

                    AddressID = int.Parse(txt_adres.Text)

                };




                //EmployeeBLL.InsertADRES(adresEnti);
                    

                MessageBox.Show("Kayıt eklendi");

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Hata alındı:" + ex.Message);
                MessageBox.Show("Kayıt ekelemede hata" + ex.Message);
            }


            this.Close();
        }
    }
  }

