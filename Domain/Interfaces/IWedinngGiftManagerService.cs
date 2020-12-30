using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IWedinngGiftManagerService
    {
        public void CreateGiftList(IEnumerable<(string Name, string Link)> gifts, int wedinngID);
        public void AddGiftToList(WeddingGift gift, int wedinngID);
        public void RemoveGiftFromList(WeddingGift gift, int wedinngID);
        public void RegisterGift(int giftId, int userId);
    }
}
