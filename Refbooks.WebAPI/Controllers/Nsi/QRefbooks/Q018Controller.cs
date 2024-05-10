
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.QRefbooks.Q018Refbook.Queries.GetAllQ018;
using Refbooks.Application.Refbooks.Nsi.QRefbooks.Q018Refbook.Queries.GetAllRelevantQ018;
using Refbooks.Application.Refbooks.Nsi.QRefbooks.Q018Refbook.Queries.GetQ018ByCode;
using Refbooks.Application.Refbooks.Nsi.QRefbooks.Q018Refbook.Queries.GetRelevantQ018ByCode;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.QRefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class Q018Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns Q018[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<Q018[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllQ018Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }

    /// <summary>
    /// Возвращает запись справочника по коду
    /// </summary>
    /// <param name="code"></param>
    /// <returns>Returns Q018/returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Запись справочника с таким кодом не найдена</response>
    [HttpGet("{code}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "ByCode300")]
    public async Task<ActionResult<Q018[]>> GetByCode(string code, CancellationToken cancellationToken)
    {
        var query = new GetQ018ByCodeQuery
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
    /// <returns>Returns Q018[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet("{date}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "AllRelevant300")]
    public async Task<ActionResult<Q018[]>> GetAllRelevant(DateTime date, CancellationToken cancellationToken)
    {
        var query = new GetAllRelevantQ018Query
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
    /// <returns>Returns Q018</returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Актуальная на указанную дату запись справочника
    /// с таким кодом не найдена</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "RelevantByCode300")]
    public async Task<ActionResult<Q018>> GetRelevantByCode(string code, DateTime date,
        CancellationToken cancellationToken)
    {
        var query = new GetRelevantQ018ByCodeQuery
        {
            Code = code,
            Date = date
        };

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
