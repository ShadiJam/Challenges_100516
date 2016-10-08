using System;
using System.Diagnostics;

public class Program
{
    static string tweeter(string text)
    {
        string newText = text;
        int index = newText.IndexOf("naps");

        while (index != -1)
        {
            newText = newText.Remove(index, 4).Insert(index, "maps");
            index = newText.IndexOf("naps");

        }
        return newText;
    }
    public static void Main()
    {
        Console.WriteLine(tweeter("I really like naps") == "I really like maps");
        Console.WriteLine(tweeter("naps maps naps maps") == "maps maps maps maps");
    }
}


