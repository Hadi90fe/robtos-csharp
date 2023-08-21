// See https://aka.ms/new-console-template for more information
namespace Algorithms;
using System;



class EntryPoint
{


    public static void Main(String[] args)
    {


        IntChainLink lastLink = new IntChainLink(3);
        IntChainLink secondLink = new IntChainLink(2, lastLink);
        IntChainLink firstLink = new IntChainLink(1, secondLink);
        Console.WriteLine(firstLink.Head()); // 1
        Console.WriteLine(firstLink.Rest().Head()); // 2
        Console.WriteLine(firstLink.Rest().Rest().Head()); // 3
    }
}
