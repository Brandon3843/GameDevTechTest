using System.Collections.Generic;
using System.Numerics;
using System.Xml;


// X, Y, angle, spread, dist
Point[] output = PointAnalyser.VisiblePoints(new Vector2(30, 30), 15, 35, 25);


Console.WriteLine("Points in cone are:");


// printing results
foreach (Point p in output)
{
    if (p is null) continue;

    Console.WriteLine("(" + p.loc.X + "," + p.loc.Y + "," + p.num + "," + p.dir + ")");
}

