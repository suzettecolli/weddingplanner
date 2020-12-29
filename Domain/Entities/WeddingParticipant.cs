using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Domain.Enums;

namespace Domain.Entities
{
    public class WeddingParticipant : Entity
    {
        public int WeddingId { get; set; }
        public int AppUserId { get; set; }
        public string WeddingPassword { get; set; }
        public IList<int> ConnectedUsersId { get; set; }
        public bool AttendationOfCeremony { get; set; }
        public bool AttendationOfCelebration { get; set; }
        public FoodLimits Food { get; set; }
        public bool Transportation { get; set; }

        /// <summary>
        /// User roles at various weddings <WeddingID, GuestRole>
        /// </summary>
        public Dictionary<int, GuestRole> WeddingsRoles { get; set; }
    }
}
