
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.QRefbooks.Q016Refbook.Queries.GetAllQ016;
using Refbooks.Application.Refbooks.Nsi.QRefbooks.Q016Refbook.Queries.GetAllRelevantQ016;
using Refbooks.Application.Refbooks.Nsi.QRefbooks.Q016Refbook.Queries.GetQ016ByCode;
using Refbooks.Application.Refbooks.Nsi.QRefbooks.Q016Refbook.Queries.GetRelevantQ016ByCode;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.QRefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class Q016Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns Q016[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<Q016[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllQ016Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }

    /// <summary>
    /// Возвращает запись справочника по коду
    /// </summary>
    /// <param name="code"></param>
    /// <returns>Returns Q016/returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Запись справочника с таким кодом не найдена</response>
    [HttpGet("{code}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "ByCode300")]
    public async Task<ActionResult<Q016[]>> GetByCode(string code, CancellationToken cancellationToken)
    {
        var query = new GetQ016ByCodeQuery
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
    /// <returns>Returns Q016[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet("{date}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "AllRelevant300")]
    public async Task<ActionResult<Q016[]>> GetAllRelevant(DateTime date, CancellationToken cancellationToken)
    {
        var query = new GetAllRelevantQ016Query
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
    /// <returns>Returns Q016</returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Актуальная на указанную дату запись справочника
    /// с таким кодом не найдена</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "RelevantByCode300")]
    public async Task<ActionResult<Q016>> GetRelevantByCode(string code, DateTime date,
        CancellationToken cancellationToken)
    {
        var query = new GetRelevantQ016ByCodeQuery
        {
            Code = code,
            Date = date
        };

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
