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
    public partial class emailEkle : Form
    {
        public emailEkle()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            DataContext.InsertEmail(Emaillist.userID, txt_email);
            MessageBox.Show("Başarıyla eklendi");
            this.Close();


        }
    }
}
