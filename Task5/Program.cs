internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter day: ");
        string day = Console.ReadLine().ToLower();

        if (day == "friday" || day == "saturday")
            Console.WriteLine("It is: Weekend");
        else
            Console.WriteLine("It is: Weekday");

        Book b1 = new Book("C# Basics", "John Doe", 500);
        Book b2 = b1 with { title = "Advanced C#", price = 700 };

        Console.WriteLine(b1);

        var (title, author, price) = b2;
        Console.WriteLine($"Deconstructed: {title}, {author}, {price}");
    }
}
