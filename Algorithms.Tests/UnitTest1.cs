namespace Algorithms.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestQuiPasse()
    {
        Assert.AreEqual(1+ 1, 2);
    }
    [TestMethod]
    public void TestQuiNePassePas()
    {
        Assert.AreEqual(2, 1 + 1);
    }
}