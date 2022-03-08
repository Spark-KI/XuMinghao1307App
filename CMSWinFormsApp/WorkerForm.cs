﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cMSDBDataSet.tblWorker' table. You can move, or remove it, as needed.
            this.tblWorkerTableAdapter.Fill(this.cMSDBDataSet.tblWorker);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.cMSDBDataSet.tblWorker.Clear();
            sqlDataAdapter1.Fill(this.cMSDBDataSet.tblWorker);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(this.cMSDBDataSet.tblWorker);
            MessageBox.Show("The Worker Table is updated");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.cMSDBDataSet.tblWorker.Clear();
            sqlDataAdapter1.Fill(this.cMSDBDataSet.tblWorker);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
