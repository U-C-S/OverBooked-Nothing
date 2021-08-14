using Microsoft.AspNetCore.Mvc;
using OverBookedAPI.Models;

namespace OverBookedAPI.Controllers;

[Route("api/import")]
[ApiController]
public class ImportBookmarksController : ControllerBase
{
    private readonly ILogger<ImportBookmarksController> _logger;

    public ImportBookmarksController(ILogger<ImportBookmarksController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get(string x, bool y)
    {
        return new FileImport
        {
            ImportData = x + "__lol",
            Simplified = y
        }.ImportData;
    }
}
