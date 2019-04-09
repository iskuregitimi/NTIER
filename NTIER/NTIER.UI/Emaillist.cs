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
    public partial class Emaillist : Form
    {
        public Emaillist()
        {
            InitializeComponent();
            DataContext.GetPerson(listBox1);
        }
        public static int userID;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            userID = Convert.ToInt32
             ( listBox1.SelectedItem);
            emailEkle ekle = new emailEkle();

            ekle.Show();

            //dt = DataContex.Get_person_Detay(userID);

            //Form2 frm = new Form2(dt);
            //frm.ShowDialog();
        }

        private void Email_Load(object sender, EventArgs e)
        {

        }
    }
}
