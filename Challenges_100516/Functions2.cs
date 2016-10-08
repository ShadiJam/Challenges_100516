using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Functions2
{
    static Func<int, int, int> add = (a, b) => a + b;

    public static void Main()
    {

        Console.WriteLine(add(1, 2) == 3);
        Console.ReadLine();
    }
}



