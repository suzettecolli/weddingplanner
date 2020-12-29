using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence.DataMappers;

namespace Infrastructure.Persistence.Repositories
{
    public class WedinngGiftRepository: Repository<WeddingGift>, IWedinngGiftRepository
    {
        public WedinngGiftRepository(WeddingGiftDataMapper weddingGiftDataMapper) : base(weddingGiftDataMapper)
        {

        }
    }
}
