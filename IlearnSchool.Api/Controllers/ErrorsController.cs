using Microsoft.AspNetCore.Mvc;

namespace IlearnSchool.Api.Controllers;
/// <summary>
/// Extra layer for handling unexpected errors in certain edge cases
/// </summary>
public class ErrorsController : ControllerBase
{

    [HttpGet("/api/errors/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}
