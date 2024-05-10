
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.NRefbooks.N014Refbook.Queries.GetAllN014;
using Refbooks.Application.Refbooks.Nsi.NRefbooks.N014Refbook.Queries.GetAllRelevantN014;
using Refbooks.Application.Refbooks.Nsi.NRefbooks.N014Refbook.Queries.GetN014ByCode;
using Refbooks.Application.Refbooks.Nsi.NRefbooks.N014Refbook.Queries.GetRelevantN014ByCode;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.NRefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class N014Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns N014[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<N014[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllN014Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }

    /// <summary>
    /// Возвращает запись справочника по коду
    /// </summary>
    /// <param name="code"></param>
    /// <returns>Returns N014/returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Запись справочника с таким кодом не найдена</response>
    [HttpGet("{code}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "ByCode300")]
    public async Task<ActionResult<N014[]>> GetByCode(int code, CancellationToken cancellationToken)
    {
        var query = new GetN014ByCodeQuery
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
    /// <returns>Returns N014[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet("{date}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "AllRelevant300")]
    public async Task<ActionResult<N014[]>> GetAllRelevant(DateTime date, CancellationToken cancellationToken)
    {
        var query = new GetAllRelevantN014Query
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
    /// <returns>Returns N014</returns>
    /// <response code="200">Успешно</response>
    /// <response code="404">Актуальная на указанную дату запись справочника
    /// с таким кодом не найдена</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ResponseCache(CacheProfileName = "RelevantByCode300")]
    public async Task<ActionResult<N014>> GetRelevantByCode(int code, DateTime date,
        CancellationToken cancellationToken)
    {
        var query = new GetRelevantN014ByCodeQuery
        {
            Code = code,
            Date = date
        };

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
