using Products.Services.Core.Entities;

namespace Products.Services.Core.Interface
{
    public interface IProduct
    {
        public IEnumerable<Product> GetProductList();
        public Product GetProductById(int id);
        public Product AddProduct(Product product);
        public Product UpdateProduct(Product product);
        public bool DeleteProduct(int Id);
    }
}
