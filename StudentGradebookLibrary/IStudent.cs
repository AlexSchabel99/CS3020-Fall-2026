using System;

namespace StudentGradebookLibrary
{
    public interface IStudent
    {
        Guid StudentID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
