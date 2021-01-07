using System;
using System.Collections.Generic;

using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class WedinngGiftManagerService : BaseService, IWedinngGiftManagerService
    {
        public WedinngGiftManagerService(IRepositories uow) : base(uow)
        {

        }

        public void AddGiftToList(WeddingGift gift)
        {
            Repos.WedinngGifts.Add(gift);
             
        }

        //public void CreateGiftList(IEnumerable<(string Name, string Link)> gifts, int wedinngID)
        //{
        //    foreach (var gift in gifts)
        //    {
        //        Repos.WedinngGifts.Add(new WeddingGift()
        //        {
        //            WeddingId = wedinngID,
        //            Name = gift.Name,
        //            Link = gift.Link,
        //            IsRegistred = false,

        //        });
        //    }
             
        //}

        public void RegisterGift(int giftId, int userId)
        {
            var gift = Repos.WedinngGifts.Get(giftId);
            gift.UserId = userId;
            gift.IsRegistred = true;
            Repos.WedinngGifts.Update(gift, "IsRegistred");
            Repos.WedinngGifts.Update(gift, "UserId");

        }

        public void RemoveGiftFromList(int wedinngID)
        {
            Repos.WedinngGifts.Remove(wedinngID);
             
        }

        public void UnregisterGift(int giftId, int userId)
        {
            var gift = Repos.WedinngGifts.Get(giftId);
            gift.UserId = 0;
            gift.IsRegistred = false;
            Repos.WedinngGifts.Update(gift, "IsRegistred");
            Repos.WedinngGifts.Update(gift, "UserId");
        }
    }
}
