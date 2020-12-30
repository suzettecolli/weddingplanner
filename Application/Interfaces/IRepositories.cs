

namespace Application.Interfaces
{
    public interface IRepositories
    {
        public IAddressRepository Addresses { get; set; }
        public IAppUserRepository AppUsers { get; set; }
        public IWedinngGiftRepository WedinngGifts { get; set; }
        public IWedinngItineraryRepository WedinngTasks { get; set; }
        public IWedinngRepository Wedinngs { get; set; }
        public IWeddingParticipantRepository Participants{ get; set; }
        

    }
}
