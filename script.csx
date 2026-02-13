using System;

string name = null;
List<string> list = new List<string>();

void ChangeName()
{
    Console.WriteLine("_____________________");
    Console.WriteLine("What is your name? ");
    name = Console.ReadLine();

    Choose();
}

ChangeName();

void Choose()
{
    Console.WriteLine("_____________________");
    Console.WriteLine("Hello, " + name);
    Console.WriteLine("1. Add new node");
    Console.WriteLine("2. Change my name");
    Console.WriteLine("3. Check All my Nodes");

    string input = Console.ReadLine(); 
    
    Answer(input);
}

void Answer(string input)
{
    switch (input)
    {
        case "1":
            AddToDoList();
            break;
        case "2":
            ChangeName();
            break;
        case "3":
            CheckAllNodes();
            break;
        default:
            Console.WriteLine("Некорректная команда!");
            Choose();
            break;
    }
}

void AddToDoList()
{
    Console.WriteLine("_____________________");
    Console.WriteLine("Write your new note");
    string newElement = Console.ReadLine();

    list.Add(newElement);

    Choose();
}

void CheckAllNodes()
{
    Console.WriteLine("_____________________");
    Console.WriteLine("Elements in the list:");
    foreach (string element in list){
        Console.WriteLine(element);
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();

    Choose();
}