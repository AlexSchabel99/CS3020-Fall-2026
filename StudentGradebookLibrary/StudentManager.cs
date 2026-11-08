using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;



namespace StudentGradebookLibrary
{
    // Interface for StudentManager class
    public interface IStudentManager
    {
        // Interface methods for StudentManager class

        void Create(string name);
        void Get();
        Student? Get(Guid studentId);
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
        public void Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty!");
                return;
            }

            Student student = new Student(name);

            Students.Add(student);

            string json = JsonSerializer.Serialize(
                Students,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText("gradebook.json", json);

            Console.WriteLine("Student created successfully.");
        }

        public void Get()
        {
            if (File.Exists("gradebook.json"))
            {
                string json = File.ReadAllText("gradebook.json");

                Students = JsonSerializer.Deserialize<List<Student>>(json)
                           ?? new List<Student>();
            }
            else
            {
                Students = new List<Student>();
            }
        }

        
        // Returns a student based on the ID 
        public Student? Get(Guid studentId)
        {
            // Searched the list for a matching student
            Student? student = Students.Find(s => s.StudentID == studentId);

            return student;
        }

        public void DisplayAllStudents()
        {
            
        }

        public void Delete(Student student)
        {
            
        }

        // Updates student information 
        public void Update(Student student)
        {

            // Finds student based on ID
            Student? existingStudent = Get(student.StudentID);

            // Stops if there is no matches 
            if (existingStudent == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            // Updates the students information 
            existingStudent.Name = student.Name;
            existingStudent.Marks = student.Marks;

            // Serialize the list for JSON
            string json = JsonSerializer.Serialize(
                Students,
                new JsonSerializerOptions { WriteIndented = true}
            );

            // Saves the changes 
            File.WriteAllText("gradebook.json", json);

            Console.WriteLine("Student updated successfully!");
            
        }


    }
}
