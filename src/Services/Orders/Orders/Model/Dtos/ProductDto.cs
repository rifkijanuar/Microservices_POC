namespace Orders.Services.Model.Dtos
{
    public class ProductDto
    {
        public class Data
        {
            public string productName { get; set; }
            public string productDescription { get; set; }
            public int productPrice { get; set; }
            public int productStock { get; set; }
            public int id { get; set; }

        }
        public class Application
        {
            public int statusCode { get; set; }
            public int count { get; set; }
            public IList<Data> data { get; set; }
            public string message { get; set; }

        }
    }
}
