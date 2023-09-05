

using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void WhenEmployeeResultMin()
        {
            // arrange
            var employee = new Employee("Jan", "As");
            employee.AddGrade(-5);
            employee.AddGrade(8);

            // act
            var result = employee.GetStatistics();
            // asset
            Assert.AreEqual(-5, result.Min);
        }

        [Test]
        public void WhenEmployeeResultAverage()
        {
            // arrange
            var employee = new Employee("Monika", "Czyszka");
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(3);

            // act
            var result = employee.GetStatistics();
            // asset
            Assert.AreEqual(2f, result.Average);
        }

        [Test]
        public void WhenEmployeeResultMax()
        {
            // arrange
            var employee = new Employee("Zuzia", "Sanda³");
            employee.AddGrade(25);
            employee.AddGrade(15);
            employee.AddGrade(-40);
            employee.AddGrade(33);
            employee.AddGrade(12);
            employee.AddGrade(55);


            // act
            var result = employee.GetStatistics();
            // asset
            Assert.AreEqual(55, result.Max);
        }
    }
}