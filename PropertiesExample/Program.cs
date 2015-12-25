using System;

namespace PropertiesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Code = "001";
            s.Name = "Zara";
            s.Age = 15;

            Console.WriteLine("\nStudent info => {0}", s);

            s.Code = "002";
            s.Name = "Fahim";
            s.Age = 16;

            Console.WriteLine("\nStudent info =>\n {0}", s);

            s.Code = "003";
            s.Name = "Kabir";
            s.Age += 1;

            Console.WriteLine("\nStudent info => {0}", s);
            Console.ReadKey();
        }
    }
}
