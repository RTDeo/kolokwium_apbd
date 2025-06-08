using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium_apbd.Models;

[Table("Available_Program")]
public class AvailableProgram {
    public int AvailableProgramId { get; set; }
    
    [ForeignKey(nameof(WashingMachine))]
    public int WashingMachineId { get; set; }

    [ForeignKey(nameof(Program))]
    public int ProgramId { get; set; }

    [Precision(10, 2)]
    public decimal Price { get; set; }
}