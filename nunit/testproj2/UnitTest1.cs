namespace nunit.testproj2;

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
        Assert.AreEqual(1, 2);
    }
    
    [Theory]
    [TestCase(1)]
    [TestCase(2)]
    public void Test2(int a)
    {
        Assert.AreEqual(2, a);
    }
}
