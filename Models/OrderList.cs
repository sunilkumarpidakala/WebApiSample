using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAssignment.Models
{
    public class OrderList
    {
        public long? OrderId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public long? PhoneNumber { get; set; }
        public string Product { get; set; }
        public decimal? Amount { get; set; }

       
    }
}
