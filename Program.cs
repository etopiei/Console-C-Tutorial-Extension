using System;
using System.Configuration;

namespace Console
{
	class Rectangle
	{

		double length;
		double width;

		public void AcceptDetails() {
			
			length = 6;
			width = 12;

		}

		public double CalculateArea() {

			return length * width; 

		}

		public void DisplayInfo () {

			System.Console.WriteLine ("Length: {0}", length);
			System.Console.WriteLine ("Width: {0}", width);
			System.Console.WriteLine ("Area: {0}", CalculateArea());


		}

	}

	class DoStuff {

		public static void Main (string[] args)
		{

			System.Console.WriteLine ("Enter 1 for rectangle, 2 for odd or even");
			int UserInput = Convert.ToInt32 (System.Console.ReadLine ()); 

			if (UserInput == 1) {

				MakeRectangle wow = new MakeRectangle ();
				wow.Main ();

			} else if (UserInput == 2) {

				CheckIfOddOrEven yay = new CheckIfOddOrEven ();
				yay.Check ();

			} else {

				System.Console.WriteLine("WOW!");
				System.Console.ReadLine ();

			}

			}


	}

	class MakeRectangle {

			public void Main () {

		Rectangle r = new Rectangle ();
		r.AcceptDetails ();
		r.DisplayInfo ();

		System.Console.ReadLine ();

			}

	}

	class CheckIfOddOrEven {

			public void Check() {

			System.Console.WriteLine ("Enter a positive integer");

			int n = Convert.ToInt32 (System.Console.ReadLine ());

			int answer = n % 2;

			if (answer == 1) {

				System.Console.WriteLine ("Integer is odd");

			}

			else {

				System.Console.WriteLine ("Integer is even");

			}

			System.Console.ReadLine ();

			}

		}

}