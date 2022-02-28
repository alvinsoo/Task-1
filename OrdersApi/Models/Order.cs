using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Models
{
    public class Order
    {  
        public int Id {get;set;}
        public string Details { get; set; }
        public double Price { get; set; }
        public string CustomerId { get; set; }

    }

}
