namespace SigmaSoftware.HW5.Task1;

public class Garden
{// координати можуть бути дійсними. а тому все складніше.Це не графічні точки.
  private readonly int[,] _garden;
  private readonly List<Point> _fenceBorders;
  private readonly double _fenceLength;

  public Garden(int[,] garden, List<Point> fenceBorders)
  {
    _garden = garden;
    _fenceBorders = fenceBorders;
    
    for (int i = 0; i < _fenceBorders.Count - 1; i++)
    {
      _fenceLength += Point.DistanceBetweenPoints(_fenceBorders[i], _fenceBorders[i + 1]);
    }
  }

  public void PrintGarden()
  {
    for (int i = 0; i < _garden.GetLength(0) + 1; i++)
    {// на кожному кроці питати чи це не перший, погана ідея. Та і формат дивний...
      if (i == 0)
      {
        Console.Write($"{"@", 3}|");
      }
      else
      {
        Console.Write($"{i - 1, 3}|");
      }
      for (int j = 0; j < _garden.GetLength(1); j++)
      {
        if (i == 0)
        {
          Console.Write($"{j,3}|");
          continue;
        }
        Console.Write($"{_garden[i - 1, j],3}|");
      }
      Console.WriteLine();
      if (i == 0)
      {
        Console.WriteLine(string.Join("", Enumerable.Range(0, 4 * (_garden.GetLength(1) + 1)).Select(_ => '_')));
      }
    }

  }

  public void PrintTreesIndexes()
  {
    for (int i = 0; i < _garden.GetLength(0); i++)
    {
      bool haveInRow = false;
      for (int j = 0; j < _garden.GetLength(1); j++)
      {
        if (_garden[i, j] != 0)
        {
          haveInRow = true;
          Console.Write($"|({i};{j})");
        }
      }

      if(haveInRow)
      {
        Console.WriteLine($"| ROW[{i + 1}]");
      }
    }

    Console.WriteLine();
  }

  public void PrintFenceIndexes()
  {
    Console.WriteLine("Fences:");
    for (int i = 0; i < _fenceBorders.Count - 1; i++)
    {
      Console.WriteLine($"{_fenceBorders[i]} -> {_fenceBorders[i + 1]}");
    }
  }

  private double GetFenceLength()
  {
    return _fenceLength;
  }

  #region OPERATORS

  public static bool operator >(Garden garden1, Garden garden2)
  {
    return garden1.GetFenceLength() > garden2.GetFenceLength();
  }
  public static bool operator <(Garden garden1, Garden garden2)
  {
    return garden1.GetFenceLength() < garden2.GetFenceLength();
  }
  public static bool operator >=(Garden garden1, Garden garden2)
  {
    return garden1.GetFenceLength() >= garden2.GetFenceLength();
  }
  public static bool operator <=(Garden garden1, Garden garden2)
  {
    return garden1.GetFenceLength() <= garden2.GetFenceLength();
  }
  
  #endregion
}
