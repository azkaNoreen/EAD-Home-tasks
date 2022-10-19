using System;
using view;

namespace task5
{
	class program
	{
		static void Main(string[] arg)
		{
			PersonView pv = new PersonView();
			pv.Input();
			pv.display();
			Console.ReadKey();

		}
	}
}
