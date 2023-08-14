using Abp.AspNetCore.Mvc.Authorization;
using AnhDuyCompany.ManagerCompany.Authorization.Users.Profile;
using AnhDuyCompany.ManagerCompany.Graphics;
using AnhDuyCompany.ManagerCompany.Storage;

namespace AnhDuyCompany.ManagerCompany.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(
            ITempFileCacheManager tempFileCacheManager,
            IProfileAppService profileAppService,
            IImageValidator imageValidator) :
            base(tempFileCacheManager, profileAppService, imageValidator)
        {
        }
    }
}