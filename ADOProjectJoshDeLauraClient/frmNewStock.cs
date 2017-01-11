using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADOProjectJoshDeLauraClient
{
	public partial class frmNewStock : ADOProjectJoshDeLaura.FrmBase
	{

        //Instantiate Middle Tier object
        dbMiddleTier dbmt = new dbMiddleTier();

        List<string> fretList = new List<string>();
        
		public frmNewStock()
		{
			InitializeComponent();
		}

		private void frmNewStock_Load(object sender, EventArgs e)
		{
			TitleImage = Image.FromFile(Application.StartupPath + "\\DeLauraGuitarsImage.png");
            FormDocumentation = "Enter New Guitars!";

            radSix.Checked = true;
            rad22.Checked = true;

            DisplayStock();
		}

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            string frets;
            string strings;
            try
            {
                if (radSix.Checked == true)
                {
                    strings = "6";
                }
                else if (radSeven.Checked == true)
                {
                    strings = "7";
                }
                else if (radEight.Checked == true)
                {
                    strings = "8";
                }
                else
                {
                    strings = "12";
                }
                if (rad22.Checked == true)
                {
                    frets = "22";
                }
                else
                {
                    frets = "24";
                }

                //Call method to insert a row
                dbmt.InsertRowIntoGuitarsTable(mtxtSerial.Text.Trim(), strings, txtColor.Text.Trim(),
                    frets, txtBody.Text.Trim(), double.Parse(txtPrice.Text));
                MessageBox.Show("Guitar inserted successfully");
                mtxtSerial.Clear();
                txtBody.Clear();
                txtColor.Clear();
                txtPrice.Clear();
                rad22.Checked = true;
                radSix.Checked = true;
                mtxtSerial.Focus();



            }
            catch (SqlException sqx)
            {
                MessageBox.Show(sqx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DisplayStock();
        }
          

        private void btnStockCount_Click(object sender, EventArgs e)
        {
            lblTotalGuitars.Text = dbmt.CountEmployees().ToString();
        }

        private void DisplayStock()
        {
           try
             {
                 SqlDataReader sdr;
                 sdr = dbmt.GetSerialNosInStock();
                 while (sdr.Read())
                 {
                     lstIntStock.Items.Add(sdr["SerialNo"].ToString());
                 }
                 sdr.Close();
             }
             catch (SqlException sqx)
             {
                 MessageBox.Show(sqx.Message);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

    }
}

