using Products.Services;
using Products.Services.Application.Response.Dtos;
using Products.Services.Core.Interface;
using Products.Services.Infrastracture.Data;

namespace Products.Services.Application.Services
{
    public class Product : IProduct
    {
        private readonly DbContextClass _dbContext;
        public Product(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public Core.Entities.Product AddProduct(Core.Entities.Product product)
        {
            var result = _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteProduct(int Id)
        {
            var filteredData = _dbContext.Products.Where(x => x.Id == Id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }

        public Core.Entities.Product GetProductById(int id)
        {
            return _dbContext.Products.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Core.Entities.Product> GetProductList()
        {
            return _dbContext.Products.ToList();
        }

        public Core.Entities.Product UpdateProduct(Core.Entities.Product product)
        {
            var result = _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return result.Entity;
        }
    }
}
