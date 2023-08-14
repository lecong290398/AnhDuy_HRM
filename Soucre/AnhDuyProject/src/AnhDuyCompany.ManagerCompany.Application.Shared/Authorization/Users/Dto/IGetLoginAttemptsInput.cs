using Abp.Application.Services.Dto;

namespace AnhDuyCompany.ManagerCompany.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}