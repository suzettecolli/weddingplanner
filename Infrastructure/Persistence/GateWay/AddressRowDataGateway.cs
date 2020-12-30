using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

using Application.Interfaces;

using Domain.Entities;

namespace Infrastructure.Persistence.GateWay
{
    public class AddressRowDataGateway : Address
    {
        private static readonly string _path = @"/addresses.json";
        private static List<AddressRowDataGateway> All => (List<AddressRowDataGateway>)JsonSerializer.Deserialize(_path, typeof(List<AddressRowDataGateway>));

        public void Add()
        {
            InsertOrUpdate();
        }

        public AddressRowDataGateway()
        {

        }

        public AddressRowDataGateway(Address entity)
        {
            Id = entity.Id;
            Street = entity.Street;
            Number = entity.Number;
            PostCode = entity.PostCode;
            City = entity.City;
        }

        public static AddressRowDataGateway Get(long id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static IList<AddressRowDataGateway> GetAll()
        {
            return All;
        }

        private void InsertOrUpdate()
        {
            var tmp = All.Where(x => x.Id != Id).ToList();
            var nextId = All.Max(x => x.Id) + 1;
            if (Id == 0) Id = nextId;
            tmp.Add(this);
            var jsonString = JsonSerializer.Serialize(tmp);
            File.WriteAllText(_path, jsonString);
        }

        public void Remove()
        {
            var tmp = All.Where(x => x.Id != Id).ToList();
            var jsonString = JsonSerializer.Serialize(tmp);
            File.WriteAllText(_path, jsonString);
        }

        public void Update()
        {
            InsertOrUpdate();
        }
    }
}
