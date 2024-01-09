using Microsoft.AspNetCore.Mvc;
using Orders.Services.Model;
using Orders.Services.Interface;
using Newtonsoft.Json.Linq;
using Orders.Services.Response;

namespace Orders.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;
        private Result result;
        public OrderController(IOrderService _orderService)
        {
            orderService = _orderService;
            result = new Result();
        }

        [HttpPost]
        public Order AddOrder(Order order)
        {
            return orderService.AddProduct(order);
        }

        [HttpGet]
        public ActionResult<Result> GetData()
        {
            try
            {
                var orderList = orderService.GetOrderList();

                result = new Result()
                {
                    StatusCode = 200,
                    Data = orderList,
                    Message = "Succes"
                };
            }
            catch (Exception ex)
            {
                result = new Result()
                {
                    StatusCode = 500,
                    Message = ex.ToString()
                };
            }
            return Ok(result);
        }
    }
}
