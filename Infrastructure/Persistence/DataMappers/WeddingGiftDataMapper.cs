using System.Data.SqlClient;

using Domain.Entities;
using Domain.Enums;

namespace Infrastructure.Persistence.DataMappers
{
    public class WeddingGiftDataMapper : DataMapper<WeddingGift>
    {
        public WeddingGiftDataMapper() : base("WeddingGiftTable", "@WeddingId, @Name, @Link, @Description, @Price, @IsRegistred, @UserId") { }

        public override void AddParameters(WeddingGift entity, SqlParameterCollection parameterCollection)
        {
            parameterCollection.AddWithValue("@WeddingId", entity.WeddingId);
            parameterCollection.AddWithValue("@Name", entity.Name);
            parameterCollection.AddWithValue("@Link", entity.Link);
            parameterCollection.AddWithValue("@Description", entity.Description);
            parameterCollection.AddWithValue("@Price", entity.Price);
            parameterCollection.AddWithValue("@IsRegistred", entity.IsRegistred);
            parameterCollection.AddWithValue("@UserId", entity.UserId);
        }

        public override WeddingGift Map(SqlDataReader sqlDataReader)
        {
            var entity = new WeddingGift()
            {
                Id= (int)sqlDataReader["ID"],
                WeddingId = (int)sqlDataReader["WeddingId"],
                Name = (string)sqlDataReader["Name"],
                Link = (string)sqlDataReader["Link"],
                Description = (string)sqlDataReader["Description"],
                Price = (decimal)sqlDataReader["Price"],
                IsRegistred = (bool)sqlDataReader["IsRegistred"],
                UserId = (int)sqlDataReader["UserId"],
            };
            return entity;
        }
    }
}
