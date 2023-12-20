using System;
using System.Numerics;

/// <summary>
/// Point class defining points
/// </summary>
/// 
public class Point
{
	public Point(int x, int y, int num, Direction dir)
	{
		this.loc.X = x;
		this.loc.Y = y;
		this.num = num;
		this.dir = dir;
	}

	public enum Direction
	{
		North, East, South, West
	}

	public Vector2 loc;
	public int num;
    public Direction dir;
}
