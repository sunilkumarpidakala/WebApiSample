using CodeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAssignment.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CodeAssessmentContext _context;
        public CustomerRepository(CodeAssessmentContext context)
        {
            _context = context;
        }

        public string RegisterCustomer(Customer customer)
        {
            if (_context != null && !_context.Customers.Any(x => x.Email.Equals(customer.Email)))
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return "Success";
            }
            else
                return "Failed";
        }

       
    }
}
