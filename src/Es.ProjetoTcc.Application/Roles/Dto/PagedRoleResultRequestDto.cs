using Abp.Application.Services.Dto;

namespace Es.ProjetoTcc.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

