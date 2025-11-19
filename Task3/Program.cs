internal class Program
{
    static void Main(string[] args)
    {
        ParameterDemo pd = new ParameterDemo();

        int value = 20;
        pd.Increase(ref value);
        Console.WriteLine("After Increase: " + value);

        pd.GetFullName(out string fullName);
        Console.WriteLine("Full Name: " + fullName);

        int sum = pd.SumAll(1, 2, 3, 4, 5);
        Console.WriteLine("Sum of All: " + sum);
    }
}
