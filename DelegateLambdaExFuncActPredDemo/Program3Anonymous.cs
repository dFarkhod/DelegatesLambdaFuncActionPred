using System;

namespace DelegateLambdaExFuncActPredDemo
{
    class Program3_AnonymousMethods
    {
        public const double PI = 3.14;
        delegate double CalculateCircumferencePointer(double result);
       // static CalculateCircumferencePointer calcPointer = CalculateCircumference;
        static void Main(string[] args)
        {
            CalculateCircumferencePointer cpointer = new CalculateCircumferencePointer(
                delegate (double radius)
                {
                    return 2 * PI * radius;
                });

            double result = cpointer.Invoke(12);
            Console.WriteLine($"Alana uzunligi: {result}");
            Console.Read();
        }

        //static double CalculateCircumference(double radius)
        //{
        //    return 2 * PI * radius;
        //}

    }

}
