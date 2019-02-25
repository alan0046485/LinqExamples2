using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQExamples
{
    public partial class AdvancedExamplesFrm : Form
    {
        int SortField = 0;
        readonly int FieldCount = 4;

        private Student John = new Student
        {
            ProgrammeID = 1,
            ID = 100,
            FirstName = "John",
            Surname = "Lennon",
            Grades = new List<int> { 45, 54, 71, 77 }
        };

        private Student Paul = new Student
        {
            ProgrammeID = 1,
            ID = 55,
            FirstName = "Paul",
            Surname = "McCartney",
            Grades = new List<int> { 35, 65, 43, 49 }
        };

        private Student Ringo = new Student
        {
            ProgrammeID = 4,
            ID = 102,
            FirstName = "Ringo",
            Surname = "Starr",
            Grades = new List<int> { 71, 43, 51, 49 }
        };

        private Student George = new Student
        {
            ProgrammeID = 2,
            ID = 75,
            FirstName = "George",
            Surname = "Harrison",
            Grades = new List<int> { 11, 67, 51, 73 }
        };

        private Student Genghis = new Student
        {
            ProgrammeID = 5,
            ID = 104,
            FirstName = "Genghis",
            Surname = "Khan",
            Grades = new List<int> { 100, 100, 100, 100 }
        };

        private Student William = new Student
        {
            ProgrammeID = 3,
            ID = 105,
            FirstName = "William",
            Surname = "Shakespeare",
            Grades = new List<int> { 98, 64, 53, 74 }
        };

        private Student Doctor = new Student
        {
            ProgrammeID = 4,
            ID = 1,
            FirstName = "Doctor",
            Surname = "Who",
            Grades = new List<int> { 101, 101, 101, 101 }
        };

        private Student Sherlock = new Student
        {
            ProgrammeID = 8,
            ID = 2,
            FirstName = "Shelock",
            Surname = "Holmes",
            Grades = new List<int> { 101, 101, 101, 101 }
        };

        private Student JohnH = new Student
        {
            ProgrammeID = 7,
            ID = 3,
            FirstName = "John",
            Surname = "Watson",
            Grades = new List<int> { 70, 70, 70, 90 }
        };

        private List<Course> ProgrammeCourses = new List<Course>();

        private List<Student> Students = null;
        public AdvancedExamplesFrm()
        {
            Students = new List<Student> { John, Paul, Ringo, George };

            ProgrammeCourses.Add(new Course("Maths", 1));
            ProgrammeCourses.Add(new Course("English", 1));
            ProgrammeCourses.Add(new Course("History", 1));
            ProgrammeCourses.Add(new Course("Classics", 2));
            ProgrammeCourses.Add(new Course("French", 3));
            ProgrammeCourses.Add(new Course("Geography", 3));
            ProgrammeCourses.Add(new Course("Quantum Mechanics", 4));
            ProgrammeCourses.Add(new Course("Tardis Maintenance", 4));
            ProgrammeCourses.Add(new Course("Dalek Disassembly", 4));
            ProgrammeCourses.Add(new Course("Wormhole Theories", 4));
            ProgrammeCourses.Add(new Course("Murder", 5));
            ProgrammeCourses.Add(new Course("Conquest", 5));
            ProgrammeCourses.Add(new Course("Pillaging", 5));
            ProgrammeCourses.Add(new Course("The Fine Art of War", 5));

            InitializeComponent();
        }

        private void ModifyStudentList(bool addStudents)
        {
            if (addStudents)
            {
                Students.Add(Genghis);
                Students.Add(William);
                Students.Add(Doctor);
                Students.Add(Sherlock);
                Students.Add(JohnH);
            }
            else
            {
                Students.Remove(Genghis);
                Students.Remove(William);
                Students.Remove(Doctor);
                Students.Remove(Sherlock);
                Students.Remove(JohnH);
            }
        }

        private void ResetRTBs()
        {
            rtbStudents.Clear();
            rtbExtraQueries.Clear();
            rtbNumbers.Clear();
        }

        private void AdvancedExamplesFrm_Load(object sender, EventArgs e)
        {
            foreach (var student in Students)
            {
                rtbStudents.AppendText(student.ToString());
            }
        }

        private void btnShowType_Click(object sender, EventArgs e)
        {
            ResetRTBs();
            /*
             * We use .NET reflection here--we won't be covering reflection in AdvProg, but it
             * essentially provides utilies/functions that allow you to determine the 
             * properties/attributes/methods of objects and assemblies at runtime. It is a powerful
             * technique, but care is required when using it, particularly if it is being used to
             * dynamically create an instance of an object based on metadata collected from 
             * assemblies and/or runtime objects, or if you are invoking code on objects dynamically
             * (which means you have no compile time safety through the type system). ORMs (object
             * relational mappers), testing frameworks, plugins, etc all use .NET reflection.
             * Note: there is obviously a peformance impact when using .NET reflection.
             */
            IEnumerable<Student> sortedByFirstNameIE = from student in Students
                                                       orderby student.FirstName
                                                       select student;

            rtbStudents.AppendText($"Students by Firstname:{Environment.NewLine}");

            foreach (var student in sortedByFirstNameIE)
            {
                rtbStudents.AppendText($"CourseID: {student.ProgrammeID.ToString()}{Environment.NewLine}" +
                                         $"Firstname: {student.FirstName}{Environment.NewLine}" +
                                         $"Surname: {student.Surname}{Environment.NewLine}");
            }

            // Now use reflection...
            string msg1 = String.Format($"{nameof(sortedByFirstNameIE)} is actually of type {sortedByFirstNameIE.GetType().Name} which" +
                                        $" is defined in assembly {sortedByFirstNameIE.GetType().Assembly.GetName().Name}");

            rtbExtraQueries.AppendText(msg1 + Environment.NewLine);

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            IEnumerable<int> oddNums = from i in nums
                                       where i % 2 != 0
                                       select i;

            foreach (var i in oddNums)
            {
                rtbNumbers.AppendText($"{i}{Environment.NewLine}");
            }
            // Now use reflection again...
            string msg2 = String.Format($"{nameof(oddNums)} is actually of type {oddNums.GetType().Name} which" +
                                        $" is defined in assembly {oddNums.GetType().Assembly.GetName().Name}");

            rtbExtraQueries.AppendText(msg2 + Environment.NewLine);

            /*
             * The point here is that even in this simple example, the real type of the sortedByFirstNameIE list
             * is some Linq defined type located inside the Linq assembly/namespace. The range of such types is
             * quite large, but the real problem would be to locate the correct type, and in some cases the actual
             * type is not directly accessible to our code. So, how could you correctly declare an explicitly 
             * typed variable to hold a given result set? It would be practically difficult to do so, sometimes
             * impossible, hence this explains why implicitly typd variables are used.
             */
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            switch (SortField++ % FieldCount)
            {
                case 0:
                    ResetRTBs();
                    var sortedByCourseID = from student in Students
                                           orderby student.ProgrammeID
                                           // The following is an example of an anonymous type being
                                           // created using object initialiser syntax.
                                           // Recall that object initialiser syntax is the **ONLY** way that
                                           // an anonymous type can be created.
                                           select new { CourseID = student.ProgrammeID, student.Surname };

                    if (sortedByCourseID.Any())
                    {
                        rtbStudents.AppendText("Students sorted by CourseID" + Environment.NewLine);
                        foreach (var student in sortedByCourseID)
                        {
                            rtbStudents.AppendText($"CourseID: {student.CourseID}{Environment.NewLine}" +
                                                   $"Surname: {student.Surname}{Environment.NewLine}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No results returned");
                    }
                    break;

                case 1:
                    ResetRTBs();
                    var sortedByID = from student in Students
                                     orderby student.ID
                                     // Note again we use object initialiser syntax but also define our own
                                     // field names.
                                     select new { StudentID = student.ID, StudentFullname = student.FirstName +
                                                                                            " " +
                                                                                            student.Surname };

                    if (sortedByID.Count() > 0)
                    {
                        rtbStudents.AppendText("Students sorted by StudentID" + Environment.NewLine);
                        foreach (var student in sortedByID)
                        {
                            rtbStudents.AppendText($"StudentID: {student.StudentID}{Environment.NewLine}" +
                                                   $"Fullname: {student.StudentFullname}{Environment.NewLine}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No results returned");
                    }
                    break;

                case 2:
                    ResetRTBs();

                    var sortedByFirstName = from student in Students
                                            orderby student.FirstName
                                            select student;

                    IEnumerable<Student> courseID1Students = sortedByFirstName.Where(s => s.ProgrammeID == 1);

                    rtbStudents.AppendText("CourseID = 1 Students" + Environment.NewLine);

                    foreach (var student in courseID1Students)
                    {
                        rtbStudents.AppendText($"CourseID: {student.ProgrammeID}{Environment.NewLine}" +
                                               $"Firstname: {student.FirstName}{Environment.NewLine}" +
                                               $"Surname: {student.Surname}{Environment.NewLine}");
                    }
                    break;

                case 3:
                    ResetRTBs();

                    // The let clause in the following linq expression creates a new range variable that
                    // can be used later in the query
                    var sortedByCapitalisedSurname = from student in Students
                                                     let capitalisedSurname = student.Surname.ToUpper()
                                                     orderby capitalisedSurname
                                                     select new
                                                     {
                                                         capitalisedSurname,
                                                         student.FirstName,
                                                         CourseID = student.ProgrammeID
                                                     };

                    rtbStudents.AppendText("Students sorted by capitalised surname");
                    foreach (var student in sortedByCapitalisedSurname)
                    {
                        rtbStudents.AppendText($"Surname: {student.capitalisedSurname}{Environment.NewLine}" +
                                               $"CourseID: {student.CourseID}{Environment.NewLine}" +
                                               $"Firstname: {student.FirstName}{Environment.NewLine}{Environment.NewLine}");
                    }

                    break;
            }
        }

        /*
         * Most of the Linq queries in this program are what are known as deferred execution--when
         * you attempt to access the result set--either via iteration or calling an extension method
         * such as Any(), First(), ElementAt(), etc--only then does the Linq query execute. Immediate
         * execution is where you force the query to execute rather than wait until you wish to 
         * iterate over the results. Immediate execution essentially creates a cached snap-shot copy
         * of the result set; this is done via calls to ToArray(), ToList() or ToDictionary().
         */
        private void btnDeferredExecution_Click(object sender, EventArgs e)
        {
            ResetRTBs();

            var sortedByFirstname = from student in Students
                                    orderby student.FirstName
                                    select student;

            rtbStudents.AppendText($"Students by firstname: {Environment.NewLine}");
            foreach (var student in sortedByFirstname)
            {
                rtbStudents.AppendText($"CourseID: {student.ProgrammeID}{Environment.NewLine}" +
                                       $"Firstname: {student.FirstName}{Environment.NewLine}" +
                                       $"Surname: {student.Surname}{Environment.NewLine}{Environment.NewLine}");
            }

            // Note what happens when we add some more students to the generic students list
            // and iterate over the sortedByFirstname result set
            ModifyStudentList(true);

            rtbExtraQueries.AppendText($"Students by firstname after modification{Environment.NewLine}");
            foreach (var student in sortedByFirstname)
            {
                rtbExtraQueries.AppendText($"CourseID: {student.ProgrammeID}{Environment.NewLine}" +
                                       $"Firstname: {student.FirstName}{Environment.NewLine}" +
                                       $"Surname: {student.Surname}{Environment.NewLine}{Environment.NewLine}");
            }

            ModifyStudentList(false);
        }

        /*
         * This is an example of immediate execution. Note what happens when we add more students
         * to the students list data source and iterate over the result set. The newly added students
         * do not show up. Whether you use deffered or immediate exec depends on your requirements.
         * If working on a snapshot is ok for your application then immediate exec might fit the bill.
         * If, however, you require the latest data all the time, then deferred exec it the only
         * way to go.
         */
        private void btnToList_Click(object sender, EventArgs e)
        {
            ResetRTBs();
            var sortedByCourseID = (from student in Students
                                    orderby student.ProgrammeID
                                    select new { student.ProgrammeID, student.Surname }).ToList();

            rtbStudents.AppendText($"Students sorted by courseID{Environment.NewLine}");
            foreach (var student in sortedByCourseID)
            {
                rtbStudents.AppendText($"CourseID: {student.ProgrammeID}{Environment.NewLine}" +
                                       $"Surname: {student.Surname}{Environment.NewLine}{Environment.NewLine}");
            }

            // Again add more students
            ModifyStudentList(true);

            rtbExtraQueries.AppendText($"Students sorted by CourseID after modifying data source{Environment.NewLine}");
            foreach (var student in sortedByCourseID)
            {
                rtbExtraQueries.AppendText($"CourseID: {student.ProgrammeID}{Environment.NewLine}" +
                                       $"Surname: {student.Surname}{Environment.NewLine}{Environment.NewLine}");
            }

            ModifyStudentList(false);
        }

        private void btnTopPerformingStudents_Click(object sender, EventArgs e)
        {
            ResetRTBs();
            /*
            Sometimes you need to filter data where the filter is applied to an embedded list or array.
            So, for a trivial type of query we might want to return the top performing students, i.e.,
            those who have a grade >= 70. The way to do this using query expression syntax is using
            compound from clauses.
            In the below code, the first from clause iterates over the Students collection, and for each
            student the second from clause "executes" by iterating over the grades in the Grades
            collection list. The grade is then used in the where predicate to filter only for grades
            that are >= 70.  What we are doing in this code is essentially flattening the Grades list
            out.
            */
            var topPerformers = from student in Students
                                from grade in student.Grades
                                where grade >= 70
                                orderby student.Surname, student.FirstName, grade
                                select new { student.FirstName, student.Surname, grade };

            if (topPerformers.Any())
            {
                foreach (var student in topPerformers)
                {
                    rtbStudents.AppendText("Query expression results:");
                    rtbStudents.AppendText($"{student.FirstName} {student.Surname} {student.grade}{Environment.NewLine}");
                }
            }

            /*
            Query expressions get converted into method syntax by the C# compiler. Compound from clauses
            are converted into the equivalent SelectMany() method extension. The equivalent of the
            above query expression in method syntax form is:
            */
            var topPerformersMS = Students.SelectMany((s) => s.Grades,
                                                    (s, g) => new { Student = s, Grade = g })
                                                    .Where((anon) => anon.Grade >= 70)
                                                    .OrderBy((anon) => anon.Student.Surname)
                                                    .ThenBy((anon) => anon.Student.FirstName)
                                                    .ThenBy((anon) => anon.Grade)
                                                    .Select((anon) => anon);

            if (topPerformersMS.Any())
            {
                rtbStudents.AppendText("\nMethod syntax results:");
                foreach (var student in topPerformersMS)
                {
                    rtbStudents.AppendText($"{student.Student.FirstName} {student.Student.Surname} " +
                                           $"{student.Grade}{Environment.NewLine}");
                }
            }
        }

        private void btnReturningResults_Click(object sender, EventArgs e)
        {
            ResetRTBs();

            IEnumerable<Student> orderedStudents = GetOrderedStudents();

            rtbStudents.AppendText($"OrderedStudents from GetOrderedStudents(){Environment.NewLine}");
            foreach (var student in orderedStudents)
            {
                rtbStudents.AppendText($"{student.FirstName} {student.Surname} {Environment.NewLine}");
            }

            // Example of using an Array returned by called function
            Array studentObjs = GetOrderedStudentObjs();
            rtbExtraQueries.AppendText($"Ordered students from GetOrderedStudentObjs(){Environment.NewLine}");
            foreach (var item in studentObjs)
            {
                rtbExtraQueries.AppendText($"{item}{Environment.NewLine}");
            }
        }

        /*
        The thing to remember is that var types cannot be used as return values from function calls, 
        nor can they be arguments in function calls.  So, you are forced to either return IEnumerable<T>,
        IEnumerable, or make use if immediate execution and return a hash table, list or array.
        */
        private IEnumerable<Student> GetOrderedStudents()
        {
            IEnumerable<Student> orderedStudents = from student in Students
                                                   orderby student.FirstName
                                                   select student;

            return orderedStudents;
        }

        // Can't use var as return keyword. Can't use ToArray<T>(), etc as we don't know the
        // fundamental type represented by the anonymous type creation code below.
        private Array GetOrderedStudentObjs()
        {
            var orderedStudents = from student in Students
                                  orderby student.Surname
                                  select new { StudentFullname = student.FirstName + " " 
                                                + student.Surname };

            return orderedStudents.ToArray();
        }

        private void btnInnerJoin_Click(object sender, EventArgs e)
        {
            ResetRTBs();

            var studentsWithCourses = from student in Students
                                      join progCourses in ProgrammeCourses on
                                            student.ProgrammeID equals progCourses.ProgrammeID
                                      select new
                                      {
                                          student.FirstName,
                                          student.Surname,
                                          student.ProgrammeID,
                                          programmeCourseID = progCourses.ProgrammeID,
                                          progCourses.CourseName
                                      };
            // Note that we've been forced to provide a distinct name for the second instance of ProgrammeID as anonymous types
            // do not allow supporting multiple properties with the same name-->which makes sense if you think about it.
            foreach (var record in studentsWithCourses)
            {
                rtbStudents.AppendText($"{record.FirstName} {record.Surname} ProgramID: {record.ProgrammeID}" +
                                       $"programmeCourseID:  { record.programmeCourseID} " +
                                       $"{record.CourseName} {Environment.NewLine}");
            }

            // Method syntax of the above is:
            var studentsWithCourses2 = Students.Join(ProgrammeCourses,       // students is the outer sequence, ProgrammeCourses is the inner sequence
                                                     (s) => s.ProgrammeID,   // lambda to extract the join key from the outer sequence
                                                     (progC) => progC.ProgrammeID, // lambda to extract the join key from the inner sequence
                                                     (s, progC) => new {
                                                         s.FirstName,              // lambda to create the result set
                                                         s.Surname,
                                                         s.ProgrammeID,
                                                         progCourseID = progC.ProgrammeID,
                                                         progC.CourseName
                                                     });

            foreach (var record in studentsWithCourses2)
            {
                rtbExtraQueries.AppendText(record.FirstName + " " +
                                           record.Surname + " " +
                                           "ProgramID: " + record.ProgrammeID + " " +
                                           "progCourseID: " + record.progCourseID + " " +
                                           record.CourseName + Environment.NewLine);
            }

            // Example left outer join:
            var studentsWithCourses3 = from student in Students
                                       join progCourses in ProgrammeCourses on student.ProgrammeID equals progCourses.ProgrammeID into temp
                                       from progCourses in temp.DefaultIfEmpty()  //basically says if student has no identifiable course, set course to default for the type (null as course is an object)
                                       orderby student   //note we make use of the IComparable interface here
                                       select new
                                       {
                                           student.FirstName,
                                           student.Surname,
                                           student.ProgrammeID,
                                           progCourseID = progCourses == null ? -1 : progCourses.ProgrammeID,
                                           CourseName = progCourses == null ? "Freewheeling Student!" : progCourses.CourseName
                                       };

            foreach (var record in studentsWithCourses3)
            {
                rtbNumbers.AppendText(record.Surname + " " +
                                      record.FirstName + " " +
                                      "ProgramID: " + record.progCourseID    + " " +
                                      "progCourseID: " + record.progCourseID + " " +
                                      record.CourseName + Environment.NewLine);
            }
        }

        private void btnCCPP_Click(object sender, EventArgs e)
        {
            ResetRTBs();

            var orderedGroupedCourses
                    = ProgrammeCourses.GroupBy(progCourse => progCourse.ProgrammeID)
                                    // In the above we only specify TKey value as the TValue is the 
                                    // entire Course object
                                      .OrderBy(grpCourse => grpCourse.Key)
                                      .Select(orderedGrpdCourses => new
                                      {
                                          ProgId = orderedGrpdCourses.Key,
                                          CourseCount = orderedGrpdCourses.Count()
                                      });
            /*
            There are overloads of GroupBy that enable you to narrow down the associated TValue value entity of
            each group TKey-TValue pair. As mentioned above, we are grouping based on ProgrammeID and
            mapping to an entire Course entity that is stored in a IGrouping<TKey, TValue> collection.
            */
            rtbStudents.AppendText($"Method syntax: The number of courses in each programme{Environment.NewLine}");
            foreach (var item in orderedGroupedCourses)
            {
                rtbStudents.AppendText($"Programme ID: {item.ProgId} has {item.CourseCount} course(s).{Environment.NewLine}");
            }

            // Method syntax version of the above Linq query:
            var orderedGroupedCoursesMS =
                    from progCourses in ProgrammeCourses
                    group progCourses.CourseName by progCourses.ProgrammeID into groupByCourses
                    orderby groupByCourses.Key
                    select new { ProgID = groupByCourses.Key, CourseCount = groupByCourses.Count() };
        }
    }
}
