internal class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        calc.PrintWelcome();

        int sum = calc.Add(5, 10);
        int product = calc.Multiply(7);

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Multiplication: " + product);
    }
}
