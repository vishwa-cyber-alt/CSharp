using System;
class One
{
    public int id=1;
}
class Two : One
{
    public string name="vishwa";
}
public class Program

    public static void Main(string[] args)
    {
        Two a=new Two();
        Console.WriteLine (a.id);
        Console.WriteLine(a.name);
    }
}