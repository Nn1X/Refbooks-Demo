
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F042Refbook.Queries.GetAllF042;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F042Refbook.Queries.GetAllRelevantF042;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F042Refbook.Queries.GetF042ByCode;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F042Refbook.Queries.GetRelevantF042ByCode;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.FRefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class F042Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns F042[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<F042[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllF042Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }

    /// <summary>
    /// Возвращает запись справочника по коду
    /// </summary>
    /// <param name="code"></param>
    /// <returns>Returns F042/returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Запись справочника с таким кодом не найдена</response>
    [HttpGet("{code}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "ByCode300")]
    public async Task<ActionResult<F042[]>> GetByCode(string code, CancellationToken cancellationToken)
    {
        var query = new GetF042ByCodeQuery
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
    /// <returns>Returns F042[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet("{date}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "AllRelevant300")]
    public async Task<ActionResult<F042[]>> GetAllRelevant(DateTime date, CancellationToken cancellationToken)
    {
        var query = new GetAllRelevantF042Query
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
    /// <returns>Returns F042</returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Актуальная на указанную дату запись справочника
    /// с таким кодом не найдена</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "RelevantByCode300")]
    public async Task<ActionResult<F042>> GetRelevantByCode(string code, DateTime date,
        CancellationToken cancellationToken)
    {
        var query = new GetRelevantF042ByCodeQuery
        {
            Code = code,
            Date = date
        };

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
