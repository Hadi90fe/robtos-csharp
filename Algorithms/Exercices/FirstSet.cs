namespace Algorithms.Exercices;

using System;

class Solutions {

    public static string RemoveTitle(string header)
    {
        int idx = header.IndexOf(".");
        return header.Substring(idx + 1);
    }

    public static void MainExampleOfRemoveTitle(string[] args){
        Console.WriteLine(RemoveTitle("4.56.2")); // "56.2"
        Console.WriteLine(RemoveTitle("4.b.ii")); // "b.ii"
        Console.WriteLine(RemoveTitle("")); // ""
        Console.WriteLine(RemoveTitle("4.b")); // "b"
    }

    public static void PrintEachDirectoryOnPath(string path)
    {
        string[] subs = path.Split(':');

        foreach (var sub in subs)
        {
            Console.WriteLine(sub);
        }
    }

    public static void MainExampleOfPrintEachDirectoryOnPath(String[] args){
        string? path = Environment.GetEnvironmentVariable("PATH");
        PrintEachDirectoryOnPath(path ?? "");
    }
}