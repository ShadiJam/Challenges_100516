using System;
using System.Diagnostics;

public class VectorMagnitute
 {
 static float vectorLength(float[,] vecs)
 {
     double dx = (vecs[0, 0] - vecs[1, 0]);
     double dy = (vecs[0, 1] - vecs[1, 1]);
     double Sumsrt = (Math.Sqrt((Math.Pow(dx, 2)) + (Math.Pow(dy, 2))));

     return (float)(Sumsrt);
 }
 public static void Main()
 {
     Console.WriteLine(vectorLength(new float[2, 2] { { 0, 3 }, { 4, 0 } }) == 5);
     Console.WriteLine(vectorLength(new float[2, 2] { { 1, -1 }, { 1, -1 } }) == 0);
     Console.WriteLine(vectorLength(new float[2, 2] { { 0, 1 }, { 0, 0 } }) == 1);
        Console.ReadLine();
 } 
}


