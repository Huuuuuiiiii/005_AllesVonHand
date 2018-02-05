using System;

namespace _005_AllesVonHand
{
	class Program
	{
		public static int NumberOne;
		public static int NumberTwo;
		public static int ResultAddition = 0;
		public static int ResultSubstraction = 0;
		public static double ResultDivision = 0.0;
		public static int ResultMultiplication = 0;
		public static int ResultModulo = 0;
		public static string ResultCompare;

		static void Main()
		{
			Console.WriteLine("Geben Sie die erste ganze Zahl ein");
			string inputOne = Console.ReadLine();
			NumberOne = Convert.ToInt32(inputOne);
			
			Console.WriteLine("Geben Sie die zweite ganze Zahl ein");
			string inputTwo = Console.ReadLine();
			NumberTwo = Convert.ToInt32(inputTwo);

			addition();
			substraction();
			division();
			multiplication();
			modulo();
			biggerSmaller();

			Console.WriteLine("Wenn man die Zahlen {0} und {1} miteinander Addiert, so erhält man das Resultat: {2}",NumberOne, NumberTwo, ResultAddition);
			Console.WriteLine("Wenn man die Zahlen {0} und {1} miteinander Substrahiert, so erhält man das Resultat: {2}",NumberOne, NumberTwo, ResultSubstraction);			
			Console.WriteLine("Wenn man die Zahlen {0} und {1} miteinander Dividiert, so erhält man das Resultat: {2}",NumberOne, NumberTwo, ResultDivision);
			Console.WriteLine("Wenn man die Zahlen {0} und {1} miteinander Multipliziert, so erhält man das Resultat: {2}", NumberOne, NumberTwo, ResultMultiplication);
			Console.WriteLine("Wenn man die Zahlen {0} und {1} miteinander Modulosiert, so erhält man das Resultat: {2}", NumberOne, NumberTwo, ResultModulo);
			Console.WriteLine(ResultCompare);
			Console.WriteLine("\nDrücken Sie die Enter-Taste um das Programm zu beenden");

			Console.ReadLine();	
		}
		
		static int addition()
		{
			ResultAddition = NumberOne + NumberTwo;
			return ResultAddition;
		}

		static int substraction()
		{
			ResultSubstraction = NumberOne - NumberTwo;
			return ResultSubstraction ;
		}
		
		static double division()
		{
			double NumberOneDouble = Convert.ToDouble(NumberOne);
			double NumberTwoDouble = Convert.ToDouble(NumberTwo);
			ResultDivision = NumberOneDouble / NumberTwoDouble;
			return ResultDivision ;
		}
		
		static int multiplication()
		{
			ResultMultiplication = NumberOne * NumberTwo;
			return ResultMultiplication ;
		}

		static int modulo()
		{
			ResultModulo = NumberOne % NumberTwo;
			return ResultModulo ;
		}

		static string biggerSmaller()
		{
			if(NumberOne > NumberTwo){
	
				ResultCompare = "Die Nummer " +NumberOne+ " ist grösser als die Nummer "+NumberTwo;
				return ResultCompare;
			}
			else if(NumberOne < NumberTwo){

				ResultCompare = "Die Nummer "+NumberOne+ " ist kleiner als die Nummer "+NumberTwo;
				return	ResultCompare;
			}else{

				ResultCompare = "Beide Nummern sind gleich gross.";
				return ResultCompare;
			}
		}
	}
}



























