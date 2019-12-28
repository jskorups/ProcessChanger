using ProcessChanger.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProcessChanger.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private IList<Product> _products = new List<Product>()
        {
            new Product
            {
                Id = 1,
                PartName = "Bpilar",
                PartNumber =  "345345"
            }
        };

        public Product GetEntity(long id)
        {
            return _products.SingleOrDefault(p => p.Id == id);
        }

        public IList<Product> GetProducts()
        {
            return _products;
        }
    }
}