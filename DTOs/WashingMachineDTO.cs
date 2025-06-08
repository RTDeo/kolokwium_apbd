using System.ComponentModel.DataAnnotations;
using kolokwium_apbd.Models;

namespace kolokwium_apbd.DTOs;

public class WashingMachineDTO {
    public int WashingMachineId { get; set; }
    public int MaxWeight { get; set; }
    public string SerialNumber { get; set; } = null!;
    public List<AvailableProgram> availablePrograms  { get; set; } = null!;
}