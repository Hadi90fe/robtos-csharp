namespace Algorithms;
using System;
class Point
{
    private double x;
    private double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double X()
    {
        return x;
    }

    public double Y()
    {
        return y;
    }

    public double Distance()
    {
        return Math.Sqrt(X() * X() + Y() * Y());
    }

    public Point MidPointOf(Point other)
    {
        double midX = (X() + other.X()) / 2;
        double midY = (Y() + other.Y()) / 2;
        return new Point(midX, midY);
    }

}