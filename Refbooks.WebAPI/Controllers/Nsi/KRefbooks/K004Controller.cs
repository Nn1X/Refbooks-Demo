
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.KRefbooks.K004Refbook.Queries.GetAllK004;
using Refbooks.Domain.Nsi.KRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.KRefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class K004Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns K004[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<K004[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllK004Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
