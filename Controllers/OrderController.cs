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
    public class OrderController : ControllerBase
    {
        private readonly CodeAssessmentContext _context;

        private readonly IOrderService _orderService;

        public OrderController(CodeAssessmentContext codeAssessmentContext, IOrderService orderService)
        {
            _context = codeAssessmentContext;
            _orderService = orderService;
        }


        [HttpPost("CreateOrder")]
        public ActionResult CreateOrder(OrderViewModel orderVM)
        {
            string result = _orderService.CreateOrder(orderVM);
            if (result == "Success")
            {
                return Ok("Registered Successfully.");
            }
            return Ok();
        }


        [HttpGet("GetOrderList")]
        public ActionResult<OrderPagination> GetOrderList(int currentPage = 1, int pageSize = 5)
        {
            var result = _orderService.GetOrderList(currentPage, pageSize);
            return Ok(result);
        }
    }
}
