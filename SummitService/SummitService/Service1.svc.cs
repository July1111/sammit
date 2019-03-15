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
        //readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\npartyko\Source\Repos\sammit\SummitService\SummitService\App_Data\SummitDB.mdf;Integrated Security=True";
        readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Юрий\Desktop\8 семестр\Проектирование ИСУ\репоз\SummitService\SummitService\App_Data\SummitDB.mdf;Integrated Security=True";
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

        public Summit AddSummit(string name, DateTime date)
        {
            string sqlExpression = "AddSummit";
            Summit summit = new Summit();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand("Select count(*) from Summit where Name = @name", connection);
                command1.Parameters.AddWithValue("@name", name);
                int count_summit = (int)command1.ExecuteScalar();

                if (count_summit == 0)
                {

                    SqlCommand command = new SqlCommand(sqlExpression, connection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };

                    SqlParameter NameParam = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = name
                    };
                    command.Parameters.Add(NameParam);

                    SqlParameter DateParam = new SqlParameter
                    {
                        ParameterName = "@Date",
                        Value = date
                    };
                    command.Parameters.Add(DateParam);

                    var result = command.ExecuteScalar();
                    summit.error = false;
                    return summit;
                }
                

                else {
                        summit.error = true;
                        summit.error_message = "Такой саммит уже сущесвтует!";
                    return summit;

                }
                
            }
        }

        public Country AddCountry(string name)
        {
            string sqlExpression = "AddCountry";
            Country country = new Country();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("Select count(*) from Country where Name = @name", connection);
                command1.Parameters.AddWithValue("@name", name);
                int count_country = (int)command1.ExecuteScalar();

                if (count_country == 0)
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };

                    SqlParameter CountryNameParamet = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = name
                    };
                    command.Parameters.Add(CountryNameParamet);

                    var result = command.ExecuteScalar();
                    country.error = false;
                    return country;

                }
                else {
                    country.error = true;
                    country.error_message = "такая страна уже сущесвтует!";
                    return country;
                }
           
            }
        }

        public Variant AddVariant(DateTime StartDate, DateTime FinishDate, int country_id, int user_id, int summit_id)
        {
                string sqlExpression = "AddVariant";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Variant variant = new Variant();

                    SqlCommand command1 = new SqlCommand("Select count(*) from Variant where User_ID = @user_id AND Summit_ID = @summit_id AND Country_ID = @country_id", connection);
                    command1.Parameters.AddWithValue("@user_id", user_id);
                    command1.Parameters.AddWithValue("@summit_id", summit_id);
                    command1.Parameters.AddWithValue("@country_id", country_id);
                    int count_variantsFromOneUser = (int)command1.ExecuteScalar();

                    if (count_variantsFromOneUser == 0)
                    {

                        SqlCommand command = new SqlCommand(sqlExpression, connection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure
                        };

                        SqlParameter DateStart = new SqlParameter
                        {
                            ParameterName = "@StartDate",
                            Value = StartDate
                        };
                        command.Parameters.Add(DateStart);

                        SqlParameter DateFinish = new SqlParameter
                        {
                            ParameterName = "@FinishDate",
                            Value = FinishDate
                        };
                        command.Parameters.Add(DateFinish);


                        SqlParameter country_idParam = new SqlParameter
                        {
                            ParameterName = "@Country_ID",
                            Value = country_id
                        };
                        command.Parameters.Add(country_idParam);


                        SqlParameter user_idParam = new SqlParameter
                        {
                            ParameterName = "@User_ID",
                            Value = user_id
                        };
                        command.Parameters.Add(user_idParam);


                        SqlParameter summit_idParam = new SqlParameter
                        {
                            ParameterName = "@Summit_ID",
                            Value = summit_id
                        };
                        command.Parameters.Add(summit_idParam);

                        var result = command.ExecuteScalar();
                        variant.error = false;
                        return variant;
                    }
                    else
                    {
                        variant.error = true;
                        variant.error_message = "Вариант с такими параметрами от данного пользователя уже был!";
                        return variant;
                    }
                }
        }

        public Voice AddVoice(int user_id, int variant_id)
        {
            string sqlExpression = "AddVoice";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                Voice voice = new Voice();

                SqlCommand command1 = new SqlCommand("Select count(*) from Variant Where User_ID = @user_id and ID_Variant=@variant_id", connection);
                command1.Parameters.AddWithValue("@user_id", user_id);
                command1.Parameters.AddWithValue("@variant_id", variant_id);
                int count_voicesFromOneUser = (int)command1.ExecuteScalar();

                if (count_voicesFromOneUser == 0)
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };

                    SqlParameter user_idParam = new SqlParameter
                    {
                        ParameterName = "@User_ID",
                        Value = user_id
                    };
                    command.Parameters.Add(user_idParam);


                    SqlParameter variant_idParam = new SqlParameter
                    {
                        ParameterName = "@Variant_ID",
                        Value = variant_id
                    };
                    command.Parameters.Add(variant_idParam);

                    var result = command.ExecuteScalar();
                    voice.error = false;
                    return voice;
                }
                else
                {
                    voice.error = true;
                    voice.error_message = "Пользователь не может проголосовать за свой вариант!";
                    return voice;
                }
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

        public List<Summit> SelectSummit()
        {
            string sqlExpression = "SelectSummit";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                var reader = command.ExecuteReader();

                List<Summit> summ = new List<Summit>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Summit summit = new Summit
                        {
                            Summit_ID = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        };
                        summ.Add(summit);
                    }
                    return summ;
                }
                else
                {
                    return null;
                }

            }
        }

        public List<Variant> SelectVariant()
        {
            string sqlExpression = "SelectVariant";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                var reader = command.ExecuteReader();

                List<Variant> vari = new List<Variant>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Variant variant = new Variant
                        {
                            ID_Variant = reader.GetInt32(0),
                            StartDate = reader.GetDateTime(1),
                            FinishDate = reader.GetDateTime(2),
                            country_id = reader.GetInt32(3),
                            user_id = reader.GetInt32(4),
                            summit_id = reader.GetInt32(5)
                        };
                        vari.Add(variant);
                    }
                    return vari;
                }
                else
                {
                    return null;
                }

            }
        }
    }
}



public class Voice
{
    public int user_id;
    public int variant_id;
    public int sum;
    public bool error;
    public string error_message;
}

public class Variant
    {
        public int ID_Variant;
        public DateTime StartDate;
        public DateTime FinishDate;
        public int country_id;
        public int user_id;
        public int summit_id;
        public bool error;
        public string error_message;
}

public class Summit
    {
        public int Summit_ID;
        public string Name;
        public DateTime Date;
        public bool error;
        public string error_message;
    }

public class Auth
    {
        public bool error;
        public string error_message;
        public int id_user;
    }

public class Country
{
    public bool error;
    public string error_message;
    public int Country_ID;
    public string Name;
}





