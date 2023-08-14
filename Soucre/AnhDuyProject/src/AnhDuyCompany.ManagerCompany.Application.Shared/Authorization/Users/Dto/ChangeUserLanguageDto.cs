using System.ComponentModel.DataAnnotations;

namespace AnhDuyCompany.ManagerCompany.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
