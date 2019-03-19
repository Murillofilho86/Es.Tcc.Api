using Abp.Domain.Entities.Auditing;
using System;

namespace Es.ProjetoTcc.Models
{
    public class Customer : FullAuditedEntity
    {
        public Customer()
        {
            
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string DriversLicense { get; set; }
        public string Document { get; set; }

        public int PlanId { get; set; }
        public Plan Plan { get; set; }

    }

}
