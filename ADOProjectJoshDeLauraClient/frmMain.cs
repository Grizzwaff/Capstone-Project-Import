using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADOProjectJoshDeLauraClient
{
	public partial class frmMain : ADOProjectJoshDeLaura.FrmBase
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnEnterNewStock_Click(object sender, EventArgs e)
		{
			
			frmNewStock ns = new frmNewStock();
			ns.ShowDialog();
			
		}

		private void btnEnterNewCustomer_Click(object sender, EventArgs e)
		{
			
			frmNewCustomer nc = new frmNewCustomer();
			nc.ShowDialog();
			
		}

		private void btnEnterNewEmployee_Click(object sender, EventArgs e)
		{
			
			frmNewEmployee ne = new frmNewEmployee();
			ne.ShowDialog();
			
		}

         private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder no = new frmOrder();
            no.ShowDialog();
        }

		private void frmMain_Load(object sender, EventArgs e)
		{
			TitleImage = Image.FromFile(Application.StartupPath + "\\DeLauraGuitarsImage.png");
            FormDocumentation = "Welcome to the Company Homepage!";
		}

      
       

       
	}
}
