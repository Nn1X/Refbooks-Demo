using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Yamed.KsgCalculation.FirstStageAdultMedicalExaminationByServiceCountCalculation.Queries.GetAll;
using Refbooks.Domain.Yamed.KsgCalculation;

namespace Refbooks.WebAPI.Controllers.Yamed.KsgCalculation
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class FirstStageAdultMedicalExaminationByServiceCountCalculationController
        : BaseController
    {
        /// <summary>
        /// Возвращает все записи справочника
        /// </summary>
        /// <returns>Returns FirstStageAdultMedicalExaminationByServiceCountCalculation[]</returns>
        /// <response code="200">Успешно</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(CacheProfileName = "All300")]
        public async Task<ActionResult<FirstStageAdultMedicalExaminationByServiceCountCalculation[]>> GetAll(CancellationToken cancellationToken)
        {
            var query = new GetAllFirstStageAdultMedicalExaminationByServiceCountCalculationQuery();

            var result = await Mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
