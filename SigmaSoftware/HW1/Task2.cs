using System.Security.Cryptography;
using System.Text;

namespace SigmaSoftware.HW1;

public class Task2
{
    private readonly int[][] _matrix;

    private readonly int _height;
    private readonly int _width;
    
    public Task2(int width, int height)
    {
        _matrix = new int[height][];

        for (int i = 0; i < height; i++)
        {
            _matrix[i] = new int[width];
        }

        _height = height;
        _width = width;
        
        FillRandom();
    }

    public Task2(int[][] matrix)
    {
        _matrix = matrix;

        if (_matrix is null || _matrix.Length == 0)
        {
            throw new ArgumentException("Empty matrix");
        }

        _height = _matrix.Length;
        _width = _matrix[0].Length;
    }

    public Task2() : this(5, 5) { }

    public (int row, int begin, int end, int color) GetTheLongestColoredLine()
    {
        int row = -1;
        
        int begin = -1;
        int end = -1;
        
        int color = -1;
        
        int count = -1;

        for (int i = 0; i < _height; i++)
        {
            for (int j = 0; j < _width; )
            {
                int currentColor = _matrix[i][j];
                IEnumerable<int> nums = _matrix[i].Skip(j).TakeWhile(element => element == currentColor);
                
                int lineLength = nums.Count();
                
                if (count < lineLength)
                {
                    row = i;
                    begin = j;
                    end = j + lineLength - 1;
                    color = currentColor;
                    count = lineLength;
                }
                
                j += lineLength;
            }
        }

        return (row, begin, end, color);
    }
    
    private void FillRandom()
    {
        for (int hIndex = 0; hIndex < _height; hIndex++)
        {
            for (int wIndex = 0; wIndex < _width; wIndex++)
            {
                _matrix[hIndex][wIndex] = RandomNumberGenerator.GetInt32(0, 17);
            }
        }
    }

    public override string ToString()
    {
        StringBuilder matrix = new StringBuilder();
        for (int hIndex = 0; hIndex < _height; hIndex++)
        {
            StringBuilder row = new StringBuilder();
            for (int wIndex = 0; wIndex < _width; wIndex++)
            {
                row.Append(_matrix[hIndex][wIndex] + " ");
            }

            matrix.Append(row + "\n");
        }

        return matrix.ToString();
    }
}