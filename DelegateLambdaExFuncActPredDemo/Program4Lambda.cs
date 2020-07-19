using System;

namespace DelegateLambdaExFuncActPredDemo
{
    class Program4_LambdaExp
    {
        public const double PI = 3.14;
        delegate double CalculateCircumferencePointer(double result);
        static void Main(string[] args)
        {
            CalculateCircumferencePointer cpointer = radius =>  2 * PI * radius;
            double result = cpointer(12);
            Console.WriteLine($"Alana uzunligi: {result}");
            Console.Read();
        }


    }

}
