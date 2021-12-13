using System;

namespace unitylesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            // .점연산자
            // 클래스의 멤버에 접근할 때 사용 namespace 안에 클래스에 접근할 때도 사용
            // 객체의 멤버에 접근할 때도 사용.
            person1.name = "김아무개";
            person1.age = 123;
            person1.height = 224.31f;
            person1.isFemale = false;
            person1.genderChar = '남';

            Person person2 = new Person();
            person2.name = "김아무개";
            person2.age = 123;
            person2.height = 254.31f;
            person2.isFemale = true;
            person2.genderChar = '여';
            person1.SayAge();
            person2.Sayname();

        }
    }
}


        class Person
        {   // 접근제한자 : 자료형 앞에 붙여준다.
            // public, private, protected
            // public : 다른 클래스가 접근할 수 있다.
            // private : 다른 클래스는 접근할 수 없다.
            // protected : 상속자만 접근할 수 있다.
            public int age; // 나이 
            public float height; // 키 
            public bool isFemale; // 여자인지?
            public char genderChar; // 성별 문자 
            public string name; // 이름


            
            public void SayALLInfo()
            {
                SayAge();
                SayHeihgt();
                SayIsFemale();
                SaygenderChar();
                Sayname();
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

            public void SaygenderChar()
            {
                Console.WriteLine($"성별 : {genderChar}");

            }


}
  