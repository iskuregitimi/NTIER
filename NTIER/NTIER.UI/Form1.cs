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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniPersonelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_AddEmployee dialog = new dlg_AddEmployee();
            dialog.MdiParent = this;
            dialog.Show();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PersonelListesi form = new frm_PersonelListesi();
            form.MdiParent = this;            
            form.Show();
        }
    }
}
