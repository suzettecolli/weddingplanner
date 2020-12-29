namespace Application.Interfaces
{
    public interface IUnitOfWork
    {
        public IAddressRepository Addresses { get; set; }
        public IAppUserRepository AppUsers { get; set; }
        public IWedinngGiftRepository WedinngGifts { get; set; }
        public IWedinngItineraryRepository WedinngTasks { get; set; }
        public IWedinngRepository Wedinngs { get; set; }

        public int Save();
    }
}
