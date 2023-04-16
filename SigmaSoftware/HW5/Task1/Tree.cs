namespace SigmaSoftware.HW5.Task1;

public class Tree
{
  public Guid Id { get; } = Guid.NewGuid();
  public Point Coordinate { get; private set; }

  public Tree(int x, int y)
  {
    Coordinate = new Point(x, y);
  }

  public Tree(Point coordinate)
  {
    Coordinate = coordinate.Clone();
  }
}