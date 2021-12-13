using System;

namespace unitylesson_Csharp_static_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Person person1 = new Person();
                person1.name = "김아무개";

                Person person2 = new Person();
                person2.name = "이아무개";

                Person.typeName = "사람 타입";
                ork.typeName= "오크타입";

                Person.SayTypeName();
          
            }   
           
           
        }

        class ork
        {
            static public string typeName;

        }
        

       

            class Person
            {
                public int age; // 나이 
                public float height; // 키 
                public bool isFemale; // 여자인지?
                public char genderChar; // 성별 문자 
                public string name; // 이름

                static public string typeName;
                static public void SayTypeName()
                {
                Console.WriteLine(typeName);
                }
                public void SayALLInfo()
                {
                    SayAge();
                    SayHeihgt();
                    SayIsFemale();
                    SaygenderChar();
                    Sayname();
                }

                public void SaygenderChar()
                {
                    throw new NotImplementedException();
                }

                public void SayAge()
                {
                    Console.WriteLine($"나이 : {age}");

                }
                public void SayHeihgt()
                {
                    Console.WriteLine($"키 : {height}");
                }
                public void SayIsFemale()
                {

                    Console.WriteLine($"여자인가? : { isFemale}");
                }
                public void Sayname()
                {
                    Console.WriteLine($"이름 : { name}");

                }
            }

    }
}

