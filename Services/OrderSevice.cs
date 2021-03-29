using CodeAssignment.Models;
using CodeAssignment.Repository;
using CodeAssignment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAssignment.Services
{
    public class OrderSevice:IOrderService
    {
        private readonly CodeAssessmentContext _context;
        private readonly IOrderRepository _orderRepository;
        public OrderSevice(CodeAssessmentContext context, IOrderRepository orderRepository)
        {
            _context = context;
            _orderRepository = orderRepository;
        }

        public string CreateOrder(OrderViewModel orderVM)
        {
            try
            {
                var usId = _context.Customers.Where(x => x.Email.Equals(orderVM.Email)).Select(s => s.Id).FirstOrDefault();
                foreach(var item in orderVM.Item)
                {
                    var prod = _orderRepository.GetProduct(item);
                    Order order = new Order
                    {
                      
                        ItemId = prod.Id,
                        
                        UserId = usId,
                        IsActive = true,
                        IsCreatedOn = DateTime.Now
                    };
                    var result = _orderRepository.CreateOrder(order);
                }

                return "Success";

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public OrderPagination GetOrderList(int currentPage = 1, int pageSize = 5)
        {
            try
            {
                OrderPagination model = new OrderPagination();

                var orderList = _orderRepository.GetOrderList(currentPage, pageSize);

                model.OrderList = orderList;
                int totalCount = orderList.Count();
                var page = new Pagination()
                {
                    Count = totalCount,
                    CurrentPage = currentPage,
                    PageSize = pageSize,
                    TotalPages = (int)Math.Ceiling(decimal.Divide(totalCount, pageSize))
                };

                model.Pagination = page;
                return model;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
