using System.ComponentModel.DataAnnotations;
using CommanderGQL.Models;

namespace Commander.Models
{
    [GraphQLDescription("Represents any software or service that has a command line interface.")]
    public class Platform
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string? Name { get; set; }

        [GraphQLDescription("Represents the purchased and valid license key for the platform.")]
        public string? LicenseKey { get; set; }

        public ICollection<Command> Commands { get; set; } = new List<Command>();
    }
}