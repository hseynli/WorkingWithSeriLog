using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WorkingWithSeriLog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<PersonController> _logger;

        public PersonController(ApplicationDbContext context, ILogger<PersonController> logger)
        {
            _context = context;
            _logger = logger;

            _logger.LogInformation("PersonController initialized");
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Get all people");

            return Ok(_context.People.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i == 30)
                        throw new Exception("i = 30");
                    _logger.LogInformation($"i = {i}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in Get(int id)");
            }


            return Ok(_context.People.Find(id));
        }
    }
}