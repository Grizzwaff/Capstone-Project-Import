using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADOProjectJoshDeLauraClient
{
    public partial class frmLogin : ADOProjectJoshDeLaura.FrmBase
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            TitleImage = Image.FromFile(Application.StartupPath + "\\DeLauraGuitarsImage.png");
            FormDocumentation = "Please Login!";
            txtPass.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            //check Employee against stored Employee for verfication.  Pasword hard coded not up to user,
            //for small business.  More control, no change except owner or admin
            if (txtEmp.Text.Trim().CompareTo("1") == 0 && txtPass.Text.Trim().CompareTo("steve1") == 0)
            {
                //MessageBox.Show("Login Successful. Click Ok to continue.", "Login",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();  //hide this form
                frmMain nm = new frmMain();
                nm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Information! Try again!", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clear text boxes
                txtEmp.Clear();
                txtPass.Clear();
                txtEmp.Focus();
            }
        }
    }
}
