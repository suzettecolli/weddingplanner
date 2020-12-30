using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Domain.Enums;

namespace Domain.Entities
{
    public class AppUser : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int AddressId { get; set; }
        public AppUserRole Role{ get; set; }
    }
}
