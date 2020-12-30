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
        public void Add(Address entity)
        {
            var gw = new AddressRowDataGateway()
            {
                City = entity.City,
                Id = entity.Id,
                Number = entity.Number,
                PostCode = entity.PostCode,
                Street = entity.Street
            };
            gw.Add();
        }

        public Address Get(long id)
        {
           return AddressRowDataGateway.Get(id);
        }

        public IList<Address> GetAll()
        {
            return AddressRowDataGateway.GetAll().Select(x=> (Address)x).ToList();
        }

        public void Remove(Address entity)
        {
            new AddressRowDataGateway(entity).Remove();
        }

        public void Update(Address entity)
        {
            new AddressRowDataGateway(entity).Update();
        }
    }
}
