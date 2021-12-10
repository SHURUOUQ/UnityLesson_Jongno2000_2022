using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReallyJustATest_NoNeedtoSave
{
	class Program
	{
		static void 전투(string[] args)
		{
		}
	}

	Pubic class 검사
	{
		float HP = 100f;
		int ATK = 80;

		Public void 내려찍기(Monster monster)
		{
			monster.HP = monster.HP - ATK;
		}


		class 캐릭터생성

		{
			검사 검사1 = new 검사();
			검사1.내려찍기();
		}

		class Monster
		{
			Public float HP = 1000f;

		}

}
