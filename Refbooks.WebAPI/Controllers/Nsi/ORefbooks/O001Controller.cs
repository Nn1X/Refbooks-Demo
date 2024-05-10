
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.ORefbooks.O001Refbook.Queries.GetAllO001;
using Refbooks.Application.Refbooks.Nsi.ORefbooks.O001Refbook.Queries.GetO001ByCode;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.ORefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class O001Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns O001[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<O001[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllO001Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }

    /// <summary>
    /// Возвращает запись справочника по коду
    /// </summary>
    /// <param name="code"></param>
    /// <returns>Returns O001/returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Запись справочника с таким кодом не найдена</response>
    [HttpGet("{code}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "ByCode300")]
    public async Task<ActionResult<O001>> GetByCode(string code, CancellationToken cancellationToken)
    {
        var query = new GetO001ByCodeQuery
        {
            Code = code
        };

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
