using NTIER.BLL;
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
    public partial class dlg_PersonelDetay : Form
    {
     

        public dlg_PersonelDetay()
        {
            InitializeComponent();
        }


        private void dlg_PersonelDetay_Load(object sender, EventArgs e)
        {
           
            DataSet ds = EmployeeBLL.SelectEmployeeDetails(frm_PersonelListesi.BusinessEntityID);

            //lbl_Id.Text = BusinessEntityID.ToString();  
            //rowlarda 0. nın 1. si diyerek yada kolonun ismiyle çağırabiliriz!!!!!

            //lbl_JobTitle.Text = ds.Tables[0].Rows[0]["JobTitle"].ToString();
            //lbl_HireDate.Text = ds.Tables[0].Rows[0]["HireDate"].ToString();
            //lbl_Name.Text = ds.Tables[0].Rows[0]["FirstName"].ToString();
            //lbl_Surname.Text = ds.Tables[0].Rows[0]["LastName"].ToString();
            //lbl_BirthDate.Text = ds.Tables[0].Rows[0]["BirstDate"].ToString();

            dgv_PersonelBilgileri.DataSource = null;
            dgv_PersonelBilgileri.DataSource = ds.Tables[0];

            dgv_Adres.DataSource = null;
            dgv_Adres.DataSource = ds.Tables[1];

            dgv_Tel.DataSource = null;
            dgv_Tel.DataSource = ds.Tables[2];

            dgv_Email.DataSource = null;
            dgv_Email.DataSource = ds.Tables[3];




        }
    }
}
