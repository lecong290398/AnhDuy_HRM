using System.Collections.Generic;

namespace AnhDuyCompany.ManagerCompany.Authorization.Users.Profile.Dto
{
    public class UpdateGoogleAuthenticatorKeyOutput
    {
        public IEnumerable<string> RecoveryCodes { get; set; }
    }
}
