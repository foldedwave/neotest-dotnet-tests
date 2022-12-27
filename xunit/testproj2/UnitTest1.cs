namespace xunit.testproj2;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(1, 2);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void Test2(int a)
    {
        Assert.Equal(2, a);
    }
}
