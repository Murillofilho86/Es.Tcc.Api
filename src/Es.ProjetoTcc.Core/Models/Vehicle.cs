using Abp.Domain.Entities.Auditing;

namespace Es.ProjetoTcc.Models
{
    public class Vehicle : FullAuditedEntity
    {
        public string Brand { get; set; }
        public string Manufacturer { get; set; }
        public string YearManufacturer { get; set; }
        public string Color { get; set; }
        public string NumberPlate { get; set; }
        public string Category { get; set; }
    }
}
