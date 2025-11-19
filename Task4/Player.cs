public class Player
{
    public string playerName;
    public int level;
    public int health;

    public Player()
    {
        Console.WriteLine("Default constructor has been called");
    }

    public Player(string name, int lv, int hp)
    {
        playerName = name;
        level = lv;
        health = hp;
    }
}
