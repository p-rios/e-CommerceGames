using Dapper;
using Microsoft.Data.SqlClient;
using System;

namespace e_CommerceGames
{
    class Program
    {
        static void Main(string[] args)
        {
            //    const string connectionString = "Server=localhost;Database=e-CommerceGames;Integrated Security=SSPI";

            const string connectionString = "Data Source=DESKTOP-229IIK6;Initial Catalog=e-CommerceGames;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Query(""
                    );
                   
            }
        }
    }
}