using System.Security.Cryptography;

public class Animal(string name, int age)
{
    public string Name => name;
    public int Age => age;

    public Animal Parent { get; set; }

    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("The animal is sleeping.");
    }

    public void MakeSound()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var animal = new Animal("Rex", 3);
        animal.MakeSound();

        Func<int, int, bool> testForEquality = (x, y) => x == y;
    }
}