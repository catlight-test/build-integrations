namespace dotnet_failed_build;

public class Tests
{

    public int TestInvalidMethod()
    {
        return "test";
    }
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}