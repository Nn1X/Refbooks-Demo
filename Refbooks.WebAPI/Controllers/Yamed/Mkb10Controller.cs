using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Yamed.Mkb10Refbook.Queries.GetAll;
using Refbooks.Domain.Yamed;

namespace Refbooks.WebAPI.Controllers.Yamed
{

    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class Mkb10Controller : BaseController
    {
        /// <summary>
        /// Возвращает все записи справочника
        /// </summary>
        /// <returns>Returns Mkb10[]</returns>
        /// <response code="200">Успешно</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(CacheProfileName = "All300")]
        public async Task<ActionResult<Mkb10[]>> GetAll(
            CancellationToken cancellationToken)
        {
            var query = new GetAllMkb10Query();

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
