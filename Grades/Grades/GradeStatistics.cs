namespace Grades
{
	public class GradeStatistics
	{
		public double HighestGrade { get; set; }
		public double AverageGrade { get; set; }
		public double LowestGrade { get; set; }

		public string Description
		{
			get
			{
				string result;
				switch (LetterGrade)
				{
					case "A":
						result = "Excellent Job!";
						break;
					case "B":
						result = "Great Job";
						break;
					case "C":
						result = "Good enough";
						break;
					case "D":
						result = "Barely passing, you need to work harder";
						break;
					case "F":
						result = "You didn't pass the course, you will need to take it again";
						break;
					default:
						result = LetterGrade + "Unrecognized";
						break;
				}
				return result;
			}
		}

		public string LetterGrade
		{
			get
			{
				string result;
				if (AverageGrade >= 90)
				{
					result = "A";
				}
				else if (AverageGrade >= 80)
				{
					result = "B";
				}
				else if (AverageGrade >= 65)
				{
					result = "C";
				}
				else if (AverageGrade >= 50)
				{
					result = "D";
				}
				else
				{
					result = "F";
				}
				return result;
			}
		}
		//constructor
		public GradeStatistics()
		{
			HighestGrade = 0;
			LowestGrade = double.MaxValue;
		}


	}
}