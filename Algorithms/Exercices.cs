namespace Algorithms;
using System;

class Exercice {
    public static List<int> Get2Biggers(List<int> list) {
        return list.OrderByDescending(n => n).Take(2).ToList();
    }
    public string PathToString(List<Point> path) {
        string ret = "[";
        bool isFirst = true;
        foreach(Point p in path) {
            string prefix = isFirst ? "" : ",";
            ret += prefix + p.ToString();
            isFirst = false;
        };
        return ret;
    }
}