using System;

/// <summary>
/// Point class
/// </summary>
/// 
public class Point
{
	public Point(int x, int y, int num, Direction dir)
	{
		this.x = x;
		this.y = y;
		this.num = num;
		this.dir = dir;
	}

	public enum Direction
	{
		North, East, South, West
	}

	
	public int x;
	public int y;
	public int num;
    public Direction dir;
}
