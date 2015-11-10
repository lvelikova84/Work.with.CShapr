using System;

namespace primerm02.v07
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");
//			Пример1:модул02, видео07
//			Дефинирайте масив от низове и го напълнете с имена на плодове
//			Създайте три променливи с произволни числа от 0 до 2(вкючително)
//			Изпишете съдържанието на масива в произволните ни числа 
//			Поздравления, Вие създадохте първата си ротативка 

			string[] row = {"портокали","банани","лимони"}; 
			var r = new Random();
			int a1 = r.Next(0,3);
			int a2 = r.Next(0,3);
			int a3 = r.Next(0,3);
			Console.WriteLine(row[a1]+" "+row[a2]+" "+row[a3]); 
		}
	}
}
