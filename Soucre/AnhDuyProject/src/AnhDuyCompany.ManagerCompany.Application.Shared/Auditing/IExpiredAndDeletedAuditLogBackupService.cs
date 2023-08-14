using System.Collections.Generic;
using Abp.Auditing;

namespace AnhDuyCompany.ManagerCompany.Auditing
{
    public interface IExpiredAndDeletedAuditLogBackupService
    {
        bool CanBackup();
        
        void Backup(List<AuditLog> auditLogs);
    }
}