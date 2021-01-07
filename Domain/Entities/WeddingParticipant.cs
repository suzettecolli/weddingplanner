using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Domain.Enums;

namespace Domain.Entities
{
    public class WeddingParticipant : Entity, IEnumerable
    {
        public int WeddingId { get; set; }
        public int AppUserId { get; set; }
        public string WeddingPassword { get; set; }
        public bool AttendationOfCeremony { get; set; }
        public bool AttendationOfCelebration { get; set; }
        public int ConnectedPersons { get; set; }
        public FoodLimits Food { get; set; }
        public bool Transportation { get; set; }

        public GuestRole WeddingsRole { get; set; }
        public bool Verificated { get; set; }
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
