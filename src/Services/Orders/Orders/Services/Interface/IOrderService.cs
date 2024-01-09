using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Orders.Services.Model;

namespace Orders.Services.Interface
{
    public interface IOrderService
    {
        public Order AddProduct(Order order);
        public string GetOrderList();
    }
}
