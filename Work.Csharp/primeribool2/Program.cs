using System;

namespace primeribool2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a=4,b=1,c=5,d=4;
			bool x=false;
			if (a>b) {
				if (c>d) {
					if (d>d) {
						x=true; 
					} else {
						if (a>3) {
							x=true; 
						} 
					}
				} else {
					x=true;
				}
			} 

			if (x) Console.WriteLine("Има"); 
			else Console.WriteLine("Няма");

		}
	}
}
