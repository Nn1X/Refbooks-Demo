
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.VRefbooks.V033Refbook.Queries.GetAllV033;
using Refbooks.Application.Refbooks.Nsi.VRefbooks.V033Refbook.Queries.GetAllRelevantV033;
using Refbooks.Application.Refbooks.Nsi.VRefbooks.V033Refbook.Queries.GetV033ByCode;
using Refbooks.Application.Refbooks.Nsi.VRefbooks.V033Refbook.Queries.GetRelevantV033ByCode;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.VRefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class V033Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns V033[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<V033[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllV033Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }

    /// <summary>
    /// Возвращает запись справочника по коду
    /// </summary>
    /// <param name="code"></param>
    /// <returns>Returns V033/returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Запись справочника с таким кодом не найдена</response>
    [HttpGet("{code}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "ByCode300")]
    public async Task<ActionResult<V033[]>> GetByCode(string code, CancellationToken cancellationToken)
    {
        var query = new GetV033ByCodeQuery
        {
            Code = code
        };

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
    /// <summary>
    /// Возвращает все актуальные на указанную дату
    /// записи справочника
    /// </summary>
    /// <returns>Returns V033[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet("{date}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "AllRelevant300")]
    public async Task<ActionResult<V033[]>> GetAllRelevant(DateTime date, CancellationToken cancellationToken)
    {
        var query = new GetAllRelevantV033Query
        {
            Date = date
        };

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
    /// <summary>
    /// Возвращает актуальную на указанную дату
    /// запись справочника по коду
    /// </summary>
    /// <param name="query"></param>
    /// <returns>Returns V033</returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Актуальная на указанную дату запись справочника
    /// с таким кодом не найдена</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "RelevantByCode300")]
    public async Task<ActionResult<V033>> GetRelevantByCode(string code, DateTime date,
        CancellationToken cancellationToken)
    {
        var query = new GetRelevantV033ByCodeQuery
        {
            Code = code,
            Date = date
        };

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
