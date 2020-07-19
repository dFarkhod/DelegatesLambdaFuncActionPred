using System;

namespace DelegateLambdaExFuncActPredDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MySmartCalc myClass = new MySmartCalc();
            myClass.CalculateCircumference(12, CalculationCompleted);
            Console.Read();
        }

        static void CalculationCompleted(double result)
        {
            Console.WriteLine($"Aylana uzunligi: {result}");
        }
    }

    public class MySmartCalc
    {
        public const double PI = 3.14;
        public delegate void CalculationCompletedCallback(double result);
        
        public void CalculateCircumference(double radius, CalculationCompletedCallback callback)
        {
            double result = 2 * PI * radius;
            callback.Invoke(result);
        }
    }
}
