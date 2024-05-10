
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.VRefbooks.V002Refbook.Queries.GetAllV002;
using Refbooks.Application.Refbooks.Nsi.VRefbooks.V002Refbook.Queries.GetAllRelevantV002;
using Refbooks.Application.Refbooks.Nsi.VRefbooks.V002Refbook.Queries.GetV002ByCode;
using Refbooks.Application.Refbooks.Nsi.VRefbooks.V002Refbook.Queries.GetRelevantV002ByCode;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.VRefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class V002Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns V002[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<V002[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllV002Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }

    /// <summary>
    /// Возвращает запись справочника по коду
    /// </summary>
    /// <param name="code"></param>
    /// <returns>Returns V002/returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Запись справочника с таким кодом не найдена</response>
    [HttpGet("{code}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "ByCode300")]
    public async Task<ActionResult<V002[]>> GetByCode(int code, CancellationToken cancellationToken)
    {
        var query = new GetV002ByCodeQuery
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
    /// <returns>Returns V002[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet("{date}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "AllRelevant300")]
    public async Task<ActionResult<V002[]>> GetAllRelevant(DateTime date, CancellationToken cancellationToken)
    {
        var query = new GetAllRelevantV002Query
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
    /// <returns>Returns V002</returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Актуальная на указанную дату запись справочника
    /// с таким кодом не найдена</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "RelevantByCode300")]
    public async Task<ActionResult<V002>> GetRelevantByCode(int code, DateTime date,
        CancellationToken cancellationToken)
    {
        var query = new GetRelevantV002ByCodeQuery
        {
            Code = code,
            Date = date
        };

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
