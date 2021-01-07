using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IWedinngService
    {
        void AddWedding(Wedding wedding);
        Wedding GetWedding(int id);
        int GetLastWeddingId();
        void RemoveWedding(int weddingId);
        //void AddOrganizer(int weddingId, int organizerId);       
    }
}
