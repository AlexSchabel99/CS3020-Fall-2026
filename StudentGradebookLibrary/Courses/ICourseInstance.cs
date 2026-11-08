using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradebookLibrary.Courses
{
    internal interface ICourseInstance
    {
        int CourseInstanceID();
        int CourseID();

        string CourseTerm();

        int CourseYear();

    }
}
