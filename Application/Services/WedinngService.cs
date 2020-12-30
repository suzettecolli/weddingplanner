
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

        public void AddOrganizer(int weddingId, AppUser organizer)
        {
            var wedding = UnitOfWork.Wedinngs.Get(weddingId);
            wedding.Organiser = organizer;
            UnitOfWork.Wedinngs.Update(wedding);
            UnitOfWork.Save();
        }

        public void AddWedding(Wedding wedding)
        {
            UnitOfWork.Wedinngs.Add(wedding);
            UnitOfWork.Save();
        }

        public void RemoveWedding(int weddingId)
        {
            var wedding = UnitOfWork.Wedinngs.Get(weddingId);
            UnitOfWork.Wedinngs.Remove(wedding);
            UnitOfWork.Save();
        }
    }
}
