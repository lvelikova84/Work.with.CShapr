using System;

namespace mathoper
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
//			Сметнете колко е 2 на степен 10 и го запишете в променливата a. 
//			Това число също така показва колко мегабайта има един гигабайт.
			double a = Math.Pow(2,10);
			Console.WriteLine("2^10 = " + a);

//			Нека да проверим дали числото 16 е точен квадрат. 
//			Това значи, че корена му трябва да е цяло число
			double b = Math.Sqrt( 16 );
			Console.WriteLine(b);

//			Сега ще проверим и 17
			Console.WriteLine( Math.Sqrt( 17).ToString("#0.00"));

//			Изпишете закръглението на дробното число 1.5
			Console.WriteLine( Math.Round(1.5) ); 

//			Закръглете надолу числото 1.6
			Console.WriteLine( Math.Floor(1.6) ); 

//			Закръглете нагоре числото 1.4
			Console.WriteLine( Math.Ceiling(1.4) );



		}
	}
}
