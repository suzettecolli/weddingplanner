using System;

using Application.Interfaces;

using Domain.Entities;
using Domain.Interfaces;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

using Microsoft.AspNetCore.Identity;
using System.Text;
using System.Linq;

namespace Application.Services
{
    public class AppUserService : BaseService, IAppUserService
    {
        private string _salt = "Jm8mCE0HvVUw1GugoTpruA==";

        public AppUserService(IRepositories uow) : base(uow)
        {
        }

        public bool VerificateWeddingLog(AppUser user, string password)
        {
            var participant = Repos.Participants.GetAll().Where(x => x.AppUserId == user.Id);
            foreach (WeddingParticipant wp in participant)
            {
                if (wp != null && wp.WeddingPassword.Equals(Hasher(password)))
                {
                    wp.Verificated = true;
                    Repos.Participants.Update(wp, "Verificated");
                    return true;
                }
            }
            return false;
        }
        public bool LogIn(string userName, string password)
        {
            var user = Repos.AppUsers.GetAll().FirstOrDefault(x => x.UserName == userName);
            if (user != null && user.PasswordHash.Equals(Hasher(password)))
            {
                return true;
            }
            return false;
        }

        public bool Register(AppUser user, string password)
        {
            user.PasswordHash = Hasher(password);
            Repos.AppUsers.Add(user);
             
            return true;
        }


        private string Hasher(string input)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: input,
                salt: Encoding.ASCII.GetBytes(_salt),
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;
        }

        public string HashPassword(string input)
        {
            return Hasher(input);
        }
    }
}
