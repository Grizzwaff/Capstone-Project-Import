using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace ADOProjectJoshDeLauraClient
{
    public partial class frmOrder : ADOProjectJoshDeLaura.FrmBase
    {
        dbMiddleTier dbmt = new dbMiddleTier();
        dsGuits datCustomers = new dsGuits();

        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            TitleImage = Image.FromFile(Application.StartupPath + "\\DeLauraGuitarsImage.png");
            FormDocumentation = "Take an Order";

            try
            {
                //call method to return customers in a dataset
                datCustomers = dbmt.ReturnAllCustomersInDataSet();

                //fill in the listbox with customers last names
                int i;
                for (i = 0; i < datCustomers.Customers.Rows.Count; i++)
                {
                    
                    //ListViewItem lvitem = new ListViewItem(datCustomers.Customers[i].LastName.ToString().Trim());
                    //lvitem.SubItems.Add(datCustomers.Customers[i].FirstName.ToString().Trim());
                    //lvitem.SubItems.Add(datCustomers.Customers[i].CustomerNo.ToString().Trim());
                    //lstVCustInfo.Items.Add(lvitem);
                    //put the last name in the listbox
                    lstCustInfo.Items.Add(datCustomers.Customers[i].LastName.ToString().Trim() +
                        ", " + datCustomers.Customers[i].FirstName.ToString().Trim() +
                        "\t" + datCustomers.Customers[i].CustomerNo.ToString().Trim());

                    mtxtCustNo.Clear();
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

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double tax = 0, subTotal = 0, total = 0;

            string fname = dbmt.GetFirstNameFromCustNo(int.Parse(mtxtCustNo.Text));
                string lname = dbmt.GetLastNameFromCustNo(int.Parse(mtxtCustNo.Text));
                string email = dbmt.GetEmailFromCustNo(int.Parse(mtxtCustNo.Text));
                string serial = mtxtSerialNo.Text;
                string custno = mtxtCustNo.Text;

             try
            {
                double price = dbmt.GetPrice(mtxtSerialNo.Text);

                tax = 0.096 * price;
                subTotal = price;
                total = 1.096 * price;

            }
            catch (SqlException sqx)
            {
                MessageBox.Show(sqx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 


        try
            {
                dbmt.InsertRowIntoOrdersTable(DateTime.Now,int.Parse(mtxtCustNo.Text.Trim()), 
                    int.Parse(mtxtEmpNo.Text.Trim()), mtxtSerialNo.Text.Trim(),
                    tax, subTotal, total);

                

                lstOrderInfo.Items.Add(fname);
                lstOrderInfo.Items.Add(lname);
                lstOrderInfo.Items.Add("Customer Number " + mtxtCustNo.Text.Trim());
                lstOrderInfo.Items.Add("Order Date " + DateTime.Now);
                lstOrderInfo.Items.Add("Guitar Serial Number " + mtxtSerialNo.Text.Trim());
                lstOrderInfo.Items.Add("SubTotal: " + subTotal.ToString("C"));
                lstOrderInfo.Items.Add("Tax: " + tax.ToString("C"));
                lstOrderInfo.Items.Add("Order Total: " + total.ToString("C"));
                                       
                MessageBox.Show("Order Successfully Placed!");
                mtxtSerialNo.Clear();
                mtxtEmpNo.Clear();
                mtxtCustNo.Clear();
               
            }
            catch (SqlException sqx)
            {
                MessageBox.Show(sqx.Message);
            }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        var fromAddress = new MailAddress("josh.delaura@gmail.com", "DeLaura Guitars");
        var toAddress = new MailAddress(email, fname);
        const string fromPassword = "fqbdpqytrmgalnqy";
        const string subject = "DeLaura Guitars Order Receipt";
        string body = ("Thank you for ordering from DeLaura Guitars!" + "\nWe hope you are pleased with your new purchase." +
            "\nHere is your receipt and order information." + "\n\n" + fname + "\n" + lname + "\n\nCustomer Number " + custno +
            "\nOrder Date " + DateTime.Now + "\nGuitar Serial Number " + serial + "\n\nSubTotal: " + subTotal.ToString("C") +
            "\nTax: " + tax.ToString("C") + "\nOrder Total: " + total.ToString("C") + "\n\n\nIf you have any " +
            "questions, comments, compliments, or concerns..." + 
            "\nPlease call 206-555-3210" + "\nWe appreciate your business!");


        var smtp = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
            Timeout = 20000
        };
        using (var message = new MailMessage(fromAddress, toAddress)
        {
            Subject = subject,
            Body = body
        })
        {
            smtp.Send(message);
        }

        }//end order placed button

        private void lstCustInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
             try
            {
                mtxtCustNo.Text = datCustomers.Customers[lstCustInfo.SelectedIndex].CustomerNo.ToString();
                mtxtCustNo.Focus();
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

        //private void lstVCustInfo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (lstVCustInfo.SelectedItems.Count > 0)
        //        {
        //            mtxtCustNo.Text = lstVCustInfo.SelectedItems[2].ToString();
        //            mtxtCustNo.Focus();
        //        }
                
        //    }
        //    catch (SqlException sqx)
        //    {
        //        MessageBox.Show(sqx.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    } 
        //}

       

     

      

       
    }
}
