namespace mstest.testproj1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Test1()
    {
        Assert.AreEqual(1, 1);
    }

    [DataTestMethod]
    [DataRow(1)]
    [DataRow(2)]
    public void Test2(int a)
    {
        Assert.AreEqual(1, a);
    }
}
