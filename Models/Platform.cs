using System.ComponentModel.DataAnnotations;
using CommanderGQL.Models;

namespace Commander.Models
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string? Name { get; set; }

        public string? LicenseKey { get; set; }

        public ICollection<Command> Commands { get; set; } = new List<Command>();
    }
}