using NTIER.BLL;
using NTIER.DAL;
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
    public partial class dlg_PersonelDetay : Form
    {
        Employee selectedEmployee = new Employee();

        public dlg_PersonelDetay()
        {
            InitializeComponent();
        }

        public int BusinessEntityID;

        public int EmailAdressId;

        private void dlg_PersonelDetay_Load(object sender, EventArgs e)
        {
            dgv_Email.ClearSelection();
            //DataSet ds = EmployeeBLL.SelectEmployeeDetails(BusinessEntityID);

            EFW.Employee employee = EmployeeBLL.GetEmployee(BusinessEntityID);

            lbl_Id.Text = BusinessEntityID.ToString();


            lbl_HireDate.Text = employee.HireDate.ToString(); ;
            lbl_Name.Text =employee.Person.FirstName;
            lbl_Surname.Text =employee.Person.LastName;
            txt_JobTitle.Text =employee.JobTitle;

            selectedEmployee.BusinessEntityID = BusinessEntityID;
            //selectedEmployee.HireDate = DateTime.Parse(ds.Tables[0].Rows[0]["HireDate"].ToString());
            //selectedEmployee.JobTitle = ds.Tables[0].Rows[0]["JobTitle"].ToString();


            //dgv_Adres.DataSource = null;
            //dgv_Adres.DataSource = ds.Tables[1];
            //dgv_Adres.ClearSelection();

            dgv_Tel.DataSource = null;
            dgv_Tel.DataSource = employee.Person.PersonPhones.ToList(); ;
          

            dgv_Email.DataSource = null;
            dgv_Email.DataSource = employee.Person.EmailAddresses.ToList();
           


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

     

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (dgv_Email.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen email seçiniz.");
                return;
            }

            EmailAdressId = int.Parse(dgv_Email.SelectedRows[0].Cells[1].Value.ToString());
            EmployeeBLL.EmailSil_BLL(EmailAdressId);
            MessageBox.Show("Email adresi Silindi");

            //dlg_PersonelDetay_Load(null,null);

            dgv_Email.Rows.Remove(dgv_Email.SelectedRows[0]);
            dgv_Email.Refresh();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            try
            {
                selectedEmployee.JobTitle = txt_JobTitle.Text;

                //ekrana komponent eklememek için böyle yapıldı
                selectedEmployee.HireDate = selectedEmployee.HireDate.AddYears(-1);


                EmployeeBLL.UpdateEmployeBLL(selectedEmployee);

                MessageBox.Show("Personel güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.ToString());
            }

        }
    }
}
