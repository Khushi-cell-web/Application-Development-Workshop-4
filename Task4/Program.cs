using System.Numerics;

internal class Program
{
    static void Main(string[] args)
    {
        Player p1 = new Player();

        Player p2 = new Player("Khushi", 10, 100);
        Console.WriteLine($"Name: {p2.playerName}, Level: {p2.level}, Health: {p2.health}");
    }
}
