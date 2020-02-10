using System;

namespace w2_day1
{
	class Program
	{
		static void Main(string[] args)
		{
			HomeWork3();
		}

		static void HomeWork3()
		{
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine(i);
				Console.WriteLine("stop?");
				var answer = Console.ReadLine();
				if (answer == "stop"|| answer == "yes")
				{
					break;
				}
			}
		}

		static void HomeWork2Calc()
		{
			bool resume = true;
			while (resume == true)
			{
				Console.WriteLine("Insert first digit");
				string input = Console.ReadLine();
				int a = Convert.ToInt32(input);


				Console.WriteLine("+ or - or * or /");
				string math = Console.ReadLine();

				Console.WriteLine("insert 2nd digit");
				input = Console.ReadLine();
				int b = Convert.ToInt32(input);

				double result = Calc(a, math, b);

				Console.WriteLine("Result: " + result);
				Console.WriteLine("Continue? true/false");
				resume = Convert.ToBoolean(Console.ReadLine());
			}

		}

		static double Calc(int a, string math, int b)
		{
			double result = 1;
			if (math == "+")
			{
				result = a + b;
			}
			else if (math == "-")
			{
				result = a - b;
			}
			else if (math == "*")
			{
				result = a * b;
			}
			else if (math == "/")
			{
				result = a / b;
			}
			else
			{
				Console.WriteLine("incorrect mathematical action action");
			}
			return result;
		}

		static void HomeWork1Factorial()
		{
			int sum = 1;
			Console.WriteLine($"Input digit: ");
			int input = Convert.ToInt32(Console.ReadLine());
			for (int i = input; i > 0; i--)
			{
				sum *= i;
			}
			Console.WriteLine($"Result {input}!={sum}");
		}

		static void ExtraExtraSubString()
		{
			int max = 5;
			string stars = "*****";
			for (int i = 1; i <= max; i++)
			{
				Console.WriteLine(stars.Substring(0, i));
			}
			for (int i = max; i >= 0; i-=1)
			{
				Console.WriteLine(stars.Substring(0, i));
			}
		}

		static void ExtraExtra()
		{
			int max = 4;
			//string stars = "*";
			string output = null;
			for (int i = 0; i <= max; i++)
			{
				output += "*";
				Console.WriteLine(output);
			}

			for (int i = max; i > 0; i-=1)
			{
				output = output.Remove(i);
				Console.WriteLine(output);
			}
		}



		static void LoopExtra()
		{
			int sum = 1;
			Console.Write($"Input digit: ");
			int input = Convert.ToInt32(Console.ReadLine());
			Console.Write($"Input degree: ");
			int degree = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < degree; i++)
			{
				sum *= input;
			}
			Console.WriteLine(sum);
		}

		static void ForLoopTask2()
		{
			int sum = 0;
			for (int i = 0; i < 5; i++)
			{
				Console.Write($"Input digit #{i+1}: ");
				int input = Convert.ToInt32(Console.ReadLine());
				sum += input;
			}
			Console.WriteLine(sum);
		}

		static void ForLoopTask1()
		{
			int a = 0;
			for (int i = 1; i <= 10; i++)
			{
				a+=i;
			}
			Console.WriteLine(a);
		}

		static void ForLoopExample()
		{
			for (int i = 1; i < 101; i++)
			{
				Console.WriteLine(i);
			}

			for (int i = 0; i<5; i++)
			{
				Console.WriteLine("cicle value -> " + i);
			}
		}

		//static void ForLoopString(string ab)
		//{
		//	for (ab = null; ab == "bad";)
		//	{
		//		ab = Console.ReadLine();
		//		Console.WriteLine(ab);
		//		Console.WriteLine("test");
		//	}
		//}

		static void WhileAndDoWhile()
		{
			int a = 0;
			while (a < 5)
			{
				Console.WriteLine("cickle value ->" + a);
				a++;
			}
		}
	}
}
