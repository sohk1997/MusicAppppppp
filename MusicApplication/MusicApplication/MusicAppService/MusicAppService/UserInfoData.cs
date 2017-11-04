using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MusicAppService
{
    public class UserInfoData
    {
        private string connectionString;
        public UserInfo checkLogin(string username, string password)
        {
            UserInfo user = new UserInfo();
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            string query = "SELECT ID , Name, [Password] FROM [User] " +
                "WHERE Username = @Username";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@Username", username);
            try
            {
                cnn.Open();
                using (SqlDataReader myReader = cmd.ExecuteReader())
                {
                    if (myReader.Read())
                    {
                        string realPassword = myReader["Password"].ToString();
                        if (realPassword.Equals(password))
                        {
                            user.Name = myReader["Name"].ToString();
                            user.ID = myReader["ID"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
            return user;
        }

        public bool registerAccount(UserInfo user)
        {
            bool check = false;
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            string sql = "insert into [User](Username, Name, Password, [E-mail]) values (@Username, @Name, @Password, @Email)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            try
            {
                cnn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    check = true;
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return check;
        }
        public bool CheckDupUsername(string username)
        {
            bool check = false;
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            string sql = "select Username from [User] where Username=@Username";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Username", username);
            try
            {
                cnn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    check = true;
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return check;
        }
    }
}