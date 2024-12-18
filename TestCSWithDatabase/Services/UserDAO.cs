﻿using System.Data.SqlClient;
using TestCSWithDatabase.Models;

namespace TestCSWithDatabase.Services
{

    //USE SqlCommand.Parameters documentation if need help.
    public class UserDAO
    {
        //Is the link used to make the connection with the specified Database.
        string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";


        public bool FindUserByPassword(User user)
        {
            bool hasSucceed = false;

            string sqlStatement = "SELECT * FROM dbo.User WHERE user.password = @userPassword";
            //With this using, you will be able to actually make the connection. 
            //The code inside the {} will be done using the connection.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SqlCommand is what will actually make the SqlStatement posible
                //by using the statement you made and using the connection, you can define parameters
                //using the .Add function.
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.Add("@userPassword", System.Data.SqlDbType.VarChar, 50).Value = user.password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        hasSucceed = true;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return hasSucceed;
        }
    }
}
