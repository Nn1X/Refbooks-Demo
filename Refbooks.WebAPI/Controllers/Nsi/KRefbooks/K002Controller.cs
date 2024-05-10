
using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.KRefbooks.K002Refbook.Queries.GetAllK002;
using Refbooks.Domain.Nsi.KRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.KRefbooks;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]/[action]")]
public class K002Controller : BaseController
{
    /// <summary>
    /// Возвращает все записи справочника
    /// </summary>
    /// <returns>Returns K002[]</returns>
    /// <response code="200">Успешно</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ResponseCache(CacheProfileName = "All300")]
    public async Task<ActionResult<K002[]>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllK002Query();

        var result = await Mediator.Send(query, cancellationToken);

        return Ok(result);
    }
}
