using CodeAssignment.Models;
using CodeAssignment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAssignment.Services
{
    public interface ICustomerService
    {
        string RegisterCustomer(CustomerViewModel cusVM);
    }
}
