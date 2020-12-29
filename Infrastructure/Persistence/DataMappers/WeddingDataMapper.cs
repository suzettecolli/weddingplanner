using System;
using System.Data.SqlClient;

using Domain.Entities;

namespace Infrastructure.Persistence.DataMappers
{
    public class WeddingDataMapper : DataMapper<Wedding>
    {
        public WeddingDataMapper() : base("WeddingTable", "@ID, @WeddingName, @BrideName, @GroomsName, @CeremonyAddress, @CelebrationAddress, @CeremonyDateTime, @CelebrationDateTime, @GuestCappacity") { }

        public override void AddParameters(Wedding entity, SqlParameterCollection parameterCollection)
        {
            parameterCollection.AddWithValue("@ID", entity.Id);
            parameterCollection.AddWithValue("@WeddingName", entity.WeddingName);
            parameterCollection.AddWithValue("@BrideName", entity.BrideName);
            parameterCollection.AddWithValue("@GroomsName", entity.GroomsName);
            parameterCollection.AddWithValue("@CeremonyAddress", entity.CeremonyAddress);
            parameterCollection.AddWithValue("@CelebrationAddress", entity.CelebrationAddress);
            parameterCollection.AddWithValue("@CeremonyDateTime", entity.CeremonyDateTime);
            parameterCollection.AddWithValue("@CelebrationDateTime", entity.CelebrationDateTime);
            parameterCollection.AddWithValue("@GuestCappacity", entity.GuestCappacity);
        }

        public override Wedding Map(SqlDataReader sqlDataReader)
        {
            var entity = new Wedding()
            {
                WeddingName = (string)sqlDataReader["WeddingName"],
                BrideName = (string)sqlDataReader["BrideName"],
                GroomsName = (string)sqlDataReader["GroomsName"],
                CeremonyAddress = (Address)sqlDataReader["CeremonyAddress"],
                CelebrationAddress = (Address)sqlDataReader["CelebrationAddress"],
                CeremonyDateTime = (DateTime)sqlDataReader["CeremonyDateTime"],
                CelebrationDateTime = (DateTime)sqlDataReader["CelebrationDateTime"],
                GuestCappacity = (int)sqlDataReader["GuestCappacity"],
            };
            return entity;
        }
    }
}
