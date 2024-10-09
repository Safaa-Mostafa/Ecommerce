using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(EcommerceContext context) : base(context)
        {

        }
    }
}
