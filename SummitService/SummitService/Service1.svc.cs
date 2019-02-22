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
        //readonly string connectionString = @"Data Source=Юрий-ПК\SQLEXPRESS;Initial Catalog=SummitDB;Integrated Security=True";
        readonly string connectionString = @"Data Source=737B;Initial Catalog=SummitDB;Integrated Security=True";

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

        public void AddCountry(Country country)
        {
            string sqlExpression = "AddCountry";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                SqlParameter CountryNameParamet = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = country.Name
                };
                command.Parameters.Add(CountryNameParamet);

                var result = command.ExecuteScalar();
                connection.Close();
            }
        }

        public void AddVariant(Variant variant)
        {
            string sqlExpression = "AddVariant";
            string dateS = variant.StartDate.ToString("ds");
            string dateF = variant.FinishDate.ToString("df");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                SqlParameter DateStart = new SqlParameter
                {
                    ParameterName = "@StartDate",
                    Value = variant.StartDate
                };
                command.Parameters.Add(DateStart);

                SqlParameter DateFinish = new SqlParameter
                {
                    ParameterName = "@FinishDate",
                    Value = variant.FinishDate
                };
                command.Parameters.Add(DateFinish);


                SqlParameter country_idParam = new SqlParameter
                {
                    ParameterName = "@Country_ID",
                    Value = variant.country_id
                };
                command.Parameters.Add(country_idParam);


                SqlParameter user_idParam = new SqlParameter
                {
                    ParameterName = "@User_ID",
                    Value = variant.user_id
                };
                command.Parameters.Add(user_idParam);


                SqlParameter summit_idParam = new SqlParameter
                {
                    ParameterName = "@Summit_ID",
                    Value = variant.summit_id
                };
                command.Parameters.Add(summit_idParam);

                var result = command.ExecuteScalar();
                connection.Close();
            }
        }

        public void AddVoice(Voice voice)
        {
            string sqlExpression = "AddVoice";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                SqlParameter user_idParam = new SqlParameter
                {
                    ParameterName = "@User_ID",
                    Value = voice.user_id
                };
                command.Parameters.Add(user_idParam);


                SqlParameter variant_idParam = new SqlParameter
                {
                    ParameterName = "@Variant_ID",
                    Value = voice.variant_id
                };
                command.Parameters.Add(variant_idParam);

                var result = command.ExecuteScalar();
                connection.Close();
            }
        }

        public List<Voice> Summarizing(int id)
        {
            string sqlExpression = "Summarizing";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                SqlParameter Param = new SqlParameter
                {
                    ParameterName = "@Summin_ID",
                    Value = id
                };
                command.Parameters.Add(Param);

                var reader = command.ExecuteReader();

                List<Voice> summarizing = new List<Voice>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Voice cli = new Voice
                        {

                            variant_id = reader.GetInt32(0),
                            sum = reader.GetInt32(1)

                        };
                        summarizing.Add(cli);
                    }
                    return summarizing;
                }
                else
                {
                    return null;
                }

            }
        }

        public List<Country> SelectCountry()
        {
            string sqlExpression = "SelectCountry";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                var reader = command.ExecuteReader();

                List<Country> summarizing = new List<Country>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Country cli = new Country
                        {
                            Country_ID = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        };
                        summarizing.Add(cli);
                    }
                    return summarizing;
                }
                else
                {
                    return null;
                }

            }
        }

        public void DeleteAllVoices()
        {
            string sqlExpression = "DeleteAllVoices";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                var result = command.ExecuteScalar();
                connection.Close();
            }
        }
}



public class Voice
{
    public int user_id;
    public int variant_id;
    public int sum;
}

public class Variant
    {
        public DateTime StartDate;
        public DateTime FinishDate;
        public int country_id;
        public int user_id;
        public int summit_id;
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
    public int Country_ID;
    public string Name;
}





