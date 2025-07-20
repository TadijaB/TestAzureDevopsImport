namespace TestAzureDevopsImport;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [Ignore("")]
    public void Test1()
    {
        Assert.Fail("My failed test.");
    }

    [Test]
    public void Test2()
    {
        Assert.Pass();
    }
}
