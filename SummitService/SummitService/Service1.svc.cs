using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SummitService
{
    public class Service1 : IService1
    {
        readonly string connectionString = @"Data Source=Юрий-ПК\SQLEXPRESS;Initial Catalog=SummitDB;Integrated Security=True";

        public Auth Authorisation(string Login, string Password)
        {
            Auth auth = new Auth();

            if (FindByLoginUsers(Login, Password))
            {
                string sqlExpression = "Authorisation";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };

                    SqlParameter LoginParam = new SqlParameter
                    {
                        ParameterName = "@Login",
                        Value = Login
                    };
                    command.Parameters.Add(LoginParam);

                    SqlParameter PasswordParam = new SqlParameter
                    {
                        ParameterName = "@Password",
                        Value = Password
                    };
                    command.Parameters.Add(PasswordParam);

                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            auth.error = false;
                            auth.error_message = null;
                            auth.id_user = id;

                        }
                        return auth;
                    }
                    else
                    {
                        auth.error = true;
                        auth.error_message = "Неверное имя пользователя или пароль";
                        return auth;
                    }
                }
            }
            else
            {
                auth.error = true;
                auth.error_message = "Неверное имя пользователя или пароль";
                return auth;
            }
        }

        public bool FindByLoginUsers(string Login, string Password)
        {
            string FindByLoginUsers = "Authorisation";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(FindByLoginUsers, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                SqlParameter LoginParam = new SqlParameter
                {
                    ParameterName = "@Login",
                    Value = Login
                };
                command.Parameters.Add(LoginParam);

                SqlParameter PasswordParam = new SqlParameter
                {
                    ParameterName = "@Password",
                    Value = Password
                };
                command.Parameters.Add(PasswordParam);

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public void AddSummit(Summit summit)
        {
            string sqlExpression = "AddSummit";
            string date = summit.Date.ToString("d");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                SqlParameter NameParam = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = summit.Name
                };
                command.Parameters.Add(NameParam);

                SqlParameter DateParam = new SqlParameter
                {
                    ParameterName = "@Date",
                    Value = summit.Date
                };
                command.Parameters.Add(DateParam);

                var result = command.ExecuteScalar();
                connection.Close();
            }
        }
    }
}

    public class Summit
    {
        public string Name;
        public DateTime Date;
    }

    public class Auth
    {
        public bool error;
        public string error_message;
        public int id_user;
    }

    public class Country
    {
        public string Name;
    }


