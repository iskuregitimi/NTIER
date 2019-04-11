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
    public partial class Detay : Form
    {
        internal int businessEntityId;

        public Detay()
        {
            InitializeComponent();
        }

        public int BusinessEntityID;

        private void Detay_Load(object sender, EventArgs e)
        {
            DataSet ds = EmployeeBLL.GetDetailsBLL(BusinessEntityID);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView2.DataSource = ds.Tables[1];
            dataGridView3.DataSource = ds.Tables[2];
            dataGridView4.DataSource = ds.Tables[3];

        }
    }
}
