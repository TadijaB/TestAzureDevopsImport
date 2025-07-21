namespace TestAzureDevopsImport;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [Ignore("")]
    public void Test_1()
    {
        Assert.Fail("My failed test.");
    }

    [Test]
    public void Test_2()
    {
        Assert.Pass();
    }

    [Test]
    public void Test_3()
    {
        Assert.Pass();
    }
}
