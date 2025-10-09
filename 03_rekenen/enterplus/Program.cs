namespace enterplus;

class Program
{
    static void Main(string[] args)
    {
        int enters = 0;
        while (true)
        {
            enters++;
            Console.WriteLine($"aantal enters {enters}");
            Console.ReadLine();
        }
    }
}
