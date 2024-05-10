using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F010Refbook.Queries.GetAllF010;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F010Refbook.Queries.GetAllRelevantF010;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F010Refbook.Queries.GetF010ByCode;
using Refbooks.Application.Refbooks.Nsi.FRefbooks.F010Refbook.Queries.GetRelevantF010ByCode;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.WebAPI.Controllers.Nsi.FRefbooks
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class F010Controller : BaseController
    {
        /// <summary>
        /// Возвращает все записи справочника
        /// </summary>
        /// <returns>Returns F010[]</returns>
        /// <response code="200">Успешно</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(CacheProfileName = "All300")]
        public async Task<ActionResult<F010[]>> GetAll(CancellationToken cancellationToken)
        {
            var query = new GetAllF010Query();

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }

        /// <summary>
        /// Возвращает записи справочника по коду
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Returns F010/returns>
        /// <response code="200">Успешно</response>
        /// <response code="404">Записи справочника с таким кодом не найдены</response>
        [HttpGet("{code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ResponseCache(CacheProfileName = "ByCode300")]
        public async Task<ActionResult<F010[]>> GetByCode(string code, CancellationToken cancellationToken)
        {
            var query = new GetF010ByCodeQuery
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
        /// <returns>Returns F010[]</returns>
        /// <response code="200">Успешно</response>
        [HttpGet("{date}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(CacheProfileName = "AllRelevant300")]
        public async Task<ActionResult<F010[]>> GetAllRelevant(DateTime date, CancellationToken cancellationToken)
        {
            var query = new GetAllRelevantF010Query
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
        /// <returns>Returns F010</returns>
        /// <response code="200">Успешно</response>
        /// <response code="404">Актуальная на указанную дату запись справочника
        /// с таким кодом не найдена</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ResponseCache(CacheProfileName = "RelevantByCode300")]
        public async Task<ActionResult<F010>> GetRelevantByCode(string code, DateTime date,
            CancellationToken cancellationToken)
        {
            var query = new GetRelevantF010ByCodeQuery
            {
                Code = code,
                Date = date
            };

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
