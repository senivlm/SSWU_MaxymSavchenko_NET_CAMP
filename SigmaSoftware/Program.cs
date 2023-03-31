/*Task1 task1 = new Task1(5, 5);
task1.Fill(Task1.FillDirection.Clockwise);
Console.WriteLine("Task 1\n" + task1);

int[][] matrix =
{
    new[] { 1, 1, 1 },
    new[] { 1, 2, 2 },
    new[] { 1, 2, 3 }
};*/

/*Task2 task2 = new Task2(matrix);
Console.WriteLine("Task 2 \n" + task2);
task2.GetTheLongestColouredLine();*/

/* using SigmaSoftware.HW2;

Console.Write("Input username: ");
string username = Console.ReadLine()!;
User currentUser = new User(username);

Simulator simulator = Simulator.GetInstance();

while (true)
{
    Console.Clear();
    
    Console.WriteLine("Press key to choose action. [R - Get Logs, A - Add Water, D - Get Water, W - Pump Info, S - Stop Pump, Q - Exit]");
    simulator.CheckWaterLevel();
    ConsoleKey key = Console.ReadKey().Key;

    if (key == ConsoleKey.R)
    {
        Console.Clear();
        simulator.PrintLogs();
        Console.WriteLine("Q - exit.");
        while (Console.ReadKey().Key != ConsoleKey.Q) { }
        Console.WriteLine();
        BlockThread(3);
        continue;
    }
    
    if (key != ConsoleKey.A &&
        key != ConsoleKey.D &&
        key != ConsoleKey.Q &&
        key != ConsoleKey.W &&
        key != ConsoleKey.S)
    {
        Console.WriteLine("Incorrect input.");
        BlockThread(3);
        continue;
    }

    Console.WriteLine();
    
    switch (key)
    {
        case ConsoleKey.W:
            simulator.PumpInfo(currentUser);
            BlockThread(3);
            continue;
        case ConsoleKey.S:
            simulator.StopPump(currentUser);
            BlockThread(3);
            continue;
        case ConsoleKey.Q:
            BlockThread(3);
            return;
    }
    
    Console.Write("Input volume: ");
    
    if (!int.TryParse(Console.ReadLine(), out int volume) ||
        volume < 0)
    {
        Console.WriteLine("Incorrect input.");
        BlockThread(3);
        continue;
    }
    Console.Clear();
    switch (key)
    {
        case ConsoleKey.A:
            simulator.AddWater(volume, currentUser);
            break;
        case ConsoleKey.D:
            simulator.GetWater(volume, currentUser);
            break;
    }
    BlockThread(3);
}

void BlockThread(int seconds)
{
    if (seconds == 0) return;
    Console.WriteLine(seconds);
    Thread.Sleep(TimeSpan.FromSeconds(1));
    BlockThread(seconds - 1);
} */

UserInputActions inputActions = new ("Hello im Maxym yyyyey");

Console.WriteLine(inputActions.GetIndexSecondEnteringSubstring("TEST") ?? -1);

System.Console.WriteLine(inputActions.GetCountWordsWithUppercase());

System.Console.WriteLine(inputActions.ReplaceAllLetterDuplicates("LOL"));