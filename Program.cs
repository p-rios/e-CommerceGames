using Dapper;
using e_CommerceGames.Models;
using e_CommerceGames.Repositories;
using Microsoft.Data.SqlClient;
using System;

namespace e_CommerceGames
{
    class Program
    {
        static void Main(string[] args)
        {

            // const string connectionString = "Data Source=DESKTOP-229IIK6;Initial Catalog=e-CommerceGames;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //   var customer1 = new CustomerRepository();
            //   var customer1 = new CustomerRepository();



            const string connectionString = "Data Source=DESKTOP-229IIK6;Initial Catalog=e-CommerceGames;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (var connection = new SqlConnection(connectionString))
            {
         var customers =     connection.Query<Customer>(@"SELECT TOP (1000) [customer_id]
      ,[customer_code] 
      ,[Customer_name] 
      ,[Customer_adress] 
      ,[Customer_otherDetails] 
  FROM [e-CommerceGames].[dbo].[Customer]");


                foreach (var customer in customers)
                {
                    Console.WriteLine($"{ customer.Customer_Name}");
                }

            }

           


        }
    }
    }
