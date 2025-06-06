using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            try
            {
                Console.WriteLine(a[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
