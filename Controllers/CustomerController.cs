using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAssignment.Models;
using CodeAssignment.Services;
using CodeAssignment.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CodeAssessmentContext _context;
        private readonly ICustomerService _customerService;
       
        public CustomerController(CodeAssessmentContext codeAssessmentContext, ICustomerService customerService)
        {
            _context = codeAssessmentContext;
            _customerService = customerService;
        }

       

        [HttpPost("Register")]
        public IActionResult Register(CustomerViewModel cusVM)
        {
            if (ModelState.IsValid)
            {
                string result = _customerService.RegisterCustomer(cusVM);
                if (result == "Success")
                {
                    return Ok("Registered Successfully.");
                }
                return StatusCode(409);
            }
           
                return BadRequest(cusVM);
            
         
        }

       
    }
}
