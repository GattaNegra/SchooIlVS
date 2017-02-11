using System;

namespace sex_and_gender
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			//Console.WriteLine ("Enter age");
			double age= double.Parse(Console.ReadLine ());

			//Console.WriteLine ("Enter gender");
			var gender = Console.ReadLine ();
			//Console.WriteLine ("Gender: {0}",gender);
			//Console.WriteLine ("Age: {0}",age);

			if (gender=="f") {
				if (age<=16) {
					Console.WriteLine ("Miss");
				} else {
					Console.WriteLine ("Ms.");
				}
			}
			if (gender=="m") {
				if (age<=16) {
					Console.WriteLine ("Master");
				} else {
					Console.WriteLine ("Mr.");
				}
				
			}


		}
	}
}
