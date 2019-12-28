using ProcessChanger.Entities;
using System.Collections.Generic;

namespace ProcessChanger.Repositories
{
    public interface IProductRepository
    {
        Product GetEntity(long id);
        IList<Product> GetProducts();
    }
}

