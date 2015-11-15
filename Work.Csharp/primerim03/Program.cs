using System;

namespace primerim03
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Имаме променливите ivan и georgi които обозначават кой от тях присъства в нашето въображаемо събитие. 
//			Нека първата ни bool променлива да е "true" (вярна) когато и двамата присъстват
//			Нека втората ни променлива да е вярна когато поне един присъства
//			Нека третата ни променлива да е вярна когато нито един не присъства
//			Нека да видим какво се е получило

			bool ivan = true;
			bool georgi = false;
			bool i_dvamata = ivan && georgi; 
			bool pone_edin = ivan || georgi; 
			bool nito_edin = !pone_edin; 
			Console.WriteLine(i_dvamata + " " + pone_edin + " " +nito_edin);

		
		}
	}
}
