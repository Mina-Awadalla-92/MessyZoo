using MessyZoo;
using System;
using System.Collections.Generic;

List<Bear> bears = new ();
List<Monkey> monkeys = new();
List<Parrot> parrots = new();

bool repeat = true;
while (repeat)
{
    Console.WriteLine("Welcome to the zoo");
    Console.WriteLine("Press 0 to terminate");
    Console.WriteLine("Press 1 to add an animal");
    Console.WriteLine("Press 2 to view the animals");


    var input1 = Console.In.ReadLine();


    switch (input1)
    {
        case "1":
        {
            Console.WriteLine("What kind of animal would you like to add?");
            Console.WriteLine("1: Bear, 2: Monkey, 3: Parrot");
            var input2 = Console.ReadLine();
            switch (input2)
            {
                case "1":
                {
                    //make bear
                    Bear bear = new Bear();
                    Console.WriteLine("Name?:");
                    bear.name = Console.ReadLine();
                    Console.WriteLine("Age?:");
                    bear.age = Console.ReadLine();
                    Console.WriteLine("Color?:");
                    bear.color = Console.ReadLine();
                    bears.Add(bear);
                    break;
                }
                case "2":
                {
                    Monkey monkey = new();
                    Console.WriteLine("Name?:");
                    monkey.name = Console.ReadLine();
                    Console.WriteLine("Age?:");
                    monkey.age = Console.ReadLine();
                    Console.WriteLine("height?:");
                    monkey.height = Console.ReadLine();
                    monkeys.Add(monkey);
                    break;
                }
                case "3":
                {
                    Parrot parrot = new Parrot();
                    Console.WriteLine("Name?:");
                    parrot.name = Console.ReadLine();
                    Console.WriteLine("Age?:");
                    parrot.age = Console.ReadLine();
                    Console.WriteLine("Wingspan?:");
                    parrot.wingspan = Console.ReadLine();
                    parrots.Add(parrot);
                    break;
                }
            }

            break;
        }
        case "2":
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

            break;
        }
        case "0":
        {
            Console.WriteLine("Program will terminate, Thank you");
            repeat = false;
            break;
        }

    }
}