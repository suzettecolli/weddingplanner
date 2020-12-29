using System;

using Application.Interfaces;

using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class AppUserService : BaseService, IAppUserService
    {
        public AppUserService(IUnitOfWork uow) : base(uow)
        {

        }
        public bool LogIn(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public bool LogOut()
        {
            throw new NotImplementedException();
        }

        public bool Register(AppUser user, string password)
        {
            throw new NotImplementedException();
        }
    }
}
