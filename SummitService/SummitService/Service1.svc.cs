using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace SummitService
{
    public class Service1 : IService1
    {
        //readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\npartyko\Source\Repos\sammit\SummitService\SummitService\App_Data\SummitDB.mdf;Integrated Security=True";
        //readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Юрий\Desktop\8 семестр\Проектирование ИСУ\репоз\SummitService\SummitService\App_Data\SummitDB.mdf;Integrated Security=True";
        public Auth Authorisation(string Login, string Password)
        {
            Auth auth = new Auth();
            if (FindByLoginUsers(Login, Password))
            {
                using (SummitDBEntity summit = new SummitDBEntity())
                {
                    User use = summit.Users
                               .Where(s => s.Login == Login)
                               .Where(p => p.Password == Password)
                               .FirstOrDefault();
                    if (use != null)
                    {
                        auth.error = false;
                        auth.error_message = null;
                        auth.id_user = use.ID_User;
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
            using (SummitDBEntity summit = new SummitDBEntity())
            {
                User use = summit.Users
                           .Where(s => s.Login == Login)
                           .Where(p => p.Password == Password)
                           .FirstOrDefault();
                if (use != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public Summit AddSummit(Summit sum)
        {
            using (SummitDBEntity summit = new SummitDBEntity())
            {
                var count = summit.Summits
                            .Where(s => s.Name == sum.Name)
                            .Count();
                if (count == 0)
                {
                    summit.Summits.Add(sum);
                    summit.SaveChanges();
                }   
            }
            return sum;
        }

        public Country AddCountry(Country cou)
        {
            using (SummitDBEntity summit = new SummitDBEntity())
            {
                var count = summit.Countries
                            .Where(s => s.Name == cou.Name)
                            .Count();
                if (count == 0)
                {
                    summit.Countries.Add(cou);
                    summit.SaveChanges();
                }
            }
            return cou;
        }

        public Variant AddVariant(Variant va)
        {
            using (SummitDBEntity summit = new SummitDBEntity())
            {
                var count = summit.Variants
                .Where(s => s.User_ID == va.User_ID)
                .Where(s => s.Summit_ID == va.Summit_ID)
                .Where(s => s.Country_ID == va.Country_ID)
                .Count();
                if (count == 0)
                {
                    summit.Variants.Add(va);
                    summit.SaveChanges();
                }
                return va;
            }
        }

        public Voice AddVoice(Voice vo)
        {
            using (SummitDBEntity summit = new SummitDBEntity())
            {
                var count = summit.Voices
                .Where(s => s.User_ID == vo.User_ID)
                .Where(s => s.Variant_ID == vo.Variant_ID)
                .Count();
                if (count == 0)
                {
                    summit.Voices.Add(vo);
                    summit.SaveChanges();
                }
                return vo;
            }
        }
        
        /*public List<Voice> Summarizing()
        {
            //string sqlExpression = "Summarizing";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            using (SummitDBEntity summit = new SummitDBEntity())
            {

                /*connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };


                var reader = command.ExecuteReader();

                List<Voice> summarizing = new List<Voice>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Voice cli = new Voice
                        {

                            variant_id = reader.GetInt32(0),
                            sum = reader.GetInt32(1),
                            country_name = reader.GetString(2),
                            start_date = reader.GetDateTime(3),
                            finish_date = reader.GetDateTime(4)

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
        }*/

        public List<Country> SelectCountry()
        {
            using(SummitDBEntity summit = new SummitDBEntity())
            {
                List<Country> co = summit.Countries.ToList();
                return co;
            }
        }

        public void DeleteAllVoices()
        {
            using (SummitDBEntity summit = new SummitDBEntity())
            {
                foreach (var s in summit.Voices)
                summit.Voices.Remove(s);
                summit.SaveChanges();
            }
        }

        public List<Summit> SelectSummit()
        {
            using (SummitDBEntity summit = new SummitDBEntity())
            {
                List<Summit> su = summit.Summits.ToList();
                return su;
            }
        }
/*
        public ObservableCollection<Variant> SelectVariant(int summit_id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"Select Variant.ID_Variant as 'id', Variant.StartDate as 'StartDate', Variant.FinishDate as 'FinishDate', Country.Name as 'Country', [User].FIO as 'User'  from Variant
                                inner join Country on Country.ID_Country = Variant.Country_ID
                                inner join [User] on [User].ID_User = Variant.User_ID
                                where Summit_ID = @summit_id";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@summit_id", summit_id);



                var reader = command.ExecuteReader();

                ObservableCollection<Variant> summ = new ObservableCollection<Variant>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Variant variant = new Variant
                        {
                            variant_id = reader.GetInt32(0),
                            StartDate = reader.GetDateTime(1),
                            FinishDate = reader.GetDateTime(2),
                            country = reader.GetString(3),
                            user = reader.GetString(4)
                        };
                        summ.Add(variant);
                    }
                    return summ;
                }
                else
                {
                    return null;
                }

            }
        }

        public bool CheckVoice(int user_id, int summit_id) {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"Select Voice.ID_Voice as 'ID_voice' , Voice.User_ID as 'User_id', Variant.Summit_ID from Voice 
                                inner join Variant on  Variant.ID_Variant = Voice.Variant_ID
                                where Voice.User_ID = @user_id and Variant.Summit_ID = @summit_id";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@summit_id", summit_id);
                command.Parameters.AddWithValue("@user_id", user_id);


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

        }*/
    }
}

public class Auth
    {
        public bool error;
        public string error_message;
        public int id_user;
    }






