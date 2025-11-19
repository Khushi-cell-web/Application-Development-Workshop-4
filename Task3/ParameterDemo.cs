public class ParameterDemo
{
    public void Increase(ref int number)
    {
        number += 10;
    }

    public void GetFullName(out string fullname)
    {
        fullname = "Khushi Bohora";
    }

    public int SumAll(params int[] numbers)
    {
        return numbers.Sum();
    }
}
