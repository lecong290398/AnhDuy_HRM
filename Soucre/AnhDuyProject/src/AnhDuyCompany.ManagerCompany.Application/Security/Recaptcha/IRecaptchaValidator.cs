using System.Threading.Tasks;

namespace AnhDuyCompany.ManagerCompany.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}