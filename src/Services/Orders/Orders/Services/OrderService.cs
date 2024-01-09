using Orders.Services.Model;
using Orders.Services.Interface;
using RestSharp;
using Orders.Services.Data;
using Newtonsoft.Json;
using Orders.Services.Model.Dtos;

namespace Orders.Services.Services
{
    public class OrderService : IOrderService
    {
        protected readonly IConfiguration _configuration;
        private string _urlProduct;
        private string _urlUser;
        private readonly DbContextClass _dbContext;

        public OrderService(IConfiguration configuration, DbContextClass dbContext)
        {
            _configuration = configuration;
            _urlProduct = _configuration.GetSection("Url").GetSection("Product").Value;
            _urlUser = _configuration.GetSection("Url").GetSection("User").Value;
            _dbContext = dbContext;
        }
        public Order AddProduct(Order order)
        {
            var restClientOption = new RestClientOptions(_urlProduct)
            {
                RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true
            };

            var clientProduct = new RestClient(restClientOption);
            var requestProduct = new RestRequest("/api/product");
            var responseProduct = clientProduct.ExecuteGet(requestProduct);

            var clientUser = new RestClient(restClientOption);
            var requestUser = new RestRequest("/api/users");
            var responseUser = clientProduct.ExecuteGet(requestUser);

            //var dataProduct = JsonSerializer.Deserialize<ProductDto>(responseProduct.Content);
            //var data = JsonSerializer.Serialize(responseProduct);
            //var data2 = JsonSerializer.Deserialize<Order>(data);
            //JObject jsonObject = JObject.Parse(data);
            //JsonContent jcontent = JsonContent.Create(jsonObject);



            var result = _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public string GetOrderList()
        {
            var restClientOption = new RestClientOptions(_urlProduct)
            {
                RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true
            };

            var clientProduct = new RestClient(restClientOption);
            var request = new RestRequest("/api/product");
            var response = clientProduct.ExecuteGet(request);
            var dataProduct = JsonConvert.DeserializeObject<ProductDto.Application>(response.ContentType);

            return response.Content;
        }
    }
}
