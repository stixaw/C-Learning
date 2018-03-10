using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIF
{
	class Program
	{
		static void Main(string[] args)
		{
			grades();
		}

		static void grades()
		{
			string grade;
			int score = 0;

			Console.WriteLine("Please Enter your score between 1-100");
			var num = Console.ReadLine();

            int.TryParse(num, out score);


			if (score >= 50)
			{
                Console.WriteLine(num);
				if (score >= 90)
				{
					grade = "A";
				}
				if (score >= 80)
				{
					grade = "B";
				}
				if (score >= 70)
				{
					grade = "C";
				}
				else
				{
					grade = "D";
				}
			}
			else
			{
                grade = "F";
			}
            string gradeMessage = "You earned the grade of  " + grade + " for your score of " + num + ".";
            Console.WriteLine(gradeMessage);
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();

    }

}
}
