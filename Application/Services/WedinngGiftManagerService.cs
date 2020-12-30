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

        public void AddGiftToList(WeddingGift gift, int wedinngID) //FIX proc id v parametrtu ?
        {
            Repos.WedinngGifts.Add(gift);
             
        }

        public void CreateGiftList(IEnumerable<(string Name, string Link)> gifts, int wedinngID)
        {
            foreach (var gift in gifts)
            {
                Repos.WedinngGifts.Add(new WeddingGift()
                {
                    WeddingId = wedinngID,
                    Name = gift.Name,
                    Link = gift.Link,
                    IsRegistred = false,

                });
            }
             
        }

        public void RegisterGift(int giftId, int userId)
        {
            var gift = Repos.WedinngGifts.Get(giftId);
            gift.UserId = userId;
            Repos.WedinngGifts.Update(gift);
             
        }

        public void RemoveGiftFromList(WeddingGift gift, int wedinngID)
        {
            Repos.WedinngGifts.Remove(gift);
             
        }
    }
}
