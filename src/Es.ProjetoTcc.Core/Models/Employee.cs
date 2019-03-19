using Abp.Domain.Entities.Auditing;

namespace Es.ProjetoTcc.Models
{
    public class Employee : FullAuditedEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string CPF { get; set; }
    }
}
