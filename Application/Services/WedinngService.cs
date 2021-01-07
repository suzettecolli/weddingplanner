
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using System.ComponentModel;

namespace Application.Services
{
    public class WedinngService : BaseService, IWedinngService
    {
        public WedinngService(IRepositories uow) : base(uow)
        {

        }

        //public void AddOrganizer(int weddingId, int organizerId)
        //{
        //    var wedding = Repos.Wedinngs.Get(weddingId);
        //    wedding.OrganiserId = organizerId;
        //    Repos.Wedinngs.Update(wedding, "Organiser");

        //}

        public void AddWedding(Wedding wedding)
        {
            Repos.Wedinngs.Add(wedding);
             
        }

        public Wedding GetWedding(int id)
        {
            var wedding = Repos.Wedinngs.Get(id);
            return wedding;
        }

        public int GetLastWeddingId()
        {
            var id = Repos.Wedinngs.GetLastID();
            return id;
        }

        public void RemoveWedding(int weddingId)
        {
            Repos.Wedinngs.Remove(weddingId);
             
        }
    }
}
