using System;
using System.Collections.Generic;
using System.Text;

using Application.Interfaces;

using Domain.Interfaces;

namespace Application.Services
{
    public class GuestManageService : BaseService, IGuestManageService
    {
        public GuestManageService(IUnitOfWork uow) : base(uow)
        {

        }
        public void AddGuestToWedinng(int wedinngId, int guestId)
        {
            throw new NotImplementedException();
        }

        public void GeneratePasswordForWeddingGuest(int wedinngId, int guestId)
        {
            throw new NotImplementedException();
        }

        public void RemoveGuestFromWedinng(int wedinngId, int guestId)
        {
            throw new NotImplementedException();
        }
    }
}
