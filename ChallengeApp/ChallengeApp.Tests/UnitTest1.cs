

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectOnePositiveAndOneNegativescore_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Jan", "As", 30);
            employee.AddScore(-5);
            employee.AddScore(8);

            // act
            var result = employee.Result;
            // asset
            Assert.AreEqual(3, result);
        }

        [Test]
        public void WhenEmployeeCollectTwoPositiveScoresAndOneNegative_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Monika", "Czyszka", 22);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(-2);

            // act
            var result = employee.Result;
            // asset
            Assert.AreEqual(9, result);
        }

        [Test]
        public void WhenEmployeeCollectThreeScoresAndSumZero_ShouldCorrectResult3()
        {
            // arrange
            var employee = new Employee("Zuzia", "Sanda³", 15);
            employee.AddScore(25);
            employee.AddScore(15);
            employee.AddScore(-40);
            

            // act
            var result = employee.Result;
            // asset
            Assert.AreEqual(0, result);
        }
    }
}