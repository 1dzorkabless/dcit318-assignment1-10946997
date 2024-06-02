using System;

class GradeCalculator
{
	static void Main()
	{
		Console.Write("Enter a numerical grade between 0 and 100: ");
		string input = Console.ReadLine();
		int grade;

		if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
		{
			string letterGrade;

			if (grade >= 90)
				letterGrade = "A";
			else if (grade >= 80)
				letterGrade = "B";
			else if (grade >= 70)
				letterGrade = "C";
			else if (grade >= 60)
				letterGrade = "D";
			else
				letterGrade = "F";

			Console.WriteLine($"The corresponding letter grade is: {letterGrade}");
		}
		else
		{
			Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
		}
	}
}
