using kolokwium_apbd.DTOs;
using kolokwium_apbd.Models;

namespace kolokwium_apbd.Services;

public interface IDbService
{
    Task<List<WashingMachineDTO>> getWashingMachines();
}