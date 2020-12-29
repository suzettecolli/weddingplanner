using System.Data.SqlClient;

using Domain.Entities;
using Domain.Enums;

namespace Infrastructure.Persistence.DataMappers
{
    public class WeddingItineraryDataMapper : DataMapper<WeddingItineraryItem>
    {
        public WeddingItineraryDataMapper() : base("WeddingItineraryTable", "@ID, @Street, @Number, @PostCode, @City") { }

        public override void AddParameters(WeddingItineraryItem entity, SqlParameterCollection parameterCollection)
        {
            parameterCollection.AddWithValue("@ID", entity.Id);
            parameterCollection.AddWithValue("@WeddingId", entity.WeddingId);
            parameterCollection.AddWithValue("@Name", entity.Name);
            parameterCollection.AddWithValue("@State", entity.State);
            parameterCollection.AddWithValue("@Description", entity.Description);
        }

        public override WeddingItineraryItem Map(SqlDataReader sqlDataReader)
        {
            var entity = new WeddingItineraryItem()
            {
                WeddingId = (int)sqlDataReader["WeddingId"],
                Name = (string)sqlDataReader["Name"],
                State = (ItineraryState)sqlDataReader["State"],
                Description = (string)sqlDataReader["Description"],
            };
            return entity;
        }
    }
}
