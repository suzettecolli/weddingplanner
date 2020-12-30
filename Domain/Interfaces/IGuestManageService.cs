using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IGuestManageService
    {
        public void AddGuestToWedinng(int wedinngId, int guestId);

        public void RemoveGuestFromWedinng(int wedinngId, int guestId);

        public string GeneratePasswordForWeddingGuest(int wedinngId, int guestId);

    }
}
