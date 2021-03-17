using System.Collections.Generic;
using Microsoft.Extensions.Logging;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRespository;
    private readonly ILogger _logger;

    public StudentService(IStudentRepository studentRepository, ILoggerFactory loggerFactory)
    {
        _studentRespository = studentRepository;
        _logger = loggerFactory.CreateLogger("Controllers.StudentService");
    }

    public List<StudentModel> GetAllStudents()
    {
        var studentViewModels = new List<StudentModel>();

        foreach(var student in _studentRespository.GetAllStudents())
        {
            StudentModel studentModel = new StudentModel {
                Id = student.student_id,
                Email = student.email_address
            };

            if (BusinessRules.isEndWithOITDomain(student))
            {
                studentModel.Special = true;

                _logger.LogInformation(
                    "Found an email with non-oit domain. " + 
                    student.student_id +
                    ": " +
                    student.email_address);
            }

            studentViewModels.Add(studentModel);
        }

        return studentViewModels;
    }
}