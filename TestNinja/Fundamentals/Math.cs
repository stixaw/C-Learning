using System.Collections.Generic;

namespace TestNinja.Fundamentals
{
    public class Math
    {
        public int Add(int a, int b)
        { 
            var result =  a + b;

			// change this line after test case is written if test fails you have a good test
			return result;
        }
        
        public int Max(int a, int b)
        {
			var result = (a > b) ? a : b;
			return result;
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i; 
        }
    }
}