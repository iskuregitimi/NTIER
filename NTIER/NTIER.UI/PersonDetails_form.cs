﻿using NTIER.BLL;
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
    public partial class PersonDetails_form : Form
    {
        public PersonDetails_form()
        {
            InitializeComponent();
        }
        public int BusinessEntityID = 0;

        private void dlg_PersonelDetay_Load(object sender, EventArgs e)
        {
            DataSet ds = EmployeeBLL.PersonelDetay(BusinessEntityID);
            lbl_Id.Text = ds.Tables[0].Rows[0][0].ToString();
            lbl_Name.Text = ds.Tables[0].Rows[0][1].ToString();
            lbl_Surname.Text = ds.Tables[0].Rows[0][2].ToString();
            lbl_JobTitle.Text = ds.Tables[0].Rows[0][3].ToString();
            lbl_BirthDate.Text = ds.Tables[0].Rows[0][4].ToString();
            lbl_HireDate.Text = ds.Tables[0].Rows[0][5].ToString();

            dgv_PersonDetails.DataSource = ds.Tables[0];
            dgv_Adress.DataSource = ds.Tables[1];
            dgv_PhoneNumbers.DataSource = ds.Tables[2];
            dgv_emails.DataSource = ds.Tables[3];

        }


    }
}