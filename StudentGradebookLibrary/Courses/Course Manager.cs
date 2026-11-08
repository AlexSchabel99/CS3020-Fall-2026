using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradebookLibrary.Courses
{
    internal class CourseManager 
    {
        public string CourseName { get; set; }
        public int CourseID { get; set; }
        public string CourseDescription { get; set; }

        public CourseManager(string CourseName, int CourseID, string CourseDescription)
        {
            CourseName = CourseName;
            CourseID = CourseID;
            CourseDescription = CourseDescription;
        }
        public string GetCourseID()
        {
            return GetCourseID();
        }
    }
}

          
