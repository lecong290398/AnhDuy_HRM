using System.Threading.Tasks;

namespace AnhDuyCompany.ManagerCompany.Net.Emailing
{
    public interface IEmailSettingsChecker
    {
        bool EmailSettingsValid();

        Task<bool> EmailSettingsValidAsync();
    }
}