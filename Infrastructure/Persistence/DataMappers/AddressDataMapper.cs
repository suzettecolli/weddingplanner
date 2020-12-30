//using System.Data.SqlClient;

//using Domain.Entities;

//namespace Infrastructure.Persistence.DataMappers
//{
//    public class AddressDataMapper : DataMapper<Address>
//    {
//        public AddressDataMapper() : base("AddressTable", "@ID, @Street, @Number, @PostCode, @City") { }

//        public override void AddParameters(Address entity, SqlParameterCollection parameterCollection)
//        {
//            parameterCollection.AddWithValue("@ID", entity.Id);
//            parameterCollection.AddWithValue("@Street", entity.Street);
//            parameterCollection.AddWithValue("@Number", entity.Number);
//            parameterCollection.AddWithValue("@PostCode", entity.PostCode);
//            parameterCollection.AddWithValue("@City", entity.City);
//        }

//        public override Address Map(SqlDataReader sqlDataReader)
//        {
//            var entity = new Address()
//            {
//                Street = (string)sqlDataReader["Street"],
//                Number = (string)sqlDataReader["Number"],
//                PostCode = (string)sqlDataReader["PostCode"],
//                City = (string)sqlDataReader["City"],
//            };
//            return entity;
//        }
//    }
//}
