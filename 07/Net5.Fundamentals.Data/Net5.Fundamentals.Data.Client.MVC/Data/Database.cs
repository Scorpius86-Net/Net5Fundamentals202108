using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Net5.Fundamentals.Data.Client.MVC.Data
{
    public class Database
    {
        public List<Customer> ListCustomers()
        {
            List<Customer> customers = new List<Customer>();

            string strConn = "Data Source=.;Initial Catalog=Pharmacy;User ID=sa; Password=Password1234";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string querySQL = @"
                    SELECT  
	                    CustomerCode,
	                    CustomerName,
	                    CustomerAddress,
	                    DistrictCode,
	                    Sex,
	                    DNI,
	                    RUC,
	                    Telephone,
	                    Mobile
                    FROM Customer
                ";
                using (SqlCommand cmd = new SqlCommand(querySQL, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //System.Console.WriteLine($"{reader[0]},{reader[1]},{reader[2]},{reader[3]},{reader[4]},{reader[5]},{reader[6]},{reader[7]},{reader[8]},");
                            Customer customer = new Customer();

                            customer.CustomerCode = reader.GetString(0);
                            customer.CustomerName = reader.GetString(1);
                            customer.CustomerAddress = reader.GetString(2);
                            customer.DistrictCode = reader.GetString(3);
                            customer.Sex = reader.GetString(4);
                            customer.DNI = reader.GetString(5);
                            customer.RUC = reader.GetString(6);
                            customer.Telephone = reader.GetInt32(7);
                            customer.Mobile = reader.GetInt32(8);

                            customers.Add(customer);
                        }
                    }

                    reader.Close();
                    conn.Close();
                }
            }

            return customers;
        }
    }
}
