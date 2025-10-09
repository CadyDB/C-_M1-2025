namespace operators;

class Program
{
    static void Main(string[] args)
    {
        int som1 = 100;
        int result = som1 -= 30;
        Console.WriteLine($"Dit is het resultaat van som1: {result}");

        int som2 = 40;
        int result2 = som2 *= 3;
        Console.WriteLine($"Dit is het resultaat van som2: {result2}");

        float som3 = 85.5f;
        float result3 = som3 /= 5;
        Console.WriteLine($"Dit is het resultaat van som3: {result3}");
    }
}
