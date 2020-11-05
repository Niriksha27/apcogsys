using System;

namespace calculator
{
    class Program
    {
		public static void Main()
		{
			Console.WriteLine("Enter the first Number");
			int x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Type *,/,+,-");
			string z = Console.ReadLine();
			Console.WriteLine("Enter the second Number");
			int y = Convert.ToInt32(Console.ReadLine());
			if (z == "+")
			{
				Console.WriteLine("Answer: {0}", x + y);
			}
			if (z == "-")
			{
				Console.WriteLine("Answer: {0}", x - y);
			}
			if (z == "*")
			{
				Console.WriteLine("Answer: {0}", x * y);
			}
			if (z == "/")
			{
				Console.WriteLine("Answer: {0}", x / y);
			}

		}
	}
}

