using Dapper;
using Dapper.Contrib.Extensions;
using e_CommerceGames.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_CommerceGames.Repositories
{
     class CustomerRepository
    {

        private  SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-229IIK6;Initial Catalog=e-CommerceGames;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //     const string connectionString = "Data Source=DESKTOP-229IIK6;Initial Catalog=e-CommerceGames;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public IEnumerable<Customer> Get()
        //    => _connection.GetAll<Customer>();

          => _connection.Query<Customer>(@"SELECT TOP (1000) [customer_id]
      ,[customer_code] 
      ,[Customer_name] 
      ,[Customer_adress] 
      ,[Customer_otherDetails] 
  FROM [e-CommerceGames].[dbo].[Customer]");
            
      
                
              



           





            
        
    }
}