using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSh_ClassInheritance
{
    class Human :  Creature  ,  iTwoLeggedWalker
    {
        public float height;

        // override 키워드 : 부모의 virtual 키워드가 붙은 함수를 재정의 하는 키워드
        public override void Breath()
        {
            base.Breath(); // base 키워드는 부모 클래스를 지칭함.
            weight += 0.00002f;
            height += 0.00004f;
        }

        public void TwoLeggedWalk()
        {
            Console.WriteLine("두발로 걷는다");
        }
    }
    
}


//객체지향 프로그래밍을 할 때 반드시 지켜주어야 하는 5가지 원칙
//1.SRP( Single Responsibility Principle 단일 책임 원칙)
// 한 클래스는 하나의 책임만 가져야함. 여러가지 가능이나 개념을 한 클래스에 다 넣으면 수정하기도 불편하고 각 클래스에 대한 확장성, 가독성이 떨어진다.


//2. OCP(Open Close Principle, 개방 폐쇄의 원칙)
//재사용 가능하고 관리하기 편한 코드를 만들기 위한 원칙.
//컴포넌트, 클래스, 모듈, 함수의 확장에는 열려있고 변경에는 닫혀있어야 한다.
// ->레고 블록을 처음에 다양하고 정확하게 설계해서, 레고끼리 조립 호환성을 높게 설계한다.
// 조립 도중에 레고블록이 안맞다고해서 레고블록 자체를 자르거나 불로 녹이는 등의 행위를 하면 안됨.

//3. LSP ( The Liskov Substitution Principle, 리스코프 치환 법칙 )
// 하위타입은 기반타입으로 언제든 교체할 수 있어야 한다.
// 기반인 부모클래스로부터 상속받은 하위인 자식크래스가 함수를 오버라이드해서 사용할경우, 언제든지 오버라이드된 함수를 지워서 기반인 부모의 원함수로 교체할 수 있어야함.
//(교체한 후에도 코드가 문제없이 동작해야한다는 뜻)
//리스코프 치환법칙을 지키기 위해서는 특히 다음 4가지를 지키면 된다.
//1)객체가 똑같은 일을 수행한다면 
// ->클래스는 하나로 만들고, 각 객체를 구분지을 수 있는 변수를 만든다.
//2) 기능 이름이 같고 동작은 비슷하나 약간의 차이가 있다면
//->인터페이스를 구현해서 공통으로 상속받는다.
//3)같은 기능을 가지지 않는다면
//->두객체는 각각 별개의 클래스로 구현함.
//4)추가적인 기능을 부여해야 한다면
//->상속을 이용한다.

//4. ISP (Interface Sergergration Principle , 인터페이스 분리 원칙)
//사용하지 않을 인터페이스는 구현하면 안되고,
// 하나의 일반적인 인터페이스보다 여러개의 구체적인 인터페이스를 추구함.
//IpointEvent 라는 인터페이스보다 (IPointerDwonEvent, IPointerUPEvent,IPointerClickEVent 등으로 세분화 하는게 좋다.)

//5. DIP (Dependency Inversion Principle 의존성 역전의 원칙)
// "자신보다 변하기 쉬운것에 의존하지마라"
//
