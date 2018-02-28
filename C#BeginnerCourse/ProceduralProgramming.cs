using System;
using System.Collections.Generic;

namespace CSharp1Exercises
{
    public class ProceduralProgramming
    {
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        public bool IsConsecutiveList(List<int> list)
        {
            // Note that I've copied the list to a new array because I didn't want callign Sort()
            // impact the argument of this method. Caller of this method only expects a true/false answer 
            // as a result of this call. So, this method should not have a side-effect.
            var numbers = new int[list.Count];
            list.CopyTo(numbers);
            Array.Sort(numbers);

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
        /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
        /// any duplicates. If so, display "Duplicate" on the console.
        /// </summary>
        public bool ContainsDuplicates(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
        /// </summary>
        public bool IsValidTime(string time)
        {
            if (String.IsNullOrWhiteSpace(time))
                return false;

            var components = time.Split(':');
            if (components.Length != 2)
                return false;
            
            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                return (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59);
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
        /// create a variable name with PascalCase convention. For example, if the user types: 
        /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
        /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
        /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
        /// </summary>
        public string GetVariableName(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return "";

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            return variableName;
        }


        /// <summary>
        /// Write a program and ask the user to enter an English word. Count the number of vowels 
        /// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
        /// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
        /// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
        /// </summary>
        public int CountVowels(string word)
        {
            var vowels = new List<char>(new char[] {'a', 'e', 'o', 'u', 'i'});
            var vowelsCount = 0;

            // Note the ToLower() here. This is used to count for both A and a. 
            foreach (var character in word.ToLower())
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            return vowelsCount;
        }
    }
}
