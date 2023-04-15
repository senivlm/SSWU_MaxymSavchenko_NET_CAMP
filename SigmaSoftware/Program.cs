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

/*
UserInputActions inputActions = new ("Hello im Maxym yyyyey");

Console.WriteLine(inputActions.GetIndexSecondEnteringSubstring("TEST") ?? -1);

Console.WriteLine(inputActions.GetCountWordsWithUppercase());

Console.WriteLine(inputActions.ReplaceAllLetterDuplicates("LOL"));*/

string textUA = """
Поки сонце засідало, місто оживало від звуку гудків машин та гомону перехожих. Люди бігли, щоб встигнути на свій потяг, а вуличні торговці розставляли свої тележки, щоб продавати свої товари. Неонові ліхтарі будівель освітлювали лінію горизонту, кидая барвисте сяйво на вулиці міста.
 
Удалі від мене (1 миля), можна було почути сирену, що сигналізувала про прибуття карети швидкої допомоги. Вона проїжджала через трафік, її ліхтарі яскраво блимали, коли вона прямувала до лікарні.

Ідучи savchenko.m2019@gmail.com " asd asd"@gmail.com вздовж рухливих вулиць, я не міг не відчувати почуття енергії та хвилювання. Місто було безкінечним пригодою, повним сюрпризів та нових вражень.

Я минаю групу музикантів, що грали на кутку, їх музика наповнювала повітря живим ритмом. Уличний художник був зайнятий роботою, розмальовуючи красиву фреску на боці будинку.

Запах свіжої випічки пронісся повітрям, приходячи з недалекої пекарні. Я не зміг відстати від спокуси та зайшов всередину, щоб купити собі буханку хліба.

Ідучи далі своєю дорогою, я спостерігав, як місто змінювалося з дня на ніч (або з ночі на день). Світла ставали яскравішими, звуки ставали гучнішими, а енергія ставала сильнішою.

Нарешті я дійшов до свого пункту призначення - затишної кав'ярні, яка знаходилась в самому серці міста. Я затишно розсівся з чашкою
""";
string textEN = """
As the sun began to set, the city came alive with the sound of honking cars and bustling pedestrians. People rushed to catch their trains, while street vendors set up their carts to sell their goods. The neon lights of the buildings illuminated the skyline, casting a colorful glow over the city streets.

In the distance(1 mile), a siren could be heard, signaling the arrival of an ambulance. It weaved through the traffic, its lights flashing brightly, as it made its way towards the hospital.

As I walked through the busy streets, I couldn't help but feel a sense of energy and excitement. The city was a never-ending adventure, full of surprises and new experiences.

I passed by a group of musicians playing on the corner, their music filling the air with a lively beat. A street artist was busy at work, painting a beautiful mural on the side of a building.

The smell of freshly baked bread wafted through the air, coming from a nearby bakery. I couldn't resist the temptation and stepped inside to buy a loaf for myself.

As I continued on my way, I watched as the city transformed from day to night(or night to day). The lights grew brighter, the sounds grew louder, and the energy grew stronger.

Finally, I arrived at my destination, a cozy little cafe nestled in the heart of the city. I settled in with a cup of hot tea and watched as the world outside continued to move and change, always full of life and energy.
""";

/*TextHandler handlerUA = new TextHandler(textUA);
TextHandler handlerEN = new TextHandler(textEN);

string[] arrayUA = handlerUA.FindAllBracketsInfo();
string[] arrayEN = handlerEN.FindAllBracketsInfo();


handlerUA.GetNotEmails();

Console.WriteLine(string.Join("\n", arrayUA));
Console.WriteLine(string.Join("\n", arrayEN));*/

/*Console.OutputEncoding = Encoding.UTF8;
CultureInfo cultureInfo = new CultureInfo("uk-UA");
Thread.CurrentThread.CurrentCulture = cultureInfo;

ApartmentService service = new ApartmentService("file.txt");

Apartment? apartment = service.GetApartmentWithGreaterDebt();

service.PrintAllApartments();*/

