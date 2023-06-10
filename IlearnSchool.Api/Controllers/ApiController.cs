using ErrorOr;

using IlearnSchool.Api.Constants.Http;

using Microsoft.AspNetCore.Mvc;

namespace IlearnSchool.Api.Controllers;

[ApiController]
public class ApiController : ControllerBase
{
    protected IActionResult Problem(List<Error> errros)
    {
        HttpContext.Items[HttpContextItemKeys.Errors] = errros;

        var firstError = errros[0];

        var statusCode = firstError.Type switch
        {
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            _ => StatusCodes.Status500InternalServerError,
        };

        return Problem(statusCode: statusCode, title: firstError.Description);
    }
}
