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

        public void AddGiftToList(WeddingGift gift, int wedinngID) //FIX proc id v parametrtu ?
        {
            UnitOfWork.WedinngGifts.Add(gift);
            UnitOfWork.Save();
        }

        public void CreateGiftList(IEnumerable<(string Name, string Link)> gifts, int wedinngID)
        {
            foreach (var gift in gifts)
            {
                UnitOfWork.WedinngGifts.Add(new WeddingGift()
                {
                    WeddingId = wedinngID,
                    Name = gift.Name,
                    Link = gift.Link,
                    IsRegistred = false,

                });
            }
            UnitOfWork.Save();
        }

        public void RegisterGift(int giftId, int userId)
        {
            var gift = UnitOfWork.WedinngGifts.Get(giftId);
            gift.UserId = userId;
            UnitOfWork.WedinngGifts.Update(gift);
            UnitOfWork.Save();
        }

        public void RemoveGiftFromList(WeddingGift gift, int wedinngID)
        {
            UnitOfWork.WedinngGifts.Remove(gift);
            UnitOfWork.Save();
        }
    }
}
