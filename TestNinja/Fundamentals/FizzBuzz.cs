namespace TestNinja.Fundamentals
{
    public class FizzBuzz
    {
        public static string GetOutput(int number)
        {
			var result = number.ToString();

            if ((number % 3 == 0) && (number % 5 == 0))
			{
				result = "FizzBuzz";
			}
			else if (number % 3 == 0)
			{
				result = "Fizz";
			}
			else if(number % 5 == 0)
			{
				result = "Buzz";
			}

			return result; 

        }
    }
}