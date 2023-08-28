namespace Algorithms;

public class SierpinskiTriangle{
    private readonly Random random;

    public SierpinskiTriangle(Random random){
        this.random = random;
    }

    public List<Point> GenerateRandomPath(Point point, int length){
        List<Point> path = new List<Point>();
        Triangle triangle = Triangle.Equilateral(10);
        for(int i = 0; i < length; i++){
            path.Add(point);
            point = point.MidPointOf(triangle.RandomSummit(random));
        }

        return path;
    }
    

}