using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;

namespace webapi.tests
{
    public class StudentServiceTests
    {
        private StudentService _studentService; // System Under Test (SUT)
        private IStudentRepository _studentRepository; // Mock
        private const string oitDomain = "@oit.edu";

        [SetUp]
        public void Setup()
        {
            var loggerFactory = A.Fake<LoggerFactory>();
            _studentRepository = A.Fake<IStudentRepository>();

            _studentService = new StudentService(_studentRepository, loggerFactory);
        }

        [Test]
        public void ShouldGetOneOrMoreSpecialStudent()
        {
            // Arrange (Given)
            A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
                new List<Student> {
                    new Student {
                        student_id = 1,
                        email_address = "test1@oit.edu"
                    },
                    new Student {
                        student_id = 2,
                        email_address = "test2@gmail.com"
                    }
                }
            );

            // Act (When)
            var studentViewModels = _studentService.GetAllStudents();

            // Assert (NUnit Assertions) (Then)
            Assert.That(studentViewModels.Any(s => !s.Email.EndsWith(oitDomain)), Is.EqualTo(true));

            // Assert (FluentAssertions) (Then)
            studentViewModels.Any(s => !s.Email.EndsWith(oitDomain)).Should().BeTrue();
        }

        [Test]
        public void ShouldGetNoSpecialStudent()
        {
            // Arrange (Given)
            A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
                new List<Student> {
                    new Student {
                        student_id = 1,
                        email_address = "test1@oit.edu"
                    },
                    new Student {
                        student_id = 2,
                        email_address = "test2@oit.edu"
                    }
                }
            );

            // Act (When)
            var studentViewModels = _studentService.GetAllStudents();

            // Assert (NUnit Assertions) (Then)
            Assert.That(studentViewModels.Any(s => !s.Email.EndsWith(oitDomain)), Is.EqualTo(false));

            // Assert (FluentAssertions) (Then)
            studentViewModels.Any(s => !s.Email.EndsWith(oitDomain)).Should().BeFalse();
        }
    }
}