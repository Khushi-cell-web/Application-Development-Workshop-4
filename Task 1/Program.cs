internal class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.name = "Khushi";
        s1.age = 20;
        s1.course = "IT";

        Student s2 = new Student();
        s2.name = "Nirjala";
        s2.age = 22;
        s2.course = "Software Engineering";

        Console.WriteLine("Student 1: " + s1.name + ", " + s1.age + ", " + s1.course);
        Console.WriteLine("Student 2: " + s2.name + ", " + s2.age + ", " + s2.course);

        Console.WriteLine("College: " + Student.college);
    }
}
