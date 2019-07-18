using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrder
{
    class CoffeeOrderDetailDTO
    {
        public int OrderID { get; set; }
        public int CoffeeID { get; set; }
        public int Quantity { get; set; }
        public long TotalPrice { get; set; }
    }
}
