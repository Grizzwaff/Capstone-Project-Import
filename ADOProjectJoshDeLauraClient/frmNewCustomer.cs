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
	public partial class frmNewCustomer : ADOProjectJoshDeLaura.FrmBase
	{
        //Instantiate the middle tier
        dbMiddleTier dbmt = new dbMiddleTier();

        //Instantiate a dsGuits dataset
        dsGuits datCustomers = new dsGuits();
        dsGuits datOrdDet = new dsGuits();
        dsGuits datOrdNos = new dsGuits();
		public frmNewCustomer()
		{
			InitializeComponent();
		}

		private void frmNewCustomer_Load(object sender, EventArgs e)
		{
			TitleImage = Image.FromFile(Application.StartupPath + "\\DeLauraGuitarsImage.png");
            FormDocumentation = "Customer Info and New Customers";

            DisplayCusts();

            List<string> StateList = new List<string>()
                {
                    "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS",
                    "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", 
                    "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"
                    
                };

            foreach (string s in StateList)
            {
                cboState.Items.Add(s);
            }

            cboState.Text = ("Select State");
		}

        private void lstCusts_SelectedIndexChanged(object sender, EventArgs e)
        {
        try
            {
                txtFName.Text = datCustomers.Customers[lstCusts.SelectedIndex].FirstName.ToString();
                txtLName.Text = datCustomers.Customers[lstCusts.SelectedIndex].LastName.ToString();
                txtCity.Text = datCustomers.Customers[lstCusts.SelectedIndex].City.ToString();
                cboState.Text = datCustomers.Customers[lstCusts.SelectedIndex].State.ToString();
                mtxtZip.Text = datCustomers.Customers[lstCusts.SelectedIndex].Zip.ToString();
                mtxtTel.Text = datCustomers.Customers[lstCusts.SelectedIndex].Tel.ToString();
                txtEmail.Text = datCustomers.Customers[lstCusts.SelectedIndex].Email.ToString();
                txtCustID.Text = datCustomers.Customers[lstCusts.SelectedIndex].CustomerNo.ToString();

                

                //call the method to bring back the order numbers for empNo
                
                datOrdNos = dbmt.ReturnOrderNumbersFromCustomerNumber(txtCustID.Text);
                //Bind the dataset OrdNos table to the listbox
                //get datarowview
                //datOrdNos.Orders.
                lstOrders.DataSource = datOrdNos.Orders;              
                lstOrders.DisplayMember = "OrderNo";
                lstOrders.ValueMember = "OrderNo";  
            
                                                                  
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
                      
      

        private void btnAddNewCust_Click(object sender, EventArgs e)
        {
                try
            {
                //Call the method to insert a new row
                    dbmt.InsertRowIntoCustomersTable(txtFName.Text.Trim(), txtLName.Text.Trim(),
                        txtCity.Text.Trim(), cboState.Text, mtxtZip.Text, mtxtTel.Text, txtEmail.Text.Trim());
                    MessageBox.Show("Customer Inserted Successfully!");
                    txtFName.Clear();
                    txtLName.Clear();
                    txtCity.Clear();
                    mtxtZip.Clear();
                    mtxtTel.Clear();
                    txtEmail.Clear();
                    txtCustID.Clear();
                    txtFName.Focus();

                    DisplayCusts();
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

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            lstOrderDetail.Items.Clear();
            //below gets this error, fix it!
            //Items collection cannot be modified when the DataSource property is set.
            //lstOrders.Items.Clear();

            txtFName.Clear();
            txtLName.Clear();
            txtCity.Clear();
            mtxtZip.Clear();
            mtxtTel.Clear();
            txtEmail.Clear();
            txtCustID.Clear();
            txtFName.Focus();
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            lstOrderDetail.Items.Clear();
            //items in lstOrders are objects, need to get the item as an object, then retrieve wanted column
            //cannot use normal methods to retrieve, like SelectedItem.ToString()....
            DataRowView drv = (DataRowView)lstOrders.SelectedItem;
            
            string curItem = drv.Row[0].ToString();
            int x = int.Parse(curItem);
            
         
          datOrdDet = dbmt.ReturnOrderDetailFromOrderNumber(x);
            //display dataset by each column
          foreach (DataRow row in datOrdDet.Orders.Rows)
          {
              string no = row["OrderNo"].ToString().Trim();
              string date = row["OrderDate"].ToString();              
              string custNo = row["CustomerNo"].ToString().Trim();              
              string empNo = row["EmployeeNo"].ToString();              
              string serNo = row["SerialNo"].ToString();             
              double sub = double.Parse(row["SubTotal"].ToString());              
              double tax = double.Parse(row["Tax"].ToString());              
              double total = double.Parse(row["Total"].ToString());

              lstOrderDetail.Items.Add("Order Number: " + no);
              lstOrderDetail.Items.Add("\nOrder Date: " + date);              
              lstOrderDetail.Items.Add("\nCustomer Number: " + custNo);
              lstOrderDetail.Items.Add("\nEmployee Number: " + empNo);
              lstOrderDetail.Items.Add("\nSerial Number: " + serNo);
              lstOrderDetail.Items.Add("\nSubtotal: " + sub.ToString("C"));
              lstOrderDetail.Items.Add("\nTax: " + tax.ToString("C"));
              lstOrderDetail.Items.Add("\nTotal " + total.ToString("C"));
          }
      

        }


        private void DisplayCusts()
        {
            try
            {
                lstCusts.Items.Clear();
                //call method to return authors in a dataset
                datCustomers = dbmt.ReturnAllCustomersInDataSet();

                //fill in the listbox with author last names
                int i;
                for (i = 0; i < datCustomers.Customers.Rows.Count; i++)
                {
                    //put the last name in the listbox
                    lstCusts.Items.Add(datCustomers.Customers[i].LastName.ToString().Trim() +
                        ", " + datCustomers.Customers[i].FirstName.ToString().Trim());
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
        }
       

       

       
	}
}
