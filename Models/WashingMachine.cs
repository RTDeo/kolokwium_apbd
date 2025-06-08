using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace kolokwium_apbd.Models;

[PrimaryKey(nameof(WashingMachineId))]
public class WashingMachine {
    public int WashingMachineId { get; set; }
    public int MaxWeight { get; set; }

    [Required]
    public string SerialNumber { get; set; } = null!;

    public ICollection<AvailableProgram> availablePrograms = null!;
}

