using Shop.Data.Infrastructure;
using Shop.Model.Models;
using System.Collections.Generic;

namespace Shop.Data.Repositories
{
    public interface IProductRepositery : IRepository<Product>
    {
        IEnumerable<Product> GetByAlias(string alias);
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepositery
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Product> GetByAlias(string alias)
        {
            throw new System.NotImplementedException();
        }
    }
}