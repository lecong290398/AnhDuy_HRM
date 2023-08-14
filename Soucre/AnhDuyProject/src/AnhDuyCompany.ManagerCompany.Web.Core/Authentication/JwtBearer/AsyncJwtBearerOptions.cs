using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace AnhDuyCompany.ManagerCompany.Web.Authentication.JwtBearer
{
    public class AsyncJwtBearerOptions : JwtBearerOptions
    {
        public readonly List<IAsyncSecurityTokenValidator> AsyncSecurityTokenValidators;
        
        private readonly ManagerCompanyAsyncJwtSecurityTokenHandler _defaultAsyncHandler = new ManagerCompanyAsyncJwtSecurityTokenHandler();

        public AsyncJwtBearerOptions()
        {
            AsyncSecurityTokenValidators = new List<IAsyncSecurityTokenValidator>() {_defaultAsyncHandler};
        }
    }

}
