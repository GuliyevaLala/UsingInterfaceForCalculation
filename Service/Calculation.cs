using System;

namespace Service {
    public class Calculation : ICalculation {
		public void CalculatorMethod()
		{
			Console.WriteLine("Please enter the first number");
			double first = Convert.ToDouble(Console.ReadLine());
		    Console.WriteLine("Please choose the operation + , - , * ,  /");
		Turnback: string operation = Console.ReadLine();
			if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
			{
				Console.WriteLine("Please enter the second number");
				double second = Convert.ToDouble(Console.ReadLine());

				switch (operation)
				{
					case "+":
						Console.WriteLine("The result is : {0}", first + second);
						break;
					case "-":
						Console.WriteLine("The result is : {0}", first - second);
						break;
					case "*":
						Console.WriteLine("The result is : {0}", first * second);
						break;
					case "/":
						Console.WriteLine("The result is : {0}", first / second);
						break;

				}
			}
			else
			{
				Console.WriteLine("Opps..Something went wrong. Please enter valid operation");
				goto Turnback;

			}
		}

	}
}
