using System.Security.Claims;
using AnhDuyCompany.ManagerCompany.Authorization.Users;

namespace AnhDuyCompany.ManagerCompany.Authorization.Impersonation
{
    public class UserAndIdentity
    {
        public User User { get; set; }

        public ClaimsIdentity Identity { get; set; }

        public UserAndIdentity(User user, ClaimsIdentity identity)
        {
            User = user;
            Identity = identity;
        }
    }
}