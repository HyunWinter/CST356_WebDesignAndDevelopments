using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Database;
using System;

public class InstructorRepository : IInstructorRepository
{
    private readonly SchoolContext _dbContext;
    private readonly ILogger _logger;

    public InstructorRepository(SchoolContext dbContext, ILoggerFactory loggerFactory)
    {
        _dbContext = dbContext;
        _logger = loggerFactory.CreateLogger("Controllers.InstructorRepository");
    }

    public List<Instructor> GetAllInstructors()
    {
        try
        {
            return _dbContext.Instructor.ToList();
        } 
        catch(Exception ex)
        {
            _logger.LogError("Failed to get instructors.", ex);
            
            return new List<Instructor>();
        }
    }
}