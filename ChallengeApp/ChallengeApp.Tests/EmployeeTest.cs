using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void WhenGetStatisticsResultMax()
        {
            // arrange
            var employee = new Employee("Jan","AS");
            employee.AddGrade(5);
            employee.AddGrade(8);
            employee.AddGrade(12);

            // act
            var result = employee.GetStatistics();
            // asset
            Assert.AreEqual(12, result.Max);
        }

        [Test]
        public void WhenGetStatisticsResultAverageLetter()
        {
            // arrange
            var employee = new Employee("Jan", "AS");
            employee.AddGrade(40);
            employee.AddGrade(50);
            employee.AddGrade(35);

            // act
            var result = employee.GetStatistics();
            // asset
            Assert.AreEqual('C', result.AverageLetter);
        }

        [Test]
        public void WhenGetStatisticsResultMin()
        {
            // arrange
            var employee = new Employee("Jan", "AS");
            employee.AddGrade(25);
            employee.AddGrade(15);
            employee.AddGrade(-40);
            employee.AddGrade(33);
            employee.AddGrade(12);
            employee.AddGrade(55);


            // act
            var result = employee.GetStatistics();
            // asset
            Assert.AreEqual(-40, result.Min);
        }

        [Test]
        public void WhenGetStatisticsResultLetter()
        {
            // arrange
            var employee = new Employee("Jan", "AS");
            employee.AddGrade('A');
            employee.AddGrade('D');


            // act
            var result = employee.GetStatistics();
            // asset
            Assert.AreEqual('B', result.AverageLetter);
        }

        [Test]
        public void WhenGetStatisticsResultAll()
        {
            // arrange
            var employee = new Employee("Jan", "AS");
            employee.AddGrade(90);
            employee.AddGrade(60);
            employee.AddGrade(75);


            // act
            var result = employee.GetStatistics();
            // asset
            Assert.AreEqual('B', result.AverageLetter);
            Assert.AreEqual(90, result.Max);
            Assert.AreEqual(60, result.Min);
            Assert.AreEqual(75, result.Average);
        }
    }
}