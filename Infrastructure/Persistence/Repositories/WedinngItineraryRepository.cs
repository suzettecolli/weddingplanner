using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence.DataMappers;

namespace Infrastructure.Persistence.Repositories
{
    public class WedinngItineraryRepository : Repository<WeddingItineraryItem>, IWedinngItineraryRepository
    {
        public WedinngItineraryRepository(WeddingItineraryDataMapper weddingItineraryDataMapper):base(weddingItineraryDataMapper)
        {

        }
    }
}
