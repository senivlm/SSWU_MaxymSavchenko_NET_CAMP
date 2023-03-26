using SigmaSoftware;

Task1 task1 = new Task1(5, 5);
task1.Fill(Task1.FillDirection.Clockwise);
Console.WriteLine("Task 1\n" + task1);

int[][] matrix =
{
    new[] { 1, 1, 1 },
    new[] { 1, 2, 2 },
    new[] { 1, 2, 3 }
};
Task2 task2 = new Task2(matrix);
Console.WriteLine("Task 2 \n" + task2);
task2.GetTheLongestColouredLine();