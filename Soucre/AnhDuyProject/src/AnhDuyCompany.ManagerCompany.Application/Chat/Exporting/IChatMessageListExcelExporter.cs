using System.Collections.Generic;
using Abp;
using AnhDuyCompany.ManagerCompany.Chat.Dto;
using AnhDuyCompany.ManagerCompany.Dto;

namespace AnhDuyCompany.ManagerCompany.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
