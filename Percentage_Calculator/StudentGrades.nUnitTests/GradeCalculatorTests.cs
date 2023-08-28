namespace StudentGrades.nUnitTests
{
    public class GradeCalculatorTests
    {
        private GradeCalculator _gradeCalculator  { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [TestCase(91)]
        [TestCase(1)]
        [TestCase(100)]
        [TestCase(83)]
        [TestCase(77)]
        [TestCase(65)]
        public void GetGradeByPercentage_EqualTests(int Percentage)
        {
            //Assign
            

            //Act
            string grade = _gradeCalculator.GetGradeByPercentage(Percentage);
            //string actual = "B";
            //Assert
            if(Percentage >= 91 && Percentage <= 100)
            {
                Assert.AreEqual("A", grade);
            }
            else if (Percentage >= 81 && Percentage <= 90)
            {
                Assert.AreEqual("B", grade);
            }
            else if(Percentage >= 71 && Percentage <= 80)
            {
                Assert.AreEqual("C", grade);
            }
            else if (Percentage >= 61 && Percentage <= 70)
            {
                Assert.AreEqual("D", grade);
            }
            else
            {
                Assert.That("Fail", Is.EqualTo(grade));
            }
            
            //Assert.That(actual, Is.EqualTo(grade));
        }
    }
}