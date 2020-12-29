using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence.DataMappers;

namespace Infrastructure.Persistence.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(AddressDataMapper addressDataMapper) : base(addressDataMapper)
        {

        }
    }
}
