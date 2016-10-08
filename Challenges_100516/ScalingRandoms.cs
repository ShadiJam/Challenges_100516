using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ScalingRandoms
{
    static int random(int min, int max)
    {
        Double rnd = new Random().NextDouble();
        int range = max - min;
        Double rndInRange = rnd * range;
        Double result = rndInRange + min;
        return (int)Math.Round(result, 0);
    }
    public static void Main()
    {
        Console.WriteLine(random(1, 2) <= 2 && random(1, 2) >= 1);
        Console.WriteLine(random(-11, 22) <= 22 && random(-11, 22) >= -11);
        Console.ReadLine();
    }
}



