using Abp.Dependency;

namespace AnhDuyCompany.ManagerCompany.Web.Xss
{
    public interface IHtmlSanitizer: ITransientDependency
    {
        string Sanitize(string html);
    }
}