namespace Algorithms;
using System;
using System.Globalization;

public class Point
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

    public double Distance(Point other)
    {
        double xDiff = X() - other.X();
        double yDiff = Y() - other.Y();
        return Math.Sqrt(xDiff * xDiff + yDiff*yDiff);
    }

    public Point MidPointOf(Point other)
    {
        double midX = (X() + other.X()) / 2;
        double midY = (Y() + other.Y()) / 2;
        return new Point(midX, midY);
    }

    public override string ToString(){
        return "{\"x\": " 
        + this.x.ToString(CultureInfo.InvariantCulture) 
        + ", \"y\": " 
        + this.y.ToString(CultureInfo.InvariantCulture)
        + "}";
    }

}