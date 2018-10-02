using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Services;
using Microsoft.AspNetCore.Mvc;

namespace gym_webapi_template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICustomLogger _customLogger;

        public ValuesController(ICustomLogger customLogger)
        {
            this._customLogger = customLogger;
        }

        // GET api/values
        /// <summary>
        /// Получает список значений
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetAsync()
        {
            await this._customLogger.AddWarningAsync("Получение списка занчений");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// Получает значение по идентификатору
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetAsync(int id)
        {
            await this._customLogger.AddWarningAsync("Получение занчения");
            return "value";
        }

        // POST api/values
        /// <summary>
        /// Сохраняет значение
        /// </summary>
        [HttpPost]
        public async Task PostAsync([FromBody] string value)
        {
            await this._customLogger.AddWarningAsync("Добавление записи");
        }

        // PUT api/values/5
        /// <summary>
        /// Изменяет значение
        /// </summary>
        [HttpPut("{id}")]
        public async Task PutAsync(int id, [FromBody] string value)
        {
            await this._customLogger.AddWarningAsync("Изменяет занчение");
        }

        // DELETE api/values/5
        /// <summary>
        /// Удаляет значение
        /// </summary>
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await this._customLogger.AddWarningAsync("Удаляет занчение");
        }
    }
}
