
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.ORefbooks.O002Refbook.Queries.GetO002ByCode;
using Refbooks.Application.Refbooks.Nsi.ORefbooks.O002Refbook.Queries.GetAllO002;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.ORefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class O002Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns O002[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<O002[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllO002Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }

    /// <summary>
    /// Возвращает запись справочника по коду
    /// </summary>
    /// <param name="code"></param>
    /// <returns>Returns O002/returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Запись справочника с таким кодом не найдена</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300,
        VaryByQueryKeys = new[] { "TerritoryCode", "AreaCityCode}", "VillageCouncilCode",
                        "VillageCode", "SectionCode"})]
    public async Task<ActionResult<O002>> GetByCode([FromQuery] GetO002ByCodeQuery query, CancellationToken cancellationToken)
    {
        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
