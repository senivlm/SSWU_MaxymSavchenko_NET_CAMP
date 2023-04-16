namespace SigmaSoftware.HW5.Task1;

public class Point : ICloneable<Point>
{
  public int X { get; set; }
  public int Y { get; set; }

  public Point(int x, int y)
  {
    X = x;
    Y = y;
  }

  public static bool operator ==(Point point1, Point point2)
  {
    return point1.X == point2.X && point1.Y == point2.Y;
  }
  
  public static bool operator !=(Point point1, Point point2)
  {
    return !(point1 == point2);
  }

  public static double DistanceBetweenPoints(Point point1, Point point2)
  {
    double distance = Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));

    return distance;
  }
  public static double GetAngle(Point point1, Point point2)
  {
    return Math.Atan2(point2.Y - point1.Y, point2.X - point1.X) / Math.PI * 180;
  }
  
  public Point Clone()
  {
    return new Point(X, Y);
  }
  
  public override string ToString()
  {
    return $"({X};{Y})";
  }
}