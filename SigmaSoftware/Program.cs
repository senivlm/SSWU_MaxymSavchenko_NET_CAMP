using SigmaSoftware;

Task1 task1 = new Task1(5, 5);
task1.Fill(Task1.FillDirection.CounterClockwise);
Console.WriteLine(task1);

int[][] matrix =
{
    new[] { 1, 1, 1 },
    new[] { 1, 2, 2 },
    new[] { 1, 2, 3 }
};
Task2 task2 = new Task2(matrix);
Console.WriteLine(task2);
task2.GetTheLongestColouredLine();