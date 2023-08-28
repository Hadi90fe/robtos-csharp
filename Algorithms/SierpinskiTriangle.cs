using System.Net;
using System.Threading.Tasks.Dataflow;

namespace Algorithms;

public class SierpinskiTriangle
{
    private readonly Random random;

    public SierpinskiTriangle(Random random)
    {
        this.random = random;
    }

    private string generateVegaLiteSpec(string path)
    {
        return $$""" 
        {
            "$schema": "https://vega.github.io/schema/vega-lite/v5.json",
            "data": {"values": {{path}} },
            "width": 600,
            "height": 600,
            "mark": {"type": "point", "filled": true, "size": 2},
            "encoding": {
                "x": {"field": "x", "type": "quantitative"},
                "y": {"field": "y", "type": "quantitative"}
            }
        }
        """;
    }

    private string PathToString(List<Point> path)
    {
        return "[ " + string.Join(", ", path) + " ]";
    }

    public List<Point> GenerateRandomPath(Point point, int length)
    {
        List<Point> path = new List<Point>();
        Triangle triangle = Triangle.Equilateral(10);
        for (int i = 0; i < length; i++)
        {
            path.Add(point);
            point = point.MidPointOf(triangle.RandomSummit(random));
        }
        return path;
    }

     public string GenerateVegaLiteSpec(Point point, int length){
        List<Point> path = GenerateRandomPath(point, length);
        string pathAsString = PathToString(path);
        return generateVegaLiteSpec(pathAsString);
     }


}