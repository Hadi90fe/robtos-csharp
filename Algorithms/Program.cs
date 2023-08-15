// See https://aka.ms/new-console-template for more information
namespace Algorithms;
using System;



class EntryPoint{


    public static void Main(String[] args){
        Point point1 = new Point(3, 4);
        Point point2 = new Point(-3, -4);
        Point midPoint = point1.MidPointOf(point2);

        Console.WriteLine("Hello World From A Class: " + midPoint.X() + ", " + midPoint.Y());
    }
}
