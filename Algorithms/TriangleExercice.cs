namespace Algorithms;

using System;
using System.Numerics;
using System.Xml.Serialization;

public class TriangleExercice
{
    public static string Repeat(string s, int n)
    {
        string ret = "";
        for (int i = 0; i < n; i++)
        {
            ret = ret + s;
        }
        return ret;
    }

    public static string BuildTriangle(int height)
    {
        string ret = "";
        for (int i = 0; i < height; i++)
        {
            int nbrStarts = 2 * i + 1;
            int nbrSpaces = height - (i + 1);
            string spaces = Repeat("_", nbrSpaces);
            string starts = Repeat("*", nbrStarts);
            ret += "" + spaces + starts + "\n";

        }
        return ret;
    }

}