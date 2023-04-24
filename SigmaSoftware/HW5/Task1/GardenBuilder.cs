namespace SigmaSoftware.HW5.Task1;
//Maxyv	Savchenko			0	0	98	98	70	30	78,2
public class GardenBuilder
{
  
  private readonly List<Tree> _trees = new List<Tree>();
  
  // Map borders
  private Point? _minPoint;
  private Point? _maxPoint;

  private readonly Dictionary<Align, Point> _fenceBorders = new Dictionary<Align, Point>();

  #region CTORS

  public GardenBuilder(IEnumerable<Tree> trees)
  {
    AddTreeRange(trees.DistinctBy(tree => new { tree.Coordinate.X, tree.Coordinate.Y }));
  }
  public GardenBuilder() { }

  #endregion
  
  public Garden Build()
  {
    if (_minPoint is null || _maxPoint is null)
    {
      throw new Exception("There are no trees");
    }
    
    int differenceX = Math.Abs(_maxPoint.X - _minPoint.X);
    int differenceY = Math.Abs(_maxPoint.Y - _minPoint.Y);

    List<Point> fixedFences = new List<Point>();
    foreach (Point point in GetFenceBorder())
    {
      Point fixedPoint = point.Clone();
      fixedPoint.X += -_minPoint.X + 1;
      fixedPoint.Y += -_minPoint.Y + 1;
      
      fixedFences.Add(fixedPoint);
    }
    
    int[,] gardenMatrix = new int[differenceY + 3, differenceX + 3];

    foreach (Tree tree in _trees)
    {
      int currentTreeX = tree.Coordinate.X - _minPoint.X + 1;
      int currentTreeY = tree.Coordinate.Y - _minPoint.Y + 1;

      gardenMatrix[currentTreeY, currentTreeX] = 1;
    }
    
    Garden garden = new Garden(gardenMatrix, fixedFences);

    return garden;
  }

  #region ADD
  
  public void AddTree(Tree tree)
  {
    if (_trees.Any(currentTree => currentTree.Coordinate == tree.Coordinate))
    {
      return;
    }

    _trees.Add(tree);
    
    UpdateCoordinates(tree.Coordinate);
  }
  public void AddTreeRange(IEnumerable<Tree> trees)
  {
    foreach (Tree tree in trees)
    {
      AddTree(tree);
    }
  }
  
  #endregion
  
  private List<Point> GetFenceBorder()
  {
    if (_trees.Count == 1)
    {
      return Enumerable.Empty<Point>().ToList();
    }
    
    Point currentPoint = _fenceBorders[Align.Bottom];
    List<Point> fenceBorder = new List<Point>() { currentPoint };

    int margin = 0;
    do
    {
      Point? nextPoint = null;
      double lastAngle = -1;
      foreach (Tree tree in _trees)
      {
        if (tree.Coordinate == currentPoint)
        {
          continue;
        }

        double probablyAngle = Point.GetAngle(currentPoint, tree.Coordinate);
        probablyAngle = (360 - margin * 90 + probablyAngle) % 360;
        
        if (nextPoint is null)
        {
          nextPoint = tree.Coordinate;
          lastAngle = probablyAngle;
          continue;
        }

        if (probablyAngle - lastAngle < 0)
        {
          nextPoint = tree.Coordinate;
          lastAngle = probablyAngle;
        }
        
      }

      if (nextPoint is null)
      {
        throw new Exception("Point cannot be null!");
      }
      
      margin += 1 * _fenceBorders.Values.Count(value => value == nextPoint!);
      currentPoint = nextPoint;
      fenceBorder.Add(currentPoint);
    } while (currentPoint != fenceBorder[0]);

    return fenceBorder;
  }
  private void UpdateCoordinates(Point point)
  {
    Point clonedPoint = point.Clone();
    if (_minPoint is null || _maxPoint is null || !_fenceBorders.Any())
    {
      _minPoint = point.Clone();
      _maxPoint = point.Clone();

      _fenceBorders[Align.Left] = clonedPoint;
      _fenceBorders[Align.Top] = clonedPoint;
      _fenceBorders[Align.Right] = clonedPoint;
      _fenceBorders[Align.Bottom] = clonedPoint;
      return;
    }

    _minPoint.X = Math.Min(clonedPoint.X, _minPoint.X);
    _minPoint.Y = Math.Min(clonedPoint.Y, _minPoint.Y);
    
    _maxPoint.X = Math.Max(clonedPoint.X, _maxPoint.X);
    _maxPoint.Y = Math.Max(clonedPoint.Y, _maxPoint.Y);

    _fenceBorders[Align.Right] = clonedPoint.X < _fenceBorders[Align.Right].X ? _fenceBorders[Align.Right] : clonedPoint;
    _fenceBorders[Align.Left] = clonedPoint.X > _fenceBorders[Align.Left].X ? _fenceBorders[Align.Left] : clonedPoint;
    _fenceBorders[Align.Top] = clonedPoint.Y < _fenceBorders[Align.Top].Y ? _fenceBorders[Align.Top] : clonedPoint;

    if (clonedPoint.Y < _fenceBorders[Align.Bottom].Y ||
        (clonedPoint.Y == _fenceBorders[Align.Bottom].Y && clonedPoint.X < _fenceBorders[Align.Bottom].X))
    {
      _fenceBorders[Align.Bottom] = clonedPoint;
    }
  }
}
