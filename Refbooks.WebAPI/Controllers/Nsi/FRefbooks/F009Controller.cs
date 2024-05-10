using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F009Refbook.Queries.GetAllF009;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F009Refbook.Queries.GetF009ByCode;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.FRefbooks
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class F009Controller : BaseController
    {
        /// <summary>
        /// Возвращает все записи справочника
        /// </summary>
        /// <returns>Returns F009[]</returns>
        /// <response code="200">Успешно</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(CacheProfileName = "All300")]
        public async Task<ActionResult<F009[]>> GetAll(CancellationToken cancellationToken)
        {
            var query = new GetAllF009Query();

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }

        /// <summary>
        /// Возвращает запись справочника по коду
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Returns F009/returns>
        /// <response code="200">Успешно</response>
        /// <response code="404">Запись справочника с таким кодом не найдена</response>
        [HttpGet("{code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ResponseCache(CacheProfileName = "ByCode300")]
        public async Task<ActionResult<F009>> GetByCode(int code, CancellationToken cancellationToken)
        {
            var query = new GetF009ByCodeQuery
            {
                Code = code
            };

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
