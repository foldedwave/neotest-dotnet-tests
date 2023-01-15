namespace mstest.testproj2;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Test1()
    {
        Assert.AreEqual(1, 2);
    }

    [DataTestMethod]
    [DataRow(1)]
    [DataRow(2)]
    public void Test2(int a)
    {
        Assert.AreEqual(2, a);
    }

    [TestClass]
    public class NestedClass
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(1, 2);
        }
    }
}
