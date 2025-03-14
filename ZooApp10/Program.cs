Console.Clear(); // очищення консолі
List<Animals> items = new();    
List<Korm> korms= new();
while (true)
{
    Console.Clear();
    Console.WriteLine("-------WELCOME ZOO-------");
    Console.WriteLine("----------Menu-----------\r\n" +
                     "1.Add Animal\r\n" +
                     "2.Add korm\r\n" +
                     "3.View Korm\r\n" +
                     "4.View and manage the animal database\r\n" +
                     "5.Management of animal fodder database\r\n" +
                     "6.Accounting for animal feeding costs\r\n");
    Console.WriteLine("______________________________");

    Console.Write("Your choice: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Animals newItem = new ();
            newItem.ReadFromConsole();
            items.Add (newItem);
            break;
        case 2:
            Korm newkorms= new();
            newkorms.ReadFromConsole();
            korms.Add (newkorms);
            break;

            case 3:
            foreach (Korm korm in korms)
                korm.Show();
            break;
            
        case 4:
          foreach (Animals item in items)
                item.Show();
            break;
    }

    Console.ReadKey();
}

public class Animals
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public string ViewAnimals { get; set; }
    public int Age { get; set; }

    public void ReadFromConsole()
    {
        Console.Write("Enter name: ");
        Name = Console.ReadLine();
        Console.Write("Enter ViewAnimals: ");
        ViewAnimals = (Console.ReadLine());
        Console.Write(" Enter Weight: ");
        Weight = int.Parse(Console.ReadLine());
        Console.Write(" Age: ");
        Age = int.Parse(Console.ReadLine());
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ViewAnimals: {ViewAnimals}");
        Console.WriteLine($" Weight: {Weight}");
        Console.WriteLine($"Age: {Age}");
    }
}

public class Korm
{
    public string Name { get; set; }
    public int Weight { get; set; }

    public int Number { get; set; }

    public void ReadFromConsole()
    {
        Console.Write("Enter Name");
        Name = Console.ReadLine();
        Console.Write("Enter Weight");
        Weight = int.Parse(Console.ReadLine());
        Console.Write("Enter Number");
        Number = int.Parse(Console.ReadLine());

    }
    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($" Number: {Number}");
    }
}