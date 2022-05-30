using System.ComponentModel.DataAnnotations;

namespace CommanderGQL.Models;

public class Platform
{
    [Required]
    public string Name { get; set; }
    
    [Key]
    public int Id { get; set; }
    
    public string LicenseKey { get; set; }
}