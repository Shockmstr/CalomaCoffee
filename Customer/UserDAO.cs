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

        public bool UpdateUser(UserDTO dto)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "Update [User] set Password=@Password, Role=@Role, Fullname=@Fullname, Email=@Email where  Username=@Username";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Username", dto.Username);
            cmd.Parameters.AddWithValue("@Password", dto.Password);
            cmd.Parameters.AddWithValue("@Role", dto.Role);
            cmd.Parameters.AddWithValue("@Fullname", dto.Fullname);
            cmd.Parameters.AddWithValue("@Email", dto.Email);
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
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
                con.Close();
            }
        }

        public bool DeleteUser(string username)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "Delete [User] where Username=@User";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@User", username);
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int row = cmd.ExecuteNonQuery() ;
                return row > 0 ; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable searchAllByRole(string username)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "Select * from [User] where Role like @Role";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Role", "%" + username + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dbResult = new DataTable();
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(dbResult);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
            return dbResult;
        }

        public DataTable searchAllByRoleAll()
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "Select * from [User]";
            SqlCommand cmd = new SqlCommand(sql, con);
          
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dbResult = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(dbResult);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
            return dbResult;
        }
        public DataTable searchData(string name)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "Select * where Username like @User or Role like @User";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@User", "%" + name + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dbResult = new DataTable();

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(dbResult);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
            return dbResult;

        }


        public DataTable searchByUserName(string name)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "Select * from [User] where Username like @User or Role like @User or Fullname like @User or Email like @User";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@User","%" + name + "%");
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dbResult = new DataTable();

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(dbResult);
                
            }
            catch (Exception e)
            {
                throw e; 
            }
            finally
            {
                con.Close();
            }
            return dbResult;

        }
        

    }
}
