using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuMinghao1307Project3CLSApp
{
    public partial class FrmCreative : Form
    {
        private Icon m_ready = new Icon(SystemIcons.Information, 40, 40);

        public FrmCreative()
        {
            InitializeComponent();
        }

        private void FrmCreative_Load(object sender, EventArgs e)
        {
            txtSource.Text = "F:\\visual studio\\Project2022\\W1L2ConsoleApp1\\XuMinghao1307App\\XuMinghao1307Project3CLSApp";
            txtProcessedFile.Text = "F:\\visual studio\\Project2022\\W1L2ConsoleApp1\\XuMinghao1307App\\XuMinghao1307Project3CLSApp";
            txtDest.Text = "F:\\visual studio\\Project2022\\W1L2ConsoleApp1\\XuMinghao1307App\\XuMinghao1307Project3CLSApp";
            optGenerateLog.Checked = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtSource.Text))
            {
                errMessage.SetError(txtSource, "Invalid Source Directory");
                txtSource.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
            {
                errMessage.SetError(txtSource, "");// no error
            }
            if (!Directory.Exists(txtProcessedFile.Text))
            {
                errMessage.SetError(txtProcessedFile, "Invalid Processed File Directory");
                txtSource.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
            {
                errMessage.SetError(txtProcessedFile, "");// no error
            }
            if (!Directory.Exists(txtDest.Text))
            {
                errMessage.SetError(txtDest, "Invalid Destination Directory");
                txtSource.Focus();
                tabControl1.SelectedTab = tabDest;
                return;
            }
            else
            {
                errMessage.SetError(txtDest, "");// no error
            }

            // end valication

            //activate watching directory
            watchDir.EnableRaisingEvents = true;//start matching
            watchDir.Path = txtSource.Text;

            //code for notification
            mnuNotify.Icon = m_ready;
            mnuNotify.Visible = true;
            this.ShowInTaskbar = false;//hide in task bar
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSource_KeyUp(object sender, KeyEventArgs e)
        {
            //validate source
            if (Directory.Exists(txtSource.Text))
            {
                txtSource.BackColor = Color.White;
            }
            else
            {
                txtSource.BackColor = Color.Pink;
            }

            
        }

        private void txtProcessedFile_KeyUp(object sender, KeyEventArgs e)
        {
            //validate processed file
            if (Directory.Exists(txtProcessedFile.Text))
            {
                txtProcessedFile.BackColor = Color.White;
            }
            else
            {
                txtProcessedFile.BackColor = Color.Pink;
            }
        }

        private void txtDest_KeyUp(object sender, KeyEventArgs e)
        {
            //validate dest
            if (Directory.Exists(txtDest.Text))
            {
                txtDest.BackColor = Color.White;
            }
            else
            {
                txtDest.BackColor = Color.Pink;
            }
        }

        private void configureApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuNotify.Visible = true;
            this.ShowInTaskbar = true;
            this.Show();
        }

        private void exotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuNotify_DoubleClick(object sender, EventArgs e)
        {
            mnuNotify.Visible = false;
            this.ShowInTaskbar = true;
            this.Show();

        }
    }
}
