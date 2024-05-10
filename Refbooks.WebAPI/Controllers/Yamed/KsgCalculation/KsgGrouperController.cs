using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Yamed.KsgCalculation.KsgGrouper.Queries.GetAll;

namespace Refbooks.WebAPI.Controllers.Yamed.KsgGrouper
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class KsgGrouperController : BaseController
    {
        /// <summary>
        /// Возвращает все записи справочника
        /// </summary>
        /// <returns>Returns KsgGrouper[]</returns>
        /// <response code="200">Успешно</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(CacheProfileName = "All300")]
        public async Task<ActionResult<Domain.Yamed.KsgCalculation.KsgGrouper[]>> GetAll(
            CancellationToken cancellationToken)
        {
            var query = new GetAllKsgGrouperQuery();

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
