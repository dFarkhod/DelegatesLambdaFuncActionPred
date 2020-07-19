using System;

namespace DelegateLambdaExFuncActPredDemo
{
    class Program2_Delegates
    {
        public const double PI = 3.14;
        delegate double CalculateCircumferencePointer(double result);
        static CalculateCircumferencePointer cPointer = CalculateCircumference;
        static void Main(string[] args)
        {
            double result = cPointer.Invoke(12);
            Console.WriteLine($"Alana uzunligi: {result}");
            Console.Read();
        }


        static double CalculateCircumference(double radius)
        {
            return 2 * PI * radius;
        }

    }

}
