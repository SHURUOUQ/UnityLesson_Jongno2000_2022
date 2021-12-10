using System;

namespace unity_lesson_function
{
    class Program
    {
        static bool doPrintHelloWorld = true;
        static void Main(string[] args)
        {
            if (doPrintHelloWorld)
            {
                printHelloWorld();
            }

            string tmpSomething = "bla bla~";
            printsomething(tmpSomething);
        }

        static void printHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        static void printsomething(string something)
    }   {

            console.WriteLine(something);
        }

}

