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
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly ILogger _logger;

        public StudentController(IStudentService studentService, ILoggerFactory loggerFactory)
        {
            _studentService = studentService;
            _logger = loggerFactory.CreateLogger("Controllers.StudentController");
        }

        [HttpGet]
        public ActionResult<List<StudentModel>> GetAllStudents()
        {
            _logger.LogDebug("Getting all students");

            return Ok(_studentService.GetAllStudents());
        } 
    }
}
