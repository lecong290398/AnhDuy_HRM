using System.Collections.Generic;
using AnhDuyCompany.ManagerCompany.Authorization.Users.Importing.Dto;
using AnhDuyCompany.ManagerCompany.Dto;

namespace AnhDuyCompany.ManagerCompany.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
