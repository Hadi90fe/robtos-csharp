namespace Algorithms.Tests;
using Algorithms;

[TestClass]
public class TriangleTest
{
    [TestMethod]
    public void TestEquilateral()
    {
        Triangle triangle = Triangle.Equilateral(10);
        Assert.AreEqual(10, triangle.Vertex1.Distance(triangle.Vertex2), 0.001);
        Assert.AreEqual(10, triangle.Vertex2.Distance(triangle.Vertex3), 0.001);
        Assert.AreEqual(10, triangle.Vertex3.Distance(triangle.Vertex1), 0.001);
    }

    [TestMethod]
    public void TestGetVertexById(){
        Triangle triangle = Triangle.Equilateral(10);
        Assert.AreEqual(triangle.Vertex1, triangle.GetVertexById(0));
        Assert.AreEqual(triangle.Vertex2, triangle.GetVertexById(1));
        Assert.AreEqual(triangle.Vertex3, triangle.GetVertexById(2));

    }

    [TestMethod]
    public void TestRandomSummit(){
        Triangle triangle = Triangle.Equilateral(10);
        Random random = new Random(666);

        Assert.AreEqual(triangle.Vertex2, triangle.RandomSummit(random));
        Assert.AreEqual(triangle.Vertex1, triangle.RandomSummit(random));
    }
    
}