using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIProject
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstContry.Items.Add(txtContry.Text);
            txtContry.Clear();
            cboState.Items.Add(txtState.Text);
            txtState.Clear();
        }

        private void btnRemoveContry_Click(object sender, EventArgs e)
        {
            lstContry.Items.Remove(lstContry.SelectedIndex);
        }

        private void btnRemoveState_Click(object sender, EventArgs e)
        {
            cboState.Items.Remove(cboState.SelectedIndex);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (chkEMail.Checked == true 
                || chkPostalMail.Checked == true
                && rdbMale.Checked == true)
            {
                MessageBox.Show("Hello Mr, you will be contacted by either USPS or email",
                    "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (chkEMail.Checked == true 
                || chkPostalMail.Checked == true
                && rdbFemale.Checked == true)
            {
                MessageBox.Show("Hello Mam, you will be contacted by either USPS or email",
                    "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }
    }
}
