using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class GuestManageService : BaseService, IGuestManageService
    {
        public GuestManageService(IRepositories uow) : base(uow)
        {

        }
        public void AddGuestToWedinng(int wedinngId, int guestId, string weddingPassword)
        {
            var wedding = Repos.Wedinngs.Get(wedinngId);

            Repos.Participants.Add(new Domain.Entities.WeddingParticipant()
            {
                AppUserId = guestId,
                WeddingId = wedinngId,
                WeddingPassword = weddingPassword,
                WeddingsRole = Domain.Enums.GuestRole.Guest,
                AttendationOfCeremony = true,
                AttendationOfCelebration = true,
                Transportation = true,
                Food = Domain.Enums.FoodLimits.Bez_omezení,
                ConnectedPersons = 0,
            }) ;   
        }

        public string GeneratePasswordForWeddingGuest()
        {
                const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                int length = 10;
                StringBuilder res = new StringBuilder();
                Random rnd = new Random();
                while (0 < length--)
                {
                    res.Append(valid[rnd.Next(valid.Length)]);
                }
                return res.ToString();
        }

        public void RemoveGuestFromWedinng(int wedinngId, int guestId)
        {
            var partic = Repos.Participants.GetAll().FirstOrDefault(x => x.AppUserId == guestId && x.WeddingId == wedinngId);
            if(partic != null)
            {
                Repos.Participants.Remove(partic.Id);
            }
        }
    }
}
