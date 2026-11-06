using System;
using System.Collections.Generic;



namespace StudentGradebookLibrary
{
    // Interface for StudentManager class
    public interface IStudentManager
    {
        // Interface methods for StudentManager class

         void Create();
         void Get();
         void DisplayAllStudents();

         void Delete(Student student);
         void Update(Student student);

     
    }

    // StudentManager class implements the iStudentManager interface
    public class StudentManager : IStudentManager
    {
        List<Student> Students;


        public StudentManager(List<Student> students)
        {
           this.Students = students;
  
        }

        // Implement Methods from iStudentManager interface below
         public void Create()
        {
            
        }
        public void Get()
        {
            
        }
        public void DisplayAllStudents()
        {
            
        }

        public void Delete(Student student)
        {
            
        }
        public void Update(Student student)
        {
            
        }


    }
}
