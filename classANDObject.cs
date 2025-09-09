using System;

class Student
{
    public string name;
    public string course;
    public int age;

    public Student(string StudentName, string StudentCourse, int StudentAge)
    {
        name = StudentName;
        course = StudentCourse;
        age = StudentAge;
    }

    public void Greet()
    {
        Console.WriteLine($"\nHello, {name} from {course} , you are {age} years old!");
    }
}

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("\nPlease Enter Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("\nPlease Enter Coursse: ");
        string course = Console.ReadLine();

        Console.WriteLine("\nPlease Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Student st = new Student(name, course ,age);

        st.Greet();
    }
}