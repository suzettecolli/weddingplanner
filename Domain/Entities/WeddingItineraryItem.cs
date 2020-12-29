using Domain.Enums;

namespace Domain.Entities
{
    public class WeddingItineraryItem : Entity
    {
        public int WeddingId { get; set; }
        public string Name { get; set; }
        public ItineraryState State { get; set; }
        public string Description { get; set; }
    }
}
