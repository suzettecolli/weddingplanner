using System;

using Application.Interfaces;

namespace Infrastructure.Persistence
{
    public class Repos : IRepositories
    {
        public IAddressRepository Addresses { get; set; }
        public IAppUserRepository AppUsers { get; set; }
        public IWedinngGiftRepository WedinngGifts { get; set; }
        public IWedinngItineraryRepository WedinngTasks { get; set; }
        public IWedinngRepository Wedinngs { get; set; }
        public IWeddingParticipantRepository Participants { get; set; }

        public Repos(IAddressRepository addresses, IAppUserRepository appUsers, IWedinngGiftRepository wedinngGifts, IWedinngItineraryRepository wedinngTasks, IWedinngRepository wedinngs, IWeddingParticipantRepository participants)
        {
            Addresses = addresses;
            AppUsers = appUsers;
            WedinngGifts = wedinngGifts;
            WedinngTasks = wedinngTasks;
            Wedinngs = wedinngs;
            Participants = participants;
        }
    }
}
