using System;

using Application.Interfaces;

namespace Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAddressRepository Addresses { get; set; }
        public IAppUserRepository AppUsers { get; set; }
        public IWedinngGiftRepository WedinngGifts { get; set; }
        public IWedinngItineraryRepository WedinngTasks { get; set; }
        public IWedinngRepository Wedinngs { get; set; }

        public UnitOfWork()
        {
            throw new NotImplementedException();
        }
        public int Save()
        {
            throw new NotImplementedException();
        }
    }
}
