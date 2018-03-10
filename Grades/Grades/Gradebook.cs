using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
	public class Gradebook
	{
		//Fields
		private string name;
		private List<double> grades;
		public event NameChangedDelegate NameChanged;

		//data - noun - properties (state)
		public int MyProperty { get; set; }
		public string Name
		{
			get { return name; }
			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Name value can not be null");
				}
				
				if (name != value && NameChanged != null)
				{
					NameChangedEventArgs args = new NameChangedEventArgs();
					args.ExistingName = name;
					args.NewName = value;

					NameChanged(this, args);
				}

				name = value;

			}
		}

		//constructor
		public Gradebook()
		{
			name = "Empty";
			grades = new List<double>();
		}

		//behavior - methods - verbs
		public void AddGrade(double grade)
		{
			grades.Add(grade);
		}

		public GradeStatistics ComputeStatistics()
		{
			GradeStatistics stats = new GradeStatistics();

			double sum = 0;
			foreach (var grade in grades)
			{
				stats.HighestGrade = Math.Max(stats.HighestGrade, grade);
				stats.LowestGrade = Math.Min(stats.LowestGrade, grade);
				sum += grade;
			}
			if (grades.Count > 0)
			{
				stats.AverageGrade = sum / grades.Count;
			}

			return stats;
		}

		public void WriteGrades(TextWriter destination)
		{
			if (grades.Count > 0)
			{
				for (int i = 0; i < grades.Count; i++)
				{
					destination.WriteLine(grades[i]);
				}
			}
		}
	}
}
