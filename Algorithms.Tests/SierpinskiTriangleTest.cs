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

  [TestMethod]
    public void testGenerateVegaLiteSpec(){
         SierpinskiTriangle st = new SierpinskiTriangle(new Random(666));
         string vegaLite = st.GenerateVegaLiteSpec(new Point(2, 3), 2);
         Assert.AreEqual(360, vegaLite.Length);
    }
    
}