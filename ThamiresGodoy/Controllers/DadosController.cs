using Microsoft.AspNetCore.Mvc;
[ApiController]
public class DadosController : ControllerBase
{
    [HttpGet("v1/dados")]
    public async Task<IActionResult> GetResultAsync()
    {
        return Ok();
    }
}
