using System;

namespace unitylesson_csharp_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // 자료형 : 변수의 형태

            
        }
    }
}

    class person
{
    // 자료형 : 변수의 형태

    // bit = 한자리 이진수 (0과 1 , 정보처리의 최소단위 )
    // 1 byte = 8 bit (cpu의 데이터 처리 최소단위)
    // 4 byte = 4 * 8bit = 32 bit
    // 각 자료형이 표현할 수 있는 경우의 수 (표현할 수 있는 수) 2^(bit수)
    int Age = 120; // 정수형 4byte
    
    float height = 210.5f; // 실수형 4byte
    bool isFemale false; // 논리형 1byte
    char genderChar = '남'; // 단일문자형 2byte
    string name = "김덕배"; // 문자열형 문자갯수 * 2byte
}
    