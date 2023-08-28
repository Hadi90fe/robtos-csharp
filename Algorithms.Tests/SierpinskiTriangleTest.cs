namespace Algorithms.Tests;
using Algorithms;

[TestClass]
public class SierpinskiTriangleTest
{
    [TestMethod]
    public void TestGeneration()
    {
        SierpinskiTriangle st = new SierpinskiTriangle(new Random(666));
        Assert.AreEqual(10, st.GenerateRandomPath(new Point(2, 3), 10).Count());
    }
    
}