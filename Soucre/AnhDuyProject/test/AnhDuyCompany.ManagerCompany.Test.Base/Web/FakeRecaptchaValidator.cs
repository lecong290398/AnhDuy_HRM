using System.Threading.Tasks;
using AnhDuyCompany.ManagerCompany.Security.Recaptcha;

namespace AnhDuyCompany.ManagerCompany.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
