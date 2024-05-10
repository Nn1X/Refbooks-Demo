using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F011Refbook.Queries.GetAllF011;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F011Refbook.Queries.GetF011ByCode;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.FRefbooks
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class F011Controller : BaseController
    {
        /// <summary>
        /// Возвращает все записи справочника
        /// </summary>
        /// <returns>Returns F011[]</returns>
        /// <response code="200">Успешно</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(CacheProfileName = "All300")]
        public async Task<ActionResult<F011[]>> GetAll(CancellationToken cancellationToken)
        {
            var query = new GetAllF011Query();

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }

        /// <summary>
        /// Возвращает запись справочника по коду
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Returns F011/returns>
        /// <response code="200">Успешно</response>
        /// <response code="404">Запись справочника с таким кодом не найдена</response>
        [HttpGet("{code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ResponseCache(CacheProfileName = "ByCode300")]
        public async Task<ActionResult<F011>> GetByCode(int code, CancellationToken cancellationToken)
        {
            var query = new GetF011ByCodeQuery
            {
                Code = code
            };

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
