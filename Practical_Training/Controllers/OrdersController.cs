using Practical_Training.Service;
using Microsoft.AspNetCore.Mvc;

namespace Practical_Training.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }


        [HttpGet]
        public IActionResult Get()
        {
           var result = _orderService.GetAll();

           return Ok(result);
        }

        [HttpGet("details")]
        public IActionResult GetDetails()
        {
            var result = _orderService.GetDetails();

            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id )
        {
            var result = _orderService.Get(id);

            return Ok(result);
        }
    }
}