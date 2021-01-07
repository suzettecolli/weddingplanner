using System.Collections.Generic;
using System.Data.SqlClient;

using Domain.Entities;
using Domain.Enums;

namespace Infrastructure.Persistence.DataMappers
{
    public class WeddingParticipantDataMapper : DataMapper<WeddingParticipant>
    {
        public WeddingParticipantDataMapper() : base("WeddingParticipantTable", "@WeddingId, @AppUserId, @WeddingPassword, @AttendationOfCeremony, @AttendationOfCelebration, @Food, @Transportation, @WeddingsRole, @ConnectedPersons, @Verificated") { }

        public override void AddParameters(WeddingParticipant entity, SqlParameterCollection parameterCollection)
        {
            parameterCollection.AddWithValue("@WeddingId", entity.WeddingId);
            parameterCollection.AddWithValue("@AppUserId", entity.AppUserId);
            parameterCollection.AddWithValue("@WeddingPassword", entity.WeddingPassword);
            parameterCollection.AddWithValue("@AttendationOfCeremony", entity.AttendationOfCeremony);
            parameterCollection.AddWithValue("@AttendationOfCelebration", entity.AttendationOfCelebration);
            parameterCollection.AddWithValue("@Food", entity.Food);
            parameterCollection.AddWithValue("@Transportation", entity.Transportation);
            parameterCollection.AddWithValue("@WeddingsRole", entity.WeddingsRole);
            parameterCollection.AddWithValue("@ConnectedPersons", entity.ConnectedPersons);
            parameterCollection.AddWithValue("@Verificated", entity.ConnectedPersons);
        }

        public override WeddingParticipant Map(SqlDataReader sqlDataReader)
        {
            var entity = new WeddingParticipant()
            {
                Id = (int)sqlDataReader["ID"],
                WeddingId = (int)sqlDataReader["WeddingId"],
                AppUserId = (int)sqlDataReader["AppUserId"],
                WeddingPassword = (string)sqlDataReader["WeddingPassword"],
                AttendationOfCeremony = (bool)sqlDataReader["AttendationOfCeremony"],
                AttendationOfCelebration = (bool)sqlDataReader["AttendationOfCelebration"],
                Food = (FoodLimits)sqlDataReader["Food"],
                Transportation = (bool)sqlDataReader["Transportation"],
                WeddingsRole = (GuestRole)sqlDataReader["WeddingsRole"],
                ConnectedPersons = (int)sqlDataReader["ConnectedPersons"],
                Verificated = (bool)sqlDataReader["Verificated"],
            };
            return entity;
        }
    }
}
