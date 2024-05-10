
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.ORefbooks.O003Refbook.Queries.GetAllO003;
using Refbooks.Application.Refbooks.Nsi.ORefbooks.O003Refbook.Queries.GetO003ByCode;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.ORefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class O003Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns O003[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<O003[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllO003Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }

    /// <summary>
    /// Возвращает запись справочника по коду
    /// </summary>
    /// <param name="code"></param>
    /// <returns>Returns O003/returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Запись справочника с таким кодом не найдена</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300,
                VaryByQueryKeys = new[] { "sectionCode", "positionCode" })]
    public async Task<ActionResult<O003>> GetByCode(string sectionCode, string? positionCode,
        CancellationToken cancellationToken)
    {
        var query = new GetO003ByCodeQuery
        {
            SectionCode = sectionCode,
            PositionCode = positionCode
        };

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
