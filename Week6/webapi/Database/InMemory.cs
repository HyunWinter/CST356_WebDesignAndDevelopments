using System.Collections.Generic;

namespace webapi.Database
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student> {
            new Student {
                ID = "918xxxxx1",
                Email = "Tom.Jones@oit.edu"
            },
            new Student {
                ID = "918xxxxx2",
                Email = "Mary.Smith@oit.edu"
            }
        };

        public static List<Instructor> Instructors = new List<Instructor> {
            new Instructor {
                FName = "Suzanne",
                MName = "",
                LName = "Gardner"
            },
            new Instructor {
                FName = "Robyn",
                MName = "D.",
                LName = "Douglas"
            },
            new Instructor {
                FName = "Jim",
                MName = "",
                LName = "Newton"
            }
        };
    }
}