using System;

namespace maimuniibanani
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Имаме маймуни,банани и сандвичи. 
//			Понякога бананите няма да стигнат и ще трябва да нахраним останалите маймуни със сандвичи. 
//			Това е проблем достоен за програмиране, понеже не можем да оставим маймуните гладни.
//			Проверете дали маймуните са повече от бананите и ги нахранете с колкото е възможно повече банани
//			и след това все още гладните маймуни със сандвичи. Ако маймуните не са повече от бананите, 
//			то няма да раздаваме сандвичи.

			int gladni_maimuni = 6;
			int banani = 5;
			int sandvichi = 10;
			if (gladni_maimuni >= banani) {
				gladni_maimuni -= banani;
				banani = 0;
				sandvichi -= gladni_maimuni;
				gladni_maimuni = 0;
			} else {
				banani -= gladni_maimuni;
				gladni_maimuni = 0;
			}
			Console.WriteLine("Гладни маймуни: "+gladni_maimuni
				+"\n Останали банани:"
				+banani+"\n Останали сандвичи:"+sandvichi);
			
		}
	}
}
