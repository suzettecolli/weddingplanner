using System.Collections.Generic;
using System;

namespace Domain.Entities
{
    public class Wedding : Entity
    {
        public string WeddingName { get; set; }
        public string BrideName { get; set; }
        public string GroomsName { get; set; }
        public Address CeremonyAddress { get; set; }
        public Address CelebrationAddress { get; set; }
        public DateTime CeremonyDateTime { get; set; }
        public DateTime CelebrationDateTime { get; set; }
        public int GuestCappacity { get; set; }
        public int WeddingGiftListId { get; set; }
        public int WeddingItineraryListId { get; set; }
    }
}
