using System;

namespace DelegateLambdaExFuncActPredDemo
{
    class Program5_Func
    {
        public const double PI = 3.14;
        static void Main(string[] args)
        {
            Func<double, double> cpointer = radius =>  2 * PI * radius;
            double result = cpointer(12);
            Console.WriteLine($"Alana uzunligi: {result}");
            Console.Read();
        }


    }

}
