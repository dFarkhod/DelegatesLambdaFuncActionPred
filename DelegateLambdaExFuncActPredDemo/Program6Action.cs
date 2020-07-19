using System;

namespace DelegateLambdaExFuncActPredDemo
{
    class Program6_Action
    {
        static void Main(string[] args)
        {
            Action<string> WriteToConsoleAction = content =>  Console.WriteLine(content);
            WriteToConsoleAction("Alhamdulillah!");
            Console.Read();
        }


    }

}
