using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Database;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstructorController : ControllerBase
    {
        private readonly IInstructorService _instructorService;
        private readonly ILogger _logger;

        public InstructorController(
            IInstructorService instructorService, 
            ILoggerFactory loggerFactory
        )
        {
            _instructorService = instructorService;
            _logger = loggerFactory.CreateLogger("Controllers.InstructorController");
        }

        [HttpGet]
        public ActionResult<List<InstructorModel>> GetAllInstructors()
        {
            _logger.LogDebug("Getting all instructors");

            return Ok(_instructorService.GetAllInstructors());
        } 
    }
}
