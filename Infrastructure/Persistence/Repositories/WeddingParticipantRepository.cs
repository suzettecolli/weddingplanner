using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence.DataMappers;

namespace Infrastructure.Persistence.Repositories
{
    public class WeddingParticipantRepository : Repository<WeddingParticipant>, IWeddingParticipantRepository
    {
        public WeddingParticipantRepository(WeddingParticipantDataMapper weddingParticipantDataMapper) : base(weddingParticipantDataMapper)
        {

        }
    }
}
