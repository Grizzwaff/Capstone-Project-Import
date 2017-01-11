using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADOProjectJoshDeLauraClient
{
    class dbMiddleTier
    {
        //Instantiate connection objects
        SqlConnection gconn = new SqlConnection();
        SqlConnection error = new SqlConnection();

        //Instantiate Command objects
        SqlCommand scmd = new SqlCommand();

        //Instantiate Data Adapters
        SqlDataAdapter adapGuits = new SqlDataAdapter();

        //constructor
        public dbMiddleTier(){
        //set connection strings from the app.config file
            gconn.ConnectionString = ConfigurationManager.ConnectionStrings["DGDataBase"].ToString();
            error.ConnectionString = ConfigurationManager.ConnectionStrings["ErrorConnection"].ToString();
    }

        public dsGuits ReturnOrderDetailFromOrderNumber(int orderNo)
        {
             try
            {
                dsGuits datOrders = new dsGuits();
                scmd.Connection = gconn;
                scmd.CommandText = "GetOrderDetail";
                scmd.CommandType = CommandType.StoredProcedure;
                //Parameters collection
                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@OrderNo", orderNo);

                adapGuits.Fill(datOrders, "orders");
                return datOrders;

                //dsGuits datOrders = new dsGuits();
                //scmd.Connection = gconn;
                //scmd.CommandText = "select * from Orders";
                //scmd.CommandType = CommandType.Text;
                ////Parameters collection
                //adapGuits.SelectCommand = scmd;

                //adapGuits.Fill(datOrders, "Orders");
                //return datOrders;

                 
            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //method to return order numbers from employee number
        public dsGuits ReturnOrderNumbersFromCustomerNumber(string custid)
        {
            try
            {
                //Instantiate a data set
                dsGuits datGuits = new dsGuits();
                //Set up the command to execute the stored procedure
                scmd.Connection = gconn;
                scmd.CommandText = "GetOrderNo";
                scmd.CommandType = CommandType.StoredProcedure;
                //Parameters collection
                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@CustNo", custid);                                      
                //Set up the data adaptor to use the dataset and command and fill the dataset

                adapGuits.Fill(datGuits, "orders");
                //Return the dataset
                return datGuits;


            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //method to get last Serial number entered
        
        //method to get all customers by last name
        public dsGuits ReturnAllCustomersInDataSet()
        {
            try
            {
                //Instances are DAT and Datasets are DS - at the beginning.							
                //Create an instance of the dsGuits dataset class
                dsGuits datGuits = new dsGuits();
                //set up the command that will be used to fill the dataset
                scmd.Connection = gconn;
                scmd.CommandText = "select * from Customers order by LastName";
                scmd.CommandType = CommandType.Text;
                //Set up a data adaptor to use this command
                adapGuits.SelectCommand = scmd;
                //Tell the adaptor to fill a dataset with the selection
                adapGuits.Fill(datGuits, "Customers");

                //Return dataset
                return datGuits;
            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader GetSerialNosInStock()
        {   try
            {
                gconn.Open();
                scmd.Connection = gconn;
                scmd.CommandType = CommandType.Text;
                scmd.CommandText = "select * from Guitars";
                return scmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        
        }

        public SqlDataReader ReturnAllEmployeesInDataReader()
        {
            try
            {
                //Open connection
                gconn.Open();
                //set properties of the command object
                scmd.Connection = gconn;
                scmd.CommandType = CommandType.Text;
                scmd.CommandText = "select * from Employees order by EmployeeNo";
                //Execute the command
                return scmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException sqx)
            {
                throw (sqx);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
           
			
        }
       
	   public SqlDataReader ReturnEmployeeNamesByFirstLetter(string fletter)
		{
			try 
				{ 								
					gconn.Open();
					scmd.Connection = gconn;
					scmd.CommandType = CommandType.Text;
					scmd.CommandText = "select FirstName, LastName from Employees where FirstName LIKE '" + fletter + "%' order by FirstName";
					//scmd.Parameters.Clear();
					//scmd.Parameters.Add("@fletter", SqlDbType.VarChar, 40).Value = fletter;

					return scmd.ExecuteReader(CommandBehavior.CloseConnection);
				}
				catch(SqlException sqx)
				{
					throw sqx;		 
				}
				catch(Exception ex)
				{
					throw ex;		
				}
				
			
		}

        //method to insert Row into Customers Table

       public void InsertRowIntoOrdersTable(DateTime soldDate, int CustNo, int EmpNo, string SerialNo,
                                            double tax, double subTotal, double total)
       {
                 try
            {
                gconn.Open();
                scmd.Connection = gconn;
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.CommandText = "InsertRowIntoOrdersTable";

                scmd.Parameters.Clear();
                
                scmd.Parameters.AddWithValue("@OrderDate", soldDate);
                scmd.Parameters.AddWithValue("@CustomerNo", CustNo);
                scmd.Parameters.AddWithValue("@EmployeeNo", EmpNo);
                scmd.Parameters.AddWithValue("@SerialNo", SerialNo);
                scmd.Parameters.AddWithValue("@Tax", tax);
                scmd.Parameters.AddWithValue("@SubTotal", subTotal);
                scmd.Parameters.AddWithValue("@Total", total);

                scmd.ExecuteNonQuery();
            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
                 finally
                 {
                     if (gconn.State == ConnectionState.Open)
                     {
                         gconn.Close();
                     }
                 }
       }

       public void InsertRowIntoCustomersTable(string first, string last, string city, string state, string zip, string tel,
                                               string email)
       {
          try
            {
                gconn.Open();
                scmd.Connection = gconn;
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.CommandText = "InsertRowIntoCustomersTable";

                scmd.Parameters.Clear();

                scmd.Parameters.AddWithValue("@FirstName", first);
                scmd.Parameters.AddWithValue("@LastName", last);
                scmd.Parameters.AddWithValue("@City", city);
                scmd.Parameters.AddWithValue("@State", state);
                scmd.Parameters.AddWithValue("@Zip", zip);
                scmd.Parameters.AddWithValue("@Tel", tel);
                scmd.Parameters.AddWithValue("@Email", email);

                scmd.ExecuteNonQuery();
            }
            catch (SqlException sqx)                            
            {
                throw sqx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          finally
          {
              if (gconn.State == ConnectionState.Open)
              {
                  gconn.Close();
              }
          }
       }

        //method to insert Row (Stock) into Guitars Table
       public void InsertRowIntoGuitarsTable(string serial, string strings, string color, string frets, string body,
           double price)
       {
           try
           {
               gconn.Open();
               scmd.Connection = gconn;
               scmd.CommandType = CommandType.StoredProcedure;
               scmd.CommandText = "InsertRowIntoGuitarsTable";

               scmd.Parameters.Clear();

               scmd.Parameters.AddWithValue("@SerialNo", serial);
               scmd.Parameters.AddWithValue("@Strings", strings);
               scmd.Parameters.AddWithValue("@Color", color);
               scmd.Parameters.AddWithValue("@Frets", frets);
               scmd.Parameters.AddWithValue("@BodyStyle", body);
               scmd.Parameters.AddWithValue("@Price", price);

               scmd.ExecuteNonQuery();
           }
           catch (SqlException sqx)
           {
               throw sqx;
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               if (gconn.State == ConnectionState.Open)
               {
                   gconn.Close();
               }
           }
       }//end InsertRowIntoGuitarsTable

	   public void InsertRowIntoEmployeeTable(string fname, string lname, int age, DateTime hire)
	   {
				try 
					{ 								
						gconn.Open();
						scmd.Connection = gconn;
						scmd.CommandType = CommandType.StoredProcedure;
						scmd.CommandText = "InsertRowIntoEmployeeTable";

						scmd.Parameters.Clear();
						
						scmd.Parameters.AddWithValue("@FirstName", fname);
						scmd.Parameters.AddWithValue("@LastName", lname);
						scmd.Parameters.AddWithValue("@Age", age);
						scmd.Parameters.AddWithValue("@Hiredate", hire);

						scmd.ExecuteNonQuery();
					}
					catch(SqlException sqx)
					{
						throw sqx;		 
					}
					catch(Exception ex)
					{
						throw ex;		
					}
					finally
			{
				if(gconn.State == ConnectionState.Open)
				{
					gconn.Close();
				}
			}
	   }

       public int CountGuitarsInStock()
       {
           try
            {
                gconn.Open();
                scmd.Connection = gconn;
                scmd.CommandType = CommandType.Text;
                scmd.CommandText = "select count(SerialNo) from Guitars";

                return Convert.ToInt32(scmd.ExecuteScalar());
            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           finally
           {
               if (gconn.State == ConnectionState.Open)
               {
                   gconn.Close();
               }
           }
       }

	   public int CountEmployees()
	   {
			try 
				{ 								
					gconn.Open();
					scmd.Connection = gconn;
					scmd.CommandType = CommandType.Text;
					scmd.CommandText = "select count(EmployeeNo) from Employees";

					return  Convert.ToInt32(scmd.ExecuteScalar());
				}
				catch(SqlException sqx)
				{
					throw sqx;		 
				}
				catch(Exception ex)
				{
					throw ex;		
				}
			finally
			{
				if(gconn.State == ConnectionState.Open)
				{
					gconn.Close();
				}
			}
	   }

       public double GetPrice(string SerialNo)
       {
            try
            {
                gconn.Open();
                scmd.Connection = gconn;
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.CommandText = "GetPrice";

                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@SerialNo", SerialNo);

                SqlParameter price = new SqlParameter("@Price", SqlDbType.SmallMoney);
                price.Direction = ParameterDirection.Output;
                scmd.Parameters.Add(price);
                scmd.ExecuteNonQuery();
                string guitPrice = scmd.Parameters["@Price"].Value.ToString();
                double actualPrice = double.Parse(guitPrice);
                return actualPrice;
            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (gconn.State == ConnectionState.Open)
                {
                    gconn.Close();
                }
            }
       }

       public string GetFirstNameFromCustNo(int CustNo)
       {
           try
            {
                gconn.Open();
                scmd.Connection = gconn;
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.CommandText = "GetFirstNameFromCustNo";

                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@CustomerNo", CustNo);

                SqlParameter fname = new SqlParameter("@FirstName", SqlDbType.VarChar, 25);
                fname.Direction = ParameterDirection.Output;
                scmd.Parameters.Add(fname);
                scmd.ExecuteNonQuery();
                string firstname = scmd.Parameters["@FirstName"].Value.ToString().Trim();
                return firstname;
            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           finally
           {
               if (gconn.State == ConnectionState.Open)
               {
                   gconn.Close();
               }
           }
       }

       public string GetEmailFromCustNo(int CustNo)
       {
          try
            {
                gconn.Open();
                scmd.Connection = gconn;
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.CommandText = "GetEmailFromCustNo";

                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@CustomerNo", CustNo);

                SqlParameter email = new SqlParameter("@Email", SqlDbType.VarChar, 100);
                email.Direction = ParameterDirection.Output;
                scmd.Parameters.Add(email);
                scmd.ExecuteNonQuery();
                string emailReturn = scmd.Parameters["@Email"].Value.ToString().Trim();
                return emailReturn;
            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          finally
          {
              if (gconn.State == ConnectionState.Open)
              {
                  gconn.Close();
              }
          }
       }

       public string GetLastNameFromCustNo(int EmpNo)
       {
            try
            {
                gconn.Open();
                scmd.Connection = gconn;
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.CommandText = "GetLastNameFromCustNo";

                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@CustomerNo", EmpNo);

                SqlParameter lname = new SqlParameter("@LastName", SqlDbType.VarChar, 25);
                lname.Direction = ParameterDirection.Output;
                scmd.Parameters.Add(lname);
                scmd.ExecuteNonQuery();
                string lastname = scmd.Parameters["@LastName"].Value.ToString().Trim();
                return lastname;

            }
            catch (SqlException sqx)                 
            {
                throw sqx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (gconn.State == ConnectionState.Open)
                {
                    gconn.Close();
                }
            }
       }

	   public string GetLastName(string fname)
	   {
			try 
				{
                   
	
					gconn.Open();
					scmd.Connection = gconn;
					scmd.CommandType = CommandType.StoredProcedure;
					scmd.CommandText = "GetLastName";

					scmd.Parameters.Clear();
					scmd.Parameters.AddWithValue("@FirstName", fname);
					
					SqlParameter lname = new SqlParameter("@LastName", SqlDbType.VarChar,25);					
					lname.Direction = ParameterDirection.Output;
					scmd.Parameters.Add(lname);
					scmd.ExecuteNonQuery();
					string lastname = scmd.Parameters["@LastName"].Value.ToString();
					return lastname;
				}
				catch(SqlException sqx)
				{
					throw sqx;		 
				}
				catch(Exception ex)
				{
					throw ex;		
				}
				finally
			{
				if(gconn.State == ConnectionState.Open)
				{
					gconn.Close();
				}
			}
	   }
    }
}
