// 키워드 : using
// 무언가를 사용하겠다고 선언하는 키워드.

// using을 언제 쓰냐?
// 예시1) 특정 namespace 를 가져다 쓸 때. 
// 만약 다른사람이 unity_lesson 에 있는 내용을 가져다 쓰고싶으면
// 그 사람은 스크립트 최 상단에 using unity_lesson 을 선언해 주어야한다.

// 예시2) 우선순위가 차순위인 함수 호출
// UnityEngine.Physics에 RayCast() 라는 함수가 있음. 
// Unity.Physics 에 RayCast() 라는 함수가 있음. 
// UnityEngine.Physics 가 우선순위기 때문에
// Using UnityEngine.Physics;                   
// UnityEngine.Physics;
// 이렇게 둘 다 선언을 했을 때,
// RayCast()라는 함수를 호출하면
// UnityEngine.Physics.RayCast()가 호출됨.
// 근데 만약 일반적으로 RayCast() 를 호출했는데 Unity.Physics.RayCast() 를 호출하고 싶으면
// Using RayCast = Unity.Engine.Physics.RayCast;
using System;
// 키워드 : namespace
// 클래스 간에 멤버이름 충돌을 방지함.
namespace unity_lesson
{ 
    // C# 에서만 특별하게 Main 함수가 class program 안에 있음
    // 이유는? 00P(객체 지향 프로그래밍) 컨셉에 맞게..
    class Program
    {
        // Main 함수
        // 실행파일(.exe) 을 실행하면 
        // 하드디스크에 있던 프로젝트를 RAM으로 복제한 후처음 실행되는 함수
        
        // static
        // static(정적)은 dynamic(동적) 과 반대되는 개념의 키워드.
        // static 의 의미 : 메모리에 할당수 없다. 
        // dynamic 의 의미 : 메모리에 할당할 수 있다.

        // static class : 해당 클래스로 객체를 생성하고 메모리에 할당하는 것이 금지된다.
        // static method : 이 멤버함수를 포함한 클래스가 여러개 객체화 되고 메모리에 할당되어도
        // (인스턴스화 되어도) 이 멤버함수는 객체가 아닌 클래스를 통해서만 접근 가능하다.

        // void ?
        // 반환값이 없다. 라는 자료형.
        // 함수의 기본 형태 : 입력 -> 기능수행-> 출력
        // void 는 출력이 없다는 뜻

        // Main : 함수의 이름

        // args : arguments 의 줄임말.
        // argument : 인자, 인수
        // 함수의 입력은 함수 이름 뒤에 괄호 열고 "자료형" , "이름" 괄호닫고 형태.
        // 이 함수의 입력 인자를 argument 라고 함.
        static void Main(string[] args)
        {
            // Console?
            // 스크립트 최상단에 Using 으로 선언한 System 이라는 namespace 에 포함된 클래스다.
            // 
            // WriteLine() ?
            // 콘솔창에 괄호안의 내용을 써주는 함수


            // .연산자
            // namespace 안에 있는 class에 접근할 때 namespace.class
            // class 안에 있는 function에 접근할 때 class.function()

            // WriteLine 함수 괄호 안의 내용 : WriteLine함수의 입력 변수.
            // parameter라고함. 
            Console.WriteLine("부추비빔밥");

            // 현재 WriteLine 함수는 입력으로 string 형태를 받고있고
            // string은 문자열을 뜻함. 그리고 문자열은 ""로 표기함.

           

        }
    }
}
