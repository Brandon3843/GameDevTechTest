using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


public static class PointAnalyser
{

    private static List<Point> GetData()
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
                int y = int.Parse(values[1]);
                int num = int.Parse(values[2]);
                Point.Direction dir = (Point.Direction)Enum.Parse(typeof(Point.Direction), values[3], true);

                points.Add(new(x, y, num, dir));
                i++;
            }
        }

        return points;
    }


    // inputP is the origin of cone
    // angleCentre is angle the centre line of the cone points towards, measured in degrees clockwise to north line
    // spread is the angle in degrees of cone either side of centre line
    // dist is the length of cone
    public static Point[] VisiblePoints(Vector2 inputP, float angleCentre, float spread, float dist)
    {
        List<Point> points = GetData();

        // finding unit vector of direction pointing to
        angleCentre = (90 - angleCentre) * (float)(Math.PI / 180);
        Vector2 vecCone = new Vector2((float)Math.Cos(angleCentre), (float)Math.Sin(angleCentre));


        // looping over all points backwards
        for (int i = points.Count - 1; i>=0; i--)
        {
            Vector2 vecPointDelta = points[i].loc - inputP;

            // removing if greater than max distance and moving to next point
            if (vecPointDelta.Length() > dist)
            {
                points.Remove(points[i]);
                continue;
            }

            // find angle between facing vector and point
            float dot = (float)Vector2.Dot(vecPointDelta, vecCone);
            float angleCentreToPoint = (float)Math.Acos( dot / ( vecPointDelta.Length() * vecCone.Length() ) );

            // removing point if angle to centreline is greater than spread
            if (angleCentreToPoint / (float)(Math.PI / 180) > spread)
            {
                points.Remove(points[i]);
            }
        }

        // returning point list as array
        return points.ToArray();
    }
}

