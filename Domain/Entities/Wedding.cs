using System.Collections.Generic;
using System;

namespace Domain.Entities
{
    public class Wedding : Entity
    {
        public string WeddingName { get; set; }
        public string BrideName { get; set; }
        public string GroomsName { get; set; }
        public int CeremonyAddressId { get; set; }
        public int CelebrationAddressId { get; set; }
        public DateTime CeremonyDateTime { get; set; }
        public DateTime CelebrationDateTime { get; set; }
        public int GuestCappacity { get; set; }
        public int OrganiserId { get; set; }
    }
}
