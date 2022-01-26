using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers;

[ApiController]
[Route("[controller]")]
public class LibraryController : ControllerBase
{
    private readonly ILogger<LibraryController> _logger;

    public LibraryController(ILogger<LibraryController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public void Get()
    {
        throw new NotImplementedException();
    }
}
