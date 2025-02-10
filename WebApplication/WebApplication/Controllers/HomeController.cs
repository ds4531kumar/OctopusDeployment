using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly AppSettings _appSettings;

    public HomeController(IOptions<AppSettings> appSettings)
    {
        _appSettings = appSettings.Value;
    }

    [HttpGet("settings")]
    public IActionResult GetSettings()
    {
        return Ok(new
        {
            _appSettings.ApiKey,
            _appSettings.SiteTitle,
            _appSettings.IsEnable,
        });
    }
}
