namespace nunit.testproj1;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.AreEqual(1, 1);
    }

    [Theory]
    [TestCase(1)]
    [TestCase(2)]
    public void Test2(int a)
    {
        Assert.AreEqual(1, a);
    }
}
