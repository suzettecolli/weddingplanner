using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IWedinngGiftManagerService
    {
        //public void CreateGiftList(IEnumerable<(string Name, string Link)> gifts, int wedinngID);
        public void AddGiftToList(WeddingGift gift);
        public void RemoveGiftFromList(int wedinngID);
        public void RegisterGift(int giftId, int userId);
        public void UnregisterGift(int giftId, int userId);
    }
}
