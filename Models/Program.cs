using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium_apbd.Models;

[Table("Program")]
[PrimaryKey(nameof(ProgramId))]
public class Program {
    public int ProgramId { get; set; }
    
    [MaxLength(50), Required]
    public string Name { get; set; } = null!;
    public int DurationMinutes { get; set; }
    public int TemperatureCelsius { get; set; }
}