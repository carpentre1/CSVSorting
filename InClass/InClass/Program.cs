using System;

namespace InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
            GuidDataGenerator dataGenerator = new GuidDataGenerator();
            dataGenerator.Write();
            dataGenerator.Read();
        }
    }
}
