using System;

namespace StudentGradebookLibrary.Courses
{
    internal class CourseInstance : ICourseInstance
    {
        public Guid CourseInstanceID { get; set; }
        public Guid CourseID { get; set; }
        public Semester Semester { get; set; }
        public int Year { get; set; }

        public CourseInstance(Guid courseInstanceID, Guid courseID, Semester semester, int year)
        {
            this.CourseInstanceID = courseInstanceID;
            this.CourseID = courseID;
            this.Semester = semester;
            this.Year = year;
        }
    }
}
