using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Application.Interfaces;

using Domain.Entities;

using Infrastructure.Persistence.GateWay;

namespace Infrastructure.Persistence.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private int lastId=0;
        public Address Add(Address entity)
        {
            var gw = new AddressRowDataGateway()
            {
                City = entity.City,
                Id = entity.Id,
                Number = entity.Number,
                PostCode = entity.PostCode,
                Street = entity.Street
            };
            gw=gw.Add();
            lastId = gw.Id;
            return (Address)gw;
        }

        public Address Get(long id)
        {
           return AddressRowDataGateway.Get(id);
        }

        public IList<Address> GetAll()
        {
            return AddressRowDataGateway.GetAll().Select(x=> (Address)x).ToList();
        }

        public int GetLastID()
        {
            return this.lastId;
        }

        public void Remove(long addressId)
        {
            new AddressRowDataGateway().Remove(addressId);
        }

        public void Update(Address entity, string item)
        {
            new AddressRowDataGateway(entity).Update(entity.Id, item);
        }
    }
}
