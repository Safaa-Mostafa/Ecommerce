using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data.Repositories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(EcommerceContext context) : base(context)
        {

        }
    }
}
