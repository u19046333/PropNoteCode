using System.ComponentModel.DataAnnotations;

namespace PropNote.Models
{
    public class SnagListItem
    {
        [Key]
        public int SnagListItemId { get; set; }

        [MaxLength(50)]
        public string SnagListItemDescription { get; set; } = string.Empty;
    }
}
