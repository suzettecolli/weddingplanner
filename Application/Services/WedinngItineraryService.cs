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
            throw new NotImplementedException();
        }

        public void ChangeState(WeddingGift gift, ItineraryState newState)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(WeddingItineraryItem item)
        {
            throw new NotImplementedException();
        }
    }
}
