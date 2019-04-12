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
    public partial class dlg_AddEmployee : Form
    {
        public dlg_AddEmployee()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person
                {
                    FirstName = txt_firstName.Text,
                    MiddleName = txt_MiddleName.Text,
                    LastName = txt_LastName.Text
                };

                Employee employee = new Employee
                {
                    BirthDate = dtp_BirthDate.Value,
                    JobTitle = txt_JobTitle.Text,
                    LoginID = txt_LoginId.Text,
                    NationalIDNumber = int.Parse(txt_nationalID.Text)
                };


                EmployeeBLL.InsertEmployee(person, employee);

                MessageBox.Show("Kayıt eklendi");

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Hata alındı:" + ex.Message);
                MessageBox.Show("Kayıt ekelemede hata" + ex.Message);
            }
          

            this.Close();
        }

		private void dlg_AddEmployee_Load(object sender, EventArgs e)
		{

		}
	}
}
