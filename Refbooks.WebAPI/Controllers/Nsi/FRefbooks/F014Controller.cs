using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F014Refbook.Queries.GetAllF014;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F014Refbook.Queries.GetAllRelevantF014;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F014Refbook.Queries.GetF014ByCode;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F014Refbook.Queries.GetRelevantF014ByCode;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.FRefbooks
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class F014Controller : BaseController
    {
        /// <summary>
        /// Возвращает все записи справочника
        /// </summary>
        /// <returns>Returns F014[]</returns>
        /// <response code="200">Успешно</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(CacheProfileName = "All300")]
        public async Task<ActionResult<F014[]>> GetAll(CancellationToken cancellationToken)
        {
            var query = new GetAllF014Query();

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }

        /// <summary>
        /// Возвращает записи справочника по коду
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Returns F014/returns>
        /// <response code="200">Успешно</response>
        /// <response code="404">Записи справочника с таким кодом не найдены</response>
        [HttpGet("{code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ResponseCache(CacheProfileName = "ByCode300")]
        public async Task<ActionResult<F014[]>> GetByCode(int code, CancellationToken cancellationToken)
        {
            var query = new GetF014ByCodeQuery
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
        /// <returns>Returns F014[]</returns>
        /// <response code="200">Успешно</response>
        [HttpGet("{date}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(CacheProfileName = "AllRelevant300")]
        public async Task<ActionResult<F014[]>> GetAllRelevant(DateTime date, CancellationToken cancellationToken)
        {
            var query = new GetAllRelevantF014Query
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
        /// <returns>Returns F014</returns>
        /// <response code="200">Успешно</response>
        /// <response code="404">Актуальная на указанную дату запись справочника
        /// с таким кодом не найдена</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ResponseCache(CacheProfileName = "RelevantByCode300")]
        public async Task<ActionResult<F014>> GetRelevantByCode(int code, DateTime date,
            CancellationToken cancellationToken)
        {
            var query = new GetRelevantF014ByCodeQuery
            {
                Code = code,
                Date = date
            };

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
