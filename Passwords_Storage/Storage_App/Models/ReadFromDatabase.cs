using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Storage_App.Models
{
    public static class ReadFromDatabase
    {
        public static List<Work_Area> Read_All_Infos()
        {
            // An objects of ADO .NET:
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader dReader = null;
            List<Work_Area> list = new List<Work_Area>();

            try
            {
                using (conn = new SqlConnection(ConfigurationManager.ConnectionStrings["My_Context"].ConnectionString))
                {
                    using (cmd = new SqlCommand("SELECT * from Work_Area", conn))
                    {
                        conn.Open();
                        dReader = cmd.ExecuteReader();

                        while (dReader.Read())
                        {
                            Work_Area area = new Work_Area();
                            area.Id = Convert.ToInt32(dReader["Id"]);
                            area.Site_Name = dReader["Site_Name"].ToString();
                            area.Email = dReader["Email"].ToString();
                            area.Login = dReader["Login"].ToString();
                            area.Password = dReader["Password"].ToString();
                            area.URL = dReader["URL"].ToString();
                            area.Phone = dReader["Phone"].ToString();
                            area.Comments = dReader["Comments"].ToString();

                            list.Add(area);
                        }
                    }
                }
            }
            catch (DataException dex)
            {
                MessageBox.Show(dex.Message, "System Exception..Failed..",
                     MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                dReader.Close();
                conn.Close();
            }

            return list;
        }

        // Read All Users:
        public static List<User> Read_All_Users()
        {
            // An objects of ADO .NET:
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader dReader = null;
            List<User> list = new List<User>();

            try
            {
                using (conn = new SqlConnection(ConfigurationManager.ConnectionStrings["My_Context"].ConnectionString))
                {
                    using (cmd = new SqlCommand("SELECT * from Users", conn))
                    {
                        conn.Open();
                        dReader = cmd.ExecuteReader();

                        while (dReader.Read())
                        {
                            User user = new User();
                            user.Id = Convert.ToInt32(dReader["Id"]);
                            user.First_Name = dReader["First_Name"].ToString();
                            user.Last_Name = dReader["Last_Name"].ToString();
                            user.Login = dReader["Login"].ToString();
                            user.Password = dReader["Password"].ToString();
                            user.Role = dReader["Role"].ToString();
                            user.Age = dReader["Age"].ToString();
                            user.Date_Register = Convert.ToDateTime(dReader["Date_Register"].ToString());

                            list.Add(user);
                        }
                    }
                }
            }
            catch (DataException dex)
            {
                MessageBox.Show(dex.Message, "System Exception..Failed..",
                     MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                dReader.Close();
                conn.Close();
            }

            return list;
        }
    }
    }
