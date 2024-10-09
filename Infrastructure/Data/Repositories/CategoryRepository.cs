using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(EcommerceContext context) : base(context)
        {

        }
    }
}
