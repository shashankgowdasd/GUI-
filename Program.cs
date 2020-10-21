using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
           var name = new Student();
           name.add(23.6);
           name.add(50.45);
           name.add(67.8);
           name.add(67.5);
           
           var result = name.getstatistics();
            Console.WriteLine($" avaerage grade:{result.average}");
            Console.WriteLine($" avaerage grade:{result.high}");
            Console.WriteLine($" avaerage grade:{result.low}");
        }
    }
}
