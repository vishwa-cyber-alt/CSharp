using System;

public class Program
{
    public void Getresult(int mark)
{
        if(mark<35)
        {
            Console.WriteLine("Fail");
        }
        else{
            Console.WriteLine("Pass");
        }
        
    }
    public static void Main(string[] args)
    {
        Program a=new Program();
       a.Getresult(80);
       a.Getresult(34);
    }
}