using System;
using System.Collections.Generic;

namespace DelegateLambdaExFuncActPredDemo
{
    class Program7_Predicate
    {
        static void Main(string[] args)
        {
            Predicate<string> IsLongerThan5 = content => content.Length > 5;
            Console.WriteLine(IsLongerThan5("Bismillah"));

            List<string> customers = new List<string>();
            customers.Add("Maxis");
            customers.Add("Digi");
            customers.Add("Celcom");
            customers.Add("Yes!");

            string greaterThan5 = customers.Find(IsLongerThan5);
            Console.WriteLine($"Custome name longer than 5: {greaterThan5}");

            Console.Read();
        }


    }

}
