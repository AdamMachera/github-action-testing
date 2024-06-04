using Microsoft.AspNetCore.Mvc;

namespace CurrencyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CurrencyController> _logger;

        public CurrencyController(ILogger<CurrencyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new Currency { Name = "PLN", ValueInDollar = 3.98 });
        }
    }
}
