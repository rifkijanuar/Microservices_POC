using Microsoft.AspNetCore.Mvc;
using Products.Services.Core.Interface;
using Products.Services.Core.Entities;
using Products.Services.Response;

namespace Products.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct productService;
        private Result result;
        public ProductController(IProduct _productService)
        {
            productService = _productService;
            result = new Result();
        }

        [HttpGet]
        public ActionResult<Result> ProductList()
        {
            try
            {
                var productList = productService.GetProductList();

                result = new Result()
                {
                    StatusCode = 200,
                    Count = productList.Count(),
                    Data = productList,
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

        [HttpGet("{id}")]
        public ActionResult<Result> GetProductById(int id)
        {
            try
            {
                var productDetail = productService.GetProductById(id);

                result = new Result()
                {
                    StatusCode = 200,
                    Data = productDetail,
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

        [HttpPost]
        public ActionResult<Result> AddProduct(Product product)
        {
            try
            {
                var addProduct = productService.AddProduct(product);

                result = new Result()
                {
                    StatusCode = 200,
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

        [HttpPut]
        public ActionResult<Result> UpdateProduct(Product product)
        {
            try
            {
                var updateProduct = productService.UpdateProduct(product);

                result = new Result()
                {
                    StatusCode = 200,
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
        [HttpDelete("{id}")]
        public ActionResult<Result> DeleteProduct(int id)
        {
            try
            {
                var deleteProduct = productService.DeleteProduct(id);

                result = new Result()
                {
                    StatusCode = 200,
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
