Console.Clear(); // очищення консолі
Animals item = new Animals();

while (true)
{
    Console.Clear();
    Console.WriteLine("-------WELCOME ZOO-------");
    Console.WriteLine("----------Menu-----------\r\n" +
                     "1.Add Animal\r\n" +
                     "2.Add feed\r\n" +
                     "3.Edit Animal\r\n" +
                     "4.View and manage the animal database\r\n" +
                     "5.Management of animal fodder database\r\n" +
                     "6.Accounting for animal feeding costs\r\n");

    Console.Write("Your choice: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Name");
            item.Name = Console.ReadLine();
            Console.WriteLine("ViewAnimals");
            item.ViewAnimals = Console.ReadLine();
            Console.WriteLine("Weight");
            item.Weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Age");
            item.Age = int.Parse(Console.ReadLine());
            break;
        case 4:
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"ViewAnimals: {item.ViewAnimals}");
            Console.WriteLine($"Weight: {item.Weight}");
            Console.WriteLine($"Age: {item.Age}");
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
}


