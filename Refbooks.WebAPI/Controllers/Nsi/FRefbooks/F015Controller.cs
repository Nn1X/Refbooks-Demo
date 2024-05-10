
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F015Refbook.Queries.GetAllF015;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F015Refbook.Queries.GetAllRelevantF015;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F015Refbook.Queries.GetF015ByCode;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F015Refbook.Queries.GetRelevantF015ByCode;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.FRefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class F015Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns F015[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<F015[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllF015Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }

    /// <summary>
    /// Возвращает запись справочника по коду
    /// </summary>
    /// <param name="code"></param>
    /// <returns>Returns F015/returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Запись справочника с таким кодом не найдена</response>
    [HttpGet("{code}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "ByCode300")]
    public async Task<ActionResult<F015[]>> GetByCode(int code, CancellationToken cancellationToken)
    {
        var query = new GetF015ByCodeQuery
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
    /// <returns>Returns F015[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet("{date}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "AllRelevant300")]
    public async Task<ActionResult<F015[]>> GetAllRelevant(DateTime date, CancellationToken cancellationToken)
    {
        var query = new GetAllRelevantF015Query
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
    /// <returns>Returns F015</returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Актуальная на указанную дату запись справочника
    /// с таким кодом не найдена</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "RelevantByCode300")]
    public async Task<ActionResult<F015>> GetRelevantByCode(int code, DateTime date,
        CancellationToken cancellationToken)
    {
        var query = new GetRelevantF015ByCodeQuery
        {
            Code = code,
            Date = date
        };

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
