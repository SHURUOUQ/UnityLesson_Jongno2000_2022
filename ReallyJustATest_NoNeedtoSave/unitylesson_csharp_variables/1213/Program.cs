using System;

namespace _1213
{
    class Program
    {
        static void Main(string[] args)
        {
            0rc[] = arr_Orc = new Orc[10];
            int length = arr_Orc.Length;
            for (int i = 0; i < length; i++)
            {

                arr_Orc[i] = new Orc();
                arr_Orc[i].name = $"오크{i}";

            }

            for (int i = 0; i < length; i++)
            {
                arr_Orc[i].isResting = GetRandomBool();

            }
        }


        static public bool GetRandomBool()
        {
            Random rand = new Random();
            bool value = Convert.ToBoolean(rand.Next(0, 2));  // Next 함수는 minValue ~ maxValue - 1 범위 값을 반환. 0,2 를 넣으면 0또는 1반응
            return value;


        }
    }

}
