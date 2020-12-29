
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class WedinngService : BaseService, IWedinngService
    {
        public WedinngService(IUnitOfWork uow) : base(uow)
        {

        }

        public void AddOrganizer(AppUser organizer)
        {
            throw new System.NotImplementedException();
        }

        public void AddWedding(Wedding wedding)
        {
            throw new System.NotImplementedException();
        }

        public void ArchiveWedding(int weddingId)
        {
            throw new System.NotImplementedException();
        }
    }
}
