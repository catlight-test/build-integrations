namespace dotnet_failed_tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Fail("Intentional test fail");
    }

    [Test]
    public void Test2()
    {
        Assert.Pass();
    }
}