using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSh_ClassInheritance
{
    class Dog : Creature , iFourLeggedWalkers
    {
        public float tailLenght;

        public void FourLeggedWalk()
        {
            Console.WriteLine("네발로 걷는다");
        }
    }
}
