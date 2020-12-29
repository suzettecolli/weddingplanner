using System.Collections.Generic;
using System.Data.SqlClient;

using Domain.Entities;
using Domain.Enums;

namespace Infrastructure.Persistence.DataMappers
{
    public class WeddingParticipantDataMapper : DataMapper<WeddingParticipant>
    {
        public WeddingParticipantDataMapper() : base("WeddingParticipantTable", "@ID, @WeddingId, @AppUserId, @WeddingPassword, @ConnectedUsers, @AttendationOfCeremony, @AttendationOfCelebration, @Food, @Transportation, @WeddingsRoles") { }

        public override void AddParameters(WeddingParticipant entity, SqlParameterCollection parameterCollection)
        {
            parameterCollection.AddWithValue("@ID", entity.Id);
            parameterCollection.AddWithValue("@WeddingId", entity.WeddingId);
            parameterCollection.AddWithValue("@AppUserId", entity.AppUserId);
            parameterCollection.AddWithValue("@WeddingPassword", entity.WeddingPassword);
            parameterCollection.AddWithValue("@ConnectedUsersId", entity.ConnectedUsersId);
            parameterCollection.AddWithValue("@AttendationOfCeremony", entity.AttendationOfCeremony);
            parameterCollection.AddWithValue("@AttendationOfCelebration", entity.AttendationOfCelebration);
            parameterCollection.AddWithValue("@Food", entity.Food);
            parameterCollection.AddWithValue("@Transportation", entity.Transportation);
            parameterCollection.AddWithValue("@WeddingsRoles", entity.WeddingsRoles);
        }

        public override WeddingParticipant Map(SqlDataReader sqlDataReader)
        {
            var entity = new WeddingParticipant()
            {
                WeddingId = (int)sqlDataReader["WeddingId"],
                AppUserId = (int)sqlDataReader["AppUserId"],
                WeddingPassword = (string)sqlDataReader["WeddingPassword"],
                ConnectedUsersId = (IList<int>)sqlDataReader["ConnectedUsersId"],
                AttendationOfCeremony = (bool)sqlDataReader["AttendationOfCeremony"],
                AttendationOfCelebration = (bool)sqlDataReader["AttendationOfCelebration"],
                Food = (FoodLimits)sqlDataReader["Food"],
                Transportation = (bool)sqlDataReader["Transportation"],
                WeddingsRoles = (Dictionary<int, GuestRole>)sqlDataReader["WeddingsRoles"],
            };
            return entity;
        }
    }
}
