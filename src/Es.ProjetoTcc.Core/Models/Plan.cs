using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;

namespace Es.ProjetoTcc.Models
{
    public class Plan : FullAuditedEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal MonthlyPayment { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal ValuePlan { get; set; }

        public int CustomerId { get; set; }
        public ICollection<Customer> Customers { get; set; }

    }
}
