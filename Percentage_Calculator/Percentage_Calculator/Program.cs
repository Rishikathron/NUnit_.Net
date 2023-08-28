using StudentGrades;

var gradeCalculator = new GradeCalculator();

Console.Write("Enter The Percentage : ");
var Percentage = Convert.ToInt32(Console.ReadLine());

var grade = gradeCalculator.GetGradeByPercentage(Percentage);

Console.WriteLine($"Student Grade : {grade}");