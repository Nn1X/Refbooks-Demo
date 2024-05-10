using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F005Refbook.Queries.GetAllF005;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F005Refbook.Queries.GetAllRelevantF005;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F005Refbook.Queries.GetF005ByCode;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.FRefbooks
{

    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class F005Controller : BaseController
    {
        /// <summary>
        /// Возвращает запись справочника по коду
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Returns F005</returns>
        /// <response code="200">Успешно</response>
        /// <response code="404">Запись справочника с таким кодом не найдена</response>
        [HttpGet("{code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ResponseCache(CacheProfileName = "ByCode300")]
        public async Task<ActionResult<F005>> GetByCode(int code, CancellationToken cancellationToken)
        {
            var query = new GetF005ByCodeQuery
            {
                Code = code
            };

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }
        /// <summary>
        /// Возвращает все записи справочника
        /// </summary>
        /// <returns>Returns F005[]</returns>
        /// <response code="200">Успешно</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(CacheProfileName = "All300")]
        public async Task<ActionResult<F005[]>> GetAll(CancellationToken cancellationToken)
        {
            var query = new GetAllF005Query();

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }

        /// <summary>
        /// Возвращает все актуальные записи справочника
        /// </summary>
        /// <returns>Returns F005[]</returns>
        /// Пример:
        /// GET f005/getf005allrelevant/
        /// </remarks>
        /// <response code="200">Успешно</response>
        [HttpGet("{date}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(CacheProfileName = "AllRelevant300")]
        public async Task<ActionResult<F005[]>> GetAllRelevant(DateTime date, CancellationToken cancellationToken)
        {
            var query = new GetAllRelevantF005Query
            {
                Date = date
            };

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
