using System.Data.SqlClient;

using Domain.Entities;
using Domain.Enums;

namespace Infrastructure.Persistence.DataMappers
{
    public class AppUserDataMapper : DataMapper<AppUser>
    {
        public AppUserDataMapper() : base("AppUserable", "@ID, @FirstName, @LastName, @UserName, @PasswordHash, @Email, @PhoneNumber, @AddressId, @Role") { }

        public override void AddParameters(AppUser entity, SqlParameterCollection parameterCollection)
        {
            parameterCollection.AddWithValue("@ID", entity.Id);
            parameterCollection.AddWithValue("@FirstName", entity.FirstName);
            parameterCollection.AddWithValue("@LastName", entity.LastName);
            parameterCollection.AddWithValue("@UserName", entity.UserName);
            parameterCollection.AddWithValue("@PasswordHash", entity.PasswordHash);
            parameterCollection.AddWithValue("@Email", entity.Email);
            parameterCollection.AddWithValue("@PhoneNumber", entity.PhoneNumber);
            parameterCollection.AddWithValue("@AddressId", entity.AddressId);
            parameterCollection.AddWithValue("@Role", entity.Role);
        }

        public override AppUser Map(SqlDataReader sqlDataReader)
        {
            var entity = new AppUser()
            {
                FirstName = (string)sqlDataReader["FirstName"],
                LastName = (string)sqlDataReader["LastName"],
                UserName = (string)sqlDataReader["UserName"],
                PasswordHash = (string)sqlDataReader["PasswordHash"],
                Email = (string)sqlDataReader["Email"],
                PhoneNumber = (string)sqlDataReader["PhoneNumber"],
                AddressId = (int)sqlDataReader["Address"],
                Role = (AppUserRole)sqlDataReader["Role"],
            };
            return entity;
        }
    }
}
