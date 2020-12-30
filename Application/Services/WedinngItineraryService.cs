using System;

using Application.Interfaces;

using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;

namespace Application.Services
{
    public class WedinngItineraryService : BaseService, IWedinngItineraryService
    {
        public WedinngItineraryService(IRepositories uow) : base(uow)
        {

        }
        public void AddItem(WeddingItineraryItem item)
        {
            Repos.WedinngTasks.Add(item);
             
        }

        public void ChangeState(WeddingGift gift, ItineraryState newState)
        {
            var item = Repos.WedinngTasks.Get(gift.Id);
            Repos.WedinngTasks.Update(item);
             
        }

        public void RemoveItem(WeddingItineraryItem item)
        {
            Repos.WedinngTasks.Remove(item);
             
        }
    }
}
