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
	public partial class frmNewEmployee : ADOProjectJoshDeLaura.FrmBase
	{
        //Instantiate MiddleTier object
        dbMiddleTier dbmt = new dbMiddleTier();

		public frmNewEmployee()
		{
			InitializeComponent();
		}

        private void frmNewEmployee_Load(object sender, EventArgs e)
        {
            TitleImage = Image.FromFile(Application.StartupPath + "\\DeLauraGuitarsImage.png");
            FormDocumentation = "Enter New Employee!";

            DisplayEmps();
                
        

			 List<string> a = new List<string>()
        {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z",
        };

		foreach (string s in a)
		{
			cboSampleQuery.Items.Add(s);
		}

                
        }

		private void cboSampleQuery_SelectedIndexChange(object sender, EventArgs e)
		{
				SqlDataReader rdr = null;
			try 
				{ 								
					lstEmployee.ForeColor = System.Drawing.Color.Orchid;
					
					rdr = dbmt.ReturnEmployeeNamesByFirstLetter(cboSampleQuery.SelectedItem.ToString().ToUpper());
			 		lstEmployee.Items.Clear();

					 if (!rdr.HasRows)
                {
                    lstEmployee.Items.Add("No names returned for " + cboSampleQuery.SelectedItem.ToString());
                  rdr.Close();
                   return;
                }

				while (rdr.Read())
				{
					lstEmployee.Items.Add(rdr["FirstName"].ToString() + "\t" + rdr["LastName"].ToString());
				}
				}
            catch (SqlException sqx)
            {
                MessageBox.Show(sqx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
			finally
			{
				rdr.Close();
			}
			
			
		}

		private void btnEnterNew_Click(object sender, EventArgs e)
		{
			 try
            {
                //Call the method to insert a new row
                dbmt.InsertRowIntoEmployeeTable(txtFName.Text.Trim(), txtLname.Text.Trim(), 
                    int.Parse(txtAge.Text.Trim()), DateTime.Parse(mtxtHireDate.Text.Trim()));
                MessageBox.Show("Employee inserted successfully");
                txtAge.Clear();
                txtFName.Clear();
                txtLname.Clear();
                mtxtHireDate.Clear();
                txtFName.Focus();

            }
            catch (SqlException sqx)
            {
                MessageBox.Show(sqx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

             DisplayEmps();
             
		}

		private void btnEmployeeCount_Click(object sender, EventArgs e)
		{
			lblTotal.Text = dbmt.CountEmployees().ToString();
		}

		private void btnGetLastName_Click(object sender, EventArgs e)
		{
			lstEmployee.Items.Clear();
			string lname = dbmt.GetLastName(txtEnterFirstName.Text);
			if (lname == "")
			{
				MessageBox.Show("Enter a valid name");
			}
			
			lstEmployee.Items.Add("You chose " + txtEnterFirstName.Text + ", they have the last name of " + lname);
		}

        public void DisplayEmps()
        {
            try
            {
                lstEmployee.Items.Clear();
                SqlDataReader sdr;
                //call the method to return a datareader of employees
                sdr = dbmt.ReturnAllEmployeesInDataReader();
                //load listbox
                while (sdr.Read())
                {
                    lstEmployee.Items.Add(sdr["EmployeeNo"].ToString() + "\t" + sdr["FirstName"].ToString() + "\t" + sdr["LastName"].ToString() + "\t" +
                                            sdr["Age"].ToString() + "\t" + sdr["HireDate"].ToString());

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
