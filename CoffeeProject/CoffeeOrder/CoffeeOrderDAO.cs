using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CoffeeOrder
{
    class CoffeeOrderDAO
    {
        string strString;
        public CoffeeOrderDAO()
        {
            strString = getConnectionString();
        }
        public string getConnectionString()
        {
            string cnn = "server=DESKTOP-0VJ110H\\TOAN;database=CSharpCoffee;user=sa;password=123456789";
            return cnn;
        }
        // status (0 => ;1=> ;2=>)

        // get all order 
        public DataTable GetAllCoffee()
        {
            string sql = "select * from CoffeeOrder";
            SqlConnection cnn = new SqlConnection(strString);
            SqlCommand cmd = new SqlCommand(sql,cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                if(cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dt);
            }catch(Exception e)
            {
                throw new Exception(e.Message + "");
            }
            finally
            {
                cnn.Close();
            }
            return dt;
        }
        // delete order 
        public bool deleteCoffee(int id)
        {
            string sql = "delete CoffeeOrder where CoffeeOrderId =@ID";
            SqlConnection cnn = new SqlConnection(strString);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ID", id);
            if(cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count >0);
        }
        // update order
        public bool updateCoffee(int status, int id) {
            string sql = "update CoffeeOrder set status = @status where CoffeeOrderId =@ID";
            SqlConnection cnn = new SqlConnection(strString);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@status", status);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        // find order coffee
        public DataTable findCoffee(int ID)
        {
            string sql = "select * from CoffeeOrder where CoffeeOrderId=@ID ";
            SqlConnection cnn = new SqlConnection(strString);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dt;
        }

    }
}
