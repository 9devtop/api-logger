using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LoggerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoggerController : ControllerBase
    {
        _9devlogdbContext dbContext = new _9devlogdbContext();

        //https://localhost:44334/api/logger
        [HttpGet]
        public ActionResult<IEnumerable<CalLog>> Get()
        {
            return dbContext.CalLog;
        }

        [HttpPost]
        public void Post([FromBody] CalLog value)
        {
            dbContext.CalLog.Add(value);
            dbContext.SaveChanges();
        }
    }
}
