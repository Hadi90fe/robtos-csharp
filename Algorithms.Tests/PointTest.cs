namespace Algorithms.Tests;
using Algorithms;

[TestClass]
public class PointTest
{
    [TestMethod]
    public void TestToString()
    {
        Point point = new Point(0, 1);
        Assert.AreEqual("{\"x\": 0, \"y\": 1}", point.ToString());

        point = new Point(0, 1.5);
        Assert.AreEqual("{\"x\": 0, \"y\": 1.5}", point.ToString());
    }

    [TestMethod]
    public void TestMidPointOf(){
        Point point1 = new Point(2, 6);
        Point point2 = new Point(5, 3);
        Point res = point1.MidPointOf(point2);

        Assert.AreEqual(3.5, res.X(), 0.001);
        Assert.AreEqual(4.5, res.Y(), 0.001);
    }
    

    [TestMethod]
    public void TestDistance(){
        Point point1 = new Point(2, 6);
        Point point2 = new Point(5, 3);
        Assert.AreEqual(4.24264, point1.Distance(point2), 0.001);

    }
}