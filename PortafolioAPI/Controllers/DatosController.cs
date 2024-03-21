using Microsoft.AspNetCore.Mvc;
using PortafolioAPI.Services;


namespace PortafolioAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DatosController : ControllerBase
{
    private readonly ILogger<DatosController> _logger;
    private readonly PortafolioService _portafolioServices;

    public DatosController(ILogger<DatosController> logger, PortafolioService portafolioServices)
    {
        _logger = logger;
        _portafolioServices = portafolioServices;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetDatos()
    {
        var portafolio = await _portafolioServices.GetAsync();
        return Ok(portafolio);
    }
}
