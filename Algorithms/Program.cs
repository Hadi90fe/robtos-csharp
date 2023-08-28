// See https://aka.ms/new-console-template for more information
namespace Algorithms;
using System;



class EntryPoint
{


    public static void Main(String[] args)
    {
        SierpinskiTriangle st = new SierpinskiTriangle(new Random(666));
        string vegaLite = st.GenerateVegaLiteSpec(new Point(2, 3), 2000);
        Console.WriteLine(vegaLite);
    }
}
