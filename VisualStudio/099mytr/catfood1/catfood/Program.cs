using System;

namespace catfood
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("This is a catfood calculator!");
			Console.WriteLine ("How many cats?");
			var cats = int.Parse(Console.ReadLine ());
			Console.WriteLine ("How many kilos is the Bag?");
			var amount = double.Parse(Console.ReadLine ())*1000;
			Console.WriteLine ("Ration quantity in grams?");
			var ration = int.Parse(Console.ReadLine ());
			var servings = ((amount/ration)/cats);
			Console.WriteLine ("How many times per day?");
			var feedingsPerDay = int.Parse(Console.ReadLine ());
			var time = Math.Round(servings / feedingsPerDay);
			Console.WriteLine("Cats: {0} \nPackage: {1} \nRation: {2} grams \nServings: {3} \nWill last {4} days",cats,amount/1000,ration,servings,time);


		}
	}
}
