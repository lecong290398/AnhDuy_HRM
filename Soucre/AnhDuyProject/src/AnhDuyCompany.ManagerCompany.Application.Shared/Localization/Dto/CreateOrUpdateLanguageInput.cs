using System.ComponentModel.DataAnnotations;

namespace AnhDuyCompany.ManagerCompany.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}