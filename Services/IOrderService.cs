using CodeAssignment.Models;
using CodeAssignment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAssignment.Services
{
    public interface IOrderService
    {
        string CreateOrder(OrderViewModel orderViewModel);
        OrderPagination GetOrderList(int currentPage = 1, int pageSize = 10);

    }
}
