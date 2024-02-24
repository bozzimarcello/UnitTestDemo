namespace UnitTestDemoApp.NUnitTest
{
    public class GradeCalculatorTests
    {
        private GradeCalculator _gradeCalculator { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [TestCase(90)]
        [TestCase(91)]
        [TestCase(92)]
        [TestCase(-1)]
        public void CalculateGrade_EqualTest(int score)
        {
            // Assing
            //var score = 90;

            // Act
            var grade = _gradeCalculator.CalculateGrade(score);

            // Assert
            Assert.AreEqual("A", grade);
        }
    }
}