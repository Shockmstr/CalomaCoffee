using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace User
{
    public class UserDAO
    {
        private string connectionStr;
        public UserDAO()
        {
            connectionStr = getConnectionStr();
        }

        private string getConnectionStr()
        {
            string s = ConfigurationManager.ConnectionStrings["Coffee"].ConnectionString;
            return s;
        }

        public string CheckLogin(string username, string password)
        {
            string role = "";
            SqlConnection cnn = new SqlConnection(connectionStr);
            string SQL = "Select Role from [User] where Username=@User and Password=@Pass";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@User", username);
            cmd.Parameters.AddWithValue("@Pass", password);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        role = dr.GetString(0);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return role;
        }

        public string FindPassword(string email)
        {
            string pass = "";
            SqlConnection cnn = new SqlConnection(connectionStr);
            string SQL = "Select Password from [User] where Email=@Email";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@Email", email);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        pass = dr.GetString(0);
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
            return pass;
        }

        public bool CreateUser(UserDTO dto)
        {
            SqlConnection cnn = new SqlConnection(connectionStr);
            string SQL = "Insert [User] values(@Username, @Password, @Role, @Fullname, @Email)";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@Username", dto.Username);
            cmd.Parameters.AddWithValue("@Password", dto.Password);
            cmd.Parameters.AddWithValue("@Fullname", dto.Fullname);
            cmd.Parameters.AddWithValue("@Email", dto.Email);
            cmd.Parameters.AddWithValue("@Role", dto.Role);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                int row = cmd.ExecuteNonQuery();
                return row > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cnn.Close();
            }           
        }
    }
}
