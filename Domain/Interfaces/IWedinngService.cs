using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IWedinngService
    {
        void AddWedding(Wedding wedding);
        void ArchiveWedding(int weddingId);
        void AddOrganizer(AppUser organizer);
    }
}
