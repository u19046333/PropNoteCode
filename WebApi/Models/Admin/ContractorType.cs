using System.ComponentModel.DataAnnotations;

namespace PropNote.Models
{
    public class ContractorType
    {
        [Key]
        public int ContractorTypeId { get; set; }

        [MaxLength(50)]
        public string ContractorTypeName { get; set; } = string.Empty;
    }
}
