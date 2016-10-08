using System;
using System.Diagnostics;

public class Tweeter1
{
    static string tweeter(string text)
    {
        Func<string, bool> hasN = (str) => str.IndexOf("naps") != -1;

        Func<string, string, string, string> replace = (str, oldStr, newStr) =>
            text.Substring(0, text.IndexOf(oldStr)) + newStr +
            text.Substring(text.IndexOf(oldStr) + oldStr.Length);

        while (hasN(text))
        {
            text = replace(text, "naps", "maps");
            Console.WriteLine(text);
        }
        return text;
    }
    public static void Main()
    {
        Console.WriteLine(tweeter("I really like naps") == "I really like maps");
        Console.WriteLine(tweeter("naps maps naps maps") == "maps maps maps maps");
        Console.ReadLine();
    }
}
