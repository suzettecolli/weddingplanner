using System;

using Application.Interfaces;

using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;

namespace Application.Services
{
    public class WedinngItineraryService : BaseService, IWedinngItineraryService
    {
        public WedinngItineraryService(IUnitOfWork uow) : base(uow)
        {

        }
        public void AddItem(WeddingItineraryItem item)
        {
            UnitOfWork.WedinngTasks.Add(item);
            UnitOfWork.Save();
        }

        public void ChangeState(WeddingGift gift, ItineraryState newState)
        {
            var item = UnitOfWork.WedinngTasks.Get(gift.Id);
            UnitOfWork.WedinngTasks.Update(item);
            UnitOfWork.Save();
        }

        public void RemoveItem(WeddingItineraryItem item)
        {
            UnitOfWork.WedinngTasks.Remove(item);
            UnitOfWork.Save();
        }
    }
}
