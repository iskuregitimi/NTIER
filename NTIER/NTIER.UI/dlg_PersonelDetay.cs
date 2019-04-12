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
        EF.Employee selectedEmployee;

        public dlg_PersonelDetay()
        {
            InitializeComponent();
        }

        public int BusinessEntityID = 0;
        public int EmailAdressId = 0;

        private void dlg_PersonelDetay_Load(object sender, EventArgs e)
        {

            selectedEmployee = EmployeeBLL.GetEmployee(BusinessEntityID);

            lbl_Id.Text = BusinessEntityID.ToString();

            lbl_HireDate.Text = selectedEmployee.HireDate.ToString();
            lbl_Name.Text = selectedEmployee.Person.FirstName;
            lbl_Surname.Text = selectedEmployee.Person.LastName;
            txt_JobTitle.Text = selectedEmployee.JobTitle;



            dgv_Tel.DataSource = null;
            dgv_Tel.DataSource = selectedEmployee.Person.PersonPhones.ToList();


            dgv_Email.DataSource = null;
            dgv_Email.DataSource = selectedEmployee.Person.EmailAddresses.ToList();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgv_Email_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


                // EmployeeBLL.UpdateEmployeBLL(selectedEmployee);

                MessageBox.Show("Personel güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.ToString());
            }

        }
    }
}
