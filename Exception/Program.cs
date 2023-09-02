using System;

public class Program
{
    public static void Main()
    {
        Student std = null;

        try
        {
            PrintStudentName(std);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }

    public static void PrintStudentName(Student std)
    {
        if (std == null)
            throw new NullReferenceException("Student object is null. ");

        Console.WriteLine(std.StudentName);
    }
}

public class Student
{

    public string StudentName { get; set; }
}
