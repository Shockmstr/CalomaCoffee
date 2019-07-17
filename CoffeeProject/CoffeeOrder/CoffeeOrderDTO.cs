using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrder
{
    public class CoffeeOrderDTO
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public int status { get; set; }

    }
}
