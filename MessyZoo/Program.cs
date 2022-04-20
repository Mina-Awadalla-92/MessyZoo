using MessyZoo;

List<Bear> bears = new();
List<Monkey> monkeys = new();
List<Parrot> parrots = new();

while (true)
{
    Console.WriteLine("Welcome to the zoo");
    Console.WriteLine("Press 1 to add an animal");
    Console.WriteLine("Press 2 to view the animals");


    string? input1 = Console.In.ReadLine();


    if(input1 == "1")
    {
        Console.WriteLine("What kind of animal would you like to add?");
        Console.WriteLine("1: Bear, 2: Monkey, 3: Parrot");
        string? input2 = Console.ReadLine();
        if(input2 == "1")
        {
            //make bear
            Console.WriteLine("Name?:");
            string? bearname = Console.ReadLine();
            Console.WriteLine("Age?:");
            string? bearage = Console.ReadLine();
            Console.WriteLine("Color?:");
            string? bearcolor = Console.ReadLine();

            Bear bear = new Bear();
            bear.name = bearname;
            bear.color = bearcolor;
            bear.age = bearage;

            bears.Add(bear);

        }
        else if (input2 == "2")
        {
            Console.WriteLine("Name?:");
            string? monkeyname = Console.ReadLine();
            Console.WriteLine("Age?:");
            string? monkeyage = Console.ReadLine();
            Console.WriteLine("height?:");
            string? monkeyheight = Console.ReadLine();

            Monkey monkey = new();
            monkey.name = monkeyname;
            monkey.height = monkeyheight;
            monkey.age = monkeyage;

            monkeys.Add(monkey);
            
        }
        else if (input2 == "3")
        {
            Console.WriteLine("Name?:");
            string? parrotname = Console.ReadLine();
            Console.WriteLine("Age?:");
            string? parrotage = Console.ReadLine();
            Console.WriteLine("Wingspan?:");
            string? parrotwingspan = Console.ReadLine();

            Parrot parrot = new Parrot();

            parrot.name = parrotname;
            parrot.age = parrotage;
            parrot.wingspan = parrotwingspan;

            parrots.Add(parrot);


        }

    }

    else if (input1 == "2")
    {
        Console.WriteLine("In the zoo there are: ");

        Console.WriteLine($"{bears.Count} bears, their names are:");
        foreach(Bear bear in bears)
        {
            Console.WriteLine(bear.name);
        }

        Console.WriteLine($"{monkeys.Count} monkeys, their names are:");
        foreach (Monkey monkey in monkeys)
        {
            Console.WriteLine(monkey.name);
        }

        Console.WriteLine($"{parrots.Count} parrots, their names are:");
        foreach (Parrot parrot in parrots)
        {
            Console.WriteLine(parrot.name);
        }
    }
}
