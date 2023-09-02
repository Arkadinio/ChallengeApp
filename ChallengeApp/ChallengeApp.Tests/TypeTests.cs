namespace ChallengeApp.Tests;

public class TypeTests
{
    [Test]
    public void TestTwoDouble()
    {
        // arrange
        double result1 = 1.23;
        double result2 = 1.23;

        // act

        // assert
        Assert.AreEqual(result1, result2);
    }

    [Test]
    public void TestTwoString()
    {
        // arrange
        string result1 = "test";
        string result2 = "test";

        // act

        // assert
        Assert.AreEqual(result1, result2);
    }

    [Test]
    public void TestTwoInt()
    {
        // arrange
        int result1 = 5;
        int result2 = 5;

        // act

        // assert
        Assert.AreEqual(result1, result2);
    }

    [Test]
    public void TestTwoChar()
    {
        // arrange
        char result1 = 'c';
        char result2 = 'c';

        // act

        // assert
        Assert.AreEqual(result1, result2);
    }


    [Test]
    public void TESTGetEmployeeNotEqual()
    {
        // arrange
        var employee1 = GetUser("test");
        var employee2 = GetUser("test");

        // act

        // assert
        Assert.AreNotEqual(employee1, employee2);
    }

    private Employee GetUser(string name)
    {
        return new Employee(name);
    }

}
