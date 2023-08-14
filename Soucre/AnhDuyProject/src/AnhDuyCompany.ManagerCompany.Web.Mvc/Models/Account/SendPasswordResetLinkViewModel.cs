using System.ComponentModel.DataAnnotations;

namespace AnhDuyCompany.ManagerCompany.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}