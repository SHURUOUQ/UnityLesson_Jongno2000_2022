using System;

namespace UnityLesson_Csharp_IF
{
    class Program
    {
        static bool condition1 = false;
        static bool condition2 = true;
        static bool condition3 = true;

        static void Main(string[] args)
        {
            if (condition1)
            {
                Console.WriteLine("조건 1이 참이다");
                 
            }
            else if (condition2)
            {
                Console.WriteLine("조건 1이 거짓이고 조건 2가 참이다");
            }
            else if(condition3)
            {
                Console.WriteLine("조건 1,2가 거짓이고 조건 3이 참이다");

            }
           else
            {
                조건 1,2,3이 모두 거짓인 경우 실행할 내용
            }
                    조건이 거짓일 경우 실행할 내용
            Console.WriteLine("조건 1,2,3이 모두 거짓이다");
        }
    }
}
