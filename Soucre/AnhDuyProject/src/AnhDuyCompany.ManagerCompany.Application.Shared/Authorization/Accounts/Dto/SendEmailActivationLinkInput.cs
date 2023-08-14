using System.ComponentModel.DataAnnotations;

namespace AnhDuyCompany.ManagerCompany.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}