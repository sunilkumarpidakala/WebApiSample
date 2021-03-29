using CodeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAssignment.Repository
{
    public interface ICustomerRepository
    {
        string RegisterCustomer(Customer customer);
    }
}
