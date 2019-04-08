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
    public partial class dlg_AddEmployee : Form
    {
        public dlg_AddEmployee()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
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
                JobTitle = txt_JobTitle.Text
            };

            EmployeeBLL.InsertEmployee(person, employee);
        }
    }
}
