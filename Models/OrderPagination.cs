using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAssignment.Models
{
    public class OrderPagination
    {
        public Pagination Pagination { get; set; }

        public List<OrderList> OrderList { get; set; }
    }
}
