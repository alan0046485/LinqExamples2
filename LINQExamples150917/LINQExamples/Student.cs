using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    public class Student : IComparable<Student>
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int ProgrammeID { get; set; }
        public List<int> Grades { get; set; }
        public IEnumerable<string> Courses { get; private set; }

        public Student()
        {
            ID = 0;
            ProgrammeID = 99999;
        }

        public Student(int ID, string firstName, string surname, int courseID, 
                       List<int> grades, IEnumerable<string> courses)
        {
            this.ID = ID;
            FirstName = firstName;
            Surname = surname;
            ProgrammeID = courseID;
            Grades = grades;
            Courses = courses;
        }

        public int CompareTo(Student anotherStudent)
        {
            if(anotherStudent == null)
            {
                return -1;
            }
            else
            {
                int cmpSurname = Surname.CompareTo(anotherStudent.Surname);
                if(cmpSurname == 0)
                {
                    int cmpFirstname = FirstName.CompareTo(anotherStudent.FirstName);
                    return cmpFirstname != 0 ? cmpFirstname : ID.CompareTo(anotherStudent.ID);
                }
                else
                {
                    return cmpSurname;
                }
            }
        }

        public override string ToString()
        {
            return $"{nameof(FirstName)}: {FirstName}{Environment.NewLine}" +
                   $"{nameof(Surname)}: {Surname}{Environment.NewLine}" +
                   $"{nameof(ID)}: {ID}{Environment.NewLine}" +
                   $"{nameof(ProgrammeID)}: {ProgrammeID}{Environment.NewLine}";
        }
    }

    public class Course
    {
        public string CourseName { get; set; }
        public int ProgrammeID { get; set; }

        public Course(string courseName, int programmeID)
        {
            CourseName = courseName;
            ProgrammeID = programmeID;
        }

        public override string ToString()
        {
            return $"{nameof(CourseName)}: {CourseName}\n{nameof(ProgrammeID)}: {ProgrammeID}";
        }
    }
}
