
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.RRefbooks.R010Refbook.Queries.GetAllR010;
using Refbooks.Application.Refbooks.Nsi.RRefbooks.R010Refbook.Queries.GetAllRelevantR010;
using Refbooks.Application.Refbooks.Nsi.RRefbooks.R010Refbook.Queries.GetR010ByCode;
using Refbooks.Application.Refbooks.Nsi.RRefbooks.R010Refbook.Queries.GetRelevantR010ByCode;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.RRefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class R010Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns R010[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<R010[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllR010Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }

    /// <summary>
    /// Возвращает запись справочника по коду
    /// </summary>
    /// <param name="code"></param>
    /// <returns>Returns R010/returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Запись справочника с таким кодом не найдена</response>
    [HttpGet("{code}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "ByCode300")]
    public async Task<ActionResult<R010[]>> GetByCode(int code, CancellationToken cancellationToken)
    {
        var query = new GetR010ByCodeQuery
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
    /// <returns>Returns R010[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet("{date}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "AllRelevant300")]
    public async Task<ActionResult<R010[]>> GetAllRelevant(DateTime date, CancellationToken cancellationToken)
    {
        var query = new GetAllRelevantR010Query
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
    /// <returns>Returns R010</returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Актуальная на указанную дату запись справочника
    /// с таким кодом не найдена</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "RelevantByCode300")]
    public async Task<ActionResult<R010>> GetRelevantByCode(int code, DateTime date,
        CancellationToken cancellationToken)
    {
        var query = new GetRelevantR010ByCodeQuery
        {
            Code = code,
            Date = date
        };

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
