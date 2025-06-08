using System.Data;
using kolokwium_apbd.Data;
using kolokwium_apbd.DTOs;
using Microsoft.EntityFrameworkCore;

namespace kolokwium_apbd.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;

    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<WashingMachineDTO> getWashingMachines()
    {
        var washingMachines = await _context.WashingMachines.ToList();
        return washingMachines;
    }
}