using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Age");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 18)
        {
            Console.WriteLine("Not Eligible to Vote");
        }
        else
        {
            Console.WriteLine("Eligible to Vote");
        }
    }
}