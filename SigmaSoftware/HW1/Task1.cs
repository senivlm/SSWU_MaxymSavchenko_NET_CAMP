using System.Text;

namespace SigmaSoftware.HW1;

public class Task1
{
    private readonly int[,] _matrix;

    private readonly int _height;
    private readonly int _width;

    public int Square => _height * _width;
    public Task1(int width, int height)
    {
        _matrix = new int[height, width];

        _height = height;
        _width = width;
    }

    public Task1() : this(5, 5) { }

    public void Fill()
    {
        Direction[] allDirections = Enum.GetValues<Direction>(); 

        
        int indexCurrentDirection = 0;
        int currentValue = 1;
        int currentWidth = 0;
        int currentHeight = 0;
        while (currentValue <= Square)
        {
            _matrix[currentHeight, currentWidth] = currentValue++;
            switch (allDirections[indexCurrentDirection])
            {
                case Direction.Right:
                    currentWidth++;
                    if (currentWidth == _width || _matrix[currentHeight, currentWidth] != 0)
                    {
                        currentWidth--;
                        currentHeight++;
                        indexCurrentDirection = ++indexCurrentDirection % allDirections.Length;
                    }
                    break;
                case Direction.Down:
                    currentHeight++;
                    if (currentHeight == _height || _matrix[currentHeight, currentWidth] != 0)
                    {
                        currentWidth--;
                        currentHeight--;
                        indexCurrentDirection = ++indexCurrentDirection % allDirections.Length;
                    }
                    break;
                case Direction.Left:
                    currentWidth--;
                    if (currentWidth == -1 || _matrix[currentHeight, currentWidth] != 0)
                    {
                        currentWidth++;
                        currentHeight--;
                        indexCurrentDirection = ++indexCurrentDirection % allDirections.Length;
                    }
                    break;
                case Direction.Up:
                    currentHeight--;
                    if (currentHeight == -1 || _matrix[currentHeight, currentWidth] != 0)
                    {
                        currentWidth++;
                        currentHeight++;
                        indexCurrentDirection = ++indexCurrentDirection % allDirections.Length;
                    }
                    break;
            }
        }
    }

    public override string ToString()
    {
        StringBuilder matrix = new StringBuilder();
        for (int i = 0; i < _height; i++)
        {
            StringBuilder currentRow = new StringBuilder();

            for (int j = 0; j < _width; j++)
            {
                currentRow.Append(_matrix[i, j] + "\t");
            }

            matrix.Append(currentRow + "\n");
        }

        return matrix.ToString();
    }
    
    private enum Direction
    {
        Right,
        Down,
        Left,
        Up 
    }
}