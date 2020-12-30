using System;
using System.Data.SqlClient;

using Domain.Entities;

namespace Infrastructure.Persistence.DataMappers
{
    public class WeddingDataMapper : DataMapper<Wedding>
    {
        public WeddingDataMapper() : base("WeddingTable", "@ID, @WeddingName, @BrideName, @GroomsName, @CeremonyAddressId, @CelebrationAddressId, @CeremonyDateTime, @CelebrationDateTime, @GuestCappacity") { }

        public override void AddParameters(Wedding entity, SqlParameterCollection parameterCollection)
        {
            parameterCollection.AddWithValue("@ID", entity.Id);
            parameterCollection.AddWithValue("@WeddingName", entity.WeddingName);
            parameterCollection.AddWithValue("@BrideName", entity.BrideName);
            parameterCollection.AddWithValue("@GroomsName", entity.GroomsName);
            parameterCollection.AddWithValue("@CeremonyAddress", entity.CeremonyAddressId);
            parameterCollection.AddWithValue("@CelebrationAddress", entity.CelebrationAddressId);
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
                CeremonyAddressId = (int)sqlDataReader["CeremonyAddressId"],
                CelebrationAddressId = (int)sqlDataReader["CelebrationAddressId"],
                CeremonyDateTime = (DateTime)sqlDataReader["CeremonyDateTime"],
                CelebrationDateTime = (DateTime)sqlDataReader["CelebrationDateTime"],
                GuestCappacity = (int)sqlDataReader["GuestCappacity"],
            };
            return entity;
        }
    }
}
