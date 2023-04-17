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

using SigmaSoftware.HW5.Task2;

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

/*Tree[] trees =
{
    new (-4, 4),
    new (-3, -9),
    new (-2, 12),
    new (10, 11),
    new (8, -1),
    new (-13, -12),
    new (13, -11),
    new (-10, 5),
    new (7, 0),
    new (-7, 2),
    new (2, 9),
    new (10, -7),
    new (2, -1),
    new (-10, -12),
    new (5, -6),
    new (-6, 5),
    new (7, -10),
    new (-3, 4),
    new (-4, 6),
    new (10, -14),
    new (-9, 14),
    new (-13, -6),
    new (-4, -2),
    new (4, 0),
    new (9, 5),
    new (7, 6),
    new (2, -5),
    new (-12, -7),
    new (14, -7),
    new (14, -8),
    new (-11, 11),
    new (-13, 0),
    new (10, 2),
    new (-3, 9),
    new (8, 3),
    new (-3, -7),
    new (-11, -7),
    new (11, -11),
    new (9, -10),
    new (-7, -13),
    new (-11, -12),
    new (13, -2),
    new (-2, -3),
    new (1, 14),
    new (-3, -10),
    new (13, 5)
};


GardenBuilder gardenBuilder = new GardenBuilder();

gardenBuilder.AddTreeRange(trees);

Garden garden = gardenBuilder.Build();

garden.PrintGarden();
garden.PrintTreesIndexes();
garden.PrintFenceIndexes();*/


ShopOrganizer organizer = new ShopOrganizer();

List<ShopBox> bought = new List<ShopBox>();

while (true)
{
    Console.WriteLine("Choose action" +
                      "\n\t1 - Check all products" +
                      "\n\t2 - Add to cart product" +
                      "\n\t3 - Remove from cart" +
                      "\n\t4 - Add product to shop" +
                      "\n\t5 - Delete product from shop" +
                      "\n\t6 - Buy" +
                      "\n\t7 - Get all bought");
    
    if (!int.TryParse(Console.ReadLine()!, out int action))
    {
        Console.WriteLine("\nError");
        continue;
    }

    Console.WriteLine();

    switch (action)
    {
        case 1:
            CheckAllProducts(organizer);
            break;
        case 2:
            AddProductToCart(organizer);
            break;
        case 3:
            RemoveProductFromCart(organizer);
            break;
        case 4:
            AddProductToShop(organizer);
            break;
        case 5:
            DeleteProductFromShop(organizer);
            break;
        case 6:
            ShopBox shopBox = organizer.Buy();
            if (shopBox.SectionBoxes.Any())
            {
                bought.Add(shopBox);
            }
            break;
        case 7:
            PrintAllBought(bought);
            break;
        default:
            Console.WriteLine("Error");
            break;
    }
    
    Console.WriteLine();
}

void CheckAllProducts(ShopOrganizer shopOrganizer)
{ 
    Console.WriteLine(string.Join("\n", shopOrganizer.GetProducts()));
}

void AddProductToCart(ShopOrganizer shopOrganizer)
{
    Console.Clear();
    Dictionary<string, IEnumerable<ShopProduct>> products = shopOrganizer.GetProductsWithSections();

    bool isFirstLoop = true;
    do
    {
        Console.WriteLine();

        if (!isFirstLoop)
        {
            Console.Write("> Type '1' to continue or anything else to exit: ");
            string input = Console.ReadLine()!;
            if (input != "1")
            {
                break;
            }
        }

        isFirstLoop = false;
        int i = 1;
        Dictionary<int, ShopProduct> productsWithId = new Dictionary<int, ShopProduct>();
        foreach (KeyValuePair<string, IEnumerable<ShopProduct>> sectionWithProducts in products)
        {
            Console.WriteLine($"Section: {sectionWithProducts.Key}");
            foreach (ShopProduct product in sectionWithProducts.Value)
            {
                productsWithId.Add(i, product);
                Console.WriteLine($"\t[{i++}] {product.Name}, {product.Quantity} piece(s)");
            }

            Console.WriteLine();
        }
        
        Console.Write("> Product id: ");
        if (!int.TryParse(Console.ReadLine()!, out int productId) ||
            productId < 1 ||
            productId > productsWithId.Values.Count)
        {
            Console.WriteLine("Incorrect input!");
            continue;
        }

        Guid correctId = productsWithId[productId].Id;
        Console.Write("> Quantity: ");
        if (!int.TryParse(Console.ReadLine()!, out int quantity) || quantity < 1)
        {
            Console.WriteLine("Incorrect input!");
            continue;
        }

        bool isSucceeded = organizer.AddToCartProduct(correctId, quantity);

        if (!isSucceeded)
        {
            Console.WriteLine("Program error");
            continue;
        }

        Console.WriteLine("\nSuccessfully!\n");
    } while (true);
}

