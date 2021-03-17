using System.Collections.Generic;
using Microsoft.Extensions.Logging;

public class InstructorService : IInstructorService
{
    private readonly IInstructorRepository _instructorRespository;
    private readonly ILogger _logger;

    public InstructorService(IInstructorRepository instructorRepository, ILoggerFactory loggerFactory)
    {
        _instructorRespository = instructorRepository;
        _logger = loggerFactory.CreateLogger("Controllers.InstructorService");
    }

    public List<InstructorModel> GetAllInstructors()
    {
        var instructorViewModels = new List<InstructorModel>();

        foreach(var instructor in _instructorRespository.GetAllInstructors())
        {
            instructorViewModels.Add(new InstructorModel {
                Id = instructor.instructor_id,
                FName = instructor.fname,
                MName = instructor.mname,
                LName = instructor.lname
            });
        }

        return instructorViewModels;
    }
}