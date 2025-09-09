using System;

internal class Teacher
{
    public string firstName;
    public string middleName;
    public string lastName;
    public string major;

    public Teacher(string TeacherFirstName, string TeacherMiddleName, string TeacherLastName, string TeacherMajor)
    {
   
        firstName = TeacherFirstName;
        middleName = TeacherMiddleName;
        lastName = TeacherLastName;
        major = TeacherMajor;

    }

    public void Greet()
    {
        Console.WriteLine($"\nHello sir, {firstName}  {middleName}  {lastName} , from {major}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Firstname: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Middlename: ");
        string middleName = Console.ReadLine();

        Console.WriteLine("Enter LastName: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter Major: ");
        string major = Console.ReadLine();

        Teacher teacher = new Teacher(firstName, middleName, lastName, major);
        teacher.Greet();
    }
}