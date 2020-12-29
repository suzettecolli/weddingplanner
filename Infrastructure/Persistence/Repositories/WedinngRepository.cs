using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence.DataMappers;

namespace Infrastructure.Persistence.Repositories
{
    public class WedinngRepository : Repository<Wedding>, IWedinngRepository
    {
        public WedinngRepository(WeddingDataMapper weddingDataMapper) : base(weddingDataMapper)
        {

        }
    }
}
