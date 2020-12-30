using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IWedinngService
    {
        void AddWedding(Wedding wedding);
        void RemoveWedding(int weddingId);
        void AddOrganizer(int weddingId, AppUser organizer);
    }
}
