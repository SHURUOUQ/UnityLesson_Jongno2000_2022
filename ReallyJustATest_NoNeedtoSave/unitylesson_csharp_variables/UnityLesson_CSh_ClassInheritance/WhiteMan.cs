using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSh_ClassInheritance
{
    class WhiteMan : Human 
    {
        public override void Breath()
        {
            lifeTime++;
            weight += 0.00003f;
            height += 0.00005f;
        }
    }
}
