using System.Collections.Generic;
using Abp.Collections.Extensions;
using Abp.Dependency;
using AnhDuyCompany.ManagerCompany.Authorization.Users.Importing.Dto;
using AnhDuyCompany.ManagerCompany.DataExporting.Excel.MiniExcel;
using AnhDuyCompany.ManagerCompany.Dto;
using AnhDuyCompany.ManagerCompany.Storage;

namespace AnhDuyCompany.ManagerCompany.Authorization.Users.Importing
{
    public class InvalidUserExporter : MiniExcelExcelExporterBase, IInvalidUserExporter, ITransientDependency
    {
        public InvalidUserExporter(ITempFileCacheManager tempFileCacheManager)
            : base(tempFileCacheManager)
        {
        }

        public FileDto ExportToFile(List<ImportUserDto> userList)
        {
            var items = new List<Dictionary<string, object>>();

            foreach (var user in userList)
            {
                items.Add(new Dictionary<string, object>()
                {
                    {L("UserName"), user.UserName},
                    {L("Name"), user.Name},
                    {L("Surname"), user.Surname},
                    {L("EmailAddress"), user.EmailAddress},
                    {L("PhoneNumber"), user.PhoneNumber},
                    {L("Password"), user.Password},
                    {L("Roles"), user.AssignedRoleNames?.JoinAsString(",")},
                    {L("Refuse Reason"), user.Exception}, //TODO@MiniExcel -> localize
                });
            }

            return CreateExcelPackage("InvalidUserImportList.xlsx", items);
        }
    }
}
