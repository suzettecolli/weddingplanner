
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence.DataMappers;

namespace Infrastructure.Persistence.Repositories
{
    public class AppUserRepository : Repository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(AppUserDataMapper appUserDataMapper) : base(appUserDataMapper)
        {

        }
    }
}
