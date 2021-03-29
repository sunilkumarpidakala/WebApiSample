using CodeAssignment.Models;
using CodeAssignment.Services;
using CodeAssignment.ViewModels;
using System;
using System.Linq;

namespace CodeAssignment.Repository
{

    public class CustomerService : ICustomerService
    {
        private readonly CodeAssessmentContext _context;
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(CodeAssessmentContext context, ICustomerRepository customerRepository)
        {
            _context = context;
            _customerRepository = customerRepository;
        }
        public string RegisterCustomer(CustomerViewModel cusVM)
        {
            try
            {
                Customer customer = new Customer()
                {
                    Name = cusVM.Name,
                    Address = cusVM.Address,
                    City = cusVM.City,
                    Country = cusVM.Country,
                    Email = cusVM.Email,
                    PhoneNumber = cusVM.PhoneNumber,
                    IsActive = true,
                    IsCreatedOn = DateTime.Now
                };
                return _customerRepository.RegisterCustomer(customer);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
    }
}
