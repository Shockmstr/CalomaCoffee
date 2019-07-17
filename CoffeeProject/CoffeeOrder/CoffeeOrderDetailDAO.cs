using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CoffeeOrder
{
    class CoffeeOrderDetailDAO
    {
        public string connectionStr;
        public CoffeeOrderDetailDAO()
        {
            connectionStr = getConnectionStr();
        }
        public string getConnectionStr()
        {
            string s = "server=DESKTOP-0VJ110H\\TOAN;database=CSharpCoffee;user=sa;password=123456789";
            return s;
        }
        // get id and delete 
        public bool deleteCoffee(int dto)
        {
            SqlConnection cnn = new SqlConnection(connectionStr);
            string sql = "delete CoffeeOrderDetail where CoffeeOrderId=@CoffeeOrderID";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@CoffeeOrderID", dto);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        // update coffee
        public bool updateCoffee(CoffeeOrderDetailDTO dto)
        {
            SqlConnection cnn = new SqlConnection(connectionStr);
            string sql = "update CoffeeOrderDetail set CoffeeId = @coffeeId,Quantity= @quantity,Price = @Price where CoffeeOrderId = @orderID";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@orderID", dto.OrderID);
            cmd.Parameters.AddWithValue("@coffeeId", dto.CoffeeID);
            cmd.Parameters.AddWithValue("@quantity", dto.Quantity);
            cmd.Parameters.AddWithValue("@Price", dto.Price);
            if(cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count >0);
        }
        // get username and show id of customer
        public DataTable getOrderOfCustomer(String username)
        {
            SqlConnection cnn = new SqlConnection(connectionStr);
            string sql = "Select * from CoffeeOrderDetail where CoffeeOrderId IN(select CoffeeOrderId from CoffeeOrder where Username = @User)";       
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@User", username);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCoffee = new DataTable();
            try
            {
                if(cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtCoffee);
            }catch(Exception e)
            {
                throw new Exception(e.Message + "");
            }
            finally
            {
                cnn.Close();
            }
            return dtCoffee;
        }
     }
}
