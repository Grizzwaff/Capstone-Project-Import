using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOProjectJoshDeLaura
{
	public partial class FrmBase : Form
	{

	public Image TitleImage
		{
			get { return picTitleImage.Image;}
			set { picTitleImage.Image = value;}
		}

		public string FormDocumentation
		{
			get { return lblDocumentation.Text;}
			set { lblDocumentation.Text = value;}
		}
		public FrmBase()
		{
			InitializeComponent();
		}

		private void btnReturnToMain_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void btnExitProgram_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


	}
}
