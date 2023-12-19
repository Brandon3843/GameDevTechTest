using System.Collections.Generic;
using System.Xml;


//Console.WriteLine("Please input X location:");
//float x = float.Parse(Console.ReadLine());


//Console.WriteLine("Please input Y location:");
//float y = float.Parse(Console.ReadLine());


//Console.WriteLine("Please input cone angle:");
//float angle = float.Parse(Console.ReadLine());


//Console.WriteLine("Please input cone length:");
//float dist = float.Parse(Console.ReadLine());




Point[] output = PointAnalyser.GetData();

foreach (Point p in output)
{
    if (p is null) continue;

    Console.WriteLine("(" + p.x + "," + p.y + "," + p.num + "," + p.dir + ")");
}



//Point p = new(1, 1, 1, Point.Direction.North);
//Console.WriteLine("(" + p.x + "," + p.y + "," + p.num + "," + p.dir + ")");