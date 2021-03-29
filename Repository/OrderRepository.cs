using CodeAssignment.Models;
using CodeAssignment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAssignment.Repository
{
    public class OrderRepository:IOrderRepository
    {
        private readonly CodeAssessmentContext _context;
        public OrderRepository(CodeAssessmentContext context)
        {
            _context = context;
        }
        public string CreateOrder(Order order)
        {
            if (_context != null)
            {
                
                _context.Orders.Add(order);
                _context.SaveChanges();
                return "Success";
            }
            else
                return "Failed";
        }
    
        public Item GetProduct(ItemList item)
        {
           var prod= _context.Items.Where(x => x.Name == item.Item).Select(S=> new Item()
           {
               Id=S.Id,
               Name=S.Name,
               Amount=S.Amount,
               IsActive=S.IsActive
           }).FirstOrDefault();
            if (prod == null)
            {
                Item newProd = new Item()
                {
                    Name = item.Item,
                    Amount=item.Amount,
                    IsActive = true
                };
                _context.Items.Add(newProd);
                _context.SaveChanges();
                return newProd;
            }
            \

            return prod;
        }
      
        public List<OrderList> GetOrderList(int currentPage = 1, int pageSize = 5)
        {
            List<OrderList> orderList = (from O in _context.Orders
                                         join C in _context.Customers on O.UserId equals C.Id
                                         join P in _context.Items on O.ItemId equals P.Id
                                         select new OrderList()
                                         {
                                             OrderId = O.Id,
                                             CustomerName = C.Name,
                                             Email = C.Email,
                                             PhoneNumber = C.PhoneNumber,
                                             Product = P.Name,
                                             Amount = P.Amount
                                         }).OrderBy(x => x.OrderId).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            return orderList;
        }
    }
}
