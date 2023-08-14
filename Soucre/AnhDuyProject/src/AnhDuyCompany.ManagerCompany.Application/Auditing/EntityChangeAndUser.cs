using Abp.EntityHistory;
using AnhDuyCompany.ManagerCompany.Authorization.Users;

namespace AnhDuyCompany.ManagerCompany.Auditing
{
    /// <summary>
    /// A helper class to store an <see cref="EntityChange"/> and a <see cref="User"/> object.
    /// </summary>
    public class EntityChangeAndUser
    {
        public EntityChange EntityChange { get; set; }

        public User User { get; set; }
    }
}