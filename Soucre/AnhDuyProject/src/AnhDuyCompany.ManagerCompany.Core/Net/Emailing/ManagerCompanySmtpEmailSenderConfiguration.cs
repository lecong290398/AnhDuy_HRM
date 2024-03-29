﻿using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace AnhDuyCompany.ManagerCompany.Net.Emailing
{
    public class ManagerCompanySmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public ManagerCompanySmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}