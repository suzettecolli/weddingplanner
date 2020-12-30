using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Application.Interfaces;

using Domain.Interfaces;

namespace Application.Services
{
    public class GuestManageService : BaseService, IGuestManageService
    {
        public GuestManageService(IRepositories uow) : base(uow)
        {

        }
        public void AddGuestToWedinng(int wedinngId, int guestId)
        {
            var wedding = Repos.Wedinngs.Get(wedinngId);
            Repos.Participants.Add(new Domain.Entities.WeddingParticipant() // use wedding name as wedding password
            {
                AppUserId = guestId,
                WeddingId = wedinngId,
                WeddingPassword = wedding.WeddingName
            });
             
        }

        public string GeneratePasswordForWeddingGuest(int wedinngId, int guestId)
        {
            var wedding = Repos.Wedinngs.Get(wedinngId);
            return wedding.WeddingName;
        }

        public void RemoveGuestFromWedinng(int wedinngId, int guestId)
        {
            var partic = Repos.Participants.GetAll().FirstOrDefault(x => x.AppUserId == guestId && x.WeddingId == wedinngId);
            if(partic != null)
            {
                Repos.Participants.Remove(partic);
            }
        }
    }
}
