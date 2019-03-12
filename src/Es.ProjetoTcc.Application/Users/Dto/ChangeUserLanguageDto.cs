using System.ComponentModel.DataAnnotations;

namespace Es.ProjetoTcc.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}