using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    public class Order
    {
        public int Id { get; set; }
        public decimal totalAmount { get; set; } 
        public decimal discount { get; set; }
        public int Quantity { get; set; }   

    }
}
