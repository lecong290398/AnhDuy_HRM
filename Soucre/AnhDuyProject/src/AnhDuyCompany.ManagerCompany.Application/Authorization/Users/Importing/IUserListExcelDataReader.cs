using System.Collections.Generic;
using AnhDuyCompany.ManagerCompany.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace AnhDuyCompany.ManagerCompany.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
