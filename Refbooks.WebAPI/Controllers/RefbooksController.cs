using Microsoft.AspNetCore.Mvc;
using Refbooks.Application.Refbooks.Commands;

namespace Refbooks.WebAPI.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class RefbooksController:BaseController
    {
        /// <summary>
        /// Обновляет справочники 
        /// и возвращает массив 
        /// сообщений-результатов обновления
        /// </summary>
        /// <remarks>
        /// Пример запроса:
        /// ["F005", "F006", "V009", "NON-EXISTENT_REFBOOK"]
        /// </remarks>
        /// <returns>Returns string[]</returns>
        /// <response code="200">Успешно</response>
        [HttpPost]
        public async Task<ActionResult<string[]>> Update([FromBody]string[] refbooks)
        {
            var query = new UpdateRefbooksCommand
            {
                Refbooks = refbooks
            };

            var result = await Mediator.Send(query);

            return Ok(result);
        }
    }
}
