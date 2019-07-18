using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Coffee
{
    public class CoffeeDAO
    {
        private string connectionStr;

        private string getConnectionStr()
        {
            string s = ConfigurationManager.ConnectionStrings["Coffee"].ConnectionString;
            return s;
        }

        public List<CoffeeDTO> getCoffeeList()
        {
            List<CoffeeDTO> list = null;
            connectionStr = getConnectionStr();
            SqlConnection cnn = new SqlConnection(connectionStr);
            string sql = "Select CoffeeId, CoffeeName, Price, Description, CoffeeType from Coffee";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (list == null) list = new List<CoffeeDTO>();
                        CoffeeDTO dto = new CoffeeDTO
                        {
                            ID = dr.GetInt32(0),
                            Name = dr.GetString(1),
                            Price = dr.GetInt32(2),
                            Description = dr.GetString(3),
                            Type = dr.GetString(4),
                        };
                        list.Add(dto);
                    }
                }
                
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                cnn.Close();
            }
            return list;
        }
    }
}
