
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class WedinngService : BaseService, IWedinngService
    {
        public WedinngService(IRepositories uow) : base(uow)
        {

        }

        public void AddOrganizer(int weddingId, AppUser organizer)
        {
            var wedding = Repos.Wedinngs.Get(weddingId);
            wedding.Organiser = organizer;
            Repos.Wedinngs.Update(wedding);
             
        }

        public void AddWedding(Wedding wedding)
        {
            Repos.Wedinngs.Add(wedding);
             
        }

        public void RemoveWedding(int weddingId)
        {
            var wedding = Repos.Wedinngs.Get(weddingId);
            Repos.Wedinngs.Remove(wedding);
             
        }
    }
}
