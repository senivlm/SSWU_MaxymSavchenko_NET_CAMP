using System.Text;

namespace SigmaSoftware;

public class Task1
{
    private readonly int[,] _matrix;

    private readonly int _height;
    private readonly int _width;
    public Task1(int width, int height)
    {
        _matrix = new int[height, width];

        _height = height;
        _width = width;
    }

    public Task1() : this(5, 5) { }

    public void Fill(FillDirection fillDirection = FillDirection.Clockwise)
    {
        int maximumHeight = _height;
        int maximumWidth = _width;
        
        int minimumHeight = 0;
        int minimumWidth = 1;

        int currentHeight = 0;
        int currentWidth = 0;

        int maximumValue = _width * _height;
        int currentValue = 1;
        
        switch (fillDirection)
        {
            case FillDirection.Clockwise:
                (minimumHeight, minimumWidth) = (minimumWidth, minimumHeight);
                while (currentValue <= maximumValue)
                {
                    try
                    {
                        Move(Direction.Right);

                        Move(Direction.Down);

                        Move(Direction.Left);
                        
                        Move(Direction.Up);
                    }
                    catch
                    {
                        break;
                    }
                }

                break;
            case FillDirection.CounterClockwise:
                while (currentValue <= maximumValue)
                {
                    try
                    {
                        Move(Direction.Down);

                        Move(Direction.Right);

                        Move(Direction.Up);

                        Move(Direction.Left);
                    }
                    catch
                    {
                        break;
                    }
                }

                break;
            default:
                throw new ArgumentException("Unknown direction.");
        }
        
        
        void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    for (; currentHeight >= minimumHeight; currentHeight--)
                    {
                        _matrix[currentHeight, currentWidth] = currentValue++;
                        if (currentHeight == minimumHeight) break;
                    }
                    minimumHeight++;
                    
                    if (fillDirection == FillDirection.CounterClockwise)
                    {
                        currentWidth--;
                    }
                    else
                    {
                        currentWidth++;
                    }
                    
                    break;
                case Direction.Left:
                    for (; currentWidth >= minimumWidth; currentWidth--)
                    {
                        _matrix[currentHeight, currentWidth] = currentValue++;
                        if (currentWidth == minimumWidth) break;
                    }
                    minimumWidth++;
                    
                    if (fillDirection == FillDirection.CounterClockwise)
                    {
                        currentHeight++;
                    }
                    else
                    {
                        currentHeight--;
                    }
                    
                    break;
                case Direction.Down:
                    for (; currentHeight < maximumHeight; currentHeight++)
                    {
                        _matrix[currentHeight, currentWidth] = currentValue++;
                        if (currentHeight + 1 == maximumHeight) break;
                    }
                    maximumHeight--;
                    
                    if (fillDirection == FillDirection.CounterClockwise)
                    {
                        currentWidth++;
                    }
                    else
                    {
                        currentWidth--;
                    }
                    
                    break;
                case Direction.Right:
                    for (; currentWidth < maximumWidth; currentWidth++)
                    {
                        _matrix[currentHeight, currentWidth] = currentValue++;
                        if (currentWidth + 1 == maximumWidth) break;
                    }
                    maximumWidth--;
                    
                    if (fillDirection == FillDirection.CounterClockwise)
                    {
                        currentHeight--;
                    }
                    else
                    {
                        currentHeight++;
                    }
                    break;
                default:
                    throw new ArgumentException("Invalid direction.");
            }
            if (currentValue > maximumValue) throw new Exception();
        }
    }


    public enum FillDirection
    {
        Clockwise,
        CounterClockwise
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
        Up,
        Left,
        Down,
        Right
    }
}