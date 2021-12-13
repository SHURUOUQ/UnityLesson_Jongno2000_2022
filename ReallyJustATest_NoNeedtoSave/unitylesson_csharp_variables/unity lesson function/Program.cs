using System;

namespace unity_lesson_function
{
    class Program
    {

        static void main(string[] args)
        {
        }
        // CamelCase (이름 설정 규칙 중 하나)
        // class, function namespace 등은 대문자로 시작한다.
        // 변수는 소문자로 시작한다.
        // 단어가 바뀔경우 첫 문자는 대문자로 한다.
        // 줄임말은 되도록 사용하지 않는다.
        // 이름을 보았을 때 어떤 기능, 목적인지 알 수 있도록 작성한다.
        // 애매한 부분이 있으면 주석을 달아준다. 

        class Person
        {
            int age; // 나이 
            float height; // 키 
            bool isFemale; // 여자인지?
            char genderChar; // 성별 문자 
            string name; // 이름



            public void SayALLInfo()
            {
                SayAge();
                SayHeihgt();
                SayIsFemale();
                SaygenderChar();
                Sayname();
            }

            private void SaygenderChar()
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