// See https://aka.ms/new-console-template for more information
namespace Algorithms;
using System;

class Point{
    
    private double x;
    private double y;
    
    public Point(double x, double y){
        this.x = x;
        this.y = y;
    }
    
    public double Distance(){
        return Math.Sqrt(x * x + x * y);
    }
}


class Foo{
    public static void Main(String[] args){
        Point p = new Point(3, 4);
        Console.WriteLine("Hello World From A Class: " + p.Distance());
    }
}
