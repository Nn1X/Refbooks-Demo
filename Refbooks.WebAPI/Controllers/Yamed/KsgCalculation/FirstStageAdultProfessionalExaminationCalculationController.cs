using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Yamed.KsgCalculation.FirstStageAdultProfessionalExaminationCalculation.Queries.GetAll;
using Refbooks.Domain.Yamed.KsgCalculation;

namespace Refbooks.WebAPI.Controllers.Yamed.KsgCalculation
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class FirstStageAdultProfessionalExaminationCalculationController
        : BaseController
    {
        /// <summary>
        /// Возвращает все записи справочника
        /// </summary>
        /// <returns>Returns FirstStageAdultProfessionalExaminationCalculation[]</returns>
        /// <response code="200">Успешно</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(CacheProfileName = "All300")]
        public async Task<ActionResult<FirstStageAdultProfessionalExaminationCalculation[]>> GetAll(CancellationToken cancellationToken)
        {
            var query = new GetAllFirstStageAdultProfessionalExaminationCalculationQuery();

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
