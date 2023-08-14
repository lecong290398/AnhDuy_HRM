using System.Threading.Tasks;

namespace AnhDuyCompany.ManagerCompany.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}