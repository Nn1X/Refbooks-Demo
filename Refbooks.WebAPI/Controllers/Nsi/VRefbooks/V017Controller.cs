
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.VRefbooks.V017Refbook.Queries.GetAllV017;
using Refbooks.Application.Refbooks.Nsi.VRefbooks.V017Refbook.Queries.GetAllRelevantV017;
using Refbooks.Application.Refbooks.Nsi.VRefbooks.V017Refbook.Queries.GetV017ByCode;
using Refbooks.Application.Refbooks.Nsi.VRefbooks.V017Refbook.Queries.GetRelevantV017ByCode;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.VRefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class V017Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns V017[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<V017[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllV017Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }

    /// <summary>
    /// Возвращает запись справочника по коду
    /// </summary>
    /// <param name="code"></param>
    /// <returns>Returns V017/returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Запись справочника с таким кодом не найдена</response>
    [HttpGet("{code}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "ByCode300")]
    public async Task<ActionResult<V017[]>> GetByCode(int code, CancellationToken cancellationToken)
    {
        var query = new GetV017ByCodeQuery
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
    /// <returns>Returns V017[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet("{date}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "AllRelevant300")]
    public async Task<ActionResult<V017[]>> GetAllRelevant(DateTime date, CancellationToken cancellationToken)
    {
        var query = new GetAllRelevantV017Query
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
    /// <returns>Returns V017</returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Актуальная на указанную дату запись справочника
    /// с таким кодом не найдена</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "RelevantByCode300")]
    public async Task<ActionResult<V017>> GetRelevantByCode(int code, DateTime date,
        CancellationToken cancellationToken)
    {
        var query = new GetRelevantV017ByCodeQuery
        {
            Code = code,
            Date = date
        };

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
