using System;
using System.Collections.Generic;

using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class WedinngGiftManagerService : BaseService, IWedinngGiftManagerService
    {
        public WedinngGiftManagerService(IUnitOfWork uow) : base(uow)
        {

        }

        public void AddGiftToList(WeddingGift gift, int wedinngID)
        {
            throw new NotImplementedException();
        }

        public void CreateGiftList(IEnumerable<(string Name, string Link)> gifts, int wedinngID)
        {
            throw new NotImplementedException();
        }

        public bool RegisterGift(string giftId, string userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveGiftFromList(WeddingGift gift, int wedinngID)
        {
            throw new NotImplementedException();
        }
    }
}
