﻿using System;
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
        private readonly ILogger _logger;

        public ValuesController(ICustomLogger customLogger, ILogger logger)
        {
            this._customLogger = customLogger;
            this._logger = logger;
        }

        // GET api/values
        /// <summary>
        /// Получает список значений
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            this._customLogger.AddWarning("Логгируем, что хотим");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// Получает значение по идентификатору
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// Сохраняет значение
        /// </summary>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// Изменяет значение
        /// </summary>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// Удаляет значение
        /// </summary>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
