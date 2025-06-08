
using kolokwium_apbd.Services;
using Microsoft.AspNetCore.Mvc;

namespace kolokwium_apbd.Controllers;


[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly IDbService _dbService;
    public CustomersController(IDbService dbService) {
        _dbService = dbService;
    }

    [HttpGet("washing-machines")]
    public async Task<IActionResult> getWashingMachines() {
        try {
            var washingMachines = await _dbService.getWashingMachines();
            return Ok(washingMachines);
        } catch(Exception e) {
            return NotFound();
        }
    }
}
