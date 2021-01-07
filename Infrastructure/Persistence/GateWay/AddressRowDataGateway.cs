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
        private static readonly string _path = @"addresses.json";
        private static List<AddressRowDataGateway> All= new List<AddressRowDataGateway>();

        public AddressRowDataGateway Add()
        {
            try
            {
                StreamReader sr = new StreamReader(_path);
                All = (List<AddressRowDataGateway>)JsonSerializer.Deserialize(sr.ReadToEnd(), typeof(List<AddressRowDataGateway>));
                sr.Close();
                var tmp = All.ToList();
                var nextId = All.Max(x => x.Id) + 1;
                this.Id = nextId;
                tmp.Add(this);
                var jsonString = JsonSerializer.Serialize(tmp);
                File.WriteAllText(_path, jsonString);
            }
            catch
            {
                this.Id = 0;
                All.Add(this);
                var jsonString = JsonSerializer.Serialize(All);
                File.WriteAllText(_path, jsonString);
            }
            return this;
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
            StreamReader sr = new StreamReader(_path);
        All = (List<AddressRowDataGateway>)JsonSerializer.Deserialize(sr.ReadToEnd(), typeof(List<AddressRowDataGateway>));
            sr.Close();
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static IList<AddressRowDataGateway> GetAll()
        {
            StreamReader sr = new StreamReader(_path);
            All = (List<AddressRowDataGateway>)JsonSerializer.Deserialize(sr.ReadToEnd(), typeof(List<AddressRowDataGateway>));
            sr.Close();
            return All;
        }
        public void Remove(long id)
        {
            var tmp = All.Where(x => x.Id != id).ToList();
            var jsonString = JsonSerializer.Serialize(tmp);
            File.WriteAllText(_path, jsonString);
        }

        public void Update(int id, string item)
        {
            StreamReader sr = new StreamReader(_path);
            All = (List<AddressRowDataGateway>)JsonSerializer.Deserialize(sr.ReadToEnd(), typeof(List<AddressRowDataGateway>));
            sr.Close();
            var tmp = All.Where(x => x.Id != id).ToList();
            this.Id = id;
            this.GetType().GetProperty(item).GetValue(this, null);
            tmp.Add(this);
            var jsonString = JsonSerializer.Serialize(tmp);
            File.WriteAllText(_path, jsonString);
        }
    }
}
