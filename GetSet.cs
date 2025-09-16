using System;

namespace PropertyDemo
{
    public class Student
    {
        public string Name { get; set; }
        public string Course { get; set; }
        public int Age { get; set; }

        public Student(string studentName, string studentCourse, int studentAge)
        {
            Name = studentName;
            Course = studentCourse;
            Age = studentAge;
        }

        public void Greet()
        {
            Console.WriteLine($"\nName: {Name}\nCourse: {Course}\nAge: {Age}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Student Fullname: ");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter Student Course: ");
            string studentCourse = Console.ReadLine();

            Console.WriteLine("Enter Student Age: ");
            int studentAge = Convert.ToInt32(Console.ReadLine());

            Student student = new Student(studentName, studentCourse, studentAge);

            student.Greet();
            
       
        }
    }
}
