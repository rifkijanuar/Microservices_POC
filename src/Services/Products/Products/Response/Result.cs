

using Products.Services.Core.Entities;

namespace Products.Services.Response
{
    public class Result
    {
        public int StatusCode { get; set; }
        public int Count { get; set; }
        public dynamic Data { get; set; }
        public string Message { get; set; }
    }
}
