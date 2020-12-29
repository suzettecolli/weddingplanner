
using Domain.Entities;
using Domain.Enums;

namespace Domain.Interfaces
{
    public interface IWedinngItineraryService
    {
        public void ChangeState(WeddingGift gift, ItineraryState newState);
        public void AddItem(WeddingItineraryItem item);
        public void RemoveItem(WeddingItineraryItem item);
    }
}