void RemoveProductFromCart(ShopOrganizer shopOrganizer)
{
    List<ShopProduct> cartProducts = shopOrganizer.GetCartProducts().ToList();
    
    if (!cartProducts.Any())
    {
        Console.WriteLine("There are no products.");
        return;
    }

    int index = 1;
    foreach (ShopProduct product in cartProducts)
    {
        Console.WriteLine($"[{index++}] {product.Name} | {product.Quantity} piece(s)");
    }

    Console.Write("> Product Id: ");
    if (!int.TryParse(Console.ReadLine()!, out int productId) ||
        productId < 1 ||
        productId > cartProducts.Count)
    {
        Console.WriteLine("Incorrect id.");
    }

    ShopProduct chosenProduct = cartProducts[productId - 1];
    Console.Write("> Quantity: ");
    if (!int.TryParse(Console.ReadLine()!, out int quantity) ||
        quantity < 1 ||
        quantity > chosenProduct.Quantity)
    {
        Console.WriteLine("Incorrect quantity.");
    }

    bool isSucceeded = shopOrganizer.RemoveFromCartProduct(chosenProduct.Id, quantity);

    if (!isSucceeded)
    {
        Console.WriteLine("Program error.");
        return;
    }

    Console.WriteLine("Successfully!");
    
    Console.WriteLine("> Type 1 to continue or anything else to exit to menu: ");
    if (Console.ReadLine()! == "1")
    {
        RemoveProductFromCart(organizer);
    }
}

void AddProductToShop(ShopOrganizer shopOrganizer)
{
    Console.Write("> Name: ");
    string name = Console.ReadLine()!;

    Console.Write("> Section(if more than one split by '/'): ");
    string section = Console.ReadLine()!;

    Console.Write("> Input height: ");
    if (!double.TryParse(Console.ReadLine()!, out double height))
    {
        AddProductToShop(shopOrganizer);
        return;
    }
    
    Console.Write("> Input width: ");
    if (!double.TryParse(Console.ReadLine()!, out double width))
    {
        AddProductToShop(shopOrganizer);
        return;
    }
    
    Console.Write("> Input length: ");
    if (!double.TryParse(Console.ReadLine()!, out double length))
    {
        AddProductToShop(shopOrganizer);
        return;
    }
    
    Console.Write("> Input quantity: ");
    if (!int.TryParse(Console.ReadLine()!, out int quantity))
    {
        AddProductToShop(shopOrganizer);
        return;
    }

    Console.WriteLine($"Name: {name} | Section: {section} | Quantity: {quantity}");
    Console.WriteLine($"\tHeight: {height}");
    Console.WriteLine($"\tWidth: {width}");
    Console.WriteLine($"\tLength: {length}");

    Console.Write("Is correct? (y/n): ");
    ConsoleKey key = Console.ReadKey().Key;

    while (key != ConsoleKey.Y && key != ConsoleKey.N)
    {
        key = Console.ReadKey().Key;
    }

    if (key == ConsoleKey.Y)
    {
        ShopProduct product = new ShopProduct(name, section, height, width, length, quantity);
        shopOrganizer.AddProductToShop(product);
        Console.WriteLine("Successfully!");
    }
    
}

void DeleteProductFromShop(ShopOrganizer shopOrganizer)
{
    Console.Write("> Are you sure?(y/n):");
    ConsoleKey key = Console.ReadKey().Key;

    while (key != ConsoleKey.Y && key != ConsoleKey.N)
    {
        Console.Write("> Do you want delete product?(y/n):");
        key = Console.ReadKey().Key;
    }

    if (key == ConsoleKey.N)
    {
        return;
    }

    Console.WriteLine();
    
    List<ShopProduct> products = shopOrganizer.GetProducts().ToList();

    int index = 1;
    foreach (ShopProduct product in products)
    {
        Console.WriteLine($"[{index++}] {product.Name}");
    }

    Console.Write("> Product id: ");

    if (!int.TryParse(Console.ReadLine()!, out int id))
    {
        DeleteProductFromShop(shopOrganizer);
        return;
    }

    bool isSucceeded = shopOrganizer.DeleteProductFromShop(products[id - 1].Id);

    if (!isSucceeded)
    {
        Console.WriteLine("Program error.");
    }
    else
    {
        Console.WriteLine("Successfully!");
    }
}

void PrintAllBought(IEnumerable<ShopBox> shopBoxes)
{
    int boxNumber = 1;

    foreach (ShopBox box in shopBoxes)
    {
        Console.WriteLine($"Box №{boxNumber++}");

        foreach (SectionBox sectionBox in box.SectionBoxes)
        {
            PrintBox(sectionBox);
        }
    }
}

void PrintBox(SectionBox sectionBox, int embeddings = 1)
{
    string embeddingsSectionName = string.Join("", Enumerable.Repeat("\t", embeddings));
    string embeddingsProduct = string.Join("", Enumerable.Repeat("\t", embeddings + 1));
    Console.WriteLine(embeddingsSectionName + "Section: " + sectionBox.Name);
    Console.WriteLine(embeddingsSectionName + $"Height: {sectionBox.Height}, Width: {sectionBox.Width}, Length: {sectionBox.Length}");
    
    if(sectionBox.ProductsBoxes.Any())
    {
        Console.WriteLine(embeddingsSectionName + "Products");
        foreach (ProductBox productBox in sectionBox.ProductsBoxes)
        {
            Console.WriteLine(embeddingsProduct + productBox.Product.Name + " | " + productBox.Product.Quantity +
                              " piece(s)");
        }
    }

    if (!sectionBox.SectionBoxes.Any())
    {
        return;
    }
    Console.WriteLine(embeddingsSectionName + "Boxes");
    foreach (SectionBox nextSectionBox in sectionBox.SectionBoxes)
    {
        PrintBox(nextSectionBox, embeddings + 1);
    }
}