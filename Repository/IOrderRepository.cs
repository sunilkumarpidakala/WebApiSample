using CodeAssignment.Models;
using CodeAssignment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAssignment.Repository
{
    public interface IOrderRepository
    {
        Item GetProduct(ItemList product);
        string CreateOrder(Order orderViewModel);
        List<OrderList> GetOrderList(int currentPage = 1, int pageSize = 5);

    }
}
