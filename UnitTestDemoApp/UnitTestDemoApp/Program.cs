using UnitTestDemoApp;

var gradeCalculator = new GradeCalculator();

Console.WriteLine("Enter the percentage:");

var score = int.Parse(Console.ReadLine());

var grade = gradeCalculator.CalculateGrade(score);  

Console.WriteLine($"The grade is {grade}");