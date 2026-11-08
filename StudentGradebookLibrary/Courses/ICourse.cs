using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradebookLibrary.Courses
{
    internal interface ICourse
    {
        string CourseName { get; set; }
        int CourseID { get; set; }

        string Description { get; set; }

    }
}
