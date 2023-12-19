using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class PointAnalyser
{

    public static Point[] GetData()
    {
        List<Point> points = new List<Point>();
        int i = 0;

        using (StreamReader reader = new StreamReader("C:\\Game Dev\\Projects\\GameDevTechTest\\Data.csv"))
        {
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                int x = int.Parse(values[0]);
                int y = int.Parse(values[0]);
                int num = int.Parse(values[0]);
                Point.Direction dir = (Point.Direction)Enum.Parse(typeof(Point.Direction), values[3], true);

                points.Add(new(x, y, num, dir));
                i++;
            }
        }

        return points.ToArray();
    }

    public static Point[] VisiblePoints(float X, float Y, float deg, float dist)
    {
        Point[] RawData = GetData();



        return RawData;
    }
}

