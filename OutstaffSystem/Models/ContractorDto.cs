using System.ComponentModel.DataAnnotations;

namespace OutstaffSystem.Models
{
    public class ContractorDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}